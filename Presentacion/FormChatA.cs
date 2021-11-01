using MySql.Data.MySqlClient;
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
    public partial class FormChatA : Form
    {
        public FormChatA()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool btnEnviado = false;
        private bool btnEnviado2 = false;
        private void btnEnviar_Click(object sender, EventArgs e)
        
        {
            MySqlConnection conectar = new MySqlConnection("Server= localhost; port = 3306; Database = chat_bd; Uid = root; pwd = 0312;");
            conectar.Open();
            MySqlCommand comando = new MySqlCommand("insert into chat(registro, CiDocente,CiAlumno ) values ('" + txtChatA.Text + "','" + txtDestinatario.Text + "','" + UserCache.cedula + "');", conectar);
            comando.ExecuteNonQuery();
            var bucle = new Label();
            panelChat.Controls.Add(bucle);
            bucle.BringToFront();
            bucle.Left = 10;
            bucle.Top = 20;
            bucle.Dock = DockStyle.Top;
            bucle.Text = txtChatA.Text;
            bucle.BorderStyle = BorderStyle.Fixed3D;
            
            
            
        }









        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
                    }
    }
}


