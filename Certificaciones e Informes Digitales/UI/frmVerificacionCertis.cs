using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Certificaciones_e_Informes_Digitales.UI
{
    public partial class frmVerificacionCertis : Form
    {
        public frmVerificacionCertis()
        {
            InitializeComponent();
        }

        private void frmVerificacionCertis_Load(object sender, EventArgs e)
        {
            
            //Util.Utilities.EnviarPDFCorreo("kevinsteven.07.sg@gmail.com", hist.pdf);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                BLL.HistorialBLL logica = new BLL.HistorialBLL();
                Entities.Historial hist = logica.VerPorID(Convert.ToInt32(txtCodigoCert.Text));
                if (hist == null)
                {
                    MessageBox.Show("No existe ninguna certificacion emitida por el Registro Nacional con este Codigo");
                }
                else
                {
                    MessageBox.Show("Si existe una certificacion emitida por el Registro Nacional con este Codigo");
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
