using ArunExtraedgeassignment.Model;
using ArunExtraedgeassignment.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace ArunExtraedgeassignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IConfiguration _config;
        private readonly ILoginService service;

        public LoginController(IConfiguration config, ILoginService service)
        {
            _config = config;
            this.service = service;
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login([FromBody] UserModel login)
        {
           // IActionResult response = Unauthorized();
            var user = service.Add(login);

            /*if (user != null)
            {
                var tokenString = GenerateJSONWebToken(user);
                response = Ok(new { token = tokenString });
            }*/

            return Ok(user);
        }

       

       
    }
}
