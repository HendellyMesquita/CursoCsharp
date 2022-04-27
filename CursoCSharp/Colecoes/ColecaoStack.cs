using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class ColecaoStack
    {
        public static void Executar()
        {
            var pilha = new Stack();

            pilha.Push("Maria");
            pilha.Push("João");
            pilha.Push("Paula");
            pilha.Push("Marcos");

            Console.WriteLine("Pessoas na fila: ");
            foreach (var pessoa in pilha)
            {
                Console.Write(pessoa + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine("Primeiro da lista: " + pilha.Peek());
            Console.WriteLine("Remover da lista: " + pilha.Pop());
            Console.WriteLine("------------------------");
            Console.WriteLine("Pessoas na fila: ");
            foreach (var pessoa in pilha)
            {
                Console.Write(pessoa + ", ");
            }
        }

    }
}
