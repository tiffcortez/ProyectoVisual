using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVisual
{
    public partial class Form1 : Form
    {
        PictureBox pb;
        Grafo grafo;
        Graphics lienzo;

        public Form1()
        {
            InitializeComponent();
            Inicializar();
        }

        public void Inicializar()
        {
            pb = new PictureBox();
            lienzo = pictureBox1.CreateGraphics();
            grafo = new Grafo();
            //pictureBox1.Enabled = false;

            Controls.Add(pb);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            lienzo.Clear(Color.White);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pb.Paint += new PaintEventHandler(pictureBox1_Paint);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            grafo.AgregaVertice(lienzo, e.X, e.Y);
            /*Pen p = new Pen(Color.Black);
            lienzo.DrawEllipse(p, e.X - 10, e.Y - 10, 20, 20);*/
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Enabled = true;
            lienzo.Clear(Color.White);
            MessageBox.Show("Cuántos grafos desea crear?");
        }
    }
}
