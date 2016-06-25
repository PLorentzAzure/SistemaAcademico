using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaAcademico.Util.Web;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Servico.Tests.Base
{
    public abstract class TesteWebApi
    {
        protected static string UrlBase = ConfigurationManager.AppSettings["UrlBase"];

        [TestInitialize]
        public void ResetaBD()
        {
            bool resetaBD;
            if (bool.TryParse(ConfigurationManager.AppSettings["ResetaBancoDados"], out resetaBD) && resetaBD)
            {
                var url = $"{UrlBase}ResetarBase/ResetarBase";
                var retorno = RequisicaoWeb.Requisicao(url);
            }
        }
    }
}
