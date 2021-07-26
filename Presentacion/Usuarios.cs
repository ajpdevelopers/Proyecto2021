using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Presentacion
{
    class Usuarios
    {
        static public string usuario ; 
        static public string contraseña ;
        static public string cedula ;
        static public string grupo;
        static public string nombre ;
        static public string apellido ;
        public static string consultaA;
        public static string destinoA;

        static public object imagen;
        
        public Usuarios(string consultaA, string destinoA)
        {
            this.ConsultaA = consultaA;
            this.DestinoA = destinoA;
            
        }
        public string DestinoA
        {
            get { return destinoA; }
            set { destinoA = value; }
        }
        public string ConsultaA
        {
            get { return consultaA; }
            set { consultaA = value; }
        }
    }
}
