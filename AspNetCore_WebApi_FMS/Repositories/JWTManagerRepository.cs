using AspNetCore_WebApi_FMS.Data;
using AspNetCore_WebApi_FMS.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace AspNetCore_WebApi_FMS.Repositories
{
    public class JWTManagerRepository : IJWTManagerRepository
    {
        private readonly IConfiguration iconfiguration;
        private FMSDbContext _db;
        public JWTManagerRepository(IConfiguration iconfiguration, FMSDbContext context)
        {
            this.iconfiguration = iconfiguration;
            this._db = context;
        }
        public MyJwtToken Authenticate(string username, string password)
        {
            var u = _db.Users.Include(u => u.Role).FirstOrDefault(u => u.UserName == username && u.Password == password);
            if (u == null)
                return null;
            // Else we generate JSON Web Token
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.UTF8.GetBytes(iconfiguration["JWT:Key"]);
            //var tokenDescriptor = new SecurityTokenDescriptor
            //{
            //    Subject = new ClaimsIdentity(new Claim[]
            //    {
            //        new Claim(ClaimTypes.Name, u.Email),
            //        new Claim(ClaimTypes.Role, u.Role.RoleName)
            //    }),
            //    Expires = DateTime.UtcNow.AddMinutes(10),
            //    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
            //};
            var tokenDescriptor = new SecurityTokenDescriptor();
            Claim c1 = new Claim(ClaimTypes.Name, u.UserName);
            Claim c2 = new Claim(ClaimTypes.Role, u.Role.RoleName);
            ClaimsIdentity cIdentity = new ClaimsIdentity(new Claim[] { c1, c2 });

            tokenDescriptor.Subject = cIdentity;
            tokenDescriptor.Expires = DateTime.UtcNow.AddMinutes(10);
            tokenDescriptor.SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature);
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return new MyJwtToken { Token = tokenHandler.WriteToken(token) };
        }
    }
}