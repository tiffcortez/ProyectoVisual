using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProyectoVisual
{
    class Vertice
    {
        private int id;
        private int x, y, xv, yv, radio;

        private List<Arista> a;

        public Vertice(int id_in)
        {
            id = id_in;
            radio = 30;
        }
        public Vertice()
        {
            id = 00;
            radio = 10;
        }
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public int XV
        {
            get
            {
                return xv;
            }
            set
            {
                xv = value;
            }
        }

        public int YV
        {
            get
            {
                return yv;
            }
            set
            {
                yv = value;
            }
        }

        public void Dibujar(Graphics g,int xM,int yM)
        {
            Pen juan = new Pen(Color.Blue);

            g.DrawEllipse(juan, xM - radio, yM - radio, radio * 2, radio * 2);

        }
    }
}
