using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Auth.Contracts;
using Auth.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cards.Commands.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] AuthenticateModel model)
        {
            var user = _userService.Authenticate(model.UserName, model.Password); 
            if (user == null)
                return BadRequest(new { message = "Kullanıcı adı veya parola hatalı" });

            return Ok(user);
        }

       
    }
}