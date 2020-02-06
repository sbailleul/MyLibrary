using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Library.API.Models;
using Library.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.JsonPatch.Operations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Library.API.Controllers
{
    [Route("api/v{version:apiVersion}/authors")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository _authorsRepository;
        private readonly IMapper _mapper;

        public AuthorsController(
            IAuthorRepository authorsRepository,
            IMapper mapper)
        {
            _authorsRepository = authorsRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<Author>>> GetAuthors()
        {
            var authorsFromRepo = await _authorsRepository.GetAuthorsAsync();

            return Ok(_mapper.Map<IEnumerable<Author>>(authorsFromRepo));
        }

        /// <summary>
        ///     Get an author by her/his id
        /// </summary>
        /// <param name="authorId">The id of the author you want to get</param>
        /// <returns>An ActionResult of type Author</returns>
        [HttpGet("{authorId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Author>> GetAuthor(
            Guid authorId)
        {
            var authorFromRepo = await _authorsRepository.GetAuthorAsync(authorId);
            if (authorFromRepo == null) return NotFound();

            return Ok(_mapper.Map<Author>(authorFromRepo));
        }

        [HttpPut("{authorId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        public async Task<ActionResult<Author>> UpdateAuthor(
            Guid authorId,
            AuthorForUpdate authorForUpdate)
        {
            var authorFromRepo = await _authorsRepository.GetAuthorAsync(authorId);
            if (authorFromRepo == null) return NotFound();

            _mapper.Map(authorForUpdate, authorFromRepo);

            //// update & save
            _authorsRepository.UpdateAuthor(authorFromRepo);
            await _authorsRepository.SaveChangesAsync();

            // return the author
            return Ok(_mapper.Map<Author>(authorFromRepo));
        }

        /// <summary>
        ///     Partially update and author
        /// </summary>
        /// <param name="authorId">The id of the author you want to update</param>
        /// <param name="patchDocument">The set of operations to apply to author</param>
        /// <returns>Return an ActionResult of type of Author</returns>
        /// <remarks>
        ///     Sample request (this request update the author's **first name**) 
        ///     ```json
        ///     PATCH /authors/id
        ///     [ 
        ///         { 
        ///             "op": "replace", 
        ///             "path": "/firstname", 
        ///             "value": "new first name" 
        ///         } 
        ///     ]
        /// </remarks>
        [HttpPatch("{authorId}")]
        [Consumes("application/json-patch+json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType( StatusCodes.Status422UnprocessableEntity)]
        public async Task<ActionResult<Author>> UpdateAuthor(
            Guid authorId,
            [FromBody] JsonPatchDocument<AuthorForUpdate> patchDocument)
        {
            // var patchDocument = operations as JsonPatchDocument<AuthorForUpdate>;
            var authorFromRepo = await _authorsRepository.GetAuthorAsync(authorId);
            if (authorFromRepo == null) return NotFound();

            // map to DTO to apply the patch to
            var author = _mapper.Map<AuthorForUpdate>(authorFromRepo);
            patchDocument.ApplyTo(author, ModelState);

            // if there are errors when applying the patch the patch doc 
            // was badly formed  These aren't caught via the ApiController
            // validation, so we must manually check the modelstate and
            // potentially return these errors.
            if (!ModelState.IsValid) return new UnprocessableEntityObjectResult(ModelState);

            // map the applied changes on the DTO back into the entity
            _mapper.Map(author, authorFromRepo);

            // update & save
            _authorsRepository.UpdateAuthor(authorFromRepo);
            await _authorsRepository.SaveChangesAsync();

            // return the author
            return Ok(_mapper.Map<Author>(authorFromRepo));
        }
    }
}