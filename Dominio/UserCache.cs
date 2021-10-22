using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
   public static class UserCache
    {
        public static int cedula { get; set; }
        public static string usuario { get; set; }
        public static string contraseña { get; set; }
        public static string nombre { get; set; }
        public static string apellido { get; set; }
        public static string grupo { get; set; }
        public static string imagendeperfil { get; set; }
    }
}
