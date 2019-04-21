using System;
using System.Collections.Generic;
using System.Linq;

namespace Grafos
{
    public class Vertice
    {
        public Vertice(int id, String nome, Grafo grafo)
        {

            this.Id_v = id;
            this.Nome = nome;
            this.Grafo = grafo;
        }

        public int Id_v { get; set; }
        public String Nome { get; set; }
        public Grafo Grafo { get; set; }
        public int Grau
        {
            get
            {
                return this.ListVerticesAdjacentes.Count();
            }
        }

        public IEnumerable<Vertice> ListVerticesAdjacentes
        {
            get
            {
                foreach (var arestaD in this.Grafo.ListaArestas.Where(q=> q.Vertice_O.Id_v == this.Id_v).ToList())
                {
                    yield return arestaD.Vertive_D;
                }

                foreach (var arestaO in this.Grafo.ListaArestas.Where(q => q.Vertive_D.Id_v == this.Id_v).ToList())
                {
                    yield return arestaO.Vertice_O;
                }
            }
        }
    }

}
