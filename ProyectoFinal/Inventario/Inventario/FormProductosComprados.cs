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
        private DataSet dt;

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

        private void cantidadNueva()
        {
            try
            {
                int cantidadNueva = Convert.ToInt32(txtCantidad.Text);

                lbCantidadNueva.Text = cantidadNueva.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Vuelva Ingresar la cantidad");
               
            }
            
        }

        public void cantidadTotal()
        {
            try
            {
                int cantidadBase = Convert.ToInt32(lbCantidad.Text);
                int cantidadVieja = Convert.ToInt32(lbCantidadNueva.Text);
                int cantidadTotal = cantidadBase + cantidadVieja;
                lbCantidadsumada.Text = cantidadTotal.ToString();
            }
            catch (Exception ex )
            {

                MessageBox.Show("" + ex);
            }
            

        }

        private void Edit(bool value)
        {
            txtCantidad.Enabled = value;
            txtCosto.Enabled = value;
            dateTimePicker1.Enabled = value;
            txtIDCompra.Enabled = value;
            txtMarca.Enabled = value;              
        }


        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e) // Metodo que modifica los datos de un objeto, toma las variables de los labes y aplica el cambio 
        {
            try
            {
                Edit(true);
                Conexion.conectar();
                string actualizar = "UPDATE COMPRA SET CANTIDAD_COMPRADA = @CANTIDAD_COMPRADA, PRECIO_PAGADO = @PRECIO_PAGADO,DESCRIPCION = @DESCRIPCION, FECHA= @FECHA WHERE ID_COMPRA = @ID_COMPRA";
                SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.conectar());
                cmd2.Parameters.AddWithValue("@ID_COMPRA", txtIDCompra.Text);
                cmd2.Parameters.AddWithValue("@CANTIDAD_COMPRADA", txtCantidad.Text);
                cmd2.Parameters.AddWithValue("@PRECIO_PAGADO", txtCosto.Text);
                cmd2.Parameters.AddWithValue("@DESCRIPCION", txtMarca.Text);
                cmd2.Parameters.AddWithValue("@FECHA", dateTimePicker1.Value); 
                cmd2.ExecuteNonQuery();
                MessageBox.Show("se han actualizado sus datos");
                dataGridViewProducto.DataSource = llenar_grid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar" + ex);
            }           
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e) // Metodo que toma las variables y los introduce como un nuevo objeto 
        {
            try
            {
                String agregar = "INSERT INTO COMPRA (CANTIDAD_COMPRADA,PRECIO_PAGADO,DESCRIPCION,FECHA) VALUES (@CANTIDAD_COMPRADA,@PRECIO,@DESCRIPCION,@FECHA)";
                Conexion.conectar();
                SqlCommand cmd3 = new SqlCommand(agregar, Conexion.conectar());
                cmd3.Parameters.AddWithValue("@CANTIDAD_COMPRADA", txtCantidad.Text);
                cmd3.Parameters.AddWithValue("@PRECIO", txtCosto.Text);
                cmd3.Parameters.AddWithValue("@DESCRIPCION", txtMarca.Text);
                cmd3.Parameters.AddWithValue("@FECHA", dateTimePicker1.Value);
                cmd3.ExecuteNonQuery();
                Mensaje_Hijo MH = new Mensaje_Hijo();
                MH.imprimeMesaje("compra");
                dataGridViewProducto.DataSource = llenar_grid();
                modificarInventario();
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
                string eliminar = "DELETE FROM COMPRA WHERE ID_COMPRA = @ID_COMPRA";
                SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.conectar());
                cmd3.Parameters.AddWithValue("@ID_COMPRA", txtIDCompra.Text);
                cmd3.ExecuteNonQuery();
                MessageBox.Show(" Se han eliminado los datos ");
                dataGridViewProducto.DataSource = llenar_grid();

             
                string update = "update Inventario set Cantidad = @Cantidad where Descripcion = @Descripcion";
                SqlCommand cmd6 = new SqlCommand(update, Conexion.conectar());
                cmd6.Parameters.AddWithValue("@Descripcion", txtMarca.Text);
                cmd6.Parameters.AddWithValue("@Cantidad", lbCantidadsumada.Text);
                cmd6.ExecuteNonQuery();
                MessageBox.Show("Se ha actualizado al tabla de inventario");
                cmd6.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar" + ex);
            }            
        }

        public void consultarCantidad() {
            string consultar2 = "Select Cantidad from inventario where Descripcion = @Descripcion";
            SqlCommand cmd5 = new SqlCommand(consultar2, Conexion.conectar());
            cmd5.Parameters.AddWithValue("@Descripcion", txtMarca.Text);
            cmd5.ExecuteNonQuery();
            SqlDataReader sqlDataReader1 = cmd5.ExecuteReader();

            while (sqlDataReader1.Read())
            {
                lbCantidad.Text = (sqlDataReader1["Cantidad"].ToString());
            }


        }

        public void modificarInventario()
        {
            try
            {
                Conexion.conectar();
                string actualizar = "UPDATE Inventario set Cantidad = Cantidad - @CANTIDAD WHERE Descripcion = @DESCRIPCION";
                SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.conectar());
                cmd2.Parameters.AddWithValue("@CANTIDAD", Convert.ToInt32(txtCantidad.Text));
                cmd2.Parameters.AddWithValue("@DESCRIPCION", txtMarca.Text);
                cmd2.ExecuteNonQuery();
                dataGridViewProducto.DataSource = llenar_grid();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al modificar el inventario" + ex);
            }
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

        public void BuscarElemento()  // Parte del proceso para mostrar unicamente la categoría que seleccionó
        {
            try
            {
                Conexion.conectar();
                string buscar = "SELECT * FROM COMPRA WHERE ID_COMPRA=@ID_COMPRA";
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

        public DataTable mostrarDatos() // Muestra la tabla de productos  
        {
            Conexion.conectar();
            SqlCommand cmd4 = new SqlCommand("select * from COMPRA", Conexion.conectar());
            SqlDataAdapter ad = new SqlDataAdapter(cmd4);
            dt = new DataSet();
            ad.Fill(dt, "tabla");
            return dt.Tables["tabla"];
        }

        public DataTable Buscar(string ID_COMPRA)  // Parte del proceso para mostrar unicamente la categoría que seleccionó
        {
            Conexion.conectar();
            SqlCommand cmd5 = new SqlCommand(string.Format("select * from COMPRA where ID_COMPRA like '%{0}%'", ID_COMPRA), Conexion.conectar());
            SqlDataAdapter ad = new SqlDataAdapter(cmd5);
            dt = new DataSet();
            ad.Fill(dt, "COMPRA");
            return dt.Tables["COMPRA"];
        }

        private void txtMarca_OnValueChanged(object sender, EventArgs e)
        {
            consultarCantidad();
            
        }

        private void lbCantidad_Click(object sender, EventArgs e)
        {
            consultarCantidad();
        }

        private void txtCantidad_OnValueChanged(object sender, EventArgs e)
        {
            cantidadNueva();
        }

        private void txtCosto_OnValueChanged(object sender, EventArgs e)
        {
            cantidadTotal();
        }

        private void txtIDCompra_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
