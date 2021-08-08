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
    public partial class frmCertBienInmueblePersonaF : Form
    {
        public frmCertBienInmueblePersonaF()
        {
            InitializeComponent();
        }

        private void frmCertBienInmueblePersonaF_Load(object sender, EventArgs e)
        {
            BLL.BienInmuebleBLL logica = new BLL.BienInmuebleBLL();
            BienesInmueblesBindingSource.DataSource = logica.VerPorID(1);
            this.reportViewer1.RefreshReport();

            byte[] bytes = reportViewer1.LocalReport.Render("PDF");
            
            Util.Utilities.EnviarPDFCorreo("kevinsteven.07.sg@gmail.com", bytes);
        }
    }
}
