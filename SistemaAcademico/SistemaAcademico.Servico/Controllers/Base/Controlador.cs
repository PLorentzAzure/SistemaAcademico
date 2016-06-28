using SistemaAcademico.Dominio;
using SistemaAcademico.Negocio.Gerenciador.Base;
using SistemaAcademico.Servico.Seguranca;
using SistemaAcademico.Util.Excecao.Dado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace SistemaAcademico.Servico.Controllers.Base
{
    public class Controlador : ApiController
    {
        protected readonly Adaptador adaptador;

        public Controlador()
        {
            this.adaptador = new Adaptador(RegistraErros);
        }

        public Controlador(Adaptador adaptador)
        {
            this.adaptador = adaptador;
        }

        public const string ChaveInformacaoToken = "6ae5fd96-c1eb-4f02-b42b-56c67d31a35a";

        protected InformacaoToken InformacaoTokenValidado { get { return Request.Properties[ChaveInformacaoToken] as InformacaoToken; } }

        protected void RegistraErros(string chave, string erro)
        {
            ModelState.AddModelError(chave, erro);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                adaptador.Dispose();

            base.Dispose(disposing);
        }
    }
}
