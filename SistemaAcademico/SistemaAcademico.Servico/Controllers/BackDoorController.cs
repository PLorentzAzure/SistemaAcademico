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

namespace SistemaAcademico.Servico.Controllers
{
    public class BackDoorController : Controlador
    {
        [HttpGet]
        public IHttpActionResult ResetarBase()
        {
            new GerenciadorBackDoor().ResetarBancoDeDados();

            return Ok();
        }
    }
}