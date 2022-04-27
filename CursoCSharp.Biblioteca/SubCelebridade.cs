using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Biblioteca
{
    public class SubCelebridade
    {
        //Todos
        public string InfoPublica = "Instagram";

       //Herança
        protected string SobreNome = "Silva";

        //Mesmo Projeto
        internal ulong NumeroCelular = 98548542166;

        //Herança ou projeo
        protected internal string Sotaque = "Mineiro";

        //mesma classe ou heranca ou projeto
        private protected string SegredoFamilia = "Segredo";

        //private padrao
        private bool UsaPhotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("SubCelebridade");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(SobreNome);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(Sotaque);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaPhotoshop);
        }
    }
}
