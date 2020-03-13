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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            proyectoFinal dashboard = new proyectoFinal();
            dashboard.Show();

        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
            
            
            proyectoFinal principal = new proyectoFinal();
            principal.Show();
            this.Hide();
            
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          
        }
    }
}
