using API.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    //1. ApiController binds body to DTO. If we comment this line we have to specify [FromBody] on parameters on specific method
    //2. ApiController do the validations (anotations validations)
    [ApiController]  //atributes   
    [Route("api/[controller]")] //Controller name.  you can access as GET /api/users
    public class BaseApiController : ControllerBase
    {

    }
}