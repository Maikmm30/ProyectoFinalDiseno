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

    public partial class FormularioUsuarios : Form
    {

        private DataSet dt;

        public FormularioUsuarios()
        {
            InitializeComponent();
            dataGridViewProducto.DataSource = llenar_grid();
        }

        public DataTable llenar_grid()  // Metodo que muestras los datos de la tabla correspondiente 
        {        
                Conexion.conectar();
                DataTable dt = new DataTable();
                string consulta = "SELECT * FROM USUARIOS";
                SqlCommand cmd = new SqlCommand(consulta, Conexion.conectar());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;       
        }

        private void Edit(bool value)  // Permite  que lo cambios se puedan habilitar para llenar la información
        {
            txtUsuario.Enabled = value;
            txtContraseña.Enabled = value;
            txtNyA.Enabled = value;
            txtCargo.Enabled = value;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e) // Metodo que conecta con la base de datos, toma la variable que identifica el objeto a eliminar y lo elimina. 
        {                   
            try
            {
                Conexion.conectar();
                string eliminar = "DELETE FROM USUARIOS WHERE Usuario=@Usuario";
                SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.conectar());
                cmd3.Parameters.AddWithValue("@Usuario", txtUsuario.Text);  
                cmd3.ExecuteNonQuery();
                MessageBox.Show(" Se han eliminado los datos ");
                dataGridViewProducto.DataSource = llenar_grid();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al eliminar" + ex);
            }

        }

    private void btnBuscar_Click(object sender, EventArgs e) // Metodo que modifica los datos de un objeto, toma las variables de los labes y aplica el cambio 
        {
            try
            {
                Edit(true);
                Conexion.conectar();
                string actualizar = "UPDATE USUARIOS SET Nombre = @Nombre,Usuario = @Usuario,  Password = @Password, Tipo_usuario = @Tipo_usuario WHERE Usuario = @Usuario";
                SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.conectar());
                cmd2.Parameters.AddWithValue("@USUARIO", txtUsuario.Text);
                cmd2.Parameters.AddWithValue("@PASSWORD", txtContraseña.Text);
                cmd2.Parameters.AddWithValue("@NOMBRE", txtNyA.Text);
                cmd2.Parameters.AddWithValue("@TIPO_USUARIO", txtCargo.Text);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("se han actualizado sus datos");
                dataGridViewProducto.DataSource = llenar_grid();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al buscar" + ex);
            }
     
        }

        private void btnAgregar_Click(object sender, EventArgs e) // Metodo que toma las variables y los introduce como un nuevo objeto 
        {
            try
            {
                string insertar = "INSERT INTO USUARIOS (NOMBRE,USUARIO,PASSWORD,TIPO_USUARIO)VALUES(@NOMBRE,@USUARIO,@PASSWORD,@TIPO_USUARIO)";
                Conexion.conectar();
                SqlCommand cmd = new SqlCommand(insertar, Conexion.conectar());
                cmd.Parameters.AddWithValue("@USUARIO", txtUsuario.Text);
                cmd.Parameters.AddWithValue("@PASSWORD", txtContraseña.Text);
                cmd.Parameters.AddWithValue("@NOMBRE", txtNyA.Text);
                cmd.Parameters.AddWithValue("@TIPO_USUARIO", txtCargo.Text);
                cmd.ExecuteNonQuery();
                Mensaje_Hijo MH = new Mensaje_Hijo();
                MH.imprimeMesaje("usuario");
                dataGridViewProducto.DataSource = llenar_grid();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al agregar" + ex);
            }


           
        }

        private void dataGridViewProducto_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtUsuario.Text = dataGridViewProducto.CurrentRow.Cells[0].Value.ToString();
            txtContraseña.Text = dataGridViewProducto.CurrentRow.Cells[1].ToString();
            txtNyA.Text = dataGridViewProducto.CurrentRow.Cells[2].ToString();
            txtCargo.Text = dataGridViewProducto.CurrentRow.Cells[3].ToString();

        }

        private void textBuscar_OnValueChanged(object sender, EventArgs e)
        {
            if (textBuscar.Text != "")
            {
                dataGridViewProducto.DataSource = Buscar(textBuscar.Text);
            }
            else
            {
                dataGridViewProducto.DataSource = mostrarDatos();
            }
        }

        public void BuscarElemento() // Parte del proceso para mostrar unicamente la categoría que seleccionó
        {
            try
            {
                Conexion.conectar();
                string buscar = "SELECT * FROM USUARIOS WHERE Nombre=@Nombre";
                SqlCommand cmd4 = new SqlCommand(buscar, Conexion.conectar());
                cmd4.CommandType = CommandType.Text;
                cmd4.CommandText = buscar;
                cmd4.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd4);
                da.Fill(dt);
                dataGridViewProducto.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mensaje " + ex);
            }
        }

        public DataTable mostrarDatos() // Muestra la tabla de usuarios 
        {
            Conexion.conectar();
            SqlCommand cmd4 = new SqlCommand("select * from USUARIOS", Conexion.conectar());
            SqlDataAdapter ad = new SqlDataAdapter(cmd4);
            dt = new DataSet();
            ad.Fill(dt, "tabla");
            return dt.Tables["tabla"];
        }

        public DataTable Buscar(string Nombre) // Parte del proceso para mostrar unicamente la categoría que seleccionó
        {
            Conexion.conectar();
            SqlCommand cmd5 = new SqlCommand(string.Format("select * from USUARIOS where Nombre like '%{0}%'", Nombre), Conexion.conectar());
            SqlDataAdapter ad = new SqlDataAdapter(cmd5);
            dt = new DataSet();
            ad.Fill(dt, "USUARIOS");
            return dt.Tables["USUARIOS"];
        }

        private void txtCargo_OnValueChanged(object sender, EventArgs e)
        {

        }
    }

}

