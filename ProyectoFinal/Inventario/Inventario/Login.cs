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
                    //new proyectoFinal(dt.Rows[0][0].ToString()).Show();

                    if (dt.Rows[0][1].ToString() == "Admin"){
                        // new proyectoFinal(dt.Rows[0][0].ToString()).Show();
                        //proyectoFinal principal = new proyectoFinal();
                        //principal.Show();
                        new FormularioBienvenida().Show();
                        this.Hide();
                    }
                    else if (dt.Rows[0][1].ToString() == "Usuario")
                    {
                        //new MenuCliente(dt.Rows[0][0].ToString()).Show();
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
            //if (true)
            //{
                //Conexion.conectar();
                //SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from log where Username='" + txtUserName.Text + "' and Password ='" + txtPassword.Text + "'",Conexion.conectar() );
                //DataTable dt = new DataTable();
                //sda.Fill(dt);




                //if (dt.Rows[0][0].ToString() == "admin" )
                //{

                //    proyectoFinal principal = new proyectoFinal();
                //    principal.Show();
                //    this.Hide();
                //}
                //else if (dt.Rows[0][0].ToString() == "user")
                //{


                //    MenuCliente cliente = new MenuCliente();
                //    cliente.Show();
                //    this.Hide();
                //}
                logear(this.txtUserName.Text, this.txtPassword.Text);

            //}





        
            //else
            //{
            //    if (txtUserName.Text.Equals("user") && txtPassword.Text.Equals("123"))
            //    {
            //        MenuCliente cliente = new MenuCliente();
            //        cliente.Show();
            //        this.Hide();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Usuario y/o contraseña incorrecta");
            //    }
            //}




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
            new txt_Nombre().Show();
            this.Hide();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore.exe", "D:/Users/Michael/Documents/Visual Studio 2019/ProyectoFinalDiseno/ProyectoFinal/Inventario/Inventario/PaginaWeb/indice.html");
        }
    }
}
