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
    public partial class frmAgregarCerts : Form
    {
        public frmAgregarCerts()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                BLL.CertificacionBLL logica = new BLL.CertificacionBLL();
                Entities.Certificacion cert = new Entities.Certificacion();

                cert.id = Convert.ToInt32(txtid.Text);
                cert.tipo = cboTipo.SelectedItem.ToString();
                cert.detalle = txtDetalle.Text;
                cert.precio = Convert.ToDouble(txtPrecio.Text);

                logica.Guardar(cert);
                MessageBox.Show("Certificacion agregaada correctamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAgregarCerts_Load(object sender, EventArgs e)
        {
            cboTipo.DataSource = Util.Utilities.lstTiposCert();
        }
    }
}
