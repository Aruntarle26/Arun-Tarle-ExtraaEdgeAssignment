using ArunExtraedgeassignment.Model;
using ArunExtraedgeassignment.Repository;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ArunExtraedgeassignment.Service
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository repo;
        private readonly IConfiguration configuration;
        public LoginService(ILoginRepository repo, IConfiguration configuration)
        {
            this.repo = repo;
            this.configuration = configuration;
        }
        public LoginOutput Add(UserModel userModel)
        {
            
            var user= repo.Add(userModel);
            if (user != null)
            {
                var token = GenerateJsonWebTokenExtension(userModel);
                return new LoginOutput() { Token = token, UserId = user.userId, UserName = user.UserName };

            }
            else
            {
                return null;
            }
        }
        private string GenerateJsonWebTokenExtension(UserModel user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                new Claim(ClaimTypes.Email,user.EmailAddress),
               
                new Claim("UserId",user.userId.ToString()),
                new Claim(ClaimTypes.Actor,user.userId.ToString()),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
            };

            var token = new JwtSecurityToken(
                issuer: configuration["Jwt:Issuer"],
                audience: configuration["Jwt:Issuer"],
                claims,
                expires: DateTime.Now.AddHours(2),
                signingCredentials: credentials
                );
            var encodeToeken = new JwtSecurityTokenHandler().WriteToken(token);

            return encodeToeken;
        }
    }
}
