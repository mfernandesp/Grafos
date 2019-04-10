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
                    CriarGrafo(lista_g);
                    break;

                case 2:
                    SelecionarGrafo(lista_g);
                    break;
                case 3:
                    RemoverGrafo(lista_g);
                    break;
                case 4:
                    ImportarExportar(lista_g);
                    break;
            }

            Console.Clear();

        } while (condicao != 0);

    }

    private static void CriarGrafo(List<Grafo> lista_g)
    {
        Console.WriteLine("Digite o numero do tipo do grafo:\n1:Ponderado\n2:Dirigido\n");
        int tipo = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o nome do grafo:");
        String nome = Console.ReadLine();
        Grafo grafo = new Grafo(nome, tipo);
        lista_g.Add(grafo);

        Console.WriteLine("\nGrafo criado com Sucesso!");
        _ = Console.ReadLine();
    }

    private static void SelecionarGrafo(List<Grafo> lista_g)
    {
        Console.WriteLine("Selecione o Grafo: ");
        foreach (Grafos.Grafo i in lista_g)
        {
            Console.WriteLine(" " + lista_g.IndexOf(i) + " " + i.Getnome());
        }

        Console.WriteLine("Digite o número do grafo: ");
        int numeroGrafo = int.Parse(Console.ReadLine());
        Console.WriteLine("\nVocê selecionou: " + lista_g[numeroGrafo].Getnome());
        _ = Console.ReadLine();
        Console.Clear();

        int condicao = -1;

        do
        {
            Console.WriteLine("1.Inserir");
            Console.WriteLine("2.Remover");
            Console.WriteLine("3.Obter Grau");
            Console.WriteLine("4.Verificar Conexão entre Vértices");
            Console.WriteLine("5.Verificar se o grafo é conexo");
            Console.WriteLine("6.Obter Vertices Adjacentes");
            Console.WriteLine("7.Imprimir Matriz de Adjacencia");
            Console.WriteLine("8.Verificar Caminho de Euller");
            Console.WriteLine("0. Voltar");

            condicao = int.Parse(Console.ReadLine());

            switch (condicao)
            {
                case 1:
                    Console.WriteLine("Digite a opção: \n1:Vértice\n2:Aresta\n0:Voltar\n");

                    int i = int.Parse(Console.ReadLine());
                    switch (i)
                    {
                        case 0:
                            SelecionarGrafo(lista_g);
                            break;
                        case 1:
                            InserirVertice();
                            break;
                        case 2:
                            InserirAresta();
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Digite a opção: \n1:Vértice\n2:Aresta\n0:Voltar\n");

                    int i2 = int.Parse(Console.ReadLine());
                    switch (i2)
                    {
                        case 0:
                            SelecionarGrafo(lista_g);
                            break;
                        case 1:
                            RemoverVertice();
                            break;
                        case 2:
                            RemoverAresta();
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("Digite a opção: \n1:Vértice\n2:Aresta\n0:Voltar\n");

                    int i3 = int.Parse(Console.ReadLine());
                    switch (i3)
                    {
                        case 0:
                            SelecionarGrafo(lista_g);
                            break;
                        case 1:
                            GrauVertice();
                            break;
                        case 2:
                            GrauAresta();
                            break;
                    }
                    break;
                case 4:
                    VerConexao();
                    break;
                case 5:
                    VerConexo();
                    break;
                case 6:
                    VerConexo();
                    break;
                case 7:
                    VerAdjacente();
                    break;
                case 8:
                    VerEuller();
                    break;
            }
        } while (condicao != 0);
    }

    private static void RemoverGrafo(List<Grafo> lista_g)
    {
        Console.WriteLine("Selecione o grafo para a remoção: ");
        foreach (Grafos.Grafo i in lista_g)
        {
            Console.WriteLine(" " + lista_g.IndexOf(i) + " " + i.Getnome());
        }

        Console.WriteLine("Digite o número do grafo: ");
        int numeroGrafo = int.Parse(Console.ReadLine());
        Console.WriteLine("\nVocê removeu: " + lista_g[numeroGrafo].Getnome());
        lista_g.RemoveAt(numeroGrafo);
        _ = Console.ReadLine();
    }

    private static void ImportarExportar(List<Grafo> lista_g)
    {
        Console.WriteLine("Selecione a opção:\n1:Exportar\n2:Importar\n");
    }

    public static void InserirVertice()
    {
        Console.WriteLine("Inserir Vertice");
    }
    public static void InserirAresta()
    {
        Console.WriteLine("Inserir Aresta");
    }
    
    public static void RemoverVertice()
    {
        Console.WriteLine("Remover Vértice");
    }
    public static void RemoverAresta()
    {
        Console.WriteLine("Remover Aresta");
    }
    
    public static void GrauVertice()
    {
        Console.WriteLine("Grau Vertice");
    }
    public static void GrauAresta()
    {
        Console.WriteLine("Grau Aresta");
    }

    public static void VerConexao()
    {

    }
    public static void VerConexo()
    {

    }
    public static void VerAdjacente()
    {

    }
    public static void VerEuller()
    {

    }

    



}


