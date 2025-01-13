using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using UdenDockerApi.Models;
using UdenDockerApi.Context;

using Microsoft.EntityFrameworkCore;

namespace UdenDockerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DatabaseContext _Context;

        public UserController(DatabaseContext context)
        {
            _Context = context;
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] User user)
        {
            _Context.Users.Add(user);
            await _Context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task< IActionResult> GetAllUsersById(string id) 
        {
            var user = await _Context.Users.FindAsync(id);
           
            return Ok(user);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var user = await _Context.Users.ToListAsync();

            return Ok(user);
        }

    } 
}
