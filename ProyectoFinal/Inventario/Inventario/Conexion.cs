using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Inventario
{
    class Conexion
    {     
        public static SqlConnection conectar() 
            // Metodo con el cual se conecta a la base de datos que esta dentro del archivo del proyecto.
            // Esa direccion debe de modificarse segun la computadora donde se este utilizando el proyecto por que de otra forma no va a servir. 
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\EFS\Documents\GitHub\ProyectoFinalDiseno\ProyectoFinal\Inventario\Inventario\Database1.mdf;Integrated Security=True");
            connection.Open();
            return connection;
        }
    }
}