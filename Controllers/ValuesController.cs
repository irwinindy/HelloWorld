using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HelloWorldApi.Models;
using Newtonsoft.Json;

namespace HelloWorldApi.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public string Get()
        {
            string phrase = "Hello World";
            return phrase;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}