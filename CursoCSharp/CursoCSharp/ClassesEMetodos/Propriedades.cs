using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class CarroOpcional
    {
        double desconto = 0.1;
        string nome;

        public string Nome
        {
            get { return $"Opcional: {nome}"; }
            set
            {
                nome = value;
            }
        }

        public double Preco { get; set; }
        public double PrecoComDesconto
        {
            get => Preco - (Preco * desconto);
        }

        public CarroOpcional()
        {

        }

        public CarroOpcional(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }

    public class Propriedades
    {
        public static void Executar()
        {
            var op1 = new CarroOpcional("Ar condicionado", 3499.99);

            var op2 = new CarroOpcional();
            op2.Nome = "Direção Elétrica";
            op2.Preco = 2349.99;

            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.Preco);

            Console.WriteLine(op2.Nome);
            Console.WriteLine(op2.Preco);
        }
    }
}
