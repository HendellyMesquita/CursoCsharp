using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excecoes
{

    public class Conta
    {
        double Saldo { get; set; }

        public Conta(double saldo)
        {
            Saldo = saldo;
        }
        public void Sacar(double valor)
        {
            if (valor > Saldo)
            {
                throw new ArgumentException("Saldo Insuficiente");
            }
            Saldo -= valor;
        }
    }
    class PrimeiraExcecao
    {
        public static void Executar()
        {
            var conta = new Conta(1_223.45);
            //usado sempre que existe uma possivel chance de exceção
            try
            {
                conta.Sacar(1600);
                Console.WriteLine("Retirada com sucesso!");
            }
            //tratamento de exceção 
            catch (Exception ex)
            {
                //informa tipo de exeção ocorrida
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            //execulta sempre ao final não importa o resultado dado em cima
            finally
            {
                Console.WriteLine("Obrigado");
            }
        }
    }
}
