using System;
using System.IO;
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

            Console.Write("\n\nDigite a opção desejada: ");
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
        Console.WriteLine("O grafo é Ponderado?\n0: Grafo não Ponderado\n1: Grafo Ponderado");
        Console.Write("\nDigite a opção: ");
        int ponderado = int.Parse(Console.ReadLine());

        Console.WriteLine("\n\nO grafo é Dirigido?\n0: Grafo não Dirigido\n1: Grafo Dirigido");
        Console.Write("\nDigite a opção: ");
        int dirigido = int.Parse(Console.ReadLine());

        Console.Write("\nDigite o nome do grafo: ");
        String nome = Console.ReadLine();
        Grafo grafo = new Grafo(nome, ponderado, dirigido, idGrafos++);
        
        lista_g.Add(grafo);

        Console.WriteLine("\n\nGrafo '" + grafo.Nome + "' criado com Sucesso!");
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

        Console.Write("\n\nDigite o número do grafo: ");
        int numeroGrafo = int.Parse(Console.ReadLine());
        Console.WriteLine("\nVocê selecionou: " + lista_g[numeroGrafo].Nome);
        _ = Console.ReadLine();
        Console.Clear();

        int condicao = -1;

        do
        {
            Console.Clear();
            Console.WriteLine("Grafo " + lista_g[numeroGrafo].Nome);
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
            
            Console.Write("\n\nDigite a opção desejada: ");
            condicao = int.Parse(Console.ReadLine());

            switch (condicao)
            {
                case 1:
                    Console.Clear();

                    Console.WriteLine("Opções para adicionar: \n1:Vértice\n2:Aresta\n0:Voltar\n");

                    Console.Write("Digite a opção: ");
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
                    Console.Clear();

                    Console.WriteLine("Opções para remover: \n1:Vértice\n2:Aresta\n0:Voltar\n");

                    Console.Write("Digite a opção: ");
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
                    Console.Clear();
                    Console.WriteLine("Opções para obter grau: \n1:Vértice\n2:Grafo\n0:Voltar\n");

                    Console.Write("Digite a opção: ");
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
                            GrauGrafo();
                            break;
                    }
                    break;
                case 4:
                    Console.Clear();
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
                    Console.Clear();
                    MatrizAdjacencia(lista_g[numeroGrafo]);
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

        Console.Write("Digite a opção: ");
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                Exportar(lista_g);
                break;
            case 2:
                Importar(lista_g);
                break;
        }


        _ = Console.ReadLine();
    }

    public static void Exportar(List<Grafo> lista_g)
    {
        List<String> textoArquivo = new List<String>();

        // Create a string array with the lines of text
        //string[] lines = { "First line", "Second line", "Third line" };
        foreach (var i in lista_g)
        {
            String textoGrafo = "Grafo = " + i.Nome + "," + i.Poderado + "," + i.Dirigido ;
            textoArquivo.Add(textoGrafo);

            foreach(var j in i.ListaVertices)
            {
                String textoVertice = "Vertice = " + j.Nome + "," + i.Nome;
                textoArquivo.Add(textoVertice);
            }

            foreach (var m in i.ListaArestas)
            {
                String textoAresta = "Aresta = " + m.Nome + "," + i.Nome + "," + m.Vertice_O.Nome + "," + m.Vertive_D.Nome + "," + m.Peso;
                textoArquivo.Add(textoAresta);
            }
        }

        foreach(var line in textoArquivo)
        {
            Console.WriteLine(line);
        }

        // Set a variable to the Documents path.
        string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        // Write the string array to a new file named "WriteLines.txt".
        using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "Grafos.txt")))
        {
            foreach (var line in textoArquivo)
            {
                outputFile.WriteLine(line);
            }
        }

        Console.WriteLine("\nGrafo(s) exportado(s) com sucesso!");
        _ = Console.ReadLine();

    }
    public static void Importar(List<Grafo> lista_g)
    {

        Console.Write("Digite o caminho do arquivo .txt : ");
        String caminho = Console.ReadLine();
        List<String> textoArquivo = new List<String>();

        try
        {   // Open the text file using a stream reader.
            using (StreamReader sr = new StreamReader(caminho))
            {
                string line;
                // Read and display lines from the file until the end of 
                // the file is reached.
                while ((line = sr.ReadLine()) != null)
                {
                    textoArquivo.Add(line);
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("Erro ao ler arquivo.\n");
            Console.WriteLine(e.Message);
            _ = Console.ReadLine();
        }


        foreach (var line in textoArquivo)
        {
            if(line.StartsWith("Grafo = "))
            {
               
               String linhaGrafo = line.Replace("Grafo = ", "");
               String[] propriedades = linhaGrafo.Split(new Char[] {','});

                int ponderado = int.Parse(propriedades[1]);
                int dirigido = int.Parse(propriedades[1]);

               Grafo grafo = new Grafo(propriedades[0], ponderado, dirigido, idGrafos++);
               lista_g.Add(grafo);

                Console.WriteLine("\nGrafo '" + grafo.Nome + "' criado com Sucesso!");
            }

            if (line.StartsWith("Vertice = "))
            {
                String linhaGrafo = line.Replace("Vertice = ", "");
                String[] propriedades = linhaGrafo.Split(new Char[] { ',' });

                foreach(var grafo in lista_g)
                {
                    if (grafo.Nome.Equals(propriedades[1]))
                    {
                        
                        Vertice V = new Grafos.Vertice(idVertices++, propriedades[0], grafo);

                        grafo.ListaVertices.Add(V);

                        Console.WriteLine("Vértice '" + V.Nome + "' inserido no grafo '" + grafo.Nome + "' com sucesso!");

                    }
                }



            }

            if (line.StartsWith("Aresta = "))
            {
                String linhaGrafo = line.Replace("Aresta = ", "");
                String[] propriedades = linhaGrafo.Split(new Char[] { ',' });

                foreach (var grafo in lista_g)
                {
                    if (grafo.Nome.Equals(propriedades[1]))
                    {
                        foreach(var verO in grafo.ListaVertices)
                        {
                            if (verO.Nome.Equals(propriedades[2]))
                            {
                                Vertice vO = verO;
                                foreach (var verD in grafo.ListaVertices)
                                {
                                    if (verD.Nome.Equals(propriedades[3]))
                                    {
                                        Vertice vD = verD;
                                        int peso = int.Parse(propriedades[4]);

                                        Aresta A = new Aresta(idArestas++, propriedades[0], grafo, vO, vD, peso);
                                        grafo.ListaArestas.Add(A);

                                        Console.WriteLine("Aresta '" + A.Nome + "' inserida no grafo '" + grafo.Nome + "'com sucesso!");
                                    }                                    
                                }
                            }
                        }

                    }
                }
                
            }

        }
    }

    public static void InserirVertice(Grafo grafo)
    {
        Console.Write("Digite o nome do vertice: ");
        String nomeVertice = Console.ReadLine();

        var listaVertices2 = grafo.ListaVertices;

        Grafos.Vertice V = new Grafos.Vertice(idVertices++, nomeVertice, grafo);

        listaVertices2.Add(V);

        grafo.ListaVertices = listaVertices2;

        Console.WriteLine("\n\nVértice '" + nomeVertice + "' inserido no grafo '" + grafo.Nome + "'.");
        _ = Console.ReadLine();
    }
    public static void InserirAresta(Grafo grafo)
    {   
        Console.Write("Digite o nome da Aresta: ");
        String nomeAresta = Console.ReadLine();

        int peso = 1;

        if (grafo.Poderado == 1)
        {
            Console.Write("\nDigite o peso: ");
            peso = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nVértices: ");
        foreach (Grafos.Vertice i in grafo.ListaVertices)
        {
            Console.WriteLine(" " + grafo.ListaVertices.IndexOf(i) + " " + i.Nome);
        }

        int idVerticeA = -1;
        int idVerticeB = -1;
        Boolean conectados = false;

        if (grafo.Dirigido == 1){
            Console.Write("\nDigite o número do Vertice A(Origem): ");
            idVerticeA = int.Parse(Console.ReadLine());

            Console.Write("\nDigite o número do Vertice B(Destino): ");
            idVerticeB = int.Parse(Console.ReadLine());

            conectados = VerConexaoVertice(grafo, idVerticeA, idVerticeB);
        }
        else{
            Console.Write("\nDigite o número do primeiro Vertice: ");
            idVerticeA = int.Parse(Console.ReadLine());

            Console.Write("\nDigite o número do segundo Vertice: ");
            idVerticeB = int.Parse(Console.ReadLine());

            conectados = VerConexaoVertice(grafo, idVerticeA, idVerticeB);

            if (conectados == false)
            {
                conectados = VerConexaoVertice(grafo, idVerticeB, idVerticeA);
            }
        }

        if (conectados)
        {
            Console.WriteLine("\nVértices já conectados!");
            _ = Console.ReadLine();
        }
        else
        {
            Vertice vA = grafo.ListaVertices[idVerticeA];
            Vertice vB = grafo.ListaVertices[idVerticeB];

            var listaAresta2 = grafo.ListaArestas;

            Aresta A = new Aresta(idArestas++, nomeAresta, grafo, vA, vB, peso);

            listaAresta2.Add(A);

            grafo.ListaArestas = listaAresta2;

            Console.WriteLine("\n\nAresta '" + A.Nome + "' inserida no grafo '" + grafo.Nome + "'.");
            _ = Console.ReadLine();
        }
    }
    
    public static void RemoverVertice(Grafo grafo)
    {
        Console.WriteLine("\nVétices do grafo " + grafo.Nome +":");
        foreach (Grafos.Vertice i in grafo.ListaVertices)
        {
            Console.WriteLine(" " + grafo.ListaVertices.IndexOf(i) + " " + i.Nome);
        }

        Console.Write("\nDigite o número do Vertice para remoção: ");
        int idVerticeA = int.Parse(Console.ReadLine());

        Console.WriteLine("\nVértice '" + grafo.ListaVertices[idVerticeA].Nome + "' excluído!");

        grafo.ListaVertices.RemoveAt(idVerticeA);

        _ = Console.ReadLine();
   
    }
    public static void RemoverAresta(Grafo grafo)
    {
        Console.WriteLine("\nArestas do grafo " + grafo.Nome + ":");
        foreach (Grafos.Aresta i in grafo.ListaArestas)
        {
            Console.WriteLine(" " + grafo.ListaArestas.IndexOf(i) + " " + i.Nome);
        }

        Console.WriteLine("\nDigite o número da Aresta para remoção:");
        int idVerticeA = int.Parse(Console.ReadLine());

        Console.WriteLine("\nAresta '" + grafo.ListaArestas[idVerticeA].Nome + "' excluída!");

        grafo.ListaArestas.RemoveAt(idVerticeA);

        _ = Console.ReadLine();
    }
    
    public static void GrauVertice(Grafo grafo)
    {   Console.WriteLine("\nVétices do grafo " + grafo.Nome + ":");
        foreach (Grafos.Vertice i in grafo.ListaVertices)
        {
            Console.WriteLine(" " + grafo.ListaVertices.IndexOf(i) + " " + i.Nome);
        }

        Console.Write("\nDigite o número do Vertice: ");
        int idVerticeA = int.Parse(Console.ReadLine());

        var cGrau = grafo.ListaArestas;

        int g = 0;

        foreach (var i in cGrau)
        {
            if (i.Vertive_D.Id_v == idVerticeA || i.Vertice_O.Id_v == idVerticeA)
            {
                g++;
            }
        }

        Console.WriteLine("\nGrau de '" + grafo.ListaVertices[idVerticeA].Nome + "' é: " + g);
        
        _ = Console.ReadLine();
    }
    public static void GrauGrafo()
    {
        Console.Clear();

        Console.WriteLine("Grau Grafo");

        _ = Console.ReadLine();
    }

    public static void VerConexao(Grafo grafo)
    {

        Console.WriteLine("\nVértices: ");
        foreach (Grafos.Vertice i in grafo.ListaVertices)
        {
            Console.WriteLine(" " + grafo.ListaVertices.IndexOf(i) + " " + i.Nome);
        }

        int idVerticeA = -1;
        int idVerticeB = -1;
        Boolean conectados = false;

        if (grafo.Dirigido == 1)
        {
            Console.Write("\nDigite o número do Vertice A(Origem): ");
            idVerticeA = int.Parse(Console.ReadLine());

            Console.Write("\nDigite o número do Vertice B(Destino): ");
            idVerticeB = int.Parse(Console.ReadLine());

            conectados = VerConexaoVertice(grafo, idVerticeA, idVerticeB);
        }
        else
        {
            Console.Write("\nDigite o número do primeiro Vertice: ");
            idVerticeA = int.Parse(Console.ReadLine());

            Console.Write("\nDigite o número do segundo Vertice: ");
            idVerticeB = int.Parse(Console.ReadLine());

            conectados = VerConexaoVertice(grafo, idVerticeA, idVerticeB);

            if (conectados == false)
            {
                conectados = VerConexaoVertice(grafo, idVerticeB, idVerticeA);
            }
        }

        if (conectados)
        {
            Console.WriteLine("\nVértices estão conectados.");
            _ = Console.ReadLine();
        }
        else {
            Console.WriteLine("\nVértices não estão conectados.");
            _ = Console.ReadLine();
        }
    }

    public static Boolean VerConexaoVertice(Grafo grafo, int id_origem, int id_destino)
    {
        Boolean conectados = false;
        var listaAresta = grafo.ListaArestas;


        foreach (var i in listaAresta)
        {
            if ((i.Vertice_O.Id_v == id_origem && i.Vertive_D.Id_v == id_destino))
            {
                conectados = true;
            }
        }

        return conectados;
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

    public static void MatrizAdjacencia(Grafo grafo)
    {
        var listaVertice = grafo.ListaVertices;

        //Cabeçalho
        Console.Write("   ");
        foreach (var i in grafo.ListaVertices)
        {
            Console.Write(" | " + i.Nome);
        }


        foreach (var v in listaVertice)
        {
            Console.Write("\n" + v.Nome);

            foreach(var i in grafo.ListaVertices)
            {
                int a = 0;

                foreach (var j in grafo.ListaArestas)
                {
                    if (grafo.Dirigido == 1)
                    {
                        if ((j.Vertice_O.Id_v == v.Id_v && j.Vertive_D.Id_v == i.Id_v))
                        {
                            a = j.Peso;
                        }
                    }
                    else
                    {
                        if ((j.Vertice_O.Id_v == v.Id_v && j.Vertive_D.Id_v == i.Id_v) || (j.Vertice_O.Id_v == i.Id_v && j.Vertive_D.Id_v == v.Id_v))
                        {
                            a = j.Peso;
                        }
                    }
                }

                Console.Write(" |  " + a);
            }
        }
        
        _ = Console.ReadLine();
    }
    
    


}


