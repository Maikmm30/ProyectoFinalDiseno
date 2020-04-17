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
    public partial class FormularioUsuarios : Form
    {
        public FormularioUsuarios()
        {
            InitializeComponent();
            dataGridViewProducto.DataSource = llenar_grid();
        }

        public DataTable llenar_grid()
        {
            Conexion.conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM USUARIOS";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.conectar());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        private void Edit(bool value)
        {
            txtUsuario.Enabled = value;
            txtContraseña.Enabled = value;
            txtNyA.Enabled = value;
            txtCargo.Enabled = value;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Conexion.conectar();
            string eliminar = "DELETE FROM USUARIOS WHERE Usuario=@Nombre_Usuario";
            SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.conectar());
            cmd3.Parameters.AddWithValue("@Nombre_Usuario", txtUsuario.Text);
            cmd3.ExecuteNonQuery();
            MessageBox.Show(" Se han eliminado los datos ");
            dataGridViewProducto.DataSource = llenar_grid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Edit(true);
            Conexion.conectar();
            string actualizar = "UPDATE USUARIOS SET Nombre_Usuario = @Nombre_Usuario, Password = @Contrasena,  Nombre = @Nombre,  Tipo_usuario = @Cargo WHERE Usuario = @Nombre_Usuario";
            SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.conectar());
            cmd2.Parameters.AddWithValue("@Nombre_Usuario", txtUsuario.Text);
            cmd2.Parameters.AddWithValue("@Contrasena", txtContraseña.Text);
            cmd2.Parameters.AddWithValue("@Nombre", txtNyA.Text);

            cmd2.Parameters.AddWithValue("@Cargo", txtCargo.Text);
            cmd2.ExecuteNonQuery();
            MessageBox.Show("se han actualizado sus datos");
            dataGridViewProducto.DataSource = llenar_grid();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string insertar = "INSERT INTO USUARIOS (NOMBRE,PASSWORD,USUARIO,TIPO_USUARIO)VALUES(@Nombre,@Contrasena,@Nombre_Usuario,@Cargo)";
            Conexion.conectar();
            SqlCommand cmd = new SqlCommand(insertar, Conexion.conectar());
            cmd.Parameters.AddWithValue("@Nombre_Usuario", txtUsuario.Text);
            cmd.Parameters.AddWithValue("@Contrasena", txtContraseña.Text);
            cmd.Parameters.AddWithValue("@Nombre", txtNyA.Text);
            cmd.Parameters.AddWithValue("@Cargo", txtCargo.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Se han insertado con exito");
            dataGridViewProducto.DataSource = llenar_grid();
        }

        private void dataGridViewProducto_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtUsuario.Text = dataGridViewProducto.CurrentRow.Cells[0].Value.ToString();
            txtContraseña.Text = dataGridViewProducto.CurrentRow.Cells[1].ToString();
            txtNyA.Text = dataGridViewProducto.CurrentRow.Cells[2].ToString();
            txtCargo.Text = dataGridViewProducto.CurrentRow.Cells[3].ToString();

        }
    }
}
