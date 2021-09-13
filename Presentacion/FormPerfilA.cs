﻿using System;
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
    public partial class FormPerfilA : Form
    {
        public FormPerfilA()
        {
            InitializeComponent();
        }

        

        private void btnavatar1_Click(object sender, EventArgs e)
        {
            pictureDef.Image = btnavatar1.Image;
            pictureBox1.Image = btnavatar1.Image;
            //con esto al volver iniciar sesion con este usuario la imagen quedara guardada.
            Usuarios.imagen = pictureDef.Image;

        }

        private void btnavatar2_Click(object sender, EventArgs e)
        {
            pictureDef.Image = btnavatar2.Image;
            pictureBox1.Image = btnavatar2.Image;
            //con esto al volver iniciar sesion con este usuario la imagen quedara guardada.
            Usuarios.imagen = pictureDef.Image;
        }

        private void btnavatar3_Click(object sender, EventArgs e)
        {
            pictureDef.Image = btnavatar3.Image;
            pictureBox1.Image = btnavatar3.Image;
            //con esto al volver iniciar sesion con este usuario la imagen quedara guardada.
            Usuarios.imagen = pictureDef.Image;
        }

        private void btnavatar4_Click(object sender, EventArgs e)
        {
            pictureDef.Image = btnavatar4.Image;
            pictureBox1.Image = btnavatar4.Image;


            pictureBox1.Visible = false;
            //con esto al volver iniciar sesion con este usuario la imagen quedara guardada.
            Usuarios.imagen = pictureDef.Image;
        }

        

        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog abririmagen = new OpenFileDialog();
            if (abririmagen.ShowDialog() == DialogResult.OK)
            {

                pictureDef.Visible = true;
                pictureDef.ImageLocation = abririmagen.FileName;
                pictureDef.Image = Image.FromFile(abririmagen.FileName);
                pictureDef.SizeMode = PictureBoxSizeMode.Zoom;
                
            }
            try { 
            pictureDef.Image = Image.FromFile(abririmagen.FileName);
            Usuarios.imagen = pictureDef.Image;
            }
            catch
            {

            }

        }

        private void panelEditar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkEditarpA_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelEditar.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelEditar.Visible = false;
            txtEditPass.Enabled = false;
            txtEditpass2.Enabled = false;
            txtEditUsuario.Enabled = false;


        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPerfilA_Load(object sender, EventArgs e)
        {
            lblNombreA.Text = UserCache.nombre;
            lblUsuarioPerfilA.Text = UserCache.usuario;
            lblApellidoA.Text = UserCache.apellido;
            lblCedulaA.Text = Convert.ToString(UserCache.cedula);
            lblGrupoA.Text = UserCache.grupo;
            txtEditUsuario.Text = UserCache.usuario; ;
            txtEditPass.UseSystemPasswordChar = true;
            txtEditPass.Text = UserCache.contraseña;
            txtEditpass2.UseSystemPasswordChar = true;
            txtEditpass2.Text = UserCache.contraseña;
            pictureDef.Image = (Image)Usuarios.imagen;
            pictureBox1.Image =(Image)Usuarios.imagen;







        }

        private void linkEditarPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtEditPass.Enabled = true;
            txtEditpass2.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
             
            Usuarios.usuario = txtEditUsuario.Text;
            Usuarios.contraseña = txtEditpass2.Text;
            lblUsuarioPerfilA.Text = Usuarios.usuario;
            txtEditPass.Enabled = false;
            txtEditpass2.Enabled = false;




        }

        private void txtEditUsuario_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void linkEditUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtEditUsuario.Enabled = true;
            txtEditUsuario.Text = " ";
            txtEditUsuario.Clear();
        }
    }
}
