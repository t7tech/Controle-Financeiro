using System.Collections.Generic;
using System.Web.Http;
using T7.ControleFinanceiro.Core.Web;

namespace T7.ControleFinanceiro.UI.Areas.Api.Controllers
{
    public class ProfileController : BaseApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2", UserId };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}