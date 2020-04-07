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
    public partial class FormInventario : Form
    {
        public FormInventario()
        {
            InitializeComponent();
        }

     
        public DataTable llenar_grid()
        {
            Conexion.conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM INVENTARIO";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.conectar());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        private void Edit(bool value)
        {
            txtId.Enabled = value;
            txtDescripcion.Enabled = value;
            bunifuMaterialTextbox1.Enabled = value;
            txtDepartamento.Enabled = value;
            txtPrecio.Enabled = value;
            txtProveedor.Enabled = value;
        }



        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            string insertar = "INSERT INTO INVENTARIO (ID_INVENTARIO,DESCRIPCION,MARCA,CATEGORIA,PRECIO,PROVEEDOR)VALUES(@ID_INVENTARIO,@DESCRIPCION,@MARCA,@CATEGORIA,@PRECIO,@PROVEEDOR)";
            Conexion.conectar();
            SqlCommand cmd = new SqlCommand(insertar, Conexion.conectar());
            cmd.Parameters.AddWithValue("@ID_INVENTARIO", txtId.Text);
            cmd.Parameters.AddWithValue("@DESCRIPCION", txtDescripcion.Text);
            cmd.Parameters.AddWithValue("@MARCA", bunifuMaterialTextbox1.Text);
            cmd.Parameters.AddWithValue("@CATEGORIA", txtDepartamento.Text);
            cmd.Parameters.AddWithValue("@PRECIO", txtPrecio.Text);
            cmd.Parameters.AddWithValue("@PROVEEDOR", txtProveedor.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Se han insertao con exito");
            dataGridViewProducto.DataSource = llenar_grid();


        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Conexion.conectar();
            string eliminar = "DELETE FROM INVENTARIO WHERE ID_INVENTARIO=@ID_INVENTARIO";
            SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.conectar());
            cmd3.Parameters.AddWithValue("@ID_INVENTARIO", txtId.Text);
            cmd3.ExecuteNonQuery();
            MessageBox.Show(" Se han eliminado los datos ");
            dataGridViewProducto.DataSource = llenar_grid();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            Edit(true);
            Conexion.conectar();
            string actualizar = "UPDATE INVENTARIO SET ID_INVENTARIO = @ID_INVENTARIO, DESCRIPCION = @DESCRIPCION, MARCA =@MARCA, CATEGORIA = @CATEGORIA, PRECIO = @PRECIO,   PROVEEDOR= @PROVEEDOR WHERE ID_INVENTARIO=@ID_INVENTARIO";
            SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.conectar());
            cmd2.Parameters.AddWithValue("@ID_INVENTARIO", txtId.Text);
            cmd2.Parameters.AddWithValue("@DESCRIPCION", txtDescripcion.Text);
            cmd2.Parameters.AddWithValue("@MARCA", bunifuMaterialTextbox1.Text);
            cmd2.Parameters.AddWithValue("@CATEGORIA", txtDepartamento.Text);
            cmd2.Parameters.AddWithValue("@PRECIO", txtPrecio.Text);
            cmd2.Parameters.AddWithValue("@PROVEEDOR", txtProveedor.Text);
            cmd2.ExecuteNonQuery();
            MessageBox.Show("se han actualizado sus datos");
            dataGridViewProducto.DataSource = llenar_grid();
        }
    }
}
