using API_Coworking.DBContext;
using API_Coworking.Interfaces;
using API_Coworking.Models;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace API_Coworking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserService _UserService;

        public UserController(IUserService UserService)
        {
            _UserService = UserService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUser()
        {
            var User = await _UserService.GetAllUserAsync();
            return Ok(User);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var User = await _UserService.GetUserByIdAsync(id);
            if (User == null)
                return NotFound();

            return Ok(User);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(User User)
        {
            var result = await _UserService.CreateUserAsync(User);
            if (!result)
                return BadRequest("Email already exists");

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, User User)
        {
            if (id != User.id)
                return BadRequest();

            var result = await _UserService.UpdateUserAsync(User);
            if (!result)
                return NotFound();

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var result = await _UserService.DeleteUserAsync(id);
            if (!result)
                return NotFound();

            return Ok();
        }

        [HttpPost("authentication")]
        public async Task<IActionResult> Authenticate([FromBody] LoginRequest loginRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var authenticatedUser = await _UserService.AuthenticateAsync(loginRequest.Email, loginRequest.Password);
            if (authenticatedUser == null)
            {
                return Unauthorized();
            }

            return Ok(authenticatedUser);
        }
    }
}
