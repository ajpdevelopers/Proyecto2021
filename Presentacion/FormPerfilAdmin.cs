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
using MySql.Data.MySqlClient;

namespace Presentacion
{
    public partial class FormPerfilAdmin : Form
    {
        public FormPerfilAdmin()
        {
            InitializeComponent();
        }

        private void FormPerfilAdmin_Load(object sender, EventArgs e)
        {
          
            //pictureDef.Image = (Image)Usuarios.imagen;
            //pictureBox1.Image = (Image)Usuarios.imagen;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAltaAlumno_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("Server= localhost; port = 3306; Database = chat_bd; Uid = root; pwd = 0312;");
            MySqlConnection conectar1 = new MySqlConnection("Server= localhost; port = 3306; Database = chat_bd; Uid = root; pwd = 0312;");
            try
            {
                MySqlCommand comando = new MySqlCommand("insert into usuario(ci, nombre, apellido, username, contraseña, estado) values ('" + txtCedulaAlumnos.Text + "','" + txtNombreAlumnos.Text + "','" + txtApellidoAlumnos.Text + "','" + txtUsernameAlumnos.Text + "','" + "1234" + "','" + "1" + "');", conectar);
            conectar.Open();
            comando.ExecuteNonQuery();
            conectar.Close();
            MySqlCommand comando1 = new MySqlCommand("insert into alumno(ci, estado ) values ('" + txtCedulaAlumnos.Text + "','" + "1" + "');", conectar1);
            conectar1.Open();
            comando1.ExecuteNonQuery();
            conectar1.Close();


            MessageBox.Show("Registrado con exito", "REGISTRO EXITOSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
            catch
            {
                MessageBox.Show("No se ha podido realizar la operacion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

private void btnAltaDocente_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("Server= localhost; port = 3306; Database = chat_bd; Uid = root; pwd = 0312;");
            MySqlConnection conectar1 = new MySqlConnection("Server= localhost; port = 3306; Database = chat_bd; Uid = root; pwd = 0312;");
            try
            {
                MySqlCommand comando = new MySqlCommand("insert into usuario(ci, nombre, apellido, username, contraseña, estado) values ('" + txtCedulaDocente.Text + "','" + txtNombreDocente.Text + "','" + txtApellidoDocente.Text + "','" + txtUsernameDocente.Text + "','" + "1234" + "','" + "1" + "');", conectar);
                conectar.Open();
                comando.ExecuteNonQuery();
      
                conectar.Close();
                MySqlCommand comando1 = new MySqlCommand("insert into docente(ci, estado ) values ('" + txtCedulaDocente.Text + "','" + "1" + "');", conectar1);
                conectar1.Open();
                comando1.ExecuteNonQuery();
                conectar1.Close();


                MessageBox.Show("Registrado con exito", "REGISTRO EXITOSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("No se ha podido realizar la operacion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkEditarpA_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormGruposAdmin FormPerfilAdmin = new FormGruposAdmin();
            FormPerfilAdmin.Show();
            this.Hide();
        }
       
    }

    
    }
    

