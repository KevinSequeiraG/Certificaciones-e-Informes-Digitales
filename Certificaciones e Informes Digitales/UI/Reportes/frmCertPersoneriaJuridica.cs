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
        string DetalleCert;
        public frmCertPersoneriaJuridica()
        {
            InitializeComponent();
        }
        public frmCertPersoneriaJuridica(string idPersona, string DetalleCert)
        {
            InitializeComponent();
            this.idPersona = idPersona;
            this.DetalleCert = DetalleCert;
        }

        private void frmCertPersoneriaJuridica_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsPersonaJConNombramiento.SP_PersonaJConNombramiento' table. You can move, or remove it, as needed.
            this.sP_PersonaJConNombramientoTableAdapter.Fill(this.dsPersonaJConNombramiento.SP_PersonaJConNombramiento, idPersona);
            this.reportViewer1.RefreshReport();

            BLL.HistorialBLL logicaHistorial = new BLL.HistorialBLL();

            logicaHistorial.Guardar(Util.UsuarioSingleton.GetInstance().email, DateTime.Now, DetalleCert);

            Entities.Historial his = logicaHistorial.VerUltimoHistorial(Util.UsuarioSingleton.GetInstance().email);

            his.qr = Util.Utilities.ImageToByteArray(Util.Utilities.VerQR(his.id.ToString()));

            HistorialBindingSource.DataSource = his;

            this.reportViewer1.RefreshReport();

            byte[] bytes = reportViewer1.LocalReport.Render("PDF");

            logicaHistorial.AgregarPdfAHist(his.id, bytes);

            Util.Utilities.EnviarPDFCorreo(Util.UsuarioSingleton.GetInstance().email, bytes, his.id);

        }
    }
}
