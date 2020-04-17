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
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Disco Duro 1 Tb\Descargas\Tercer Cuatrimestre\ProyectoFinalDiseno\ProyectoFinal\Inventario\Inventario\Database1.mdf;Integrated Security=True ");
            connection.Open();
            return connection;
        }

        
}
}