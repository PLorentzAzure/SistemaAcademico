using SistemaAcademico.Dominio;
using SistemaAcademico.Dominio.Base;
using SistemaAcademico.Negocio.Gerenciador;
using SistemaAcademico.Servico.Controllers.Base;
using SistemaAcademico.Servico.Dto;
using SistemaAcademico.Servico.Filtro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static SistemaAcademico.Dominio.Base.Servico;

namespace SistemaAcademico.Servico.Controllers
{
    public class RetificacoesFaltaController : ControladorCrudDto<RetificacaoFalta, RetificacaoFaltaDto>
    {
        [HttpPut]
        [ValidaToken(Perfis = new[] { PerfilPessoa.Professor })]
        [Route("api/RetificacoesFalta/{id}/Aprovar")]
        public IHttpActionResult Aprovar(int id)
        {
            return AlterarStatus(id, StatusServico.Aprovado);
        }

        [HttpPut]
        [ValidaToken(Perfis = new[] { PerfilPessoa.Professor })]
        [Route("api/RetificacoesFalta/{id}/Rejeitar")]
        public IHttpActionResult Rejeitar(int id)
        {
            return AlterarStatus(id, StatusServico.Rejeitado);
        }

        [ValidaToken]
        public override IHttpActionResult Buscar()
        {
            var retificacoes = adaptador.GerenciadorRetificacaoFalta.BuscarPorPessoa(InformacaoTokenValidado.IdPessoa ?? 0, InformacaoTokenValidado.TipoPerfil);
            return Ok(retificacoes.Select(rf => CriarDto(rf)).ToList());
        }

        public override IHttpActionResult Excluir(int id)
        {
            return Unauthorized();
        }

        public override IHttpActionResult Editar(int id, RetificacaoFaltaDto entidade)
        {
            return Unauthorized();
        }

        private IHttpActionResult AlterarStatus(int id, StatusServico status)
        {
            if (adaptador.GerenciadorRetificacaoFalta.AlterarStatus(id, status))
                return StatusCode(HttpStatusCode.NoContent);
            return BadRequest(ModelState);
        }
    }
}
