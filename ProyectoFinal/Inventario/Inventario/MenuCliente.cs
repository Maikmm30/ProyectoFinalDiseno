using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inventario
{
    public partial class MenuCliente : Form
    {

        private DataSet dt;

        public MenuCliente()
        {
            InitializeComponent();
            CenterToScreen();
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

        //public DataTable validarCantidad(String Descripcion, String cantidad)
        //{
        //    Conexion.conectar();
        //    String consultar = "SELECT DESCRIPCION, CANTIDAD, PRECIO FROM Inventario where (CANTIDAD>=@CANTIDAD) AND (DESCRIPCION=@DESCRIPCION)";
        //    SqlCommand cmd = new SqlCommand(consultar, Conexion.conectar());
        //    cmd.Parameters.AddWithValue("@CANTIDAD", cantidad);
        //    cmd.Parameters.AddWithValue("@DESCRIPCION", Descripcion);
        //    cmd.ExecuteNonQuery();

        //}
             
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
                MessageBox.Show("Si hay la cantidad solicitada");
            }
            catch (Exception)
            {

                MessageBox.Show("No se ha encontrado la cantidad buscada ");
            }
        }

        private void txtPagar_TextChanged(object sender, EventArgs e)
        {
            Conexion.conectar();
            String consultar = "SELECT DESCRIPCION, CANTIDAD, PRECIO FROM Inventario where (CANTIDAD>=@CANTIDAD) AND (DESCRIPCION=@DESCRIPCION)";
            SqlCommand cmd = new SqlCommand(consultar, Conexion.conectar());
            int cantidad = int.Parse(txtCantidad.Text);
            cmd.Parameters.AddWithValue("@CANTIDAD", cantidad);
            cmd.Parameters.AddWithValue("@DESCRIPCION", txtBuscar.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    sqlDataReader.Read();

                    txtPagar.Text = "Precio" + "" + sqlDataReader["PRECIO"] + Environment.NewLine;
                }
            }

            //double precio = double.Parse(txtPagar.Text);
            //double cantidad = double.Parse(txtCantidad.Text);
            //precio = (precio * cantidad) + (precio * cantidad) * 0.13;
            //txtPagar.Text = precio.ToString();
        }

        private void clienteData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPagar.Text = clienteData.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
