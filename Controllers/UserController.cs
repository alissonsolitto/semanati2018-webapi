using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using webapi.Data;
using webapi.Model;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // /api/User
        [HttpGet]
        public List<UserModel> GetAll()
        {
            return ListData.lstUser;
        }

        // /api/User/name/?
        [HttpGet("name/{name}")]
        public UserModel GetName(string name)
        {
            return ListData.lstUser.Find(x => x.Name == name);
        }

        // /api/User/email/?
        [HttpGet("email/{email}")]
        public UserModel GetEmail(string email)
        {
            return ListData.lstUser.Find(x => x.Email == email);
        }

        




    }
}