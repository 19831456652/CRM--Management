using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;

namespace CustomerManagement.API.Tools
{
    /// <summary>
    ///  JWT
    /// </summary>
    public class JwtFactory
    {
        /// <summary>
        /// 加密的 Token 值
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string GetToken(Claim[] data)
        {

            // 定义用户信息
            var claims = data;

            // 和 Startup 中的配置一致 可以配置在配置文件中
            SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("abcdABCD1234abcdABCD1234"));

            JwtSecurityToken token = new JwtSecurityToken(
                issuer: "server",
                audience: "client007",
                claims: claims,
                notBefore: DateTime.Now,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256)
            );

            string jwtToken = new JwtSecurityTokenHandler().WriteToken(token);
            return jwtToken;
        }
    }
}
