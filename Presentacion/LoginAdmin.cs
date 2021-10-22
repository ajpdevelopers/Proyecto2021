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
using System.Runtime.InteropServices;
using System.Threading;

namespace Presentacion
{
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "USUARIO" && txtUsuario.TextLength > 2)
            {
                if (txtContraseña.Text != "CONTRASEÑA")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtUsuario.Text, txtContraseña.Text);
                    if (validLogin == true)
                    {
                        this.Hide();
                        FormBienvenidaAdmin bienvenida = new FormBienvenidaAdmin();
                        bienvenida.ShowDialog();
                        FormPrincipal login = new FormPrincipal();
                        login.Show();
                        login.FormClosed += cerrarsesion;
                        this.Hide();
                    }
                    else
                    {
                        msgError("Usuario o contaseña incorrectos");
                        txtContraseña.Text = "CONTRASEÑA";
                        txtContraseña.UseSystemPasswordChar = false;
                        txtUsuario.Focus();
                    }
                }
                else msgError("Por favor ingrese contraseña .");
            }
            else msgError("Por favor ingrese nombre de usuario .");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
            pictureBoxOcultar.Visible = true;
            pictureBox3.Visible = false;
        }

        private void pictureBoxOcultar_Click(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = false;
            pictureBoxOcultar.Visible = false;
            pictureBox3.Visible = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormInicio Login = new FormInicio();
            Login.Show();
            this.Hide();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_MouseCaptureChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
       
        }
        private void cerrarsesion(object sender, FormClosedEventArgs e)
        {
            txtContraseña.Clear();
            txtUsuario.Clear();
            txtContraseña.Text = "CONTRASEÑA";
            txtContraseña.UseSystemPasswordChar = false;
            txtUsuario.Text = "USUARIO";
            lblError2.Visible = false;
            this.Show();





        }
        private void msgError(string msg)
        {

            lblError2.Text = "    " + msg;
            lblError2.Visible = true;
        }
        private void LoginAdmin_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
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
        public void cargaridioma()
        {

            txtUsuario.Text = Resource1.txtUsuario;
            txtContraseña.Text = Resource1.txtContraseña;
            btnIniciar.Text = Resource1.btnIniciar;
            lblSesionA.Text = Resource1.lblSesionAdmin;
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

        private void btnEspañol_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-ES");
            cargaridioma();
            panelAes.Visible = true;

            panelA.Visible = false;
        }

        private void btnIngles_Click(object sender, EventArgs e)
        {
            panelA.Visible = true;
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            cargaridioma();
            panelAes.Visible = false;
        }
    }
}

