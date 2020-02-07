using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace KubWebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { Environment.MachineName, DateTime.Now.ToString() };
        }

    }
}
