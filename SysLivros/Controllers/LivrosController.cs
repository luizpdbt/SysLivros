using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using SysLivros.Model;

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



        //[HttpPost]
        //[Route("api/ManipulaStream")]
        //public IActionResult ManipulaStream(string nomeArquivo)
        //{
        //    var creatFile = new CreateFile();
        //    if (!Directory.Exists(@"C:\Teste"))
        //    {
        //        Directory.CreateDirectory(@"C:\Teste");
        //        creatFile.ArquivoCriar(nomeArquivo);
        //    }
        //    else
        //    {
        //        creatFile.ArquivoCriar(nomeArquivo);
        //        return Ok("Diretorio já existe, criado só a pasta");
        //    }
        //    return Ok("Diretorio Criado");
        //}
    }
}