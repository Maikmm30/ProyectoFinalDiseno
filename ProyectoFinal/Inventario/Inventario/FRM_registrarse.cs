using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventario
{
    public partial class txt_Nombre : Form
    {
        public txt_Nombre()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btn_registrarse_Click(object sender, EventArgs e) // Metodo que toma las variables de los labels y los ingresa dentro de la tabla de datos 
        {

            try
            {
                if ((txtPassword3.Text == txtPassword4.Text) && (bunifuCheckbox1.Checked))
                {
                    Conexion.conectar();
                    string insertar = "INSERT INTO USUARIOS (NOMBRE,USUARIO,PASSWORD,Tipo_Usuario)VALUES(@Nombre,@Usuario,@Password,@Tipo_Uusuario)";
                    SqlCommand cmd = new SqlCommand(insertar, Conexion.conectar());
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre1.Text);
                    cmd.Parameters.AddWithValue("@Usuario", txtUserName1.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword3.Text);
                    cmd.Parameters.AddWithValue("@Tipo_Uusuario", TXTipoUsuario.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Se ha creado su usuario");
                    this.Hide();
                    new Login().Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            
        }

        private void txt_Nombre_Load(object sender, EventArgs e)
        {

        }

        private void BTN_CANCELAR_Click(object sender, EventArgs e) // Metodo para devolverse al Login. 
        {
            this.Hide();
            new Login().Show();
        }
    }
}
