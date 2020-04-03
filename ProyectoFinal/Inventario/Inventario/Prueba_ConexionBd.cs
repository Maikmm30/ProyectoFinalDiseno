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
    public partial class Prueba_ConexionBd : Form
    {
        public Prueba_ConexionBd()
        {
            InitializeComponent();
        }

        private void pruebaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pruebaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pruebaBd);

        }

        private void Prueba_ConexionBd_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pruebaBd.Prueba' Puede moverla o quitarla según sea necesario.
            this.pruebaTableAdapter.Fill(this.pruebaBd.Prueba);

        }

        private void pruebaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
