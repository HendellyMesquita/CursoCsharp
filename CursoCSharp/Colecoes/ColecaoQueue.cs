using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class ColecaoQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();

            fila.Enqueue("Maria");
            fila.Enqueue("João");
            fila.Enqueue("Paula");
            fila.Enqueue("Marcos");

            foreach (var pessoa in fila)
            {
                Console.Write(pessoa+", ");
            }
            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine("Primeiro da lista " + fila.Peek());
            Console.WriteLine("Pessoas na fila " + fila.Count);
            Console.WriteLine("Remover da lista " + fila.Dequeue());
            Console.WriteLine("Pessoas na fila " + fila.Count);
            Console.WriteLine("------------------------");

            foreach (var pessoa in fila)
            {
                Console.Write(pessoa + ", ");
            }
            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);
            Console.WriteLine();
            Console.WriteLine(salada.Contains("item"));

        }


    }
}
