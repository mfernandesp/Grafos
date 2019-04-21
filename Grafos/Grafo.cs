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
        public bool Conexo
        {
            get
            {
                return false; // TODO
            }
        }

        public bool PossuiCaminhoEuleriano
        {
            get
            {
                return (this.Dirigido == 1) && this.Conexo && (this.CountVerticesGrauImpar == 0 || this.CountVerticesGrauImpar == 2);
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
