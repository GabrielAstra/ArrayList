using System;
using System.Collections;

namespace ExempLoArraList
{
    
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList teste = new ArrayList();
            teste.Add("Tópicos Avançados em Programação");
            teste.Add("14/09/2020");
            teste.Add(2020);
            teste.Add("xxxxx");
            teste.Add(null);
            teste.Add(true);
            teste.Add("#####");
            teste.Add(12.25);
            teste.Add(1845f);

            Console.WriteLine("ArrayList teste");
            Console.WriteLine("capacidade =" + teste.Capacity);
            Console.WriteLine("tamanho =" + teste.Count);
            Console.WriteLine("removendo o elemento xxxxx");
            teste.Remove("xxxxx");
            Console.WriteLine("inserindo um novo elemento: o fim");
            teste.Add("the end");

            Console.WriteLine("Percorrendo oa ArrayList");
            for (int indice = 0; indice <teste.Count; indice ++)
            {
                Console.WriteLine("indice {0} - {1}", indice, teste[indice]);

            }
            Console.WriteLine("Limpando o teste");

            teste.Clear();
            if (teste.Count == 0)
            {
                Console.WriteLine("O teste esta vazio...");

            }
            Console.ReadKey();
        }
    }
}