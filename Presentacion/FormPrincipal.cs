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
    public partial class FormPrincipal : Form
    {

        public FormPrincipal()
        {

            InitializeComponent();
           
            //Estas lineas eliminan los parpadeos del formulario 
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //COLOR DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }
       

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            lblNombreIzq.Text = Usuarios.nombre + " " + Usuarios.apellido;
            lblGrupoizq.Text = Usuarios.grupo;
            lblCedulaizq.Text = Usuarios.cedula;
            pictureBox1.Image = (Image)Usuarios.imagen;            


        }

        public void cargaridioma()
        {

            lblPrincipal.Text = Resource1.lblPrincipal;
            btnPerfil.Text = Resource1.btnPerfil;
            btnGrupos.Text = Resource1.btnGrupos;
            btnChat.Text = Resource1.btnChat;
            btnConsultas.Text = Resource1.btnConsultas;
            btnCerrarSesion.Text = Resource1.btnCerrarSesion;
           
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Capturar posicion y tamaño antes de maximizar para restaurar
        int lx, ly;
        int sw, sh;

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelMenu_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelFormularios_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            //con esto esconderemos un boton u otro segun la necesidad
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

       

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            AbrirFormularios<FormPerfilA>();
            btnPerfil.BackColor = Color.FromArgb(12, 61, 92);
            lblPrincipal.Text = "Perfil";
            btnEspañol.Visible = false;
            btnIngles.Visible = false;
        }

        private void btnGrupos_Click(object sender, EventArgs e)
        {
            AbrirFormularios<FormGruposA>();
            btnGrupos.BackColor = Color.FromArgb(12, 61, 92);
            lblPrincipal.Text = "Grupos";
            btnEspañol.Visible = false;
            btnIngles.Visible = false;
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            AbrirFormularios<FormConsultasA>();
            btnConsultas.BackColor = Color.FromArgb(12, 61, 92);
            lblPrincipal.Text = "Consultas";
            btnEspañol.Visible = false;
            btnIngles.Visible = false;

        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            AbrirFormularios<FormChatA>();
            btnChat.BackColor = Color.FromArgb(12, 61, 92);
            lblPrincipal.Text = "Chat";
            btnEspañol.Visible = false;
            btnIngles.Visible = false;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            //Se maximiza a la resolucion de la pantalla principal
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AbrirFormularios<FormPerfilA>();
            btnPerfil.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que quieres cerrar sesion?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

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

        private void lblPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void cerrarformularios(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["FormPerfilA"] == null)
            btnPerfil.BackColor = Color.FromArgb(4, 41, 68);
            lblPrincipal.Text = " ";
            if (Application.OpenForms["FormChatA"] == null)
                btnChat.BackColor = Color.FromArgb(4, 41, 68);
            lblPrincipal.Text = " ";
            if (Application.OpenForms["FormGruposA"] == null)
                btnGrupos.BackColor = Color.FromArgb(4, 41, 68);
            lblPrincipal.Text = " ";
            if (Application.OpenForms["FormConsultasA"] == null)
                btnConsultas.BackColor = Color.FromArgb(4, 41, 68);
            lblPrincipal.Text = " ";
        }
        
        //creare metodos para abrir otros formularios en el panel
        private void AbrirFormularios <MiForm>()where MiForm : Form, new(){
            Form formulario;
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault(); //buscamos el formulario
             if(formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(cerrarformularios);
            }
             else
             //si existe 
            {
                formulario.BringToFront();
            }

        }

    }
}
