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
using static SistemaAcademico.Dominio.Base.Servico;
using SistemaAcademico.Servico.Tests.Comparador;
using SistemaAcademico.Servico.Dto;

namespace SistemaAcademico.Servico.Tests
{
    [TestClass]
    public class TestesRetificacao : TesteWebApi
    {
        [TestMethod]
        public void FluxoCompleto()
        {
            var url = $"{UrlBase}RetificacoesFalta";
            var comparador = new RetificacaoFaltaDtoEqualityComparer();

            var rfCriacao = new RetificacaoFaltaDto { IdMatricula = 1, IdOferta = 2, DataFalta = DateTime.Now.Date.AddDays(-1), Justificativa = "Tava chuvendo." };

            var rfCriada = RequisicaoWeb.Requisicao(url, method: "POST", postData: rfCriacao).Deserializa<RetificacaoFaltaDto>();

            rfCriacao.Id = rfCriada.Id;
            Assert.IsTrue(comparador.Equals(rfCriada, rfCriacao));
            Assert.AreEqual(rfCriacao.Justificativa, rfCriada.Justificativa);
            Assert.IsTrue(rfCriada.IdStatus == (int)StatusServico.Pendente);
            Assert.IsTrue(rfCriada.DataRequisicao > rfCriacao.DataFalta);

            RequisicaoWeb.Requisicao($"{url}/{rfCriacao.Id}/Aprovar", method: "PUT");
            var rfAprovada = RequisicaoWeb.Requisicao($"{url}/{rfCriacao.Id}").Deserializa<RetificacaoFaltaDto>();

            Assert.IsTrue(comparador.Equals(rfCriada, rfAprovada));
            Assert.IsTrue(rfAprovada.IdStatus == (int)StatusServico.Aprovado);
        }

        [TestMethod]
        public void ErroCriacao_DataInvalida()
        {
            var url = $"{UrlBase}RetificacoesFalta";

            var rfCriacao = new RetificacaoFalta { IdMatricula = 1, IdOferta = 2, DataFalta = DateTime.Now.Date.AddDays(10), Justificativa = "Tava chuvendo." };

            var resposta = RequisicaoWeb.Requisicao(url, method: "POST", postData: rfCriacao);

            Assert.AreEqual(HttpStatusCode.BadRequest, resposta.StatusCode);
        }

        [TestMethod]
        public void ErroCriacao_MatriculaInvalida()
        {
            var url = $"{UrlBase}RetificacoesFalta";

            var rfCriacao = new RetificacaoFalta { IdMatricula = 5000, IdOferta = 2, DataFalta = DateTime.Now.Date.AddDays(-1), Justificativa = "Tava chuvendo." };

            var resposta = RequisicaoWeb.Requisicao(url, method: "POST", postData: rfCriacao);

            Assert.AreEqual(HttpStatusCode.BadRequest, resposta.StatusCode);
        }

        [TestMethod]
        public void ErroCriacao_SemJustificativa()
        {
            var url = $"{UrlBase}RetificacoesFalta";

            var rfCriacao = new RetificacaoFalta { IdMatricula = 1, IdOferta = 2, DataFalta = DateTime.Now.Date.AddDays(-1), Justificativa = "" };

            var resposta = RequisicaoWeb.Requisicao(url, method: "POST", postData: rfCriacao);

            Assert.AreEqual(HttpStatusCode.BadRequest, resposta.StatusCode);
        }
    }
}
