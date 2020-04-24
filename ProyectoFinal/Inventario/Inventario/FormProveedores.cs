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
        private DataSet dt;

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
            try
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
                Mensaje_Hijo MH = new Mensaje_Hijo();
                MH.imprimeMesaje("proveedor");
                // MessageBox.Show("Se han insertao con exito");
                dataGridViewProducto.DataSource = llenar_grid();
            }

            catch (Exception ex)
            {

                MessageBox.Show("Error al insertar" + ex);
            }


          
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion.conectar();
                string eliminar = "DELETE FROM PROVEEDORES WHERE ID_PROVEEDOR=@ID_PROVEEDOR";
                SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.conectar());
                cmd3.Parameters.AddWithValue("@ID_PROVEEDOR", bunifuMaterialTextbox1.Text);
                cmd3.ExecuteNonQuery();
                MessageBox.Show(" Se han eliminado los datos ");
                dataGridViewProducto.DataSource = llenar_grid();
            }

            catch (Exception ex)
            {

                MessageBox.Show("Error al eliminar" + ex);
            }



    
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {

                MessageBox.Show("Error al editar" + ex);
            }
           
        }

        private void textBuscar_OnValueChanged(object sender, EventArgs e)
        {
            if (textBuscar.Text != "")
            {
                dataGridViewProducto.DataSource = Buscar(textBuscar.Text);
            }
            else
            {
                dataGridViewProducto.DataSource = mostrarDatos();
            }
        }
        public void BuscarElemento()
        {
            try
            {
                Conexion.conectar();
                string buscar = "SELECT * FROM PROVEEDORES WHERE ID_PROVEEDOR=@ID_PROVEEDOR";
                SqlCommand cmd4 = new SqlCommand(buscar, Conexion.conectar());
                cmd4.CommandType = CommandType.Text;
                cmd4.CommandText = buscar;
                cmd4.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd4);
                da.Fill(dt);
                dataGridViewProducto.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mensaje " + ex);
            }
        }

        public DataTable mostrarDatos()
        {
            Conexion.conectar();
            SqlCommand cmd4 = new SqlCommand("select * from PROVEEDORES", Conexion.conectar());
            SqlDataAdapter ad = new SqlDataAdapter(cmd4);
            dt = new DataSet();
            ad.Fill(dt, "tabla");
            return dt.Tables["tabla"];
        }

        public DataTable Buscar(string ID_PROVEEDOR)
        {
            Conexion.conectar();
            SqlCommand cmd5 = new SqlCommand(string.Format("select * from PROVEEDORES where ID_PROVEEDOR like '%{0}%'", ID_PROVEEDOR), Conexion.conectar());
            SqlDataAdapter ad = new SqlDataAdapter(cmd5);
            dt = new DataSet();
            ad.Fill(dt, "PROVEEDORES");
            return dt.Tables["PROVEEDORES"];
        }
    }
}
