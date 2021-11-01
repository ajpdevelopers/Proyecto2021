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
using MySql.Data.MySqlClient;
namespace Presentacion
{
    public partial class FormChatD : Form
    {
        public FormChatD()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("Server= localhost; port = 3306; Database = chat_bd; Uid = root; pwd = 0312;");
            try
            {
                conectar.Open();
                MySqlCommand comando = new MySqlCommand("insert into chat(registro, CiDocente,CiAlumno ) values ('" + txtChatD.Text + "','" + txtDestinatario.Text + "','" + UserCache.cedula + "');", conectar);
                comando.ExecuteNonQuery();
                var bucle = new Label();
                panelChat.Controls.Add(bucle);
                bucle.BringToFront();
                bucle.Left = 10;
                bucle.Top = 20;
                bucle.Dock = DockStyle.Top;
                bucle.Text = txtChatD.Text;
                bucle.BorderStyle = BorderStyle.Fixed3D;
            }
            catch
            {

            }
        }
    }
}
