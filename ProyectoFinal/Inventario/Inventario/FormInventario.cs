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

        private DataSet dt;
        public FormInventario()
        {
            InitializeComponent();
            dataGridViewProducto.DataSource = llenar_grid();
        }

     
        public DataTable llenar_grid() // Metodo que muestras los datos de la tabla correspondiente 
        {
            Conexion.conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM INVENTARIO";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.conectar());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        private void Edit(bool value) // Permite  que lo cambios se puedan habilitar para llenar la información
        {
            txtId.Enabled = value;
            txtDescripcion.Enabled = value;
            bunifuMaterialTextbox1.Enabled = value;
            txtDepartamento.Enabled = value;
            txtPrecio.Enabled = value;
            txtProveedor.Enabled = value;
            txtCantidad.Enabled = value;
        }



        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)  // Metodo que toma las variables y los introduce como un nuevo objeto 
        {
            try
            {
                string insertar = "INSERT INTO INVENTARIO (ID_INVENTARIO,DESCRIPCION,MARCA,CATEGORIA,PRECIO,PROVEEDOR, CANTIDAD)VALUES(@ID_INVENTARIO,@DESCRIPCION,@MARCA,@CATEGORIA,@PRECIO,@PROVEEDOR,@CANTIDAD)";
                Conexion.conectar();
                SqlCommand cmd = new SqlCommand(insertar, Conexion.conectar());
                cmd.Parameters.AddWithValue("@ID_INVENTARIO", txtId.Text);
                cmd.Parameters.AddWithValue("@DESCRIPCION", txtDescripcion.Text);
                cmd.Parameters.AddWithValue("@MARCA", bunifuMaterialTextbox1.Text);
                cmd.Parameters.AddWithValue("@CATEGORIA", txtDepartamento.Text);
                cmd.Parameters.AddWithValue("@PRECIO", txtPrecio.Text);
                cmd.Parameters.AddWithValue("@PROVEEDOR", txtProveedor.Text);
                cmd.Parameters.AddWithValue("@CANTIDAD", txtCantidad.Text);
                cmd.ExecuteNonQuery();
                Mensaje_Hijo MH = new Mensaje_Hijo();
                MH.imprimeMesaje("inventario");
                dataGridViewProducto.DataSource = llenar_grid();
            }

            catch (Exception ex)
            {

                MessageBox.Show("Error al insertar" + ex);
            }


          


        }

        private void bunifuThinButton21_Click(object sender, EventArgs e) // Metodo que conecta con la base de datos, toma la variable que identifica el objeto a eliminar y lo elimina.
        {
            try
            {
                Conexion.conectar();
                string eliminar = "DELETE FROM INVENTARIO WHERE ID_INVENTARIO=@ID_INVENTARIO";
                SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.conectar());
                cmd3.Parameters.AddWithValue("@ID_INVENTARIO", txtId.Text);
                cmd3.ExecuteNonQuery();
                MessageBox.Show(" Se han eliminado los datos ");
                dataGridViewProducto.DataSource = llenar_grid();
            }

            catch (Exception ex)
            {

                MessageBox.Show("Error al eliminar" + ex);
            }         
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e) // Metodo que modifica los datos de un objeto, toma las variables de los labes y aplica el cambio 
        {
            try
            {
                Edit(true);
                Conexion.conectar();
                string actualizar = "UPDATE INVENTARIO SET ID_INVENTARIO = @ID_INVENTARIO, DESCRIPCION = @DESCRIPCION, MARCA =@MARCA, CATEGORIA = @CATEGORIA, PRECIO = @PRECIO,   PROVEEDOR= @PROVEEDOR, CANTIDAD = @CANTIDAD WHERE ID_INVENTARIO = @ID_INVENTARIO";
                SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.conectar());
                cmd2.Parameters.AddWithValue("@ID_INVENTARIO", txtId.Text);
                cmd2.Parameters.AddWithValue("@DESCRIPCION", txtDescripcion.Text);
                cmd2.Parameters.AddWithValue("@MARCA", bunifuMaterialTextbox1.Text);
                cmd2.Parameters.AddWithValue("@CATEGORIA", txtDepartamento.Text);
                cmd2.Parameters.AddWithValue("@PRECIO", txtPrecio.Text);
                cmd2.Parameters.AddWithValue("@PROVEEDOR", txtProveedor.Text);
                cmd2.Parameters.AddWithValue("@CANTIDAD", txtCantidad.Text);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("se han actualizado sus datos");
                dataGridViewProducto.DataSource = llenar_grid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar" + ex);
            }          
        }

        private void txtCantidad_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

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

        public void BuscarElemento() // Parte del proceso para mostrar unicamente la categoría que seleccionó
        {
            try
            {
                Conexion.conectar();
                string buscar = "SELECT * FROM INVENTARIO WHERE ID_INVENTARIO=@ID_INVENTARIO";
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

        public DataTable mostrarDatos() // Muestra la tabla de inventario 
        {
            Conexion.conectar();
            SqlCommand cmd4 = new SqlCommand("select * from INVENTARIO", Conexion.conectar());
            SqlDataAdapter ad = new SqlDataAdapter(cmd4);
            dt = new DataSet();
            ad.Fill(dt, "tabla");
            return dt.Tables["tabla"];
        }

        public DataTable Buscar(string ID_INVENTARIO) // Parte del proceso para mostrar unicamente la categoría que seleccionó
        {
            Conexion.conectar();
            SqlCommand cmd5 = new SqlCommand(string.Format("select * from INVENTARIO where ID_INVENTARIO like '%{0}%'", ID_INVENTARIO), Conexion.conectar());
            SqlDataAdapter ad = new SqlDataAdapter(cmd5);
            dt = new DataSet();
            ad.Fill(dt, "INVENTARIO");
            return dt.Tables["INVENTARIO"];
        }

        private void dataGridViewProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewProducto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridViewProducto.Columns[e.ColumnIndex].Name == "Cantidad")
            {
                if (Convert.ToInt32(e.Value) <= 150)
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.BackColor = Color.LightGreen;

                    if (Convert.ToInt32(e.Value) <= 100)
                    {
                        e.CellStyle.ForeColor = Color.Black;
                        e.CellStyle.BackColor = Color.Yellow;

                        if (Convert.ToInt32(e.Value) <= 50)
                        {
                            e.CellStyle.ForeColor = Color.Black;
                            e.CellStyle.BackColor = Color.OrangeRed;

                            if (Convert.ToInt32(e.Value) <= 10)
                            {
                                e.CellStyle.ForeColor = Color.Black;
                                e.CellStyle.BackColor = Color.Red;


                            }
                        }
                    }
                }

            }
        }
    }
}
