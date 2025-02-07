using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ORM_Activity.DTOs;
using ORM_Activity.Models;
using ORM_Activity.Repositories;

namespace ORM_Activity.Controllers
{
    [ApiController]
    [Route("api/")]
    public class AuthorController : ControllerBase
    {
        private readonly IBaseRepository<Author> _authorRepository;
        private readonly IMapper _mapper;

        public AuthorController(IBaseRepository<Author> authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }


        [HttpGet("authors")]
        public async Task<IActionResult> GetAuthors()
        {
            var authors = await _authorRepository.GetAll(a => a.Books, a => a.AuthorsPublishers);
            var authorDtos = _mapper.Map<List<GetAuthorDto>>(authors);
            return Ok(authorDtos);
        }

        [HttpPost("authors")]
        public async Task<IActionResult> CreateAuthor([FromBody] CreateAuthor createAuthor)
        {
            var author = _mapper.Map<Author>(createAuthor);
            var createdAuthor = await _authorRepository.Add(author);
            var authorDto = _mapper.Map<GetAuthorDto>(createdAuthor);
            return CreatedAtAction(nameof(GetAuthor), new { id = authorDto.AuthorId }, authorDto);
        }

    }
}
