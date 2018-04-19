using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProyectoVisual
{
    class Grafo
    {
        private List<Vertice> vertices;
        int id;

        public Grafo()
        {
            vertices = new List<Vertice>();
            id = 1;
        }

        public void AgregaVertice(Graphics g, int x, int y)
        {
            Vertice v = new Vertice(id);
            id++;
            vertices.Add(v);
            v.Dibujar(g, x, y);

        }
    }
}
