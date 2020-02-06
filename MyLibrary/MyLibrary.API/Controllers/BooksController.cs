using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Library.API.Attributes;
using Library.API.Helpers;
using Library.API.Models;
using Library.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Library.API.Controllers
{
    [Route("api/v{version:apiVersion}/authors/{authorId}/books")]
    [Produces("application/json", "application/xml")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public BooksController(
            IBookRepository bookRepository,
            IAuthorRepository authorRepository,
            IMapper mapper)
        {
            _bookRepository = bookRepository;
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Get the books for a specific author
        /// </summary>
        /// <param name="authorId">The id of the author</param>
        /// <returns>An ActionResult of IEnumerable of Books</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks(
            Guid authorId)
        {
            if (!await _authorRepository.AuthorExistsAsync(authorId)) return NotFound();

            var booksFromRepo = await _bookRepository.GetBooksAsync(authorId);
            return Ok(_mapper.Map<IEnumerable<Book>>(booksFromRepo));
        }


        /// <summary>
        ///     Get a book by id for a specific author
        /// </summary>
        /// <param name="authorId">The id of the book author</param>
        /// <param name="bookId">The id of the book</param>
        /// <returns>An ActionResult of Book</returns>
        /// <response code="200">Returns the requested book</response>
        [HttpGet("{bookId}", Name = nameof(GetBook))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [RequestHeaderMatchesMediaType(ConstHeaderNames.Accept,"application/json",
            "application/vnd.marvin.book+json" )]
        [Produces("application/vnd.marvin.book+json")]
        public async Task<ActionResult<Book>> GetBook(
            Guid authorId,
            Guid bookId)
        {
            if (!await _authorRepository.AuthorExistsAsync(authorId)) return NotFound();

            var bookFromRepo = await _bookRepository.GetBookAsync(authorId, bookId);
            if (bookFromRepo == null) return NotFound();

            return Ok(_mapper.Map<Book>(bookFromRepo));
        }

        /// <summary>
        ///     Get a book by id for a specific author
        /// </summary>
        /// <param name="authorId">The id of the book author</param>
        /// <param name="bookId">The id of the book</param>
        /// <returns>An ActionResult of BookWithConcatenatedAuthorName</returns>
        /// <response code="200">Returns the requested book with concatenated author name</response>
        [HttpGet("{bookId}", Name = nameof(GetBookWithConcatenatedAuthorName))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Book))]
        [RequestHeaderMatchesMediaType(ConstHeaderNames.Accept,
            "application/vnd.marvin.bookwithconcatenatedauthorname+json")]
        [Produces("application/vnd.marvin.bookwithconcatenatedauthorname+json")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<ActionResult<BookWithConcatenatedAuthorName>> GetBookWithConcatenatedAuthorName(
            Guid authorId,
            Guid bookId)
        {
            if (!await _authorRepository.AuthorExistsAsync(authorId)) return NotFound();

            var bookFromRepo = await _bookRepository.GetBookAsync(authorId, bookId);
            if (bookFromRepo == null) return NotFound();

            return Ok(_mapper.Map<BookWithConcatenatedAuthorName>(bookFromRepo));
        }


        /// <summary>
        /// Create a book for a specific author
        /// </summary>
        /// <param name="authorId">The id of the author</param>
        /// <param name="bookForCreation">The book to create</param>
        /// <returns>Return created book</returns>
        /// <response code="422">Validation error</response>
        [HttpPost(Name = nameof(CreateBook))]
        [Consumes("application/json",
            "application/vnd.martin.bookforcreation+json")]
        [RequestHeaderMatchesMediaType(ConstHeaderNames.ContentType,
            "application/json",
            "application/vnd.martin.bookforcreation+json")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        public async Task<ActionResult<Book>> CreateBook(
            Guid authorId,
            [FromBody] BookForCreation bookForCreation)
        {
            if (!await _authorRepository.AuthorExistsAsync(authorId)) return NotFound();

            var bookToAdd = _mapper.Map<Entities.Book>(bookForCreation);
            _bookRepository.AddBook(bookToAdd);
            await _bookRepository.SaveChangesAsync();

            return CreatedAtRoute(
                "GetBook",
                new {authorId, bookId = bookToAdd.Id},
                _mapper.Map<Book>(bookToAdd));
        }

        /// <summary>
        /// Create a book for a specific author
        /// </summary>
        /// <param name="authorId">The id of the author</param>
        /// <param name="bookForCreation">The book to create</param>
        /// <returns>Return created book</returns>
        /// <response code="422">Validation error</response>
        [HttpPost]
        [Consumes("application/vnd.martin.bookforcreationwithamountofpages+json")]
        [RequestHeaderMatchesMediaType(ConstHeaderNames.ContentType,
            "application/vnd.martin.bookforcreationwithamountofpages+json")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<ActionResult<Book>> CreateBookWithAmountOfPages(
            Guid authorId,
            [FromBody] BookForCreationWithAmountOfPages bookForCreation)
        {
            if (!await _authorRepository.AuthorExistsAsync(authorId)) return NotFound();

            var bookToAdd = _mapper.Map<Entities.Book>(bookForCreation);
            _bookRepository.AddBook(bookToAdd);
            await _bookRepository.SaveChangesAsync();

            return CreatedAtRoute(
                "GetBook",
                new { authorId, bookId = bookToAdd.Id },
                _mapper.Map<Book>(bookToAdd));
        }
    }
}