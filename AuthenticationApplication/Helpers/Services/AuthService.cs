using AuthenticationApplication.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AuthenticationApplication.Helpers.Services;

public class AuthService
{
    private readonly IConfiguration _configuration;

    public AuthService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public string GenerateJwtToken(User user)
    {
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:key"]!));
        var _credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        var _claims = new[]
        {
            new Claim(ClaimTypes.NameIdentifier,user.Id),
            new Claim(ClaimTypes.Name,user.Email!),
            new Claim(ClaimTypes.Email,user.Email!),
        };

        var token = new JwtSecurityToken
            (
            issuer: _configuration["Jwt:issuer"],
            audience: _configuration["Jwt:audience"],
            signingCredentials: _credentials,
            claims: _claims,
            expires: DateTime.Now.AddDays(4)
            );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
