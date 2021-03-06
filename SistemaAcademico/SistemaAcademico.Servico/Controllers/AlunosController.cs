﻿using System;
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
    public class AlunosController : Controlador
    {
        [HttpGet]
        [ValidaToken(PropriedadeRotaIdAluno = "idAluno")]
        [Route("api/Alunos/{idAluno}/Matriculas")]
        public IHttpActionResult BuscaMatriculasAluno(int idAluno)
        {
            var matriculas = adaptador.GerenciadorMatricula.BuscarMatriculas(idAluno).ToList();
            if (matriculas.Count < 1 && !adaptador.GerenciadorAluno.Existe(idAluno))
                return NotFound();

            return Ok(matriculas);
        }

        [HttpGet]
        [ValidaToken(PropriedadeRotaIdAluno = "idAluno")]
        [Route("api/Alunos/{idAluno}/Historico")]
        public IHttpActionResult BuscaHistoricoAluno(int idAluno)
        {
            var atividades = adaptador.GerenciadorMatriculaAtividade.BuscaAtividadesPorAluno(idAluno, true).ToList();
            if (atividades.Count < 1 && !adaptador.GerenciadorAluno.Existe(idAluno))
                return NotFound();

            return Ok(atividades.Select(a => new HistoricoPeriodoDto(a.Key, a)));
        }

        [HttpGet]
        [ValidaToken(PropriedadeRotaIdAluno = "idAluno")]
        [Route("api/Alunos/{idAluno}/GradeCurricular")]
        public IHttpActionResult BuscarGradeCurricularAluno(int idAluno)
        {
            var gradeAluno = adaptador.GerenciadorAluno.BuscarGradeAluno(idAluno);
            if (gradeAluno == null)
                return NotFound();

            return Ok(gradeAluno);
        }

        [HttpGet]
        [ValidaToken(Perfis = new[] { PerfilPessoa.Aluno })]
        [Route("api/Alunos/MinhaGradeCurricular")]
        public IHttpActionResult BuscarGradeCurricularAluno()
        {
            return BuscarGradeCurricularAluno(InformacaoTokenValidado.IdPessoa.Value);
        }
    }
}