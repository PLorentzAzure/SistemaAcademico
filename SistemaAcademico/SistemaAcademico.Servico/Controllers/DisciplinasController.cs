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

namespace SistemaAcademico.Servico.Controllers
{
    public class DisciplinasController : ControladorCrud<Disciplina>
    {
        [HttpGet]
        [Route("api/Disciplinas/Matricula/{idMatricula}")]
        public IHttpActionResult BuscaMatriculasAluno(int idMatricula)
        {
            var matriculas = adaptador.GerenciadorMatricula.BuscarOfertas(idMatricula).Select(mo => mo.Oferta.GradeDisciplina.Disciplina).ToList();
            if (matriculas.Count < 1 && !adaptador.GerenciadorMatricula.Existe(idMatricula))
                return NotFound();

            return Ok(matriculas);
        }
    }
}