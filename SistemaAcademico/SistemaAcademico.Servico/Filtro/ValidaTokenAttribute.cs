using SistemaAcademico.Dominio.Base;
using SistemaAcademico.Servico.Controllers.Base;
using SistemaAcademico.Servico.Seguranca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace SistemaAcademico.Servico.Filtro
{
    public sealed class ValidaTokenAttribute : AuthorizationFilterAttribute
    {
        public override bool AllowMultiple { get { return false; } }

        /// <summary>
        /// Perfil que tem acesso à funcionalidade, null caso todos tenham acesso.
        /// </summary>
        public PerfilPessoa[] Perfis { get; set; }

        /// <summary>
        /// Propriedade da toda que define o IdAluno. Se informada, só autoriza alunos com o id certo.
        /// </summary>
        public string PropriedadeRotaIdAluno { get; set; }

        public override void OnAuthorization(HttpActionContext actionContext)
        {
            var token = actionContext.Request.Headers.Authorization?.Parameter;
            InformacaoToken info;
            if (EmissorTokenFactory.BuscaEmissorToken().ValidaToken(token, out info))
            {
                int? idAluno = null;
                if (info.TipoPerfil == PerfilPessoa.Aluno && !string.IsNullOrEmpty(PropriedadeRotaIdAluno))
                    idAluno = Convert.ToInt32(actionContext.ControllerContext.RouteData.Values[PropriedadeRotaIdAluno]);

                if ((Perfis == null || Perfis.Contains(info.TipoPerfil)) && (!idAluno.HasValue || idAluno.Value == info.IdPessoa))
                {
                    actionContext.Request.Properties.Add(Controlador.ChaveInformacaoToken, info);
                    return;
                }
            }
            actionContext.Response = new HttpResponseMessage(HttpStatusCode.Unauthorized);
        }
    }
}
