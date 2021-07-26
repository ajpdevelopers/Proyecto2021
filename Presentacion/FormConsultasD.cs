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
    public partial class FormConsultasD : Form
    {
        public FormConsultasD()
        {
            InitializeComponent();
        }

        private void FormConsultasD_Load(object sender, EventArgs e)
        {
            txtNombreD.Text = UsuariosDocente.nombre;
            txtApellidoD.Text = UsuariosDocente.apellido;
            txtGrupoD.Text = UsuariosDocente.grupo;
            dataGridView1.Columns.Add("nombre", "Nombre");
            dataGridView1.Columns.Add("apellido", "Apellido");
            dataGridView1.Columns.Add("grupo", "Grupo");
            dataGridView1.Columns.Add("consulta", "Consulta");
            dataGridView1.Columns.Add("destino", "Destino");
            dataGridView1.Columns.Add("respuesta", "Respuesta");
            //si hay consulta se carga una advertencia y se agregan los datos
            try
            { 
            if(Usuarios.consultaA != null) {
                    MessageBox.Show("Tienes una nueva consulta", "CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.Rows.Add(Usuarios.nombre, Usuarios.apellido, Usuarios.grupo, Usuarios.destinoA, Usuarios.consultaA); }
            else
            {
                
            }
            }
            catch{ 
            }
        }

        private void btnEnviarConsA_Click(object sender, EventArgs e)
        {
            string consultaAlumno;
            consultaAlumno = Usuarios.consultaA;
            
            try
            {
                UsuariosDocente dv = new UsuariosDocente(txtRespuesta.Text, txtDestino.Text);
                dataGridView1.Rows.Add(UsuariosDocente.nombre, UsuariosDocente.apellido, UsuariosDocente.grupo, "-----", UsuariosDocente.destinoD, dv.RespuestaD);
                MessageBox.Show("ha sido ingresada la respuesta con exito", "RESPUESTA EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRespuesta.Clear();
                txtDestino.Clear();
                UsuariosDocente.destinoD = txtDestino.Text;
                UsuariosDocente.respuestaD = dv.RespuestaD;
               
            }
            catch
            {
                MessageBox.Show("ERROR EN LOS DATOS", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtDestino_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGrupoD_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
