using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    public class ColecoesArrayList
    {
        public static void Executar()
        {
            var arrayList = new ArrayList
            {
                "Palavra",
                3,
                true
            };

            foreach (var item in arrayList)
            {
                Console.WriteLine($"Tipo: {item.GetType()} Valor: {item}");
            }
        }
    }
}
