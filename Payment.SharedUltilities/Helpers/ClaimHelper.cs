using Microsoft.IdentityModel.Tokens;
using Payment.SharedUltilities.Global;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Payment.SharedUltilities.Helpers
{
    public class ClaimHelper
    {
        public static string GenerateTokenStringForClaims(Dictionary<string, string> claims)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(AppGlobal.TokenSecretKey);
            var tokenClaims = new List<Claim>();
            foreach (var claim in claims)
            {
                var tokenClaim = new Claim(claim.Key, claim.Value);
                tokenClaims.Add(tokenClaim);
            }
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(tokenClaims.ToArray()),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
