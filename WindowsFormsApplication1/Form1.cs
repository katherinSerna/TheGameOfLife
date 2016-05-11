using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Tablero t;

        public int limite;
        public int limites;
        public int muertas;
        public int vivas;
        int conteo;
        public int size = 10;

        public Form1(string nicks)
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            nombresito.Text = nicks;
            limites = 0;
            conteo = 0;
            t = new Tablero(size);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            t.Dibuja(this);

            t.next(ref limites, ref muertas, ref vivas); //me inicializa el puntaje desde 0
            ContM.Text = Convert.ToString(muertas);
            ContV.Text = Convert.ToString(vivas);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            t.next(ref limites, ref muertas, ref vivas);
            t.update();
            this.Invalidate();  //borra los cuadritos anteriores para solo dejar los actuales :)*/


            /*   Tablero p = new Tablero(10);
               p.update();*/
            //   t.update(this.tama)

            if (muertas <= 100)
            {

                limites = limites + 1;

            }
            if (muertas == 100)
            {
                MessageBox.Show("TU PUNTUACION ES DE :   " + conteo);
                muertas = 0;
                limites = 0;
                conteo = 1;

            }


            if (conteo < limites)
            {
                conteo = conteo + 1;
                contador.Text = Convert.ToString(conteo);            
                ContV.Text = Convert.ToString(vivas);
                //   ContMm = ContM.Text;
                ContM.Text = Convert.ToString(muertas);

                //  MessageBox.Show("AQUI TERMINA");
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            conteo = 0; //actualiza los puntos
            limites = 0;


            t = new Tablero(10);
            t.Dibuja(this);
            this.Invalidate();
        



            if (muertas <= 100)
            {

                limites = limites + 2;

            }
            if (muertas == 100)
            {
                MessageBox.Show("TU PUNTUACION ES DE :   " + conteo);
                limites = 0;

            }


            if (conteo < limites)
            {
                conteo = conteo + 1;
                contador.Text = Convert.ToString(conteo);
               

                //   ContMm = ContM.Text;
                ContM.Text = Convert.ToString(muertas);

                //  MessageBox.Show("AQUI TERMINA");
            }
        }

        private void Dimension_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Dimension.SelectedIndex == 0)
            {
                size = 5;
                this.Invalidate();
                t = new Tablero(size);
            }
            else if (Dimension.SelectedIndex == 1)
            {
                size = 6;
                this.Invalidate();
                t = new Tablero(size);
            }
            else if (Dimension.SelectedIndex == 2)
            {
                size = 7;
                this.Invalidate();
                t = new Tablero(size);
            }

            else if (Dimension.SelectedIndex == 3)
            {
                size = 8;
                this.Invalidate();
                t = new Tablero(size);
            }
            else if (Dimension.SelectedIndex == 4)
            {
                size = 9;
                this.Invalidate();
                t = new Tablero(size);
            }

            else if (Dimension.SelectedIndex == 5)
            {
                size = 10;
                this.Invalidate();
                t = new Tablero(size);
            }



        }

       

        private void nombresito_Click(object sender, EventArgs e)
        {

        }
    }
          
        }
  
