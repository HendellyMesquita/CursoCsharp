using System;

namespace CursoCSharp.MetodosEFuncoes
{
    public static class ExtensoesInteiro
    {
        public static int Soma(this int num1, int num2)
        {
            return num1 + num2;

        }
        public static int Subtracao(this int num1, int num2)
        {
            return num1 - num2;
        }
    }
    class MetodosDeExtensao
    {
        public static void Executar()
        {
            Console.WriteLine(5.Soma(3));
            Console.WriteLine(10.Subtracao(5));

        }

    }
}
