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
            //this.pruebaTableAdapter.Fill(this.pruebaBd.Prueba);
            Edit(true);
            Conexion.conectar();
            MessageBox.Show("Conexion exitosa");
            pruebaDataGridView.DataSource = llenar_grid();
        }

        public DataTable llenar_grid()
        {
            Conexion.conectar();
            DataTable dt = new DataTable();
            string consulta =  "SELECT * FROM PRUEBA";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            return dt;


        }


        private void pruebaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //idTextBox = pruebaDataGridView.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
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
            Conexion.conectar();

            
            string insertar = "INSERT INTO PRUEBA (ID,NOMBRE,APELLIDOS,TELEFONO)VALUES(@ID,@NOMBRE,@APELLIDOS,@TELEFONO)";
            SqlCommand cmd = new SqlCommand(insertar, Conexion.conectar());
            cmd.Parameters.AddWithValue("@ID",idTextBox.Text);
            cmd.Parameters.AddWithValue("@NOMBRE", nombreTextBox.Text);
            cmd.Parameters.AddWithValue("@APELLIDOS", apellidosTextBox.Text);
            cmd.Parameters.AddWithValue("@TELEFONO", telefonoTextBox.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Se han insertao con exito");

            pruebaDataGridView.DataSource = llenar_grid();



        }

        private void button4_Click(object sender, EventArgs e)
        {
            Edit(true);
            Conexion.conectar();
            string actualizar = "UPDATE PRUEBA SET ID=@ID, NOMBRE=@NOMBRE, APELLIDOS=@APELLIDOS, TELEFONO=@TELEFONO WHERE ID=@ID";
            SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.conectar());
            cmd2.Parameters.AddWithValue("@ID",idTextBox.Text);
            cmd2.Parameters.AddWithValue("@NOMBRE", nombreTextBox.Text);
            cmd2.Parameters.AddWithValue("@APELLIDOS", apellidosTextBox.Text);
            cmd2.Parameters.AddWithValue("@TELEFONO", telefonoTextBox.Text);

            cmd2.ExecuteNonQuery();

            MessageBox.Show("se han actualizado sus datos");
            pruebaDataGridView.DataSource = llenar_grid();

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Edit(false);
            //pruebaBindingSource.ResetBindings(false);
            idTextBox.Clear();
            nombreTextBox.Clear();
            apellidosTextBox.Clear();
            telefonoTextBox.Clear();
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

        private void Eliminar_Click(object sender, EventArgs e)
        {
            Conexion.conectar();
            string eliminar = "DELETE FROM PRUEBA WHERE ID=@ID";
            SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.conectar());
            cmd3.Parameters.AddWithValue("@ID", idTextBox.Text);

            cmd3.ExecuteNonQuery();

            MessageBox.Show(" Se han eliminado los datos ");

            pruebaDataGridView.DataSource = llenar_grid();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                //int cedula = int.Parse(idTextBox.Text);
                
              

             



                Conexion.conectar();
                string buscar = "SELECT * FROM PRUEBA WHERE ID=@ID";
                SqlCommand cmd4 = new SqlCommand(buscar,Conexion.conectar());
                cmd4.CommandType = CommandType.Text;
                cmd4.CommandText = buscar;
                cmd4.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd4);
                da.Fill(dt);
                pruebaDataGridView.DataSource = dt;


            }
            catch (Exception ex)
            {

                MessageBox.Show("Mensaje " + ex);
            }
        }
    }
}
