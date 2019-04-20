using System;
using System.Collections.Generic;
using System.Text;
using Grafos;

namespace Grafos
{
    public class Vertice
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

        public int Id_v { get => id_v; set => id_v = value; }
        public String Nome { get => nome; set => nome = value; }
    }

}
