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
using Presentacion;
using Dominio;
using Datos;
//AJP DEVELOPERS
namespace Presentacion

{
    public partial class LoginAlumno : Form
    {
        public LoginAlumno()
        {
            InitializeComponent();
           
            
        }
        
        // codigo para poder arrastrar formularios, utilizando dll de windows.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        
        //Cuando entramos al text box, si escribimos cambiara la letra de color
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO" )
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
        //Cuando entramos al text box, si no hay nada escrito volvera a la "marca de agua"
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
        //Cuando entramos al text box, si escribimos cambiara la letra de color
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
        //Cuando entramos al text box, si no hay nada escrito volvera a la "marca de agua"
        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                
                txtContraseña.ForeColor = Color.Gray;
                txtContraseña.UseSystemPasswordChar = false;

            }
            else if(txtContraseña.Text == "")
            {
                txtContraseña.Text = "PASSWORD";

                txtContraseña.ForeColor = Color.Gray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }
        //metodo para cambiar el idioma
        public void cargaridioma()
        {

            txtUsuario.Text = Resource1.txtUsuario;
            txtContraseña.Text = Resource1.txtContraseña;
            btnIniciar.Text = Resource1.btnIniciar;
            lblCuenta.Text = Resource1.lblCuenta;
            Registrarse.Text = Resource1.Registrarse;
            lblSesionA.Text = Resource1.lblSesionA;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Evento para mover el form
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
       
       
        private void msgError(string msg)
        {
            
            lblError2.Text = "    " + msg;
            lblError2.Visible = true;
        }
        // aqui podremos ir a la pantalla iniciar sesion
        private void Registrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegistrarse login = new FormRegistrarse();
            login.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //volvemos a la ventana anterior
        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormInicio Login= new FormInicio();
            Login.Show();
            this.Hide();
        }
        //referenciar al recurso de español y cambiar idioma
        private void btnEspañol_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-ES");
            cargaridioma();
            panelAes.Visible = true;

            panelA.Visible = false;
        }
        //referenciar al recurso de Ingles y cambiar idioma
        private void btnIngles_Click(object sender, EventArgs e)
        {
            panelA.Visible = true;
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            cargaridioma();
            panelAes.Visible = false;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       

        private void pictureBoxOcultar_Click(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = false;
            pictureBoxOcultar.Visible = false;
            pictureBox3.Visible = true;
        }
        private void cerrarsesion(object sender, FormClosedEventArgs e)
        {
            txtContraseña.Clear();
            txtUsuario.Clear();
            txtContraseña.Text= "CONTRASEÑA";
            txtContraseña.UseSystemPasswordChar = false;
            txtUsuario.Text = "USUARIO";
            lblerror.Visible = false;
            this.Show();
      




        }

        private void Login_Load(object sender, EventArgs e)
        {

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
                        FormBienvenida bienvenida = new FormBienvenida();
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
    }
}


    