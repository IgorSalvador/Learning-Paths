﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    public class Carro
    {
        protected readonly int VelocidadeMaxima;
        private int VelocidadeAtual;

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
        public Ferrari() : base(350)
        {

        }

        public override int Acelerar()
        {
            return AlterarVelocidade(15);
        }

        // Oculta o método da classe Pai
        public new int Frear()
        {
            return AlterarVelocidade(-15);
        }
    }

    public class Herenca
    {
        public static void Executar()
        {
            Console.WriteLine("Uno...");

            var carro1 = new Uno();

            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());

            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());

            /* ===================================== */

            Console.WriteLine("Ferrari...");

            var carro2 = new Ferrari();

            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());

            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());

            /* ===================================== */

            Console.WriteLine("Ferrari com tipo carro...");
            Carro carro3 = new Ferrari(); // Polimorfismo
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());

            Console.WriteLine("Uno com tipo carro...");
            carro3 = new Uno(); // Polimorfismo
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
        }
    }
}
