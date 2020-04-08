using System;
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
            if (txtUserName.Text.Equals("admin") && txtPassword.Text.Equals("admin"))
            {
                proyectoFinal principal = new proyectoFinal();
                principal.Show();
                this.Hide();

            }
            else
            {
                if (txtUserName.Text.Equals("user") && txtPassword.Text.Equals("123"))
                {
                    MenuCliente cliente = new MenuCliente();
                    cliente.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecta");
                }
            }




        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
