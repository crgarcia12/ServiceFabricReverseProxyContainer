﻿using System.Collections;
using System.Web.Http;

namespace GreenApp.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IDictionary Get()
        {
            return System.Environment.GetEnvironmentVariables();
        }
    }
}
