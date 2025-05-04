using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Parametros
    {
        public static void Recepcionar(params string[] pessoas)
        {
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine($"Olá {pessoa}");
            }
        }

        public static void FormatarDia(int dia, int mes, int ano)
        {
            Console.WriteLine($"Data formatada: {dia:D2}/{mes:D2}/{ano}");
        }

        public static void Executar()
        {
            Recepcionar("Ana", "Bia", "Carlos", "Daniel");

            FormatarDia(1, 6, 2002);
        }
    }
}
