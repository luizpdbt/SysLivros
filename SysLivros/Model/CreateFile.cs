using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLivros.Model
{
    public class CreateFile
    {
        public void ArquivoCriar(string nomeDoArquivo)
        {
            //File.GetAttributes();
            var files = Directory.GetFiles(@"C:\Users\Luizu\Desktop").ToList();
            //BuscaFotosPNGJPG
            var fotos = files.Where(x => x.Contains("JPG") ||
            x.Contains("jpg") || x.Contains("PNG") || x.Contains("png")).ToList();

            var fotosPNG = fotos.Where(x => x.Contains("PNG") || x.Contains("png")).ToList();
            var fotoJpg = fotos.Where(x => x.Contains("jpg") || x.Contains("JPG")).ToList();

            if (!File.Exists(@$"C:\FotosJpg") && !File.Exists(@$"C:\FotosPng"))
            {
                Directory.CreateDirectory(@$"C:\FotosPng");
                Directory.CreateDirectory(@"C:\FotosJpg");

                foreach (var item in fotosPNG)
                {
                    var filesplit = item.Split("\\");
                    var tamanho = filesplit.Length-1;

                    //File.Create(@$"C:\FotosPng\{filesplit[tamanho]}");
                    File.Copy(item, @$"C:\FotosPng\{filesplit[tamanho]}");
                    

                    File.Delete(item);
                }

                foreach (var item in fotosPNG)
                {
                    File.Copy(item, @"C:\FotosJpg");
                }
            }
         }
     }
 }


