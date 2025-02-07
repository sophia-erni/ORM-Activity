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
    public class UserProfileController : ControllerBase
    {
        private readonly IBaseRepository<UserProfile> _userprofileRepository;
        private readonly IMapper _mapper;

        public UserProfileController(IBaseRepository<UserProfile> userprofileRepository, IMapper mapper)
        {
            _userprofileRepository = userprofileRepository;
            _mapper = mapper;
        }

        [HttpGet("userprofiles")]
        public async Task<IActionResult> GetUserProfile()
        {
            var userprofiles = await _userprofileRepository.GetAll();
            var userprofilesDtos = _mapper.Map<List<GetUserProfileDto>>(userprofiles);
            return Ok(userprofilesDtos);
        }

        [HttpPost("userprofiles")]
        public async Task<IActionResult> CreateUserProfile([FromBody] CreateUserProfile createUserProfile)
        {
            var userprofile = _mapper.Map<UserProfile>(createUserProfile);
            var createdUserProfile = await _userprofileRepository.Add(userprofile);
            var userProfileDto = _mapper.Map<GetUserProfileDto>(createdUserProfile);
            return CreatedAtAction(nameof(GetUserProfile), new { id = userProfileDto.UserId }, userProfileDto);
        }
    }
}
