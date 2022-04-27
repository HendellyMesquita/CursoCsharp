using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    //sealed impossivel herdar ou modificar pois é uma classe selada
    sealed class SemFilho
    {
        public double ValorDaFortuna()
        {
            return 1_000_000.00;
        }
    }
   // class SouFilho: SemFilho { }

    class Avo
    {
        public virtual bool HonrarNomeFamilia()
        {
            return true;
        }
    }
    class Pai: Avo
    {
        public override sealed bool HonrarNomeFamilia()
        {
            return true;
        }
    }
    class FilhoRebelde: Pai
    {
        //public override sealed bool HonrarNomeFamilia()
        //{
        //    return false;
        //}
    }
    class Sealed
    {
        public static void Executar()
        {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());
            Console.WriteLine("--------------");
            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonrarNomeFamilia());
        }

    }
}
