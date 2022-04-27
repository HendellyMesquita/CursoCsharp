using System;
using System.IO;

namespace CursoCSharp.Api
{
    class Diretorios
    {
        public static void Executar()
        {
            var caminhoOrigem = @"~/source/repos/CURSO C#/Arquivos/File Info/Pasta CSharp".ParseHome();
            var caminhoDestino = @"~/source/repos/CURSO C#/Arquivos/File Info/Pasta CSharp Destino".ParseHome();
            var caminhoCopia = @"~/source/repos/CURSO C#/Arquivos".ParseHome();

            if (Directory.Exists(caminhoOrigem))
                Directory.Delete(caminhoOrigem, true);

            if (Directory.Exists(caminhoDestino))
                Directory.Delete(caminhoDestino, true);

            Directory.CreateDirectory(caminhoOrigem);
            Console.WriteLine(Directory.GetCreationTime(caminhoOrigem));

            Console.WriteLine("========PASTAS========");
            var pastas = Directory.GetDirectories(caminhoCopia);
            foreach (var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }
            Console.WriteLine("\n\n========ARQUIVOS========");
            var arquivos = Directory.GetFiles(caminhoCopia);
            foreach (var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }
            Console.WriteLine("\n\n========RAIZ========");
            Console.WriteLine(Directory.GetDirectoryRoot(caminhoOrigem));

            Directory.Move(caminhoOrigem, caminhoDestino);
        }
    }
}
