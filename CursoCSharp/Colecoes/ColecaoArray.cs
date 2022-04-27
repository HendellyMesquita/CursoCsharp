using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class ColecaoArray
    {
        public static void Executar()
        {
            string[] alunos = new string[5];
            alunos[0] = "maria";
            alunos[1] = "lucas";
            alunos[2] = "ana";
            alunos[3] = "paulo";
            alunos[4] = "daiana";

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
                Console.WriteLine("------------------");
            }
            double somatorio = 0;
            double[] notas = { 9.1, 2.8, 6.3, 10.0, 5.5 };

            foreach (var nota in notas)
            {
                somatorio += nota;
            }
            double media = somatorio / notas.Length;
            Console.WriteLine(media);
            Console.WriteLine("------------------");
            
            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);
            Console.WriteLine("------------------");



            //for (int i =0; i <alunos.Length; i++)
            //{
            //    aluno += alunos[i];
            //}
            //for (int i =0; i <notas.Length; i++)
            //{
            //    somatorio += notas[i];
            //}
            //for (int i =0; i <letras.Length; i++)
            //{
            //    palavra += letras[i];
            //}
        }

    }
}
