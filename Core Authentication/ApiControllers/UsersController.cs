using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core_Authentication.Entities;
using Core_Authentication.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core_Authentication.ApiControllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userservice;

        public UsersController(IUserService userService)
        {
            _userservice = userService;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] User userParam)
        {
            var user = _userservice.Authenticate(userParam.Username, userParam.Password);
            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });
            return Ok(user);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userservice.GetAll();
            return Ok(users);
        }
    }
}