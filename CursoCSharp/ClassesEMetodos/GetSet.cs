using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Moto
    {
        private string Marca { get; set; }
        private string Modelo { get; set; }
        private uint Cilindrada { get; set; }

        public Moto(string marca, string modelo, uint cilindrada)
        {
            Marca = marca;
            Modelo = modelo;
            Cilindrada = cilindrada;
        }
        public Moto()
        {
        }

        public string GetMarca()
        {
            return Marca;
        }
        public void SetMarca(string marca)
        {
            Marca = marca;
        }
        public string GetModelo()
        {
            return Modelo;
        }
        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }
        public uint GetCilindrada()
        {
            return Cilindrada;
        }
        public void SetCilindrada(uint cilindrada)
        {
            //if (cilindrada > 0)
            //    Cilindrada = cilindrada;

            //Cilindrada = Math.Abs(cilindrada);

            Cilindrada = cilindrada;
        }
    }
    class GetSet
    {
        public static void Executar()
        {
            var kawasaki = new Moto("Kawasaki", "Ninja ZX-6R", 636);
            Console.WriteLine(kawasaki.GetMarca() + ", " + kawasaki.GetModelo() + ", " + kawasaki.GetCilindrada());

            Console.WriteLine("---------------------------------");

            var Honda = new Moto("Honda", "CG Titan", 125);
            Console.WriteLine(Honda.GetMarca() + ", " + Honda.GetModelo() + ", " + Honda.GetCilindrada());
        }
    }
}
