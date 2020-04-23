using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Inventario
{
    public partial class FormularioBienvenida : Form
    {
        public FormularioBienvenida()
        {
            InitializeComponent();
        }

        private void FormularioBienvenida_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            timer1.Start();
            //this.CircleProgressbar.Value = 0;
            //this.CircleProgressbar.MaxValue = 100;

        }
        int cont = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {

            timer1.Stop();
            timer2.Start();
            if (this.Opacity < 1) this.Opacity += 0.05;
            cont = +1;
            //CircleProgressbar.Value += 1;
            //CircleProgressbar.Text = CircleProgressbar.Value.ToString();
            if (cont == 100)
            {
                timer1.Stop();
                timer2.Start();
            }


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.01;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
                new proyectoFinal().Show();
            }
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
