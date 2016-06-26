using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Util.Web
{
    public class RequisicaoWeb
    {
        public StatusRequisicao Status { get; set; }
        public string StringRetorno { get; set; }
        public HttpStatusCode StatusCode { get; set; }

        /// <summary>
        /// Faz uma requisição à URL informada.
        /// </summary>
        /// <param name="uri">URL da requisição</param>
        /// <param name="requestHeaders">Parâmetros a serem adicionados ao cabeçalho da requisição. Exemplo: key: "Authorization" value: "Token para autenticação do usuário"</param>
        /// <param name="method"></param>
        /// <param name="postData"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        public static RequisicaoWeb Requisicao(string uri, Dictionary<HttpRequestHeader, string> requestHeaders = null, string method = "GET",
            object postData = null, string contentType = "application/json")
        {
            var retorno = new RequisicaoWeb();

            var request = WebRequest.CreateHttp(uri);
            request.Method = method;
            request.AllowAutoRedirect = false;
            request.CookieContainer = new CookieContainer();
            request.ContentLength = 0;

            if (requestHeaders != null)
            {
                //Add Request Headers
                foreach (var header in requestHeaders)
                    request.Headers.Add(header.Key, header.Value);
            }

            if (postData != null)
            {
                byte[] byteArray;

                if (contentType == "application/json")
                {
                    //Convert post data object to Json
                    var objectJson = JsonConvert.SerializeObject(postData);
                    //Get bytes from Json object
                    byteArray = Encoding.UTF8.GetBytes(objectJson);
                }
                else
                {
                    byteArray = (byte[])postData;
                }

                // Set the ContentType property of the HttpWebRequest.
                request.ContentType = contentType;
                // Set the ContentLength property of the HttpWebRequest.
                request.ContentLength = byteArray.Length;
                // Get the request stream.
                using (Stream dataStream = request.GetRequestStream())
                {
                    // Write the data to the request stream.
                    dataStream.Write(byteArray, 0, byteArray.Length);
                    dataStream.Close();
                }
            }

            try
            {
                using (var response = request.GetResponse())
                using (var responseStream = response.GetResponseStream())
                using (var responseReader = new StreamReader(responseStream))
                {
                    retorno.StringRetorno = responseReader.ReadToEnd();
                    retorno.StatusCode = ((HttpWebResponse)response).StatusCode;
                }

                retorno.Status = StatusRequisicao.OK;
            }
            catch (WebException ex)
            {
                if (((HttpWebResponse)ex.Response).StatusCode == HttpStatusCode.NotFound)
                {
                    retorno.StringRetorno = "";
                    retorno.StatusCode = HttpStatusCode.NotFound;
                    retorno.Status = StatusRequisicao.OK;
                }
                else
                {
                    var errResp = ex.Response;
                    var text = string.Empty;

                    if (errResp != null)
                    {
                        using (Stream respStream = errResp.GetResponseStream())
                        {
                            using (StreamReader reader = new StreamReader(respStream))
                                text = reader.ReadToEnd();
                        }
                    }

                    retorno.StringRetorno = text;
                    retorno.StatusCode = ((HttpWebResponse)errResp).StatusCode;
                    retorno.Status = StatusRequisicao.Error;
                }
            }
            catch (Exception ex)
            {
                retorno.StringRetorno = "Ocorreu um erro na requisição: " + ex.Message;
                retorno.StatusCode = HttpStatusCode.InternalServerError;
                retorno.Status = StatusRequisicao.Error;
            }

            return retorno;
        }

        public List<T> DeserializaLista<T>()
        {
            return Deserializa<List<T>>() ?? new List<T>();
        }

        public T Deserializa<T>()
        {
            if (this.Status == RequisicaoWeb.StatusRequisicao.OK)
                return JsonConvert.DeserializeObject<T>(StringRetorno);
            else
                throw new WebException(StringRetorno);
        }

        public enum StatusRequisicao
        {
            OK,
            Error
        }
    }
}
