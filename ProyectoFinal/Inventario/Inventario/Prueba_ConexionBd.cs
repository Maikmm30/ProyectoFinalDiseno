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
    public partial class Prueba_ConexionBd : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\William\Documents\GitHub\ProyectoFinalDiseno\ProyectoFinal\Inventario\Inventario\Database1.mdf;Integrated Security=True");
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
            Edit(false);
        }

        private void pruebaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Edit(bool value)
        {
            idTextBox.Enabled = value;
            nombreTextBox.Enabled = value;
            telefonoTextBox.Enabled = value;
            apellidosTextBox.Enabled = value;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Edit(true);
            //    pruebaBd.Prueba.AddPruebaRow(pruebaBd.Prueba.NewPruebaRow());
            //    pruebaBindingSource.MoveLast();
            //    idTextBox.Focus();
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show("Message: " + ex.Message);
            //    pruebaBd.Prueba.RejectChanges();

            //}
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "insert into 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Edit(true);
            idTextBox.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Edit(false);
            pruebaBindingSource.ResetBindings(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                Edit(false);
                pruebaBindingSource.EndEdit();
                pruebaTableAdapter.Update(pruebaBd.Prueba);
                pruebaDataGridView.Refresh();
               
                //idTextBox.Focus();
                MessageBox.Show("se ha guardado la informaciòn");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Message: " + ex.Message);
                pruebaBd.Prueba.RejectChanges();

            }
        }

        private void pruebaDataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (MessageBox.Show("Seguro de eliminar los datos seleccionados? " + "Message" + MessageBoxButtons.YesNo + MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    pruebaBindingSource.RemoveCurrent();
                }
            }
        }
    }
}
