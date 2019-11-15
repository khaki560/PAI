using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BlogWeb.Controllers
{
    public class ValuesController : ApiController
    {
        public IEnumerable<string> GetAll()
        {
            return new string[] { "value1", "value2" };

        }

        public string Get(int id)
        {
            return "value";
        }

        public void Post([FromBody]string value)
        {

        }
    }
}
