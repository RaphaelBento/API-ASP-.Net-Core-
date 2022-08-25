using Api_DotNetCore.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_DotNetCore.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {

        private static List<Cliente> clientes = new List<Cliente>();

        [HttpGet]
        public List<Cliente> Get()
        {
            return clientes;
        }


    }
}
