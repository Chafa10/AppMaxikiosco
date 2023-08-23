using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class Helper
    {
        public void mostrarMensaje(string mensaje, string tipo, string titulo)
        {
            if (tipo.Equals("Error"))
            {
                MessageBox.Show(mensaje,titulo,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tipo.Equals("Info"))
            {
                MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
