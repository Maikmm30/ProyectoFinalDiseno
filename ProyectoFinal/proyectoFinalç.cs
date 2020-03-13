using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            Bunifu.DataViz.Data data = new Bunifu.DataViz.Data();
            Bunifu.DataViz.DataPoint point1 = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuCharts._type.spline);

            point1.addLabely("LUNES","5000");
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
            Chart.Render(data);

            Bunifu.DataViz.DataPoint point3 = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuCharts._type.spline);

            point3.addLabely("LUNES", "1000");
            point3.addLabely("MARTES", "4000");
            point3.addLabely("MIERCOLES", "6000");
            point3.addLabely("JUEVES", "3000");
            point3.addLabely("VIERNES", "4000");
            point3.addLabely("SABADO", "6000");
            point3.addLabely("DOMINGO", "5000");
            data.addData(point3);
            Chart.Render(data);

            





        }

        private void bunifuCharts1_Load_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel10_Click(object sender, EventArgs e)
        {

        }
    }
}
