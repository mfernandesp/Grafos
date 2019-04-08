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
        Vertice vertive_D;

        public Aresta(int id, String nome, Grafo grafo, Vertice v_o, Vertice v_d)
        {

            id_aresta = id;
            this.nome = nome;
            this.grafo = grafo;
            this.vertice_O = v_o;
            this.vertive_D = v_d;
        }
    }

}
