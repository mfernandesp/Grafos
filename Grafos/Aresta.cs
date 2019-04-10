using System;
using System.Collections.Generic;
using System.Text;

namespace Grafos
{
    class Aresta
    {
        int id_aresta;
        String nome;
        Grafo grafo;
        Vertice vertice_O;
        Vertice vertice_D;

        public Aresta(int id, String nome, Grafo grafo, Vertice v_o, Vertice v_d)
        {

            id_aresta = id;
            this.nome = nome;
            this.grafo = grafo;
            this.vertice_O = v_o;
            this.vertice_D = v_d;
        }

        public Grafo Grafo { get => grafo; set => grafo = value; }
        public string Nome { get => nome; set => nome = value; }
        internal Vertice Vertive_D { get => vertice_D; set => vertice_D = value; }
        internal Vertice Vertice_O { get => vertice_O; set => vertice_O = value; }
    }


}
