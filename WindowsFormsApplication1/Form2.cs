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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //   Form1 nombre = new Form1();
            //   nombre.nombre.Text = nick.Text;


            /* Form form = new Form1();
             form.Show();
             */
            //   t.next(ref limites, ref muertas, ref vivas, ref ContMm);
            //  ContMm = Convert.ToString(muertas);


            String texto = nick.Text;

            Form1 m = new Form1(texto);

            m.Show();


            //    m.Visible = true;
            /*  m.Show();

              if (texto != string.Empty)
              {
                  m.Visible = true;
              }
              else
              {
                  m.Visible = false;
              }*/
        }

        private void nick_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
