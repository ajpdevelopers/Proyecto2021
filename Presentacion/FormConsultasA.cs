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
using Dominio;

namespace Presentacion
{

    public partial class FormConsultasA : Form
    {
        public FormConsultasA()
        {
            InitializeComponent();
            //dataGridView1.Columns.Add("nombre", "Nombre");
            //dataGridView1.Columns.Add("apellido", "Apellido");
            //dataGridView1.Columns.Add("grupo", "Grupo");
            //dataGridView1.Columns.Add("consulta", "Consulta");
            //dataGridView1.Columns.Add("destino", "Destino");
            //dataGridView1.Columns.Add("respuesta", "Respuesta");

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormConsultasA_Load(object sender, EventArgs e)
        {
            //txtNombreA.Text = Usuarios.nombre;
            //txtApellidoA.Text = Usuarios.apellido;
            //txtGrupoA.Text = Usuarios.grupo;
            ////si no hay respuesta no sucede nada 
            //if (UsuariosDocente.respuestaD == null) { }
            ////si hay respuesta se carga una advertencia y se agregan los datos
            //else
            //{
            //    MessageBox.Show("Tienes una nueva respuesta", "RESPUESTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    dataGridView1.Rows.Add(Usuarios.nombre, Usuarios.apellido, Usuarios.grupo, Usuarios.destinoA, Usuarios.consultaA, UsuariosDocente.respuestaD);
            //}
            

        }

        private void btnEnviarConsA_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Usuarios dv = new Usuarios(txtDestinoA.Text, txtConsulta.Text);
            //    dataGridView1.Rows.Add(Usuarios.nombre, Usuarios.apellido, Usuarios.grupo, dv.DestinoA, dv.ConsultaA);
            //    MessageBox.Show("ha sido ingresada la consulta con exito", "CONSULTA EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    txtDestinoA.Clear();
            //    txtConsulta.Clear();
            //    Usuarios.consultaA = dv.ConsultaA;
            //    Usuarios.destinoA = dv.DestinoA;
            //}
            //catch
            //{
            //    MessageBox.Show("ERROR EN LOS DATOS", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            try { 
            MySqlConnection conectar = new MySqlConnection("Server= localhost; port = 3306; Database = chat_bd; Uid = root; pwd = 0312;");
            MySqlCommand comando = new MySqlCommand("insert into consulta(Contenido, Estado, CiDocente, CiAlumno) values ('" + txtConsulta.Text + "','" + "Realizada" + "','" + txtDestinoA.Text + "','" + UserCache.cedula +"');", conectar);
            conectar.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Se ha enviado correctamente la consulta", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("No se ha podido realizar la operacion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {

        }

        private void LimpiarConsA_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = new DataTable();
                MySqlDataReader resultado;
                MySqlConnection conectar = new MySqlConnection("Server= localhost; port = 3306; Database = chat_bd; Uid = root; pwd = 0312;");
                MySqlCommand comando = new MySqlCommand("select contenido, estado, ciAlumno from consulta where ciAlumno="+UserCache.cedula, conectar);
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
