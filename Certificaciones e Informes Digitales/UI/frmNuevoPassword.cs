using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Certificaciones_e_Informes_Digitales.UI
{
    public partial class frmNuevoPassword : Form
    {
        public frmNuevoPassword()
        {
            InitializeComponent();
        }

        private void txtPassw_Enter(object sender, EventArgs e)
        {
            if (txtPassw.Text == "Contraseña...")
            {
                txtPassw.Text = "";
                txtPassw.ForeColor = Color.LightGray;
                txtPassw.UseSystemPasswordChar = true;
            }
        }

        private void txtPassw_Leave(object sender, EventArgs e)
        {
            if (txtPassw.Text == "")
            {
                txtPassw.Text = "Contraseña...";
                txtPassw.ForeColor = Color.Silver;
                txtPassw.UseSystemPasswordChar = false;
            }
        }

        private void btnListo_Click(object sender, EventArgs e)
        {

        }
    }
}
