using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using T7.ControleFinanceiro.Domain.Interface.Service.Account;
using T7.ControleFinanceiro.Domain.Entities.Account;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;

namespace T7.ControleFinanceiro.Test.Account
{
    [TestClass]
    public class RegisterTest : TestBase
    {
        [TestMethod]
        public async void TestAdd()
        {
            var client = new HttpClient(); // no HttpServer
            var url = "http://localhost:18255/api/register/add";

            //var param = "Email=teste@teste.com&Password=Teste@17&ConfirmPassword=Teste@17&Name=Julio&LastName=Cesar&DateBirth=01/01/1987";

            using (var httpClient = new HttpClient())
            {
                var parameters = new Dictionary<string, string>()
                {
                    {"Email","teste@teste.com"},
                    {"Password","Teste@17"},
                    {"ConfirmPassword","Teste@17"},
                    {"Name","Julio"},
                    {"LastName","Cesar"},
                    {"DateBirth","01/01/1987"}
                };
                var encodedContent = new FormUrlEncodedContent(parameters);

                var response = await httpClient.PostAsync(url, encodedContent).ConfigureAwait(false);
                if (response.StatusCode == HttpStatusCode.OK)
                {

                }
            }

            /*
            var request = new HttpRequestMessage
            {
                RequestUri = new Uri(url),
                Method = HttpMethod.Post,
                Content = param
            };

            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            using (var response = client.post(request, param).Result)
            {
                Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            }
             */
        }
    }
}