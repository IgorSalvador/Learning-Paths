using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Valor { get; set; }

        public Produto()
        {
            
        }

        public Produto(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }
    }

    public class ColecoesSet
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Throne", 49.9);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto> {
                new Produto("Camisa", 29.9),
                new Produto("8ª Temporada Game of Thrones", 99.9),
                new Produto("Poster", 10),
                new Produto("Poster", 10)
            };

            carrinho.UnionWith(combo);
            Console.WriteLine(carrinho.Count);
            // carrinho.RemoveAt(3);

            foreach (var item in carrinho)
            {
                // Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Valor}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);
            // Console.WriteLine(carrinho.LastIndexOf(livro));
        }
    }
}
