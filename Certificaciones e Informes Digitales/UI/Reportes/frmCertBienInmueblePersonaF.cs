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
        private string idPersona;
        private int idBien;
        private bool tipoPersona;
        string DetalleCert;
        public frmCertBienInmueblePersonaF()
        {
            InitializeComponent();
        }
        public frmCertBienInmueblePersonaF(bool tipoPersona, string idPersona, int idBien, string DetalleCert)
        {
            InitializeComponent();
            this.idPersona = idPersona;
            this.idBien = idBien;
            this.tipoPersona = tipoPersona;
            this.DetalleCert = DetalleCert;

        }

        private void frmCertBienInmueblePersonaF_Load(object sender, EventArgs e)
        {
            BLL.BienInmuebleBLL logica = new BLL.BienInmuebleBLL();
            BLL.HistorialBLL logicaHistorial = new BLL.HistorialBLL();
            BienesInmueblesBindingSource.DataSource = logica.VerPorID(idBien);

            if (tipoPersona)
            {
                BLL.PersonaFisicaBLL personalog = new BLL.PersonaFisicaBLL();
                PersonaFisicaBindingSource.DataSource = personalog.VerPorID(idPersona);
            }
            if (!tipoPersona)
            {
                BLL.PersonaJuridicaBLL personaj = new BLL.PersonaJuridicaBLL();
                PersonaJuridicaBindingSource.DataSource = personaj.VerPorID(idPersona);
            }
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
