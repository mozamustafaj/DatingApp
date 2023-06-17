using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Authorize] //Allows only authorized users we can do it for all the controller (to authorize every request) not only for e method
    //We can use [allowAnonymous] to allow anauthozied userss in method level
    public class UsersController : BaseApiController
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