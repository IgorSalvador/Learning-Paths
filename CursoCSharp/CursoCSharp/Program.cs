using CursoCSharp.ClassesEMetodos;
using CursoCSharp.CursoCSharp;
using CursoCSharp.Fundamentos;
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
                { "Struct Vs Classe - Classes e Metodos", StructVsClasse.Executar }
            });
            
            central.SelecionarEExecutar();
        }
    }
}
