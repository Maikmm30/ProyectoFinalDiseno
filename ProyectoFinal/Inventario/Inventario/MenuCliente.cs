using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Inventario
{
    public partial class MenuCliente : Form
    {
        DateTime fecha = DateTime.Today;

        private DataSet dt;

        public MenuCliente()
        {
            InitializeComponent();
            CenterToScreen();
            obtenerFecha();
        }

        public MenuCliente(string nombre)
        {
            InitializeComponent();
            CenterToScreen();

        }

        public DataTable llenar_grid()
        {
            Conexion.conectar();
            DataTable dt = new DataTable();
            string consulta = "select Categoria CATEGORIA, Descripcion DESCRIPCION, Precio PRECIO from Inventario where id_Inventario > 0; ";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            return dt;
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login Volver = new Login();
            Volver.Show();
            this.Hide();
        }


        public DataTable Buscar(string Categoria)
        {
            Conexion.conectar();
            SqlCommand cmd5 = new SqlCommand(string.Format("select Categoria CATEGORIA, Descripcion DESCRIPCION, Precio PRECIO from Inventario where Categoria like '%{0}%'", Categoria), Conexion.conectar());
            SqlDataAdapter ad = new SqlDataAdapter(cmd5);
            dt = new DataSet();
            ad.Fill(dt, "Inventario");
            return dt.Tables["Inventario"];
        }

        public DataTable BuscarTodos()
        {
            Conexion.conectar();
            SqlCommand cmd5 = new SqlCommand(string.Format("select Categoria CATEGORIA, Descripcion DESCRIPCION, Precio PRECIO from Inventario where id_Inventario > 0; "), Conexion.conectar());
            SqlDataAdapter ad = new SqlDataAdapter(cmd5);
            dt = new DataSet();
            ad.Fill(dt, "Inventario");
            return dt.Tables["Inventario"];
        }




        private void buttonVideojuegos_Click(object sender, EventArgs e)
        {

            clienteData.DataSource = Buscar("Videojuego");

        }



        private void ButtonVolver_Click(object sender, EventArgs e)
        {
            Login Volver = new Login();
            Volver.Show();
            this.Hide();

        }

        private void buttonMusica_Click(object sender, EventArgs e)
        {
            clienteData.DataSource = Buscar("Musica");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Conexion.conectar();
                string actualizar = "UPDATE Inventario set Cantidad = Cantidad - @CANTIDAD WHERE Descripcion = @DESCRIPCION";
                SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.conectar());
                cmd2.Parameters.AddWithValue("@CANTIDAD", Convert.ToInt32(txtCantidad.Text));
                cmd2.Parameters.AddWithValue("@DESCRIPCION", txtBuscar.Text);
                cmd2.ExecuteNonQuery();
                clienteData.DataSource = llenar_grid();
                MessageBox.Show("Se ha efectuado su compra" + " Gracias por preferirnos !!!");
            }
            catch (Exception ex)
            {
                if (ex is SqlException)
                {
                    MessageBox.Show("No puede comprar ese articulo, no hay");

                }
                else
                {
                    MessageBox.Show("No hay de la cantidad buscada");
                }

            }



            try
            {
                String agregar = "INSERT INTO COMPRA (CANTIDAD_COMPRADA,PRECIO_PAGADO,DESCRIPCION,FECHA) VALUES (@CANTIDAD_COMPRADA,@PRECIO,@DESCRIPCION,@FECHA)";
                SqlCommand cmd3 = new SqlCommand(agregar, Conexion.conectar());
                cmd3.Parameters.AddWithValue("@CANTIDAD_COMPRADA", txtCantidad.Text);
                cmd3.Parameters.AddWithValue("@PRECIO", txtPagar.Text);
                cmd3.Parameters.AddWithValue("@DESCRIPCION", txtBuscar.Text);
                cmd3.Parameters.AddWithValue("@FECHA", fecha);
                cmd3.ExecuteNonQuery();
                MessageBox.Show("SE HA INSERTADO EN LA TABLA DE COMPRADOS");

                txtBuscar.Clear();
                txtCantidad.Clear();
                txtPagar.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(" ");
            }
        }

        private void MenuCliente_Load(object sender, EventArgs e)
        {
            Conexion.conectar();
            MessageBox.Show("Conexion exitosa");
            clienteData.DataSource = llenar_grid();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {

            clienteData.DataSource = BuscarTodos();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            clienteData.DataSource = Buscar("Figura");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clienteData.DataSource = Buscar("Pelicula");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clienteData.DataSource = Buscar("Variado");
        }


        public DataTable BuscarTxT(string Descripcion)
        {
            Conexion.conectar();
            SqlCommand cmd5 = new SqlCommand(string.Format("select Categoria CATEGORIA, Descripcion DESCRIPCION, Precio PRECIO from Inventario where Descripcion like '%{0}%'", Descripcion), Conexion.conectar());
            SqlDataAdapter ad = new SqlDataAdapter(cmd5);
            dt = new DataSet();
            ad.Fill(dt, "Inventario");
            return dt.Tables["Inventario"];
        }

        public void obtenerFecha()
        {
            lbFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

           clienteData.DataSource = BuscarTxT(txtBuscar.Text);
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {


            try
            {



                Conexion.conectar();
                String consultar = "SELECT DESCRIPCION, CANTIDAD, PRECIO FROM Inventario where (CANTIDAD>=@CANTIDAD) AND (DESCRIPCION=@DESCRIPCION)";
                SqlCommand cmd = new SqlCommand(consultar, Conexion.conectar());
                int cantidad = int.Parse(txtCantidad.Text);
                cmd.Parameters.AddWithValue("@CANTIDAD", cantidad);
                cmd.Parameters.AddWithValue("@DESCRIPCION", txtBuscar.Text);
                cmd.ExecuteNonQuery();


                SqlDataReader sqlDataReader = cmd.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    if (txtCantidad.Text != null)
                    {


                        txtPagar.Text = (sqlDataReader["Precio"].ToString());

                    }
                    else
                    {
                        txtPagar.Clear();
                    }
                }

                int precio = int.Parse(txtPagar.Text);
                precio = (precio * cantidad);
                txtPagar.Text = precio.ToString();

            }
            catch (Exception)
            {

                if (txtCantidad.Text == null )
                {
                    MessageBox.Show("No se ha encontrado la cantidad buscada ");
                }
                else
                {
                    
                }
                
            }
        
    


        }
        
        private void txtPagar_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void clienteData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void lbFecha_Click(object sender, EventArgs e)
        {
            obtenerFecha();
        }

        private void clienteData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
