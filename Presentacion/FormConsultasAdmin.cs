using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormConsultasAdmin : Form
    {
        public FormConsultasAdmin()
        {
            InitializeComponent();
        }

        private void LimpiarConsA_Click(object sender, EventArgs e)
        {
            try { 
            DataTable dataTable = new DataTable();
            MySqlDataReader resultado;
            MySqlConnection conectar = new MySqlConnection("Server= localhost; port = 3306; Database = chat_bd; Uid = root; pwd = 0312;");
            MySqlCommand comando = new MySqlCommand("select contenido, estado, ciDocente, ciAlumno from consulta", conectar);
            comando.CommandType = CommandType.Text;


            conectar.Open();

            resultado = comando.ExecuteReader();
            dataTable.Load(resultado);


            dataGridView1.DataSource = dataTable;
            conectar.Close();
            }
            catch
            {
                MessageBox.Show("No se ha podido realizar la operacion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
