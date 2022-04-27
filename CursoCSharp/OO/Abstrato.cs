using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    public abstract class Celular
    {
        public abstract string Assistente();
        public string Tocar()
        {
            return "Piririm... Piririm... Piririm... Alguem ligou pra mim!";
        }
    }

    public class Samsung : Celular
    {
        public override string Assistente()
        {
            return "Ola? Meu nome e Bixby";
        }
    }
    public class IPhone : Celular
    {
        public override string Assistente()
        {
            return "Ola? Meu nome e Siri";
        }
    }
    class Abstrato
    {
        public static void Executar()
        {
            var celulares = new List<Celular>
{
    new IPhone(),
    new Samsung(),
};
            foreach(var celular in celulares)
            {
                Console.WriteLine( celular.Assistente());
            }
        }

    }
}
