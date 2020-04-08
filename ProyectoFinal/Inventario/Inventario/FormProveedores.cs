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
    public partial class FormProveedores : Form
    {
        public FormProveedores()
        {
            InitializeComponent();
            dataGridViewProducto.DataSource = llenar_grid();
        }

        public DataTable llenar_grid()
        {
            Conexion.conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM PROVEEDORES";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.conectar());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        private void Edit(bool value)
        {
            bunifuMaterialTextbox1.Enabled = value;
            bunifuMaterialTextbox5.Enabled = value;
            bunifuMaterialTextbox4.Enabled = value;
            bunifuMaterialTextbox3.Enabled = value;
            bunifuMaterialTextbox2.Enabled = value;
        }

        private void dataGridViewProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            string insertar = "INSERT INTO PROVEEDORES (ID_PROVEEDOR,NOMBRE_CONTACTO,NOMBRE_EMPRESA,DIRECCION,TELEFONO)VALUES(@ID_PROVEEDOR,@NOMBRE_CONTACTO,@NOMBRE_EMPRESA,@DIRECCION,@TELEFONO)";
            Conexion.conectar();
            SqlCommand cmd = new SqlCommand(insertar, Conexion.conectar());
            cmd.Parameters.AddWithValue("@ID_PROVEEDOR", bunifuMaterialTextbox1.Text);
            cmd.Parameters.AddWithValue("@NOMBRE_CONTACTO", bunifuMaterialTextbox5.Text);
            cmd.Parameters.AddWithValue("@NOMBRE_EMPRESA", bunifuMaterialTextbox4.Text);
            cmd.Parameters.AddWithValue("@DIRECCION", bunifuMaterialTextbox3.Text);
            cmd.Parameters.AddWithValue("@TELEFONO", bunifuMaterialTextbox2.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Se han insertao con exito");
            dataGridViewProducto.DataSource = llenar_grid();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Conexion.conectar();
            string eliminar = "DELETE FROM PROVEEDORES WHERE ID_PROVEEDOR=@ID_PROVEEDOR";
            SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.conectar());
            cmd3.Parameters.AddWithValue("@ID_PROVEEDOR", bunifuMaterialTextbox1.Text);
            cmd3.ExecuteNonQuery();
            MessageBox.Show(" Se han eliminado los datos ");
            dataGridViewProducto.DataSource = llenar_grid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Edit(true);
            Conexion.conectar();
            string actualizar = "UPDATE PROVEEDORES SET ID_PROVEEDOR = @ID_PROVEEDOR,NOMBRE_CONTACTO = @NOMBRE_CONTACTO,NOMBRE_EMPRESA = @NOMBRE_EMPRESA, DIRECCION = @DIRECCION,TELEFONO = @TELEFONO WHERE ID_PROVEEDOR=@ID_PROVEEDOR";
            SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.conectar());
            cmd2.Parameters.AddWithValue("@ID_PROVEEDOR", bunifuMaterialTextbox1.Text);
            cmd2.Parameters.AddWithValue("@NOMBRE_CONTACTO", bunifuMaterialTextbox5.Text);
            cmd2.Parameters.AddWithValue("@NOMBRE_EMPRESA", bunifuMaterialTextbox4.Text);
            cmd2.Parameters.AddWithValue("@DIRECCION", bunifuMaterialTextbox3.Text);
            cmd2.Parameters.AddWithValue("@TELEFONO", bunifuMaterialTextbox2.Text);
            cmd2.ExecuteNonQuery();
            MessageBox.Show("se han actualizado sus datos");
            dataGridViewProducto.DataSource = llenar_grid();
        }
    }
}
