using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    public class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Nota { get; set; }
    }
    class LINQ1
    {
        public static void Executar()
        {
            var dadosAlunos = new List<Aluno>
            {
                new Aluno(){Nome = "Pedro", Idade = 24, Nota = 8.0},
                new Aluno(){Nome = "Andre", Idade = 21, Nota = 4.0},
                new Aluno(){Nome = "Ana", Idade = 22, Nota = 9.5},
                new Aluno(){Nome = "Jorge", Idade =25, Nota = 5.5},
                new Aluno(){Nome = "Ana", Idade = 20, Nota = 7.0},
                new Aluno(){Nome = "Julia", Idade = 23, Nota = 7.5},
                new Aluno(){Nome = "Marcio", Idade = 24, Nota = 6.0},
            };
            Console.WriteLine("=======Alunos=======");
            var alunos = dadosAlunos.Where(a => true).OrderBy(a => -a.Idade);
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno.Nome + ", " + aluno.Idade + " anos. Nota: " + aluno.Nota);
            }

            Console.WriteLine();
            Console.WriteLine("======Aprovados=====");
            var aprovados = dadosAlunos.Where(a => a.Nota >= 7).OrderBy(a => a.Nome);
            foreach (var aprovado in aprovados)
            {
                Console.WriteLine(aprovado.Nome);
            }

            Console.WriteLine();
            Console.WriteLine("=====Reprovados=====");
            var reprovados = dadosAlunos.Where(a => a.Nota < 7).OrderBy(a => a.Nome);
            foreach (var reprovado in reprovados)
            {
                Console.WriteLine(reprovado.Nome);
            }

            Console.WriteLine();
            Console.WriteLine("=======Chamada======");
            var chamadas = dadosAlunos.OrderBy(a => a.Nome).Select(a => a.Nome);
            foreach (var chamada in chamadas)
            {
                Console.WriteLine(chamada);
            }

            Console.WriteLine();
            Console.WriteLine("=====Aluno Idade====");
            var alunosIdade =
                from aluno
                in dadosAlunos
                where aluno.Nota >= 7
                orderby aluno.Idade
                select aluno.Nome;
            foreach (var aluno in alunosIdade)
            {
                Console.WriteLine(aluno);
            }
        }

    }
}
