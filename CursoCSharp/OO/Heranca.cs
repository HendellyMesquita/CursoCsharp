using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    public class Carro
    {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        public Carro(int velocidadeMaxima)
        {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected int AlterarVelocidade(int delta)
        {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0)
                VelocidadeAtual = 0;

            else if (novaVelocidade > VelocidadeMaxima)
                VelocidadeAtual = VelocidadeMaxima;
            else
                VelocidadeAtual = novaVelocidade;

            return VelocidadeAtual;
        }
        public virtual int Acelerar()
        {
            return AlterarVelocidade(5);
        }
        public int Frear()
        {
            return AlterarVelocidade(-5);
        }
    }
    public class Uno : Carro
    {
        public Uno() : base(200)
        {

        }

    }
    public class Ferrari : Carro
    {
        public Ferrari() : base(500)
        {

        }
        public override int Acelerar()
        {
            return AlterarVelocidade(15);
        }
        public new int Frear()
        {
            return AlterarVelocidade(-15);
        }

    }

    class Heranca
    {
        public static void Executar()
        {
            Uno carroUno = new Uno();
            Ferrari carroFerrari = new Ferrari();

            Console.WriteLine("Uno ");
            Console.WriteLine(carroUno.Acelerar());
            Console.WriteLine(carroUno.Acelerar());
            Console.WriteLine(carroUno.Acelerar());
            Console.WriteLine(carroUno.Frear());
            Console.WriteLine(carroUno.Frear());
            Console.WriteLine(carroUno.Frear());
          
            Console.WriteLine("-----------");
            Console.WriteLine("Uno com tipo carro");
            Carro UnoCarro = new Uno();
            Console.WriteLine(UnoCarro.Acelerar());
            Console.WriteLine(UnoCarro.Acelerar());
            Console.WriteLine(UnoCarro.Acelerar());
            Console.WriteLine(UnoCarro.Frear());
            Console.WriteLine(UnoCarro.Frear());
            Console.WriteLine(UnoCarro.Frear());
            Console.WriteLine(UnoCarro.Frear());

            Console.WriteLine("-----------");
            Console.WriteLine("Ferrari ");
            Console.WriteLine(carroFerrari.Acelerar());
            Console.WriteLine(carroFerrari.Acelerar());
            Console.WriteLine(carroFerrari.Acelerar());
            Console.WriteLine(carroFerrari.Acelerar());
            Console.WriteLine(carroFerrari.Frear());
            Console.WriteLine(carroFerrari.Frear());
            Console.WriteLine(carroFerrari.Frear());

            Console.WriteLine("-----------");
            Console.WriteLine("Ferrari com tipo carro");
            Carro FerrariCarro = new Ferrari();
            Console.WriteLine(FerrariCarro.Acelerar());
            Console.WriteLine(FerrariCarro.Acelerar());
            Console.WriteLine(FerrariCarro.Acelerar());
            Console.WriteLine(FerrariCarro.Frear());
            Console.WriteLine(FerrariCarro.Frear());
            Console.WriteLine(FerrariCarro.Frear());
            Console.WriteLine(FerrariCarro.Frear());
            Console.WriteLine(FerrariCarro.Frear());

        }
    }
}