using System;
using Microsoft.AspNetCore.Mvc;


namespace Svc2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Svc2 : ControllerBase
    {
        [HttpGet]
        public String Get()
        {
            return "Hello from 'Svc2'";
        }
    }
}
