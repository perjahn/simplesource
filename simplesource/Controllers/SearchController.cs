using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace simplesource.Controllers
{
    [Produces("application/json")]
    [Route("search")]
    public class SearchController : Controller
    {
        // POST /search
        [HttpPost]
        public string Post([FromBody]string value)
        {
            using (StreamWriter sw = new StreamWriter("logS.txt", true))
            {
                sw.WriteLine($"{DateTime.UtcNow:HH:mm:ss}: search");
            }

            dynamic j = new JObject();
            j.aa = 11;
            j.bb = "ss";

            return j.ToString();
        }
    }
}