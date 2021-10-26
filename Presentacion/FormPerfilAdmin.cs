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
    public partial class FormPerfilAdmin : Form
    {
        public FormPerfilAdmin()
        {
            InitializeComponent();
        }

        private void FormPerfilAdmin_Load(object sender, EventArgs e)
        {
            lblNombreA.Text = UserCache.nombre;
            lblUsuarioPerfilA.Text = UserCache.usuario;
            lblApellidoA.Text = UserCache.apellido;
            lblCedulaA.Text = Convert.ToString(UserCache.cedula);
            txtEditUsuario.Text = UserCache.usuario; ;
            txtEditPass.UseSystemPasswordChar = true;
            txtEditPass.Text = UserCache.contraseña;
            txtEditpass2.UseSystemPasswordChar = true;
            txtEditpass2.Text = UserCache.contraseña;
            pictureDef.Image = (Image)Usuarios.imagen;
            pictureBox1.Image = (Image)Usuarios.imagen;
        }
    }
}
