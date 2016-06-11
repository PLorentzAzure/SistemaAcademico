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
using SistemaAcademico.Servico.Models.Dto;

namespace SistemaAcademico.Servico.Controllers
{
    public class BoletinsController : Controlador<Matricula>
    {
        [HttpGet]
        public IHttpActionResult Buscar(int id)
        {
            var atividades = adaptador.GerenciadorMatricula.BuscarAtividades(id);
            var atividadesPorDisciplina = atividades.GroupBy(
                a => a.MatriculaOfertaGradeDisciplina.OfertaGradeDisciplina.GradeDisciplina.Disciplina
            );
            return Ok(atividadesPorDisciplina.Select(a => new BoletimDisciplinaDto(a.Key, a)));
        }
    }
}