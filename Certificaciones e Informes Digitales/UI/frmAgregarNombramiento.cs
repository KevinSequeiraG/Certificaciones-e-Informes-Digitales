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
    public partial class frmAgregarNombramiento : Form
    {
        public frmAgregarNombramiento()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            BLL.NombramientoBLL logica = new BLL.NombramientoBLL();
            Entities.Nombramiento nombramiento = new Entities.Nombramiento();
            nombramiento.Cargo = txtCargo.Text;
            nombramiento.Nombre = txtINombre.Text;
            nombramiento.id = Convert.ToInt32(txtid.Text);
            if (frmAgregarPersonaJ.idP != null)
            {
                nombramiento.idPersonaJuridica = frmAgregarPersonaJ.idP;
            }
            else if (frmGestion.IdP != null)
            {
                nombramiento.idPersonaJuridica = frmGestion.IdP;
            }
            nombramiento.FechaInsc = dtpFechaInsc.Value;
            nombramiento.VigenciaIni = dtpVigenciaIni.Value;
            nombramiento.VigenciaVenc = dtpVigenciaVenc.Value;

            logica.Guardar(nombramiento);
            MessageBox.Show("Nombramiento agregado a la ultima persona juridica agregada");
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
