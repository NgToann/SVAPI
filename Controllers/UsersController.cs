using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SVAPI.Data;
using SVAPI.Models;

namespace SVAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly SVAPIContext _context;
        private readonly IDataRepository<User> _repo;

        public UsersController(SVAPIContext context, IDataRepository<User> repo)
        {
            _context = context;
            _repo = repo;
        }

        // GET: api/Users
        [HttpGet]
        public IEnumerable<User> GetUsers()
        {
            return _context.Users;
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetUser([FromRoute]int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        // GET: api/userName/password
        [HttpGet("{username}/{password}")]
        public async Task<ActionResult> GetUser([FromRoute] string userName, [FromRoute] string password)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var user = await _context.Users.FirstOrDefaultAsync(f => f.UserName.Equals(userName) && f.Password.Equals(password));
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
    }
}
