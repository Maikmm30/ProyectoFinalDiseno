using System;
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

        }


        public proyectoFinal(string nombre)
        {
            InitializeComponent();
            CenterToScreen();
            lbmensajeAdmin.Text = "BIENVENIDO" + nombre;
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

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Stop();

            Bunifu.DataViz.Data data = new Bunifu.DataViz.Data();
            Bunifu.DataViz.DataPoint point1 = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuCharts._type.spline);

            point1.addLabely("LUNES", "5000");
            point1.addLabely("MARTES", "5000");
            point1.addLabely("MIERCOLES", "4000");
            point1.addLabely("JUEVES", "8000");
            point1.addLabely("VIERNES", "4000");
            point1.addLabely("SABADO", "5000");
            point1.addLabely("DOMINGO", "5000");
            data.addData(point1);

            Bunifu.DataViz.DataPoint point2 = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuCharts._type.spline);

            point2.addLabely("LUNES", "2000");
            point2.addLabely("MARTES", "2000");
            point2.addLabely("MIERCOLES", "3000");
            point2.addLabely("JUEVES", "7000");
            point2.addLabely("VIERNES", "4000");
            point2.addLabely("SABADO", "9000");
            point2.addLabely("DOMINGO", "5000");
            data.addData(point2);
            bunifuCharts1.Render(data);

            Bunifu.DataViz.DataPoint point3 = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuCharts._type.spline);

            point3.addLabely("LUNES", "1000");
            point3.addLabely("MARTES", "4000");
            point3.addLabely("MIERCOLES", "6000");
            point3.addLabely("JUEVES", "3000");
            point3.addLabely("VIERNES", "4000");
            point3.addLabely("SABADO", "6000");
            point3.addLabely("DOMINGO", "5000");
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
    }
}
