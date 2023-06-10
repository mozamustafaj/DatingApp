using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]  //atributes
    [Route("api/[controller]")] //Controller name.  you can access as GET /api/users
    public class UsersController : ControllerBase
    {
        public DataContext _Context { get; set; }

        public UsersController(DataContext context)
        {
            _Context = context;
        }

        [HttpGet] //HTTP method to get the request
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()  //Return IEnumerable of type AppUser
        {
            var users = await _Context.Users.ToListAsync();
            return users;
        }

        [HttpGet("{id}")] //HTTP method to get the request
        public async Task<ActionResult<AppUser>> GetUsers(int id)  //Return IEnumerable of type AppUser
        {
          return await _Context.Users.FindAsync(id);
        }
    }
}