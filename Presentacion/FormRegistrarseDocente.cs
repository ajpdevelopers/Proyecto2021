using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Presentacion
{
    public partial class FormRegistrarseDocente : Form
    {
        public FormRegistrarseDocente()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void FormRegistrarseDocente_Enter(object sender, EventArgs e)
        {

        }
        public void cargaridioma()
        {
            txtNombreUser.Text = Resource1.txtNombreUser;
            txtNombre.Text = Resource1.txtNombre;
            txtContraseña.Text = Resource1.txtContraseña;
            btnRegistrarse.Text = Resource1.btnRegistrarse;
            txtCedula.Text = Resource1.txtCedula;
            LinkIniciar.Text = Resource1.LinkIniciar;
            txtConfirmacion.Text = Resource1.txtConfirmacion;
            lblRegistroD.Text = Resource1.lblRegistroD;
            txtGrupo.Text = Resource1.txtGrupo;
            lblCuenta.Text = Resource1.lblCuenta;
            txtApellido.Text = Resource1.txtApellido;
            txtMateria.Text = Resource1.txtMateria;
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "NOMBRE")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.LightGray;
            }
            else if (txtNombre.Text == "NAME")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.LightGray;

            }



        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "NOMBRE";
                txtNombre.ForeColor = Color.Gray;
            }
            else if (txtNombre.Text == "")
            {
                txtNombre.Text = "NAME";
                txtNombre.ForeColor = Color.Gray;

            }
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Text == "APELLIDO")
            {
                txtApellido.Text = "";
                txtApellido.ForeColor = Color.LightGray;
            }
            else if (txtApellido.Text == "LAST NAME ")
            {
                txtApellido.Text = "";
                txtApellido.ForeColor = Color.LightGray;

            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.Text = "APELLIDO";
                txtApellido.ForeColor = Color.Gray;
            }
            else if (txtApellido.Text == "")
            {
                txtApellido.Text = "LAST NAME";
                txtApellido.ForeColor = Color.Gray;

            }
        }

        private void txtCedula_Enter(object sender, EventArgs e)
        {
            if (txtCedula.Text == "CEDULA")
            {
                txtCedula.Text = "";
                txtCedula.ForeColor = Color.LightGray;
            }
            else if (txtCedula.Text == "IDENTITY CARD")
            {
                txtCedula.Text = "";
                txtCedula.ForeColor = Color.LightGray;

            }

        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            if (txtCedula.Text == "")
            {
                txtCedula.Text = "CEDULA";
                txtCedula.ForeColor = Color.Gray;
            }
            else if (txtCedula.Text == "")
            {
                txtCedula.Text = "IDENTITY CARD";
                txtCedula.ForeColor = Color.Gray;

            }
        }

        private void txtGrupo_Enter(object sender, EventArgs e)
        {
            if (txtGrupo.Text == "GRUPO")
            {
                txtGrupo.Text = "";
                txtGrupo.ForeColor = Color.LightGray;
            }
            else if (txtGrupo.Text == "GROUP")
            {
                txtGrupo.Text = "";
                txtGrupo.ForeColor = Color.LightGray;

            }

        }

        private void txtGrupo_Leave(object sender, EventArgs e)
        {
            if (txtGrupo.Text == "")
            {
                txtGrupo.Text = "GRUPO";
                txtGrupo.ForeColor = Color.Gray;
            }
            else if (txtGrupo.Text == "")
            {
                txtGrupo.Text = "GROUP";
                txtGrupo.ForeColor = Color.Gray;

            }
        }

        private void txtMateria_Enter(object sender, EventArgs e)
        {
            if (txtMateria.Text == "MATERIA")
            {
                txtMateria.Text = "";
                txtMateria.ForeColor = Color.LightGray;
            }
            else if (txtMateria.Text == "COURSE")
            {
                txtMateria.Text = "";
                txtMateria.ForeColor = Color.LightGray;

            }
        }

        private void txtMateria_Leave(object sender, EventArgs e)
        {
            if (txtMateria.Text == "")
            {
                txtMateria.Text = "MATERIA";
                txtMateria.ForeColor = Color.Gray;
            }
            else if (txtMateria.Text == "")
            {
                txtMateria.Text = "COURSE";
                txtMateria.ForeColor = Color.Gray;

            }
        }

        private void txtNombreUser_Enter(object sender, EventArgs e)
        {
            if (txtNombreUser.Text == "NOMBRE USUARIO")
            {
                txtNombreUser.Text = "";
                txtNombreUser.ForeColor = Color.LightGray;
            }
            else if (txtNombreUser.Text == "USERNAME")
            {
                txtNombreUser.Text = "";
                txtNombreUser.ForeColor = Color.LightGray;

            }




        }

        private void txtNombreUser_Leave(object sender, EventArgs e)
        {
            if (txtNombreUser.Text == "")
            {
                txtNombreUser.Text = "NOMBRE USUARIO";
                txtNombreUser.ForeColor = Color.Gray;
            }
            else if (txtNombreUser.Text == "")
            {
                txtNombreUser.Text = "USERNAME";
                txtNombreUser.ForeColor = Color.Gray;

            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.LightGray;
                //ocultamos caracteres
                txtContraseña.UseSystemPasswordChar = true;
            }
            else if (txtContraseña.Text == "PASSWORD")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.Gray;
                //retiramos la orden de ocultar
                txtContraseña.UseSystemPasswordChar = false;


            }
            else if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "PASSWORD";

                txtContraseña.ForeColor = Color.Gray;
                txtContraseña.UseSystemPasswordChar = false;
            }

        }

        private void txtConfirmacion_Enter(object sender, EventArgs e)
        {
            if (txtConfirmacion.Text == "CONFIRMAR CONTRASEÑA")
            {
                txtConfirmacion.Text = "";
                txtConfirmacion.ForeColor = Color.LightGray;
                //ocultamos caracteres
                txtConfirmacion.UseSystemPasswordChar = true;
            }
            else if (txtConfirmacion.Text == "CONFIRM PASSWORD")
            {
                txtConfirmacion.Text = "";
                txtConfirmacion.ForeColor = Color.LightGray;
                txtConfirmacion.UseSystemPasswordChar = true;
            }
        }

        private void txtConfirmacion_Leave(object sender, EventArgs e)
        {
            if (txtConfirmacion.Text == "")
            {
                txtConfirmacion.Text = "CONFIRMAR CONTRASEÑA";
                txtConfirmacion.ForeColor = Color.Gray;
                //retiramos la orden de ocultar
                txtConfirmacion.UseSystemPasswordChar = false;
            }
            else if (txtConfirmacion.Text == "")
            {
                txtConfirmacion.Text = "CONFIRM PASSWORD";

                txtConfirmacion.ForeColor = Color.Gray;
                txtConfirmacion.UseSystemPasswordChar = false;
            }
        }

        private void LinkIniciar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginDocente FormRegistrarseDocente = new LoginDocente();
            FormRegistrarseDocente.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            LoginDocente FormRegistrarseDocente = new LoginDocente();
            FormRegistrarseDocente.Show();
            this.Hide();
        }

        private void btnIngles_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            cargaridioma();
        }

        private void btnEspañol_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-ES");
            cargaridioma();
        }

        private void FormRegistrarseDocente_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        // haremos un mensaje de error para ingresarlo en una etiqueta
        private void msgError(string msg)
        {
            lblErrorRegistro.Text = "      " + msg;
            lblErrorRegistro.Visible = true;
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("Server= localhost; port = 3306; Database = chat_bd; Uid = root; pwd = 0312;");
            conectar.Open();
            MySqlConnection conectar1 = new MySqlConnection("Server= localhost; port = 3306; Database = chat_bd; Uid = root; pwd = 0312;");
            conectar1.Open();
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string cedula = txtCedula.Text;
            string grupo = txtGrupo.Text;
            string contraseña = txtContraseña.Text;
            string confircontraseña = txtConfirmacion.Text;
            string usuario = txtNombreUser.Text;
            string materia = txtMateria.Text;


            // si los datos no estan ingresados se marcara que faltan datos

            if (nombre == "NOMBRE" && apellido == "APELLIDO")
            {
                msgError("faltan datos");
            }
            else if (cedula == "CEDULA" && grupo == "GRUPO")
            {
                msgError("faltan datos");
            }
            else if (contraseña == "CONTRASEÑA" && confircontraseña == "CONFIRMAR CONTRASEÑA")
            {
                msgError("faltan datos");
            }
            else if(materia == "MATERIA")
            {
                msgError("faltan datos");
            }
        
            else if (confircontraseña != contraseña)
            {
                msgError("Las contraseñas no son iguales");
            }

            try
            {
                MySqlCommand comando = new MySqlCommand("insert into usuario(ci, nombre, apellido, username, contraseña) values ('" + txtCedula.Text + "','" + txtNombre.Text + "','" + txtApellido.Text + "','" + txtNombreUser.Text + "','" + txtContraseña.Text + "');", conectar);
                comando.ExecuteNonQuery();
                conectar.Close();
                MySqlCommand comando1 = new MySqlCommand("insert into docente(ci) values ('" + txtCedula.Text + "');", conectar1);
                comando1.ExecuteNonQuery();
                conectar1.Close();

                MessageBox.Show("Registrado con exito", "REGISTRO EXITOSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                msgError("No se pudo registrar correctamente");
            }



        }

        private void pictureBoxOcultar_Click(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = false;
            pictureBoxOcultar.Visible = false;
            pictureBox3.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
            pictureBoxOcultar.Visible = true;
            pictureBox3.Visible = false;
        }
    }
}
