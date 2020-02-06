using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Library.API.Models;
using Library.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    [Route("api/v{version:apiVersion}/authors")]
    [ApiController]
    [ApiVersion("2.0")]
    public class AuthorsControllerV2 : ControllerBase
    {
        private readonly IAuthorRepository _authorsRepository;
        private readonly IMapper _mapper;

        public AuthorsControllerV2(
            IAuthorRepository authorsRepository,
            IMapper mapper)
        {
            _authorsRepository = authorsRepository;
            _mapper = mapper;
        }


        /// <summary>
        /// Get the authors (V2)
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Author>>> GetAuthors()
        {
            var authorsFromRepo = await _authorsRepository.GetAuthorsAsync();
            return Ok(_mapper.Map<IEnumerable<Author>>(authorsFromRepo));
        }
    }
}