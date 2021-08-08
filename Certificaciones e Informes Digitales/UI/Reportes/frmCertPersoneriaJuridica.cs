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
    public partial class frmCertPersoneriaJuridica : Form
    {
        public frmCertPersoneriaJuridica()
        {
            InitializeComponent();
        }

        private void frmCertPersoneriaJuridica_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsPersonaJConNombramiento.SP_PersonaJConNombramiento' table. You can move, or remove it, as needed.
            this.sP_PersonaJConNombramientoTableAdapter.Fill(this.dsPersonaJConNombramiento.SP_PersonaJConNombramiento, "44");
            this.reportViewer1.RefreshReport();

            byte[] bytes = reportViewer1.LocalReport.Render("PDF");

            Util.Utilities.EnviarPDFCorreo("kevinsteven.07.sg@gmail.com", bytes);

        }
    }
}
