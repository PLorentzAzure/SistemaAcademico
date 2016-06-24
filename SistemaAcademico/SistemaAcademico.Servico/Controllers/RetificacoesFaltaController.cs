using SistemaAcademico.Dominio;
using SistemaAcademico.Negocio.Gerenciador;
using SistemaAcademico.Servico.Controllers.Base;
using SistemaAcademico.Servico.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static SistemaAcademico.Dominio.Base.Servico;

namespace SistemaAcademico.Servico.Controllers
{
    public class RetificacoesFaltaController : ControladorCrudDto<RetificacaoFalta, RetificacaoFaltaDTO>
    {
        [HttpPut]
        [Route("api/RetificacoesFalta/{id}/Aprovar")]
        public IHttpActionResult Aprovar(int id)
        {
            return AlterarStatus(id, StatusServico.Aprovado);
        }

        [HttpPut]
        [Route("api/RetificacoesFalta/{id}/Rejeitar")]
        public IHttpActionResult Rejeitar(int id)
        {
            return AlterarStatus(id, StatusServico.Rejeitado);
        }

        private IHttpActionResult AlterarStatus(int id, StatusServico status)
        {
            if (adaptador.GerenciadorRetificacaoFalta.AlterarStatus(id, status))
                return StatusCode(HttpStatusCode.NoContent);
            return BadRequest(ModelState);
        }
    }
}
