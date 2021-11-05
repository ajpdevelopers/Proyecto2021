using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Presentacion
{
    public partial class FormGruposAdmin : Form
    {
        public FormGruposAdmin()
        {
            InitializeComponent();
        }

        private void btnEnviarConsA_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("Server= localhost; port = 3306; Database = chat_bd; Uid = root; pwd = 0312;");
            if (radioTodos.Checked)
            {
                


                DataTable dataTable = new DataTable();
                MySqlDataReader resultado;

                MySqlCommand comando = new MySqlCommand("SELECT * FROM usuario;", conectar);


                comando.CommandType = CommandType.Text;


                conectar.Open();

                resultado = comando.ExecuteReader();
                dataTable.Load(resultado);


                dataGridView1.DataSource = dataTable;
                conectar.Close();
            }
            else if (radioAlumnos.Checked)
            {
                DataTable dataTable = new DataTable();
                MySqlDataReader resultado;

                MySqlCommand comando = new MySqlCommand("select * from usuario u, alumno a where u.Ci=a.Ci ;", conectar);


                comando.CommandType = CommandType.Text;


                conectar.Open();

                resultado = comando.ExecuteReader();
                dataTable.Load(resultado);


                dataGridView1.DataSource = dataTable;
                conectar.Close();
            }
            else if (radioDocentes.Checked)
            {
                DataTable dataTable = new DataTable();
                MySqlDataReader resultado;

                MySqlCommand comando = new MySqlCommand("select * from usuario u, docente d where u.Ci=d.Ci ;", conectar);


                comando.CommandType = CommandType.Text;


                conectar.Open();

                resultado = comando.ExecuteReader();
                dataTable.Load(resultado);


                dataGridView1.DataSource = dataTable;
                conectar.Close();
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioTodos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LimpiarConsA_Click(object sender, EventArgs e)
        {
            radioTodos.Checked = false;
            radioAlumnos.Checked = false;
            radioDocentes.Checked = false;
            dataGridView1.DataSource = " ";
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            try { 
            MySqlConnection conectar = new MySqlConnection("Server= localhost; port = 3306; Database = chat_bd; Uid = root; pwd = 0312;");
            MySqlConnection conectar1 = new MySqlConnection("Server= localhost; port = 3306; Database = chat_bd; Uid = root; pwd = 0312;");
            MySqlCommand comando = new MySqlCommand("update usuario set estado = 0 where Ci = '" + txtCedula.Text + "'", conectar);
            MySqlCommand comando1 = new MySqlCommand("update alumno set estado = 0 where Ci = '" + txtCedula.Text + "'", conectar1);


            conectar.Open();
            comando.ExecuteNonQuery();
            conectar1.Open();
            comando1.ExecuteNonQuery();
            conectar.Close();
            conectar1.Close();
            MessageBox.Show("Se ha dado de baja correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("No se ha podido realizar la operacion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            btnBaja.Enabled = true;
            txtCedula.Enabled = true;
            btnBajadocente.Enabled = false;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            btnBajadocente.Enabled = true;
            txtCedula.Enabled = true;
            btnBaja.Enabled = false;

        }

        private void btnBajadocente_Click(object sender, EventArgs e)
        {
            try { 
            MySqlConnection conectar = new MySqlConnection("Server= localhost; port = 3306; Database = chat_bd; Uid = root; pwd = 0312;");
            MySqlConnection conectar1 = new MySqlConnection("Server= localhost; port = 3306; Database = chat_bd; Uid = root; pwd = 0312;");
            MySqlCommand comando = new MySqlCommand("update usuario set estado = 0 where Ci = '" + txtCedula.Text + "'", conectar);
            MySqlCommand comando1 = new MySqlCommand("update docente set estado = 0 where Ci = '" + txtCedula.Text + "'", conectar1);
            conectar.Open();
            comando.ExecuteNonQuery();
            conectar1.Open();
            comando1.ExecuteNonQuery();
            conectar.Close();
            conectar1.Close();
            MessageBox.Show("Se ha dado de baja correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

            }
            catch
            {
                MessageBox.Show("No se ha podido realizar la operacion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
        
   }

