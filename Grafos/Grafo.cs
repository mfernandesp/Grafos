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
                foreach (var vertice in this.ListaVertices)
                {
                    var distanciasCaminhosPossiveis = Program.BellmanFord(this, vertice);
                    if (distanciasCaminhosPossiveis.Values.Any(v => v == int.MaxValue))
                        return false;
                }
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
