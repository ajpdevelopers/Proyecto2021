using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Datos;
using MySql.Data.MySqlClient;

namespace Dominio
{
   public class CargarChat : ConnectionToSql
    {
        public bool Login(int Ci, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {

                    command.Connection = connection;
                    command.CommandText = "select * from chat where ";
                    command.Parameters.AddWithValue("@Ci", Ci);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            


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

