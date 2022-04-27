using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    class LINQ2
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
            var pedro = dadosAlunos.Single(aluno => aluno.Nome.Equals("Pedro"));
            Console.WriteLine($"{pedro.Nome}, Nota: {pedro.Nota}");
            Console.WriteLine("");


            var ana = dadosAlunos.First(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine($"Primeiro encontrado: {ana.Nome}, Nota: {ana.Nota}");
            Console.WriteLine("");


            var ana2 = dadosAlunos.LastOrDefault(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine($"Ultimo encontrado: {ana2.Nome}, Nota: {ana2.Nota}");
            Console.WriteLine("------------------------");

            var exemploSkip = dadosAlunos.Skip(1).Take(3);
            foreach (var item in exemploSkip)
            {
                Console.WriteLine(item.Nome);
            }
            Console.WriteLine("------------------------");

            var maiorNota = dadosAlunos.Max(dadosAlunos => dadosAlunos.Nota);
            Console.WriteLine(maiorNota);

            var menorNota = dadosAlunos.Min(dadosAlunos => dadosAlunos.Nota);
            Console.WriteLine(menorNota);
            Console.WriteLine("------------------------");
            
            var somatorioNotas = dadosAlunos.Sum(aluno => aluno.Nota);
            Console.WriteLine("Somatorio das Notas:");
            Console.WriteLine(somatorioNotas);
            Console.WriteLine();

            var mediaDaTurma = dadosAlunos.Average(aluno => aluno.Nota);
            Console.WriteLine("Media da Turma:");
            Console.WriteLine(mediaDaTurma);
            Console.WriteLine();

            var mediaAprovados = dadosAlunos.Where(a => a.Nota >= 7).Average(aluno => aluno.Nota);
            Console.WriteLine("Media dos Aprovados:");
            Console.WriteLine(mediaAprovados);
            Console.WriteLine();

            var mediaReprovados = dadosAlunos.Where(a => a.Nota < 7).Average(aluno => aluno.Nota);
            Console.WriteLine("Media dos Reprovados:");
            Console.WriteLine(mediaReprovados);
            Console.WriteLine("------------------------");

            var alunoNome = dadosAlunos.SingleOrDefault(aluno => aluno.Nome.Equals("Fulano"));
            if (alunoNome == null)
                Console.WriteLine("Aluno Inexistente");
            Console.WriteLine("");

            var PrimeiroAlunoNome = dadosAlunos.FirstOrDefault(aluno => aluno.Nota.Equals("Fulano"));
            if (PrimeiroAlunoNome == null)
                Console.WriteLine("Aluno Inexistente");
            Console.WriteLine("------------------------");
        }

    }
}
