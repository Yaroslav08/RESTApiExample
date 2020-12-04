using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RESTApi.Models;
using RESTApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace RESTApi.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet()]
        public IActionResult GetAllUsers() => Ok(_userService.GetAllUsers());

        [HttpGet("{id}")]
        public IActionResult GetUserById(string id) => Ok(_userService.GetUserById(id));


        [HttpGet("search")]
        public IActionResult GetUsersByName(string name) => Ok(_userService.GetUserByName(name));

        [HttpPost()]
        public IActionResult CreateUser([FromBody] User user) => Ok(_userService.CreateUser(user));
    }
}