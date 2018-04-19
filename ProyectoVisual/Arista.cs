using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProyectoVisual
{
    class Arista
    {
        private int id;
        private int x0, y0, x1, y1;

        public int X0
        {
            set
            {
                x0 = value;
            }
            get
            {
                return x0;
            }
        }

        public int Y0
        {
            set
            {
                y0 = value;
            }
            get
            {
                return y0;
            }
        }

        public int X1
        {
            set
            {
                x1 = value;
            }
            get
            {
                return x1;
            }
        }

        public int Y1
        {
            set
            {
                y1 = value;
            }
            get
            {
                return y1;
            }
        }

        public int ID
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }
    }
}
