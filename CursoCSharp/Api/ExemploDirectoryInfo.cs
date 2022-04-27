using System;
using System.IO;

namespace CursoCSharp.Api
{
    class ExemploDirectoryInfo
    {
        public static void Executar()
        {

            var diretorioProjeto = @"~/source/repos/CURSO C#/Arquivos".ParseHome();
            var diretorioInfo = new DirectoryInfo(diretorioProjeto);
            if (!diretorioInfo.Exists)
            {
                diretorioInfo.Create();
            }
            Console.WriteLine("\n\n========ARQUIVOS========");
            var arquivos = diretorioInfo.GetFiles();
            foreach (var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("\n\n========DIRETÓRIOS========");
            var pastas = diretorioInfo.GetFiles();
            foreach (var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }
            Console.WriteLine("\n\n========CAMINHOS========");
            Console.WriteLine(diretorioInfo.CreationTime);
            Console.WriteLine(diretorioInfo.FullName);
            Console.WriteLine(diretorioInfo.Parent);
            Console.WriteLine(diretorioInfo.Parent.Parent);
            Console.WriteLine(diretorioInfo.Root);
        }

    }

}
