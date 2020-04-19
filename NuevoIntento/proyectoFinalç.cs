using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inventario
{
    public partial class proyectoFinal : Form
    {
        private Form Panelhijo;

        public proyectoFinal()
        {
            InitializeComponent();
            CenterToScreen();
            
            labelVariado();
            labelPelicula();
            labelMusica();
            labelFiguras();
            cantidadUsuario();
            cantidadVendidos();
            labelVideojuego();
            cantidadProveedores();
            labelStock();
            cantidadProveedores();

        }


        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCharts1_Load(object sender, EventArgs e)
        {
            
        }

        private void salir_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }





        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel10_Click(object sender, EventArgs e)
        {

        }


        public void AbrirFormInPanel(Form FormularioItems)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
                Form fh = FormularioItems as Form;
                Panelhijo = fh;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panelContenedor.Controls.Add(fh);
                this.panelContenedor.Tag = fh;
                fh.BringToFront();
                fh.Show();
                menuPrincipal.Text = fh.Text;

            }


        }

        private void item_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormularioItems());
        }

        private void Usuario_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormularioUsuarios());
        }

        private void Inventaria_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormInventario());
        }

        private void productosComprados_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormProductosComprados());
        }

        private void proveedor_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormProveedores());
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            Panelhijo.Close();
            AbrirFormInPanel(new proyectoFinal());
        }

        private void bunifuCharts1_Load_2(object sender, EventArgs e)
        {
            labelStock();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Stop();

            Bunifu.DataViz.Data data = new Bunifu.DataViz.Data();
            Bunifu.DataViz.DataPoint point1 = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuCharts._type.spline);

            point1.addLabely("LUNES", label11.Text);
            point1.addLabely("MARTES", label11.Text);
            point1.addLabely("MIERCOLES", label11.Text);
            point1.addLabely("JUEVES", "80");
            point1.addLabely("VIERNES", "90");
            point1.addLabely("SABADO", label11.Text);
            point1.addLabely("DOMINGO","100");
            data.addData(point1);

            Bunifu.DataViz.DataPoint point2 = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuCharts._type.spline);

            

            point2.addLabely("LUNES", "90");
            point2.addLabely("MARTES", "200");
            point2.addLabely("MIERCOLES", "300");
            point2.addLabely("JUEVES", "700");
            point2.addLabely("VIERNES", "400");
            point2.addLabely("SABADO", "900");
            point2.addLabely("DOMINGO", "500");
            data.addData(point2);
            bunifuCharts1.Render(data);

            Bunifu.DataViz.DataPoint point3 = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuCharts._type.spline);

            point3.addLabely("LUNES", "100");
            point3.addLabely("MARTES", "400");
            point3.addLabely("MIERCOLES", "600");
            point3.addLabely("JUEVES", "300");
            point3.addLabely("VIERNES", "400");
            point3.addLabely("SABADO", "600");
            point3.addLabely("DOMINGO", "500");
            data.addData(point3);
            bunifuCharts1.Render(data);
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
           
        }

        private void Bd_Click(object sender, EventArgs e)
        {
            Prueba_ConexionBd bd = new Prueba_ConexionBd();
            bd.Show();
            this.Hide();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void lbmensajeAdmin_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
           

        }

        public void labelStock()
        {
            try
            {
               
                int total = 0;
                int musica = int.Parse(lbMusica.Text);
                int figuras = int.Parse(lbFiguras.Text);
                int pelicula = int.Parse(lbPelicula.Text);
                int videoJuego = int.Parse(lbVideojuego.Text);
                int variado = int.Parse(lbdiferente.Text);
                total = musica + figuras + pelicula + videoJuego + variado;
                label11.Text = total.ToString();


            }
            catch (Exception)
            {


            }
        }

        public void labelMusica()
        {
            try
            {
                Conexion.conectar();
                String consultar = "SELECT CANTIDAD FROM INVENTARIO WHERE CATEGORIA=@CATEGORIA ";
                SqlCommand cmd = new SqlCommand(consultar, Conexion.conectar());


                cmd.Parameters.AddWithValue("@CATEGORIA", "Musica");
                cmd.ExecuteNonQuery();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    lbMusica.Text = (sqlDataReader["Cantidad"].ToString());


                }

            }
            catch (Exception)
            {

                MessageBox.Show("No se ha encontrado la cantidad buscada ");
            }
        }

        public void labelFiguras()
        {
           
                try
                {
                    Conexion.conectar();
                    String consultar = "SELECT CANTIDAD FROM INVENTARIO WHERE CATEGORIA=@CATEGORIA ";
                    SqlCommand cmd = new SqlCommand(consultar, Conexion.conectar());


                    cmd.Parameters.AddWithValue("@CATEGORIA", "Figura");
                    cmd.ExecuteNonQuery();
                    SqlDataReader sqlDataReader = cmd.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        lbFiguras.Text = (sqlDataReader["Cantidad"].ToString());
                    }

                }
                catch (Exception)
                {

                    MessageBox.Show("No se ha encontrado la cantidad buscada ");
                }
            }

        public void labelPelicula()
        {
            try
            {
                Conexion.conectar();
                String consultar = "SELECT CANTIDAD FROM INVENTARIO WHERE CATEGORIA=@CATEGORIA ";
                SqlCommand cmd = new SqlCommand(consultar, Conexion.conectar());


                cmd.Parameters.AddWithValue("@CATEGORIA", "Pelicula");
                cmd.ExecuteNonQuery();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    lbPelicula.Text = (sqlDataReader["Cantidad"].ToString());


                }

            }
            catch (Exception)
            {

                MessageBox.Show("No se ha encontrado la cantidad buscada ");
            }
        }

        public void labelVideojuego()
        {
            try
            {
                Conexion.conectar();
                String consultar = "SELECT CANTIDAD FROM INVENTARIO WHERE CATEGORIA=@CATEGORIA ";
                SqlCommand cmd = new SqlCommand(consultar, Conexion.conectar());


                cmd.Parameters.AddWithValue("@CATEGORIA", "VIDEOJUEGO");
                cmd.ExecuteNonQuery();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    lbVideojuego.Text = (sqlDataReader["Cantidad"].ToString());


                }

            }
            catch (Exception)
            {

                MessageBox.Show("No se ha encontrado la cantidad buscada ");
            }
        }

        public void labelVariado()
        {
            try
            {
                Conexion.conectar();
                String consultar = "SELECT CANTIDAD FROM INVENTARIO WHERE CATEGORIA=@CATEGORIA";
                SqlCommand cmd = new SqlCommand(consultar, Conexion.conectar());


                cmd.Parameters.AddWithValue("@CATEGORIA", "Variado");
                cmd.ExecuteNonQuery();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    lbdiferente.Text = (sqlDataReader["Cantidad"].ToString());


                }

            }
            catch (Exception)
            {

                MessageBox.Show("No se ha encontrado la cantidad buscada ");
            }
        }

        public void cantidadUsuario()
        {
            Conexion.conectar();
            string CUENTA = "select COUNT(*) CANTIDAD from USUARIOS";
            SqlCommand cmd = new SqlCommand(CUENTA, Conexion.conectar());
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                //label de usuarios
                label3.Text = (reader["CANTIDAD"].ToString());
            }
        }

        public void cantidadVendidos()
        {
            Conexion.conectar();
            string CUENTA = "select COUNT(*) CANTIDAD from COMPRA where id_compra >0";
            SqlCommand cmd = new SqlCommand(CUENTA, Conexion.conectar());
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                //label de usuarios
                label9.Text = (reader["CANTIDAD"].ToString());
            }
        }
        public void cantidadProveedores()
        {
            Conexion.conectar();
            string CUENTA = "select COUNT(*) CANTIDAD from PROVEEDORES;";
            SqlCommand cmd = new SqlCommand(CUENTA, Conexion.conectar());
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                //label de vendidos
                label5.Text = (reader["CANTIDAD"].ToString());
            }
        }

        private void lbFiguras_Click(object sender, EventArgs e)
        {
            labelFiguras();
        }

        private void lbMusica_Click(object sender, EventArgs e)
        {
            labelMusica();
        }

        private void lbPelicula_Click(object sender, EventArgs e)
        {
            labelPelicula();
        }

        private void lbVideojuego_Click(object sender, EventArgs e)
        {
            labelVideojuego();
        }

        private void labelVariado_Click(object sender, EventArgs e)
        {
            labelVariado();
        }

        private void lbdiferente_Click(object sender, EventArgs e)
        {
            labelVariado();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
