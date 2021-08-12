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
        string idPersona;
        public frmCertPersoneriaJuridica()
        {
            InitializeComponent();
        }
        public frmCertPersoneriaJuridica(string idPersona)
        {
            InitializeComponent();
            this.idPersona = idPersona;
        }

        private void frmCertPersoneriaJuridica_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsPersonaJConNombramiento.SP_PersonaJConNombramiento' table. You can move, or remove it, as needed.
            this.sP_PersonaJConNombramientoTableAdapter.Fill(this.dsPersonaJConNombramiento.SP_PersonaJConNombramiento, idPersona);
            this.reportViewer1.RefreshReport();

            byte[] bytes = reportViewer1.LocalReport.Render("PDF");

            Util.Utilities.EnviarPDFCorreo(Util.UsuarioSingleton.GetInstance().email, bytes);

        }
    }
}
