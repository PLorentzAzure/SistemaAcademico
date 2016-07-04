using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using SistemaAcademico.Servico.Seguranca.Contrato;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Servico.Seguranca
{
    internal class EmissorTokenJwt : IEmissorToken
    {
        private static readonly Microsoft.IdentityModel.Tokens.SecurityKey chave;
        private const string issuer = nameof(SistemaAcademico.Servico.Seguranca.EmissorTokenJwt);

        static EmissorTokenJwt()
        {
            chave = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(GetBytes(ConfigurationManager.AppSettings["ChaveToken"]));
        }

        public string CriaToken(InformacaoToken info)
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.Authentication, JsonConvert.SerializeObject(info), JsonClaimValueTypes.Json)
            };

            var handler = new JwtSecurityTokenHandler();
            var agora = DateTime.Now;
            var valoresToken = new Microsoft.IdentityModel.Tokens.SecurityTokenDescriptor
            {
                NotBefore = DateTime.Now.AddDays(-1),
                Expires = agora.AddMinutes(Convert.ToInt32(ConfigurationManager.AppSettings["ExpiracaoTokenMinutos"] ?? "60")),
                IssuedAt = agora,
                Issuer = issuer,
                Subject = new ClaimsIdentity(claims),
                SigningCredentials = new Microsoft.IdentityModel.Tokens.SigningCredentials(
                        chave, "http://www.w3.org/2001/04/xmldsig-more#hmac-sha256")
            };

            return handler.WriteToken(handler.CreateToken(valoresToken));
        }

        public bool ValidaToken(string token, out InformacaoToken info)
        {
            if (string.IsNullOrWhiteSpace(token))
            {
                info = null;
                return false;
            }

            var handler = new JwtSecurityTokenHandler();

            var parametros = new TokenValidationParameters
            {
                RequireSignedTokens = true,
                IssuerSigningKey = chave,
                ValidateAudience = false,
                ValidateActor = false,
                ValidateIssuer = true,
                ValidateIssuerSigningKey = true,
                ValidateLifetime = true,
                ValidIssuer = issuer
            };

            try
            {
                Microsoft.IdentityModel.Tokens.SecurityToken securityToken;
                var principal = handler.ValidateToken(token, parametros, out securityToken);

                var claim = principal.Claims.First(c => c.Type == ClaimTypes.Authentication);

                info = JsonConvert.DeserializeObject<InformacaoToken>(claim.Value);

                return info.IdUsuario > 0;
            }
            catch (Exception)
            {
                info = null;
                return false;
            }
        }

        public static byte[] GetBytes(string input)
        {
            var bytes = new byte[input.Length * sizeof(char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }
    }
}
