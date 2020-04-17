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

        private void btn_registrarse_Click(object sender, EventArgs e)
        {
            if (txtPassword3.Text == txtPassword4.Text)
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
            }
        }


        //public static int CrearCuentas(string pUsuario, string pContraseña, string Nombre, string Tipo_Usuario)
        //{

        //    //string insertar = "INSERT INTO PRUEBA (ID,NOMBRE,APELLIDOS,TELEFONO)VALUES(@ID,@NOMBRE,@APELLIDOS,@TELEFONO)";
        //    //SqlCommand cmd = new SqlCommand(insertar, Conexion.conectar());
        //    //cmd.Parameters.AddWithValue("@ID", idTextBox.Text);
        //    //cmd.Parameters.AddWithValue("@NOMBRE", nombreTextBox.Text);
        //    //cmd.Parameters.AddWithValue("@APELLIDOS", apellidosTextBox.Text);
        //    //cmd.Parameters.AddWithValue("@TELEFONO", telefonoTextBox.Text);

        //    //cmd.ExecuteNonQuery();

        //    int resultado =0;
            

        //    return resultado;
        //}

        private void txt_Nombre_Load(object sender, EventArgs e)
        {

        }

        private void BTN_CANCELAR_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
    }
}
