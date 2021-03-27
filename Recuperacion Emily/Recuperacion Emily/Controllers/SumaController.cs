using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Recuperacion_Emily.Controllers
{
    
    public class SumaController : ApiController
    {
        [HttpGet]
        public int suma(int a, int b)
        {
            return a + b;

        }
    }
}
