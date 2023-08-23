using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NomUsuario { get; set; }
        public string Password { get; set; }
        public int Fk_Rol { get; set; }

    }
}
