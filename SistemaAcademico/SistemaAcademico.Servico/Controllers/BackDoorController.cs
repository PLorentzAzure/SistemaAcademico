using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using SistemaAcademico.Dominio;
using SistemaAcademico.Servico.Controllers.Base;
using SistemaAcademico.Negocio.Gerenciador.Auxiliar;
using SistemaAcademico.Servico.Seguranca;

namespace SistemaAcademico.Servico.Controllers
{
    public class BackDoorController : Controlador
    {
        [HttpGet]
        [Route("api/BackDoor/"+nameof(ResetarBase))]
        public IHttpActionResult ResetarBase()
        {
            new GerenciadorBackDoor().ResetarBancoDeDados();

            return Ok();
        }

        [HttpPost]
        [Route("api/BackDoor/"+nameof(DadosToken))]
        public IHttpActionResult DadosToken([FromBody]string token)
        {
            InformacaoToken info;
            EmissorTokenFactory.BuscaEmissorToken().ValidaToken(token, out info);
            return Ok(info);
        }
    }
}