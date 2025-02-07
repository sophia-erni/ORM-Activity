using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ORM_Activity.DTOs;
using ORM_Activity.Models;
using ORM_Activity.Repositories;

namespace ORM_Activity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBaseRepository<Book> _bookRepository;
        private readonly IMapper _mapper;

        public BookController(IBaseRepository<Book> bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        [HttpGet("books")]
        public async Task<IActionResult> GetBooks()
        {
            var books = await _bookRepository.GetAll();
            var booksDtos = _mapper.Map<List<GetBookDto>>(books);
            return Ok(booksDtos);
        }

        [HttpPost("books")]
        public async Task<IActionResult> CreateBook([FromBody] CreateBook createBook)
        {
            var book = _mapper.Map<Book>(createBook);
            var createdBook = await _bookRepository.Add(book);
            var bookDto = _mapper.Map<GetBookDto>(createdBook);
            return CreatedAtAction(nameof(GetBook), new { id = bookDto.BookId }, bookDto);
        }

    }
}
