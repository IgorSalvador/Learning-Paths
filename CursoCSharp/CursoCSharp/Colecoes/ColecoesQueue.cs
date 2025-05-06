using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    public class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();

            fila.Enqueue("Ana");
            fila.Enqueue("Bia");
            fila.Enqueue("Carlos");
            fila.Enqueue("Daniel");

            Console.WriteLine($"Primeiro da Fila: {fila.Peek()}");
            Console.WriteLine($"Total de elementos na Fila: {fila.Count}");
            while (fila.Count > 0)
            {
                Console.WriteLine(fila.Dequeue());
            }
            Console.WriteLine($"Total de elementos na Fila: {fila.Count}");

            var salada = new Queue();

            salada.Enqueue(3);
            salada.Enqueue("Ana");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("3"));
        }
    }
}
