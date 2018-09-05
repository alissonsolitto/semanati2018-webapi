using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using semanati2018_webapi.Interfaces;
using webapi.Data;
using webapi.Model;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // /api/User
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_userService.GetAll());
        }

        // /api/User/name/?
        [HttpGet("name/{name}")]
        public IActionResult GetName(string name)
        {
            return Ok(_userService.FindName(name));
        }

        // /api/User/email/?
        [HttpGet("email/{email}")]
        public IActionResult GetEmail(string email)
        {
            return Ok(_userService.FindEmail(email));
        }

        // /api/User
        [HttpPost]
        public IActionResult Post([FromBody] UserModel user)
        {
            try
            {
                _userService.Create(user);
                return Created("api/User", user);
            }
            catch (Exception ex)
            {                
                return StatusCode(500, ex);
            }
        }

        // /api/User
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UserModel user)
        {
            try
            {
                return Ok(_userService.Update(id, user));
            }
            catch (Exception ex)
            {                
                return StatusCode(500, ex);
            }
        }

        // /api/User
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                return Ok(_userService.Delete(id));
            }
            catch (Exception ex)
            {                
                return StatusCode(500, ex);
            }
        }
    }
}