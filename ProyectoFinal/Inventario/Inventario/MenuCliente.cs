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
    public partial class MenuCliente : Form
    {
        public MenuCliente()
        {
            InitializeComponent();
            CenterToScreen();
        }



        


        private void button1_Click(object sender, EventArgs e)
        {
            Videojuegos PanelJuegos = new Videojuegos()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            this.panelVentas.Controls.Add(PanelJuegos);
            PanelJuegos.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login Volver = new Login();
            Volver.Show();
            this.Hide();
        }

        private void buttonVideojuegos_Click(object sender, EventArgs e)
        {
          

            Videojuegos PanelJuegos = new Videojuegos()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            this.panelVentas.Controls.Add(PanelJuegos);
            PanelJuegos.Show();

        }

        private void ButtonVolver_Click(object sender, EventArgs e)
        {
            Login Volver = new Login();
            Volver.Show();
            this.Hide();

        }

        private void buttonMusica_Click(object sender, EventArgs e)
        {
            Musica PanelMusica = new Musica()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            this.panelVentas.Controls.Add(PanelMusica);
            PanelMusica.Show();
        }
    }
}
