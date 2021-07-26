using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;


namespace Presentacion
{
    public partial class LoginDocente : Form
    {
        public LoginDocente()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void msgError(string msg)
        {

            lblError2.Text = "    " + msg;
            lblError2.Visible = true;
        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == UsuariosDocente.usuario && (txtContraseña.Text == UsuariosDocente.contraseña)))
            {
                this.Hide();
                FormBienvenidaDocente bienvenida = new FormBienvenidaDocente();
                bienvenida.ShowDialog();
                FormPrincipalD login = new FormPrincipalD();
                login.Show();
                login.FormClosed += cerrarsesion;
                this.Hide();

            }
            else
            {
                msgError("  Usuario o contraseña equivocada");
                txtContraseña.Clear();
                txtUsuario.Focus();

            }
            if (txtUsuario.Text != "USUARIO")
            {

                if (txtContraseña.Text != "CONTRASEÑA")
                {

                    {

                    }

                    {

                    }


                }
                else msgError("Por favor ingrese contraseña.");
            }
            else msgError("Por favor ingrese nombre de usuario.");








        }

        private void Registrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegistrarseDocente loginDocente = new FormRegistrarseDocente();
            loginDocente.Show();
            this.Hide();
        }
        public void cargaridioma()
        {

            txtUsuario.Text = Resource1.txtUsuario;
            txtContraseña.Text = Resource1.txtContraseña;
            btnIniciar.Text = Resource1.btnIniciar;
            lblCuenta.Text = Resource1.lblCuenta;
            Registrarse.Text = Resource1.Registrarse;
            lblSesionD.Text = Resource1.lblSesionD;
        }

        private void txtUsuario_Enter_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
            else if (txtUsuario.Text == "USER")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.Gray;

            }
            else if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USER";
                txtUsuario.ForeColor = Color.Gray;

            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.LightGray;
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
                txtContraseña.UseSystemPasswordChar = false;

            }
            else if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "PASSWORD";

                txtContraseña.ForeColor = Color.Gray;
                txtContraseña.UseSystemPasswordChar = false;
            }

        }

        private void LoginDocente_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
            FormInicio LoginDocente = new FormInicio();
            LoginDocente.Show();
            this.Hide();
        }

        private void btnIngles_Click(object sender, EventArgs e)
        {
            panelD.Visible = true;
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            cargaridioma();
            panelDes.Visible = false;
        }

        private void btnEspañol_Click(object sender, EventArgs e)
        {
            panelDes.Visible = true;
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-ES");
            cargaridioma();
            panelD.Visible = false;
        }

        private void LoginDocente_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxOcultar_Click(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
            pictureBox4.Visible = true;
            pictureBoxOcultar.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = false;
            pictureBox4.Visible = false;
            pictureBoxOcultar.Visible = true;
        }
        private void cerrarsesion(object sender, FormClosedEventArgs e)
        {
            txtContraseña.Clear();
            txtUsuario.Clear();
            txtContraseña.Text = "CONTRASEÑA";
            txtContraseña.UseSystemPasswordChar = false;
            txtUsuario.Text = "USUARIO";
            //lblerror.Visible = false;
            this.Show();





        }
    }
}
