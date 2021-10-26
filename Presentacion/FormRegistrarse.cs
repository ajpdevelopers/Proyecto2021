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
using Dominio;
using System.Threading;
using System.IO;
using System.Collections;

using MySql.Data.MySqlClient;
using MySql.Data;



namespace Presentacion
{
    public partial class FormRegistrarse : Form
    {
        public FormRegistrarse()
        {
            InitializeComponent();
        }
        // codigo para poder arrastrar formularios, utilizando dll de windows.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        // aqui podremos volver a la pantalla de iniciar sesion
        private void Registrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginAlumno FormRegistrarse = new LoginAlumno();
            FormRegistrarse.Show();
            this.Hide();
        }

        private void FormRegistrarse_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        public void cargaridioma()
        {

            txtNombre.Text = Resource1.txtNombre;
            txtNombreUser.Text = Resource1.txtNombreUser;
            txtContraseña.Text = Resource1.txtContraseña;
            btnRegistrarse.Text = Resource1.btnRegistrarse;
            txtCedula.Text = Resource1.txtCedula;
            LinkIniciar.Text = Resource1.LinkIniciar;
            txtConfirmacion.Text = Resource1.txtConfirmacion;
            lblRegistroA.Text = Resource1.lblRegistroA;
            txtGrupo.Text = Resource1.txtGrupo;
            lblCuenta.Text = Resource1.lblCuenta;
            txtApellido.Text = Resource1.txtApellido;
        }

        //Cuando entramos al text box, si escribimos cambiara la letra de color
        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Text == "APELLIDO")
            {
                txtApellido.Text = "";
                txtApellido.ForeColor = Color.LightGray;
            }
        }
        //Cuando entramos al text box, si no hay nada escrito volvera a la "marca de agua"
        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.Text = "APELLIDO";
                txtApellido.ForeColor = Color.Gray;

            }
        }
        //Cuando entramos al text box, si escribimos cambiara la letra de color
        private void txtCedula_Enter(object sender, EventArgs e)
        {
            if (txtCedula.Text == "CEDULA")
            {
                txtCedula.Text = "";
                txtCedula.ForeColor = Color.LightGray;
            }

        }
        //Cuando entramos al text box, si no hay nada escrito volvera a la "marca de agua"
        private void txtCedula_Leave(object sender, EventArgs e)
        {
            if (txtCedula.Text == "")
            {
                txtCedula.Text = "CEDULA";
                txtCedula.ForeColor = Color.Gray;

            }
        }
        //Cuando entramos al text box, si escribimos cambiara la letra de color
        private void txtGrupo_Enter(object sender, EventArgs e)
        {
            if (txtGrupo.Text == "GRUPO")
            {
                txtGrupo.Text = "";
                txtGrupo.ForeColor = Color.LightGray;
            }

        }
        //Cuando entramos al text box, si no hay nada escrito volvera a la "marca de agua"
        private void txtGrupo_Leave(object sender, EventArgs e)
        {
            if (txtGrupo.Text == "")
            {
                txtGrupo.Text = "GRUPO";
                txtGrupo.ForeColor = Color.Gray;

            }
        }
        
        
        //Cuando entramos al text box, si escribimos cambiara la letra de color
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "NOMBRE")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.LightGray;
            }
        }
        //Cuando entramos al text box, si no hay nada escrito volvera a la "marca de agua"
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "NOMBRE";
                txtNombre.ForeColor = Color.Gray;

            }
        }
        // haremos un mensaje de error para ingresarlo en una etiqueta
        private void msgError(string msg)
        {
            lblErrorRegistro.Text = "      " + msg;
            lblErrorRegistro.Visible = true;
        }
       

      

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            LoginAlumno FormRegistrarse = new LoginAlumno();
            FormRegistrarse.Show();
            this.Hide();
        }

        private void txtConfirmacion_TextChanged(object sender, EventArgs e)
        {

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
            if(txtNombreUser.Text == "")
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

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("Server= localhost; port = 3306; Database = chat_bd; Uid = root; pwd = 0312;");
            conectar.Open();
            MySqlConnection conectar1 = new MySqlConnection("Server= localhost; port = 3306; Database = chat_bd; Uid = root; pwd = 0312;");
            conectar1.Open();
            MySqlConnection conectar2 = new MySqlConnection("Server= localhost; port = 3306; Database = chat_bd; Uid = root; pwd = 0312;");
            conectar2.Open();

            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string cedula = txtCedula.Text;
            string grupo = txtGrupo.Text;
            string contraseña = txtContraseña.Text;
            string confircontraseña = txtConfirmacion.Text;
            string usuario = txtNombreUser.Text;
            

            // si los datos no estan ingresados se marcara que faltan datos
          


            //BORRAR ESTE CODIGO 
            ////Usuarios.usuario = usuario;
            ////Usuarios.contraseña = contraseña;
            ////Usuarios.cedula = cedula;
            ////Usuarios.grupo = grupo;
            ////Usuarios.nombre = nombre;
            ////Usuarios.apellido = apellido;
         
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
                else if (confircontraseña != contraseña)
                {
                    msgError("Las contraseñas no son iguales");
                }
            try
            {
                MySqlCommand comando = new MySqlCommand("insert into usuario(ci, nombre, apellido, username, contraseña, estado) values ('"+ txtCedula.Text +"','" + txtNombre.Text + "','" + txtApellido.Text + "','" +txtNombreUser.Text + "','" + txtContraseña.Text + "','" + "1" + "');", conectar);
                comando.ExecuteNonQuery();
                conectar.Close();
                MySqlCommand comando1 = new MySqlCommand("insert into alumno(ci, estado ) values ('" + txtCedula.Text + "','" + "1" + "');", conectar1);
              
                comando1.ExecuteNonQuery();
                conectar1.Close();
               

                MessageBox.Show("Registrado con exito", "REGISTRO EXITOSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                msgError("No se pudo registrar correctamente");
            }

           




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

        private void FormRegistrarse_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
       


}





