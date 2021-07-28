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
    public partial class frmEditCert : Form
    {
        BLL.CertificacionBLL logica;
        public frmEditCert()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
             this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            logica.Editar(Convert.ToInt32(txtid.Text),cboTipo.SelectedItem.ToString(),txtDetalle.Text,Convert.ToDouble(txtPrecio.Text));
            this.Close();
        }

        private void frmEditCert_Load(object sender, EventArgs e)
        {
            logica = new BLL.CertificacionBLL();
            cboTipo.DataSource = Util.Utilities.lstTiposCert();

            Entities.Certificacion cert = logica.VerPorID(frmGestion.ID);

            txtDetalle.Text = cert.detalle;
            txtid.Text = cert.id.ToString();
            txtPrecio.Text = cert.precio.ToString();
            cboTipo.SelectedItem = cert.tipo; 

        }
    }
}
