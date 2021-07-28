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
    public partial class frmEditBienInmueble : Form
    {
        BLL.BienInmuebleBLL logica;
        public frmEditBienInmueble()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string personaF = "";
            string personaJ = "";
            if (rdbPersonaF.Checked)
            {
                personaF = txtIDPersona.Text;
            }
            else
            {
                personaJ = txtIDPersona.Text;
            }
            logica.Editar(Convert.ToInt32(mtbID.Text),personaJ, personaF,  (Enums.Provincia)cboProvincia.SelectedItem, txtMide.Text, Convert.ToDouble(txtValorFiscal.Text), txtNaturaleza.Text);
        }

        private void frmEditBienInmueble_Load(object sender, EventArgs e)
        {
            this.ActiveControl = lblIDPersona;
            cboProvincia.DataSource = Enum.GetValues(typeof(Enums.Provincia));
            logica = new BLL.BienInmuebleBLL();
            Entities.BienesInmuebles bien = logica.VerPorID(frmGestion.ID);
            mtbID.Text = bien.id.ToString();
            if (bien.idPersonaJ != "")
            {
                rdbPersonaJ.Checked = true;
                txtIDPersona.Text = bien.idPersonaJ;
            }
            if (bien.idPersonaF != "")
            {
                rdbPersonaF.Checked = true;
                txtIDPersona.Text = bien.idPersonaF;
            }
            txtMide.Text = bien.Mide;
            txtNaturaleza.Text= bien.naturaleza;
            cboProvincia.SelectedIndex = (int)bien.provincia;
            txtValorFiscal.Text = bien.valorFiscal.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
