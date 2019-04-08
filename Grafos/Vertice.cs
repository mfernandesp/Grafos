using System;
using System.Collections.Generic;
using System.Text;

namespace Grafos
{
    class Vertice
    {

        int id_v;
        String nome;
        Grafo grafo;

        public Vertice(int id, String nome, Grafo grafo)
        {

            id_v = id;
            this.nome = nome;
            this.grafo = grafo;
        }
    }

}
