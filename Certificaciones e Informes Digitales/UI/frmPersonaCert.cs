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
    public partial class frmPersonaCert : Form
    {
        public frmPersonaCert()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtID.Text))
                {
                    MessageBox.Show("Debe indicar el id de la persona");
                }
                else
                {
                    frmCompra.IDpersonaF = (rdbPersonaF.Checked ? txtID.Text : "");
                    frmCompra.IDpersonaJ = (rdbPersonaJ.Checked ? txtID.Text : "");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }                     
        }

        private void frmPersonaCert_Load(object sender, EventArgs e)
        {
            rdbPersonaF.Checked = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
