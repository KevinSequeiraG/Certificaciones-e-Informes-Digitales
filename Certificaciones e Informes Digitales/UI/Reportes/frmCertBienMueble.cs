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
    public partial class frmCertBienMueble : Form
    {
        private string idPersona;
        private int idBien;
        private bool tipoPersona;

        public frmCertBienMueble()
        {
            InitializeComponent();
        }
        public frmCertBienMueble(bool tipoPersona, string idPersona, int idBien)
        {
            InitializeComponent();
            this.idPersona = idPersona;
            this.idBien = idBien;
            this.tipoPersona = tipoPersona;
        }

        private void frmCertBienMueble_Load(object sender, EventArgs e)
        {
            BLL.BienMueleBLL logica = new BLL.BienMueleBLL();
            BienesMueblesBindingSource.DataSource = logica.VerPorID(idBien);

            if (tipoPersona)
            {
                BLL.PersonaFisicaBLL personalog = new BLL.PersonaFisicaBLL();
                PersonaFisicaBindingSource.DataSource = personalog.VerPorID(idPersona);
            }
            else
            {
                BLL.PersonaJuridicaBLL personaj = new BLL.PersonaJuridicaBLL();
                PersonaJuridicaBindingSource.DataSource = personaj.VerPorID(idPersona);
            }           
            this.reportViewer1.RefreshReport(); 
            
            byte[] bytes = reportViewer1.LocalReport.Render("PDF");

            Util.Utilities.EnviarPDFCorreo(Util.UsuarioSingleton.GetInstance().email, bytes);
        }
    }
}
