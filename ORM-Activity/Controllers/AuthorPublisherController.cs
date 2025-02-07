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
    public class AuthorPublisherController : ControllerBase
    {
        private readonly IBaseRepository<AuthorPublisher> _authorpublisherRepository;
        private readonly IMapper _mapper;

        public AuthorPublisherController(IBaseRepository<AuthorPublisher> authorpublisherRepository, IMapper mapper)
        {
            _authorpublisherRepository = authorpublisherRepository;
            _mapper = mapper;
        }


        [HttpGet("authorspublishers")]
        public async Task<IActionResult> GetAuthorsPublishers()
        {
            var authorspublishers = await _authorpublisherRepository.GetAll();
            var authorspublishersDTOs = _mapper.Map<List<GetAuthorDto>>(authorspublishers);
            return Ok(authorspublishersDTOs);
        }

        
    }
}
