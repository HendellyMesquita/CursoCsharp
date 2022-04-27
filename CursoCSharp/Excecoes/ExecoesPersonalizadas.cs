using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excecoes
{

    public class NegativoException : Exception
    {
        public NegativoException() { }
        public NegativoException(string message) : base(message) { }
        public NegativoException(string message, Exception inner) : base(message, inner) { }
    }
    public class ImparException : Exception
    {
        public ImparException(string message) : base(message) { }
    }
    class ExecoesPersonalizadas
    {
        public static int PositivoPar()
        {
            Random random = new Random();
            int valor = random.Next(-31, 31);
            if (valor < 0)

                throw new NegativoException("Numero Negativo...");

            if (valor % 2 == 1)
                throw new NegativoException("Valor Impar...");

            return valor;
        }
        public static void Executar()
        {

            try
            {
                Console.WriteLine(PositivoPar());
            }
            catch (NegativoException ex)
            {
                Console.WriteLine(PositivoPar());
                Console.WriteLine(ex.Message);
            }
            catch (ImparException ex)
            {
                Console.WriteLine(PositivoPar());
                Console.WriteLine(ex.Message);
            }
        }

    }
}
