using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.CursoCSharp;
using CursoCSharp.Fundamentos;
using CursoCSharp.OO;
using System;
using System.Collections.Generic;

namespace CursoCSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>()
            {
                { "Primeiro Programa", PrimeiroPrograma.Executar },
                { "Parametros - Classes e Metodos", Parametros.Executar },
                { "Get / Set - Classes e Metodos", GetSet.Executar },
                { "Propriedades - Classes e Metodos", Propriedades.Executar },
                { "Struct - Classes e Metodos", Struct.Executar },
                { "Struct Vs Classe - Classes e Metodos", StructVsClasse.Executar },
                { "Array List - Coleções", ColecoesArrayList.Executar },
                { "Set List - Coleções", ColecoesSet.Executar },
                { "Queue - Coleções", ColecoesQueue.Executar },
                { "Herança - Programação Orientada a Objetos", Herenca.Executar }
            });
            
            central.SelecionarEExecutar();
        }
    }
}
