using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using T7.ControleFinanceiro.Domain.Entities.Account;
using T7.ControleFinanceiro.Domain.Interface.Service.Account;

namespace T7.ControleFinanceiro.Test.OAuth
{
    [TestClass]
    public class LoginTest : TestBase
    {
        [TestMethod]
        public void Validate()
        {
            var client = new HttpClient(); // no HttpServer
            var url = "http://localhost:18255/api/oauth/login";

            using (var httpClient = new HttpClient())
            {
                var parameters = new Dictionary<string, string>()
                {
                    {"Email","teste@teste.com"},
                    {"Password","Teste@17"}
                };
                var encodedContent = new FormUrlEncodedContent(parameters);

                httpClient.PostAsync(url, encodedContent).ContinueWith(t =>
                {

                });
                
            }
        }
    }
}