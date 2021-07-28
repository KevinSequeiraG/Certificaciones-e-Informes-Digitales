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
    public partial class frmEditCatastro : Form
    {
        public frmEditCatastro()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditCatastro_Load(object sender, EventArgs e)
        {
            this.ActiveControl = lblAgregarCat;

            BLL.CatastroBLL logica = new BLL.CatastroBLL();
            Entities.Catastro catastro = logica.VerPorID(frmGestion.ID);
            txtid.Text = catastro.id.ToString();
            if (catastro.idPersonaJ != "")
            {
                rdbPersonaJ.Checked = true;
                txtIDPersona.Text = catastro.idPersonaJ;
            }
            if (catastro.idPersonaF != "")
            {
                rdbPersonaF.Checked = true;
                txtIDPersona.Text = catastro.idPersonaF;
            }
            txtLocalizacion.Text = catastro.localizacion;
            txtUsoLocal.Text = catastro.usoLocal;
            txtAnno.Text = catastro.annoConst.ToString();
            txtTamanno.Text = catastro.tamanno.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            BLL.CatastroBLL logica = new BLL.CatastroBLL();
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
            logica.Editar(Convert.ToInt32(txtid.Text), personaJ,personaF,txtLocalizacion.Text,txtUsoLocal.Text,Convert.ToInt32(txtAnno.Text),Convert.ToInt32(txtTamanno.Text));
            this.Close();
        }
    }
}
