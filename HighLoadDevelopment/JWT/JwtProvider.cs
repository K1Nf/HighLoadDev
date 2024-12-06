﻿using HighLoadDevelopment.Interfaces;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace HighLoadDevelopment.JWT
{
    public class JwtProvider(IOptions<JwtConfiguration> options) : IJwtProvider
    {
        private readonly JwtConfiguration _jwtConfiguration = options.Value;

        public string CreateNewToken(Guid userId, string userName)
        {
            var signingCredentials = new SigningCredentials(
                new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtConfiguration.SecretKey)), SecurityAlgorithms.HmacSha384);

            Claim[] claims = [
                new(_jwtConfiguration.UserIdentity, userId.ToString()),
                new(ClaimTypes.Name, userName)
                ];


            var token = new JwtSecurityToken(
                claims: claims,
                signingCredentials: signingCredentials,
                expires: DateTime.UtcNow.AddMinutes(_jwtConfiguration.ExpiresMinutes),
                issuer: _jwtConfiguration.Issuer,
                audience: _jwtConfiguration.Audience
                );



            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
