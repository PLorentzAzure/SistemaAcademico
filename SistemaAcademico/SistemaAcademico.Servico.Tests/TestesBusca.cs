using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaAcademico.Servico.Tests.Fakes;
using SistemaAcademico.Servico.Controllers;
using SistemaAcademico.Dominio;
using SistemaAcademico.Dados.Repositorio;
using SistemaAcademico.Negocio.Gerenciador;
using System.Net;
using System.Configuration;
using SistemaAcademico.Util.Web;
using System.Collections.Generic;
using Newtonsoft.Json;
using SistemaAcademico.Servico.Tests.Base;
using SistemaAcademico.Servico.Tests.Comparador;
using SistemaAcademico.Servico.Dto;

namespace SistemaAcademico.Servico.Tests
{
    [TestClass]
    public class TestesBusca : TesteWebApi
    {
        [TestMethod]
        public void BuscaDisciplinas()
        {
            var url = $"{UrlBase}Disciplinas";
            var disciplinas = RequisicaoWeb.Requisicao(url).DeserializaLista<Disciplina>();

            Assert.IsTrue(disciplinas.Count > 0, "Disciplinas não foram encontradas.");
            Assert.IsTrue(disciplinas.TrueForAll(d => d.Nome != null && d.Id > 0), "Disciplinas com dados inválidos.");
        }

        [TestMethod]
        public void BuscaRetificacaoFaltasIgualEspecificas()
        {
            var url = $"{UrlBase}RetificacoesFalta";

            var retificacoes = RequisicaoWeb.Requisicao(url).DeserializaLista<RetificacaoFaltaDto>();

            var comparador = new RetificacaoFaltaDtoEqualityComparer();

            foreach (var rf in retificacoes)
            {
                var retificacaoEspecifica = RequisicaoWeb.Requisicao($"{url}/{rf.Id}").Deserializa<RetificacaoFaltaDto>();

                Assert.IsTrue(comparador.Equals(rf, retificacaoEspecifica));
            }
        }
    }

}
