using System;
using System.IO;

namespace CursoCSharp.Api
{
    //todas as informações importantes de um arquivo estao dentro de fileinfo em system.IO
    class ExemploFileInfo
    {
        public static void ExcluirSeExistir(params string[] caminhos)
        {
            foreach (var caminho in caminhos)
            {
                FileInfo arquivo = new FileInfo(caminho);
                if (arquivo.Exists)
                    arquivo.Delete();
            }
        }
        public static void Executar()
        {
            var caminhoOrigem = @"~/source/repos/CURSO C#/Arquivos/File Info/Origem_arquivo.txt".ParseHome();
            var caminhoDestino = @"~/source/repos/CURSO C#/Arquivos/File Info/Destino_arquivo.txt".ParseHome();
            var caminhoCopia = @"~/source/repos/CURSO C#/Arquivos/File Info/Copia_arquivo.txt".ParseHome();

            ExcluirSeExistir(caminhoOrigem, caminhoDestino, caminhoCopia);

            using (StreamWriter sw = File.CreateText(caminhoOrigem))
            {
                sw.WriteLine("Arquivo Original");
            }
            FileInfo origem = new FileInfo(caminhoOrigem);
            Console.WriteLine(origem.Name);
            Console.WriteLine(origem.IsReadOnly);
            Console.WriteLine(origem.FullName);
            Console.WriteLine(origem.Extension);
            Console.WriteLine(origem.DirectoryName);

            origem.CopyTo(caminhoCopia);
            origem.MoveTo(caminhoDestino);
        }

    }
}
