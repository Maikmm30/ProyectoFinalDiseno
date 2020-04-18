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
    public partial class FormProductosComprados : Form
    {
        public FormProductosComprados()
        {
            InitializeComponent();
            dataGridViewProducto.DataSource = llenar_grid();
        }

        public DataTable llenar_grid()
        {
            Conexion.conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM COMPRA";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.conectar());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        private void Edit(bool value)
        {
            txtCantidad.Enabled = value;
            txtCosto.Enabled = value;
            //txtFecha.Enabled = value;
            txtProducto.Enabled = value;
            txtMarca.Enabled = value;              
        }


        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Edit(true);
            Conexion.conectar();
            string actualizar = "UPDATE COMPRA SET ID_PRODUCTO = @ID_PRODUCTO,CANTIDAD = @CANTIDAD, PRECIO = @PRECIO,MARCA = @MARCA, FECHA= @FECHA WHERE ID_PRODUCTO = ID_PRODUCTO";
            SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.conectar());
            cmd2.Parameters.AddWithValue("@ID_PRODUCTO", txtProducto.Text);
            cmd2.Parameters.AddWithValue("@CANTIDAD", txtCantidad.Text);
            cmd2.Parameters.AddWithValue("@PRECIO", txtCosto.Text);
            cmd2.Parameters.AddWithValue("@MARCA", txtMarca.Text);
            //cmd2.Parameters.AddWithValue("@FECHA", txtFecha.Text);
            cmd2.ExecuteNonQuery();
            MessageBox.Show("se han actualizado sus datos");
            dataGridViewProducto.DataSource = llenar_grid();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            string insertar = "INSERT INTO COMPRA (ID_PRODUCTO,CANTIDAD,PRECIO,MARCA,FECHA)VALUES(@ID_PRODUCTO,@CANTIDAD,@PRECIO,@MARCA,@FECHA)";
            Conexion.conectar();
            SqlCommand cmd = new SqlCommand(insertar, Conexion.conectar());
            cmd.Parameters.AddWithValue("@ID_PRODUCTO", txtProducto.Text);
            cmd.Parameters.AddWithValue("@CANTIDAD", txtCantidad.Text);
            cmd.Parameters.AddWithValue("@PRECIO", txtCosto.Text);
            cmd.Parameters.AddWithValue("@MARCA", txtMarca.Text);
            cmd.Parameters.AddWithValue("@FECHA", dateTimePicker1.Value);          
            cmd.ExecuteNonQuery();
            MessageBox.Show("Se han insertao con exito");
            dataGridViewProducto.DataSource = llenar_grid();
            modificarInventario();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Conexion.conectar();
            string eliminar = "DELETE FROM COMPRA WHERE ID_PRODUCTO = @ID_PRODUCTO";
            SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.conectar());
            cmd3.Parameters.AddWithValue("@ID_PRODUCTO", txtProducto.Text);
            cmd3.ExecuteNonQuery();
            MessageBox.Show(" Se han eliminado los datos ");
            dataGridViewProducto.DataSource = llenar_grid();
        }


        public void modificarInventario()
        {
            Conexion.conectar();
            string actualizar = "UPDATE Inventario set Cantidad = Cantidad - @CANTIDAD WHERE Id_Inventario = @Id_Inventario";
            SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.conectar());
            cmd2.Parameters.AddWithValue("@CANTIDAD", Convert.ToInt32(txtCantidad.Text));
            cmd2.Parameters.AddWithValue("@Id_Inventario", Convert.ToInt32(txtProducto.Text));
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Se ha registrado su compra" + "Gracias por preferirnos !!!");
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

        }
    }
}
