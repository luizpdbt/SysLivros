using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SysLivros.Controllers
{
    [ApiController]
    public class LivrosController : ControllerBase
    {

        [HttpGet]
        [Route("api/Livros")]
        public IActionResult RetornaLivros()
        {

            return Ok(new 
            {
                livros="Cronnicas de Narnia,Fantastico Mundo de Bob,Mulher gato, el mariate"
            });
        }


    }
}