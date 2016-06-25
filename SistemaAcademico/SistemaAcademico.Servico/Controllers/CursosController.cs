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

namespace SistemaAcademico.Servico.Controllers
{
    public class CursosController : ControladorCrudDominio<Curso>
    {
        [HttpGet]
        [Route("api/Cursos/{idCurso}/GradeAtiva")]
        public IHttpActionResult BuscarGradeAtiva(int idCurso)
        {
            var grade = adaptador.GerenciadorGrade.BuscarPorCurso(idCurso);
            return Ok(grade);
        }
    }
}