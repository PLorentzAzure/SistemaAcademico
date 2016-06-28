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
using SistemaAcademico.Servico.Dto;
using SistemaAcademico.Servico.Filtro;
using SistemaAcademico.Dominio.Base;

namespace SistemaAcademico.Servico.Controllers
{
    public class BoletinsController : Controlador
    {
        [HttpGet]
        [ValidaToken(Perfis = new[] { PerfilPessoa.Aluno })]
        public IHttpActionResult Buscar(int id)
        {
            var matricula = adaptador.GerenciadorMatricula.Buscar(id);

            if (matricula == null)
                return NotFound();

            if (matricula.IdAluno != InformacaoTokenValidado.IdPessoa)
                return Unauthorized();

            var atividades = adaptador.GerenciadorMatriculaAtividade.BuscaAtividadesPorMatricula(id).ToList();
            return Ok(new BoletimDto(atividades.First().Key.Matricula, atividades));
        }
    }
}