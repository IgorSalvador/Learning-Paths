using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Moto
    {
        private string Marca;
        private string Modelo;
        private int Cilindrada;

        public Moto(string Marca, string Modelo, int Cilindrada)
        {
            SetMarca(Marca);
            SetModelo(Modelo);
            SetCilindrada(Cilindrada);
        }

        public string GetMarca()
        {
            return Marca;
        }

        public void SetMarca(string Marca)
        {
            this.Marca = Marca;
        }

        public string GetModelo()
        {
            return Modelo;
        }

        public void SetModelo(string Modelo)
        {
            this.Modelo = Modelo;
        }

        public int GetCilindrada()
        {
            return Cilindrada;
        }

        public void SetCilindrada(int Cilindrada)
        {
            if(Cilindrada > 0)
                this.Cilindrada = Cilindrada;
        }
    }

    public class GetSet
    {
        public static void Executar()
        {
            var moto1 = new Moto("Honda", "CB 500", 500);

            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());
        }
    }
}
