using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using MySql.Data.MySqlClient;
using System.Data;

namespace Dominio
{
   
    
        public class UserDadmin : ConnectionToSql
        {
            public bool Login(int Ci, string pass)
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new MySqlCommand())
                    {

                        command.Connection = connection;
                        command.CommandText = "select * from usuario u, administrador a where u.Ci=a.Ci and contraseña=@pass and a.Ci=@Ci";
                        command.Parameters.AddWithValue("@Ci", Ci);
                        command.Parameters.AddWithValue("@pass", pass);
                        command.CommandType = CommandType.Text;
                        MySqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                UserCache.cedula = reader.GetInt32(0);
                                UserCache.nombre = reader.GetString(1);
                                UserCache.apellido = reader.GetString(2);
                                UserCache.usuario = reader.GetString(3);
                                UserCache.contraseña = reader.GetString(4);
                                //UserCache.grupo = reader.GetString(5);
                                //UserCache.imagendeperfil = reader.GetString(6);


                            }
                            return true;
                        }
                        else
                            return false;
                    }
                }

            }
        }
}


