using System;
using System.Windows.Forms;

namespace Inventario
{
    public partial class MenuCliente : Form
    {
        public MenuCliente()
        {
            InitializeComponent();
            CenterToScreen();
        }

        public MenuCliente(string nombre)
        {
            InitializeComponent();
            CenterToScreen();
            lbnombreUsuario.Text = nombre;
        }



        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login Volver = new Login();
            Volver.Show();
            this.Hide();
        }

        private void buttonVideojuegos_Click(object sender, EventArgs e)
        {


           

        }

        private void ButtonVolver_Click(object sender, EventArgs e)
        {
            Login Volver = new Login();
            Volver.Show();
            this.Hide();

        }

        private void buttonMusica_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
