using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TPWinForm_equipo_6
{
    internal class Utilidades
    {
        public bool ValidarInput(bool condicion, string mensaje)
        {
            if (condicion)
            {
                MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }
    }
}
