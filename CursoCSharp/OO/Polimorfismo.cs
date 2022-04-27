using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    public class Comida
    {
        public double Peso;
        public Comida(double peso)
        {
            Peso = peso;
        }
        public Comida() { }
    }
    //Metodo sem Polimorfismo
    //public class Feijao
    //{
    //    public double Peso;
    //}
    //public class Arroz
    //{
    //    public double Peso;
    //}
    //public class Carne
    //{
    //    public double Peso;
    //}
    public class Feijao : Comida
    {
        public Feijao(double peso) : base(peso) { }
    }
    public class Arroz : Comida
    {
        public Arroz(double peso) : base(peso) { }

    }
    public class Carne : Comida
    {
        public Carne(double peso) : base(peso) { }

    }
    public class Pessoa
    {
        public double Peso;

        //Metodo sem Polimorfismo
        //public void Comer(Feijao feijao)
        //{
        //    Peso += feijao.Peso;
        //}
        //public void Comer(Arroz arroz)
        //{
        //    Peso += arroz.Peso;
        //}
        //public void Comer(Carne carne)
        //{
        //    Peso += carne.Peso;
        //}

        public void Comer(Comida comida)
        {
            Peso += comida.Peso;
        }
    }
    class Polimorfismo
    {
        public static void Executar()
        {
            Feijao feijao = new Feijao(0.3);
            // feijao.Peso = 0.3;
            Arroz arroz = new Arroz(0.25);
            // arroz.Peso = 0.25;
            Carne carne = new Carne(0.50);
            // carne.Peso = 0.50;

            Pessoa pessoa = new Pessoa();
            pessoa.Peso = 80.200;
            Console.WriteLine($"Pesso antes da refeição {pessoa.Peso}Kg");

            pessoa.Comer(feijao);
            pessoa.Comer(arroz);
            pessoa.Comer(carne);

            Console.WriteLine($"Pesso apos a refeição {pessoa.Peso}Kg");

        }

    }
}
