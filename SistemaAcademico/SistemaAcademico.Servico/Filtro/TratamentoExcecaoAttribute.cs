﻿using SistemaAcademico.Util.Excecao;
using SistemaAcademico.Util.Excecao.Dado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Filters;

namespace SistemaAcademico.Servico.Filtro
{
    public sealed class TratamentoExcecaoAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            var ex = actionExecutedContext.Exception;
            var httpException = ex as HttpResponseException;
            if (httpException != null)
                actionExecutedContext.Response = httpException.Response;
            else
            {
                var codigo = ex is SalvarException ? HttpStatusCode.BadRequest : HttpStatusCode.InternalServerError;
                actionExecutedContext.Response = new HttpResponseMessage(codigo)
                {
                    Content = new StringContent(string.Join(" --> ", ex.BuscaTodasMensagens()))
                };
            }
        }
    }
}
