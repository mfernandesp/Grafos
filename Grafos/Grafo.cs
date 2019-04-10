using System;
using System.Collections.Generic;
using System.Text;

namespace Grafos
{
    public class Grafo
    {
        int id;
        String nome;
        int tipo;
        List<Aresta> listaArestas = new List<Aresta>();
        List<Grafos.Vertice> listaVertices = new  List<Vertice>();

        internal List<Vertice> ListaVertices { get => listaVertices; set => listaVertices = value; }
        internal List<Aresta> ListaArestas { get => listaArestas; set => listaArestas = value; }
        public int Tipo { get => tipo; set => tipo = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Id { get => id; set => id = value; }

        public Grafo(String nome, int tipo, int id)
        {
            this.nome = nome;
            this.tipo = tipo;
            this.id = id;
        }

        //?ORDENAR LISTA DE VÉRTICES E ARESTAS.

    }
}
