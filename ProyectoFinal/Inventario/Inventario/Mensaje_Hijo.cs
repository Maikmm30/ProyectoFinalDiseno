using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    class Mensaje_Hijo : Mensaje_Padre
    {

        public void imprimeMesaje(String A)
        {
            MessageBox.Show("Se han insertado " + A + " con exito");
        }
    }
}
