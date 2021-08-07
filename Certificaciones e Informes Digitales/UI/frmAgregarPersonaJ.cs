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
    public partial class frmAgregarPersonaJ : Form
    {
        internal static string idP;
        public frmAgregarPersonaJ()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Entities.PersonaJuridica persona = new Entities.PersonaJuridica();
                BLL.PersonaJuridicaBLL logica = new BLL.PersonaJuridicaBLL();

                idP = txtid.Text;
                persona.id = txtid.Text;
                persona.razonSocial = txtIRazonSoc.Text;
                persona.estado = rdbActivo.Checked ? true : false;
                persona.FechaInsc = clrFechaInsc.SelectionStart;
                persona.tomo = Convert.ToInt32(txtTomo.Text);
                persona.asiento = Convert.ToInt32(TxtAsiento.Text);
                persona.domicilio = txtDomicilio.Text;
                persona.objeto = txtObjeto.Text;

                logica.Guardar(persona);
                MessageBox.Show("Persona agregada correctamente");

                frmAgregarNombramiento ventanaN = new frmAgregarNombramiento();
                ventanaN.ShowDialog();
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
    }
}
