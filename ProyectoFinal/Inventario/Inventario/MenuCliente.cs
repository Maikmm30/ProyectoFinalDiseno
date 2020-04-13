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
    }
}
