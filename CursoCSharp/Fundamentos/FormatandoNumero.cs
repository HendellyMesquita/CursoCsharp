using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            int valorinteiro = 15;

            Console.WriteLine("Valor padrão" + valor);

            //tipos dee formatação
            Console.WriteLine(valor.ToString("F3"));            // Quantidades de casa apos a virgula
            Console.WriteLine(valor.ToString("C"));             // Simbulo de dinheiro
            Console.WriteLine(valor.ToString("P"));             // Converter valor para porcentagem
            Console.WriteLine(valor.ToString("#.##"));          // Quantidades de casa apos a virgula
            Console.WriteLine(valorinteiro.ToString("D5"));     // Completa o tamanho informado com 0 a esquerta

            //converte para o Pais informado
            CultureInfo PT = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C3", PT));

            CultureInfo US = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C3", US));

        }

    }
}
