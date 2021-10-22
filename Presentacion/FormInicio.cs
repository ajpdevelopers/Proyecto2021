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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public void cargaridioma()
        {
            
            lblInicio.Text = Resource1.lblInicio;
            btnAlumno.Text = Resource1.btnAlumno;
            btnAdmin.Text = Resource1.btnRegistrar;
            btnDocente.Text = Resource1.btnDocente;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormInicio_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginAlumno FormInicio = new LoginAlumno();
            FormInicio.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginDocente FormInicio = new LoginDocente();
            FormInicio.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            LoginAdmin FormInicio = new LoginAdmin();
            FormInicio.Show();
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

        private void FormInicio_Load(object sender, EventArgs e)
        {

        }
    }
}
