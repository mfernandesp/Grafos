using System;
using System.Collections;
using System.Collections.Generic;
using Grafos;

public class Program
{

    static int idGrafos = 0;
    static int idVertices = 0;
    static int idArestas = 0;
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
        Console.Clear();
        Console.WriteLine("Digite o numero do tipo do grafo:\n1:Ponderado\n2:Dirigido\n");
        int tipo = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o nome do grafo:");
        String nome = Console.ReadLine();
        Grafo grafo = new Grafo(nome, tipo, idGrafos++);
        
        lista_g.Add(grafo);

        Console.WriteLine("\nGrafo criado com Sucesso!");
        _ = Console.ReadLine();
    }

    private static void SelecionarGrafo(List<Grafo> lista_g)
    {
        Console.Clear();
        Console.WriteLine("Selecione o Grafo: ");
        foreach (Grafos.Grafo i in lista_g)
        {
            Console.WriteLine(" " + lista_g.IndexOf(i) + " " + i.Nome);
        }

        Console.WriteLine("Digite o número do grafo: ");
        int numeroGrafo = int.Parse(Console.ReadLine());
        Console.WriteLine("\nVocê selecionou: " + lista_g[numeroGrafo].Nome);
        _ = Console.ReadLine();
        Console.Clear();

        int condicao = -1;

        do
        {
            Console.Clear();
            Console.WriteLine("1.Inserir");
            Console.WriteLine("2.Remover");
            Console.WriteLine("3.Obter Grau");
            Console.WriteLine("4.Verificar Conexão entre Vértices");
            Console.WriteLine("5.Verificar se o grafo é conexo");
            Console.WriteLine("6.Obter Vertices Adjacentes");
            Console.WriteLine("7.Imprimir Matriz de Adjacencia");
            Console.WriteLine("8.Verificar Caminho de Euller");
            Console.WriteLine("9.Imprimir Matriz de Adjacência");
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
                            InserirVertice(lista_g[numeroGrafo]);
                            break;
                        case 2:
                            InserirAresta(lista_g[numeroGrafo]);
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
                            RemoverVertice(lista_g[numeroGrafo]);
                            break;
                        case 2:
                            RemoverAresta(lista_g[numeroGrafo]);
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
                            GrauVertice(lista_g[numeroGrafo]);
                            break;
                        case 2:
                            GrauAresta();
                            break;
                    }
                    break;
                case 4:
                    VerConexao(lista_g[numeroGrafo]);
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
                case 9:
                    MatrizAdjacencia();
                    break;
            }
        } while (condicao != 0);
     }

    private static void RemoverGrafo(List<Grafo> lista_g)
    {
        Console.Clear();
        Console.WriteLine("Selecione o grafo para a remoção: ");
        foreach (Grafos.Grafo i in lista_g)
        {
            Console.WriteLine(" " + lista_g.IndexOf(i) + " " + i.Nome);
        }

        Console.WriteLine("Digite o número do grafo: ");
        int numeroGrafo = int.Parse(Console.ReadLine());
        Console.WriteLine("\nVocê removeu: " + lista_g[numeroGrafo].Nome);
        lista_g.RemoveAt(numeroGrafo);
        _ = Console.ReadLine();
    }

    private static void ImportarExportar(List<Grafo> lista_g)
    {
        Console.WriteLine("Selecione a opção:\n1:Exportar\n2:Importar\n");

        _ = Console.ReadLine();
    }

    public static void InserirVertice(Grafo grafo)
    {
        /*
        Console.WriteLine("Digite o numero o ID do vértice:\n");
        int idVertice = int.Parse(Console.ReadLine());
        */
        Console.Clear();
        Console.WriteLine("Digite o nome do vertice");
        String nomeVertice = Console.ReadLine();

        var listaVertices2 = grafo.ListaVertices;

        Grafos.Vertice V = new Grafos.Vertice(idVertices++, nomeVertice, grafo);

        listaVertices2.Add(V);

        grafo.ListaVertices = listaVertices2;

        Console.WriteLine("\n\nVértice '" + nomeVertice + "' inserido no grafo '" + grafo.Nome "'.");
        _ = Console.ReadLine();
    }
    public static void InserirAresta(Grafo grafo)
    {   /*
        Console.WriteLine("Digite o numero  id da Aresta\n");
        int idAresta = int.Parse(Console.ReadLine());
        */
        Console.Clear();
        Console.WriteLine("Digite o nome da Aresta");
        String nomeAresta = Console.ReadLine();

        Console.WriteLine("Vértices: ");
        foreach (Grafos.Vertice i in grafo.ListaVertices)
        {
            Console.WriteLine(" " + grafo.ListaVertices.IndexOf(i) + " " + i.Nome);
        }

        //Mudar para buscar na o id de vertices na lista de Vertices do grafo pelo nome informado, criar validação caso exista. 
        Console.WriteLine("Digite o número do Vertice A(Origem)");
        int idVerticeA = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o número do Vertice B(Destino)");
        int idVerticeB = int.Parse(Console.ReadLine());

        Vertice vA = grafo.ListaVertices[idVerticeA];
        Vertice vB = grafo.ListaVertices[idVerticeB];

        var listaAresta2 = grafo.ListaArestas;

        Aresta A = new Aresta(idArestas++, nomeAresta, grafo, vA, vB);

        listaAresta2.Add(A);

        grafo.ListaArestas = listaAresta2;
        _ = Console.ReadLine();
    }
    
    public static void RemoverVertice(Grafo grafo)
    {
        Console.Clear();
        Console.WriteLine("Vétices do grafo " + grafo.Nome +":");
        foreach (Grafos.Vertice i in grafo.ListaVertices)
        {
            Console.WriteLine(" " + grafo.ListaVertices.IndexOf(i) + " " + i.Nome);
        }

        Console.WriteLine("Digite o número do Vertice para remoção:");
        int idVerticeA = int.Parse(Console.ReadLine());

        Console.WriteLine("Vértice " + grafo.ListaVertices[idVerticeA].Nome + " excluído!");
        _ = Console.ReadLine();
        /*
        Console.Clear();
        Console.WriteLine("\nInforme o vertice que deseja remover\n");
        String rA = Console.ReadLine();

        var rListaAresta = grafo.ListaArestas;

        foreach (var i in rListaAresta)
        {
            if (i.GetNome() == rA)
            {
                rListaAresta.Remove(i);
            }
        }*/
    }
    public static void RemoverAresta(Grafo grafo)
    {
        Console.Clear();
        Console.WriteLine("Arestas do grafo " + grafo.Nome + ":");
        foreach (Grafos.Aresta i in grafo.ListaArestas)
        {
            Console.WriteLine(" " + grafo.ListaArestas.IndexOf(i) + " " + i.Nome);
        }

        Console.WriteLine("Digite o número da Aresta para remoção:");
        int idVerticeA = int.Parse(Console.ReadLine());

        Console.WriteLine("Aresta " + grafo.ListaArestas[idVerticeA].Nome + " excluída!");
        _ = Console.ReadLine();
    }
    
    public static void GrauVertice(Grafo grafo)
    {
        Console.Clear();
        Console.Write("Informe o nome do vértice:");
        String nG = Console.ReadLine();

        var cGrau = grafo.ListaArestas;

        int g = 0;

        foreach (var i in cGrau)
        {
            if (i.Vertive_D.Nome == nG || i.Vertice_O.Nome == nG)
            {
                g++;
            }
        }

        Console.WriteLine("\nGrau de " + nG + " é: " + g);

        Console.WriteLine("\n\n\n Voltar ao menu?");
        String teste2 = Console.ReadLine();
        _ = Console.ReadLine();
    }
    public static void GrauAresta()
    {
        Console.Clear();

        Console.WriteLine("Grau Aresta");

        _ = Console.ReadLine();
    }

    public static void VerConexao(Grafo grafo)
    {
        Console.Clear();
        Console.WriteLine("\nInforme os vertices que deseja verificar conexão: ");
        Console.WriteLine("\nVertice Origem: ");
        String nVerticeO = Console.ReadLine();

        Console.WriteLine("\nVertice Destino: ");
        String nVerticeD = Console.ReadLine();

        var lC = grafo.ListaArestas;

        bool z = false;

        foreach (var i in lC)
        {
            if ((i.Vertice_O.Nome == nVerticeO && i.Vertive_D.Nome == nVerticeD) || (i.Vertice_O.Nome == nVerticeD && i.Vertive_D.Nome == nVerticeO))
            {


            }
        }

        _= Console.ReadLine();
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

    public static void MatrizAdjacencia()
    {

    }
    



}


