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
    public partial class FormGruposA : Form
    {
        public FormGruposA()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void FormGruposA_Load(object sender, EventArgs e)
        {
            lblNombre.Text = UserCache.nombre + " " + UserCache.apellido;
            lblGrupo.Text = UserCache.grupo;
        }
    }
}
