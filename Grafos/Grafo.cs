using System;
using System.Collections.Generic;
using System.Text;

namespace Grafos
{
    class Grafo
    {
        int id;
        String nome;
        int tipo;


        public Grafo(String nome, int tipo)
        {
            this.nome = nome;
            this.tipo = tipo;
        }

        public String Getnome()
        {
            return nome;
        }
    }

}
