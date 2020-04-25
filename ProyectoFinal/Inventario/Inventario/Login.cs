using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

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

        public void logear(string usuario, string contrasena)
            // Este metodo tomas los datos de los labels y los compara con los valores dentro de la base de datos para saber si puede ingresar o no; y a donde ingresar. 
        {
            try
            {
                Conexion.conectar();
                SqlCommand cmd = new SqlCommand("SELECT Nombre, tipo_usuario FROM USUARIOS WHERE Usuario = @Usuario AND Password = @pass", Conexion.conectar());
                cmd.Parameters.AddWithValue("Usuario", usuario);
                cmd.Parameters.AddWithValue("pass", contrasena);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1){
                    this.Hide();

                    if (dt.Rows[0][1].ToString() == "Admin"){
                       
                        new FormBienvenidacs().Show();


                        this.Hide();
                    }
                    else if (dt.Rows[0][1].ToString() == "Usuario")
                    {
                        MenuCliente cliente = new MenuCliente();
                        cliente.Show(); 
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecta");
                }
            }
            catch (Exception E)
            {

                MessageBox.Show(E.Message);
            }
           
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           

                logear(this.txtUserName.Text, this.txtPassword.Text);


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

        private void bunifuCustomLabel1_Click(object sender, EventArgs e) // Llama al formulario para ingresar nueva cuenta de CLIENTE. 
        {
            new txt_Nombre().Show();
            this.Hide();
        }

        private void button1_Click_2(object sender, EventArgs e) // Metodo para ir a la pagina de la empresa y ver los manuales 
        {
            System.Diagnostics.Process.Start("C:/Users/EFS/Documents/GitHub/ProyectoFinalDiseno/ProyectoFinal/Inventario/Inventario/PaginaWeb/indice.html");
        }
    }
}
