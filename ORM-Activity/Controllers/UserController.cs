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
    public class UserController : ControllerBase
    {
        private readonly IBaseRepository<User> _userRepository;
        private readonly IMapper _mapper;

        public UserController(IBaseRepository<User> userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        [HttpGet("users")]
        public async Task<IActionResult> GetUser()
        {
            var users = await _userRepository.GetAll();
            var usersDtos = _mapper.Map<List<GetUserDto>>(users);
            return Ok(usersDtos);
        }

        [HttpPost("users")]
        public async Task<IActionResult> CreateUser([FromBody] CreateUser createUser)
        {
            var user = _mapper.Map<User>(createUser);
            var createdUser = await _userRepository.Add(user);
            var userDto = _mapper.Map<GetUserDto>(createdUser);
            return CreatedAtAction(nameof(GetUser), new { id = userDto.UserId }, userDto);
        }
    }
}
