using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Api
{
    class ExemploPath
    {

        public static void Executar()
        {
            var pasta = @"~/source/repos/CURSO C#/Arquivos/Path_Pasta".ParseHome();
            var arquivo = @"~/source/repos/CURSO C#/Arquivos/Path_Pasta/Path_Arquio.txt".ParseHome();

            if (!Directory.Exists(pasta))
                Directory.CreateDirectory(pasta);
         
            if (!File.Exists(arquivo))
            {
                using (StreamWriter sw = File.CreateText(arquivo))
                {
                    sw.WriteLine("Novo arquivo");
                }
            }
            Console.WriteLine("\n\n========ARQUIVO========");
            Console.WriteLine(Path.GetExtension(arquivo));
            Console.WriteLine(Path.GetFileName(arquivo));
            Console.WriteLine(Path.GetFileNameWithoutExtension(arquivo));
            Console.WriteLine(Path.GetDirectoryName(arquivo));
            Console.WriteLine(Path.HasExtension(arquivo));

            Console.WriteLine("\n\n========PASTA========");
            Console.WriteLine(Path.GetFileNameWithoutExtension(pasta));
            Console.WriteLine(Path.GetDirectoryName(pasta));
            Console.WriteLine(Path.HasExtension(pasta));
        }

    }
}
