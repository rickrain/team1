using System;
using Microsoft.AspNetCore.Mvc;

namespace Svc1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Svc1 : ControllerBase
    {
        [HttpGet]
        public String Get()
        {
            return "Hello from 'Svc1'";
        }
    }
}
