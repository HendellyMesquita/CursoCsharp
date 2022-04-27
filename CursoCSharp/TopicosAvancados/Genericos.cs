using System;
using CursoCSharp.ClassesEMetodos;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    public class Caixa<T>
    {
        T ValorPrivado;
        public T Itens { get; set; }

        public Caixa(T itens)
        {
            Itens = itens;
            ValorPrivado = itens;
        }


        public T metodoGenerico(T valor)
        {
            return new Random().Next(0, 2) == 0 ? Itens : valor;
        }

        public T GetValor()
        {

            return ValorPrivado;
        }
    }

    class CaixaInt : Caixa<int>
    {
        public CaixaInt() : base(0)
        {

        }
    }
    class CaixaProduto : Caixa<Produto>
    {
        public CaixaProduto() : base(new Produto())
        {

        }
    }

    class Genericos
    {
        public static void Executar()
        {
            var itensCaixa = new Caixa<int>(1000);
            Console.WriteLine(itensCaixa.metodoGenerico(2000));
            Console.WriteLine(itensCaixa.Itens.GetType());
            Console.WriteLine(itensCaixa.GetType());
            Console.WriteLine("_________________________");

            var ItensCaixa2 = new Caixa<string>("Bom Dia");
            Console.WriteLine(ItensCaixa2.metodoGenerico("Boa Noite"));
            Console.WriteLine(ItensCaixa2.Itens.GetType());
            Console.WriteLine(ItensCaixa2.GetType());
            Console.WriteLine("_________________________");

            var ItensCaixa3 = new CaixaProduto();
            Console.WriteLine(ItensCaixa3.Itens.GetType().Name);
            Console.WriteLine(ItensCaixa2.Itens.GetType());
            Console.WriteLine(ItensCaixa2.GetType());

        }

    }
}
