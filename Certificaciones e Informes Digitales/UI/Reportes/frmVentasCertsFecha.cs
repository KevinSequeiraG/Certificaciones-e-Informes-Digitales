using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Certificaciones_e_Informes_Digitales.UI.Reportes
{
    public partial class frmVentasCertsFecha : Form
    {
        public frmVentasCertsFecha()
        {
            InitializeComponent();
        }

        private void frmVentasCertsFecha_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dpVentasCertsFecha.SP_VerVentasCerts' table. You can move, or remove it, as needed.
            this.sP_VerVentasCertsTableAdapter.Fill(this.dpVentasCertsFecha.SP_VerVentasCerts, dtpDesde.Value, dtpHasta.Value);

            this.reportViewer1.RefreshReport();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dpVentasCertsFecha.SP_VerVentasCerts' table. You can move, or remove it, as needed.
            this.sP_VerVentasCertsTableAdapter.Fill(this.dpVentasCertsFecha.SP_VerVentasCerts, dtpDesde.Value, dtpHasta.Value);

            this.reportViewer1.RefreshReport();
        }
    }
}
