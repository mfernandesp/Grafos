using System;
using System.Collections.Generic;
using System.Linq;

namespace Grafos
{
    public class Grafo
    {
        int id;
        String nome;
        int ponderado;
        int dirigido;
        List<Aresta> listaArestas = new List<Aresta>();
        List<Grafos.Vertice> listaVertices = new List<Vertice>();

        internal List<Vertice> ListaVertices { get => listaVertices; set => listaVertices = value; }
        internal List<Aresta> ListaArestas { get => listaArestas; set => listaArestas = value; }
        public int Poderado { get => ponderado; set => ponderado = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Id { get => id; set => id = value; }
        public int Dirigido { get => dirigido; set => dirigido = value; }

        public bool PossuiConexaoEntreOsVertices(int idOrigem, int idDestino)
            => this.ListaArestas.Any(aresta => (aresta.Vertice_O.Id_v == idOrigem && aresta.Vertive_D.Id_v == idDestino)
                                                || (this.Dirigido == 0 && aresta.Vertice_O.Id_v == idDestino && aresta.Vertive_D.Id_v == idOrigem));

        public bool Conexo
        {
            get
            {
                foreach (var verticeA in this.ListaVertices) // Verifica todos os vértices do grafo
                {
                    // O grafo só é conexo se houver conexão entre todos os vértices
                    if (this.ListaVertices.Where(v => v.Id_v != verticeA.Id_v).ToList() // Recupera todos os outros vértices do grafo
                          .Any(verticeB => !this.PossuiConexaoEntreOsVertices(verticeA.Id_v, verticeB.Id_v))) // Verifica se existe algum outro vértice que não é conexo ao atual
                        return false; // Caso exista algum outro vértice do grafo sem conexão ao que estamos verificando, o grafo não é conexo
                }

                // Caso todos os vértices estejam conectados entre si, o grafo é conexo
                return true;
            }
        }

        public int Grau
        {
            get
            {
                var grauVertice = this.ListaVertices.FirstOrDefault()?.Grau ?? -1;
                if (grauVertice != -1)
                {
                    return !this.ListaVertices.Any(vertice => vertice.Grau != grauVertice) ? grauVertice : 0;
                }
                return 0;
            }
        }

        public bool PossuiCaminhoEuleriano
        {
            get
            {
                return (this.Dirigido == 0) && this.Conexo && (this.CountVerticesGrauImpar == 0 || this.CountVerticesGrauImpar == 2);
            }
        }

        public int CountVerticesGrauImpar
        {
            get
            {
                return this.ListaVertices.Count(v => v.Grau % 2 != 0);
            }
        }

        public Grafo(String nome, int ponderado, int dirigido, int id)
        {
            this.nome = nome;
            this.ponderado = ponderado;
            this.dirigido = dirigido;
            this.id = id;
        }

        //?ORDENAR LISTA DE VÉRTICES E ARESTAS.

    }
}
