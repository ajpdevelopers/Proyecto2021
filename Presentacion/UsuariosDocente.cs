using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    class UsuariosDocente
    {
        static public string usuario;
        static public string contraseña;
        static public string cedula;
        static public string grupo;
        static public string nombre ;
        static public string apellido ;
        static public string materia;
        static public object imagen;
        public static string respuestaD;
        public static string destinoD;
        public UsuariosDocente(string respuestaD, string destinoD)
        {
            this.RespuestaD = respuestaD;
            this.DestinoD = destinoD;

        }
        public string DestinoD
        {
            get { return destinoD; }
            set { destinoD = value; }
        }
        public string RespuestaD
        {
            get { return respuestaD; }
            set { respuestaD = value; }
        }
    }
}
