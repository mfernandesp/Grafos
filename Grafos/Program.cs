using System;
using System.Collections;
using System.Collections.Generic;
using Grafos;

public class Program
{
    public static void Main()
    {
        int condicao = -1;

        List<Grafo> lista_g = new List<Grafo>();

        do
        {

            Console.WriteLine("Trabalho de Grafos");
            Console.WriteLine("1.Criar Grafo");
            Console.WriteLine("2.Selecionar Grafo");
            Console.WriteLine("3.Remover Grafo");
            Console.WriteLine("4.Importar/Exportar Grafo");
            Console.WriteLine("0. Sair");

            condicao = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (condicao)
            {
                case 1:
                    Console.WriteLine("Digite o numero do tipo do grafo:\n1:Ponderado\n2:Dirigido\n");
                    int tipo = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o nome do grafo");
                    String nome = Console.ReadLine();
                    Grafo grafo = new Grafo(nome, tipo);
                    lista_g.Add(grafo);
                    break;
                case 2:
                    Console.WriteLine("Selecione o Grafo: ");
                    foreach (Grafos.Grafo i in lista_g)
                    {
                        Console.WriteLine(" " + lista_g.IndexOf(i) + " " + i.Getnome());
                    }

                    int ler = int.Parse(Console.ReadLine());
                    Console.WriteLine("Você difigou isso: " + ler);
                    break;
                case 3:
                    Console.WriteLine("Remover o Grafo: " + lista_g[0].Getnome());
                    lista_g.RemoveAt(0);
                    break;
                case 4:
                    Console.WriteLine("4.Importar/Exportar Grafo");
                    break;
            }

        } while (condicao != 0);

    }
}
