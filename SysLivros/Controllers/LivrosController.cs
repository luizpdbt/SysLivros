using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Formatters;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.VisualBasic;
using SysLivros.Model;

namespace SysLivros.Controllers
{
    [ApiController]
    public class LivrosController : ControllerBase
    {
        static HttpClient client = new HttpClient();


        [HttpGet]
        [Route("api/Livros")]
        public async Task<IActionResult> RetornaLivrosAsync()
        {
            var p = new { };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await client.GetAsync("https://feed2json.org/convert?url=https://www.atcsimulation.com/blog-feed.xml");
            var retorno = await response.Content.ReadAsStringAsync();

            return Ok(retorno);
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