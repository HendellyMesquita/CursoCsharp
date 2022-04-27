using System;
using System.IO;

namespace CursoCSharp.Api
{
    public static class ExtensaoString
    {
        public static string ParseHome(this string path)
        {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix ||
                Environment.OSVersion.Platform == PlatformID.MacOSX)
                ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~", home);
        }
    }
    class PrimeiroArquivo
    {
        public static void Executar()
        {
            var path = @"~/source/repos/CURSO C#/Arquivos/File Info/Primeiro_arquivo.txt".ParseHome();

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Criando");
                    sw.WriteLine("E escrevendo");
                    sw.WriteLine("Meu Primeiro Arquivo");
                }
            }
            using(StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("");
                sw.Write("Modificnado o texto ");
                sw.Write("do meu Primeiro Arquivo");
            }
        }

    }
}
