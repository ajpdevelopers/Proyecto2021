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
            //MySqlConnection conectar = new MySqlConnection("Server= localhost; port = 3306; Database = chat_bd; Uid = root; pwd = 0312;");
            //conectar.Open();
            //MySqlCommand comando = new MySqlCommand("insert into mensaje(registro, CiDocentCiAlumno ) values ('1'"+ txtChatA.Text + "','" + txtDestinatario.Text + "','" + UserCache.cedula + "');", conectar);
            //comando.ExecuteNonQuery();
            var bucle = new Label();
            panelChat.Controls.Add(bucle);
            bucle.BringToFront();
            bucle.Left = 10;
            bucle.Top = 20;
            bucle.Dock = DockStyle.Top;
            bucle.Text = txtChatA.Text;
            bucle.BorderStyle = BorderStyle.Fixed3D;
            
            
            
        }
        private void cargar()
        {
            //MySqlConnection conectar = new MySqlConnection("Server= localhost; port = 3306; Database = chat_bd; Uid = root; pwd = 0312;");
         
            



            //    DataTable dataTable = new DataTable();
            //    MySqlDataReader resultado;

            //    MySqlCommand comando = new MySqlCommand("SELECT registro FROM chat WHERE idChat = 99876123", conectar);


            //    comando.CommandType = CommandType.Text;


            //    conectar.Open();

            //    resultado = comando.ExecuteReader();
            //    dataTable.Load(resultado);


               
            //    conectar.Close();
            
            //for (int i = 0; i < dataTable.Rows.Count; i++)
            //{
            //    var bucle = new Label();
            //    panelChat.Controls.Add(bucle);
            //    bucle.BringToFront();
            //    bucle.Left = 10;
            //    bucle.Top = 20;
            //    bucle.Text = Convert.ToString(dataTable);
            //    bucle.Dock = DockStyle.Top;
            //    bucle.BorderStyle = BorderStyle.Fixed3D;

            //}
        }








        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
                    }

        private void txtChatA_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelChat_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}


