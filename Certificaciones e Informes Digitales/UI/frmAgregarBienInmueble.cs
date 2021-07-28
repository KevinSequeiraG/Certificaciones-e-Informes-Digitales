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
    public partial class frmAgregarBienInmueble : Form
    {
        public frmAgregarBienInmueble()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Entities.BienesInmuebles bien = new Entities.BienesInmuebles();
                bien.id = Convert.ToInt32(mtbID.Text);
                if (rdbPersonaF.Checked)
                {
                    bien.idPersonaF = txtIDPersona.Text;
                    bien.idPersonaJ = "";  
                }
                else
                {
                    bien.idPersonaJ = txtIDPersona.Text;
                    bien.idPersonaF = "";
                }
                bien.Mide = txtMide.Text;
                bien.naturaleza = txtNaturaleza.Text;
                bien.provincia = (Enums.Provincia)cboProvincia.SelectedItem;
                bien.valorFiscal = Convert.ToDouble(txtValorFiscal.Text);

                BLL.BienInmuebleBLL.Guardar(bien);
                MessageBox.Show("Bien Inmueble guardado correctamente");
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

        private void frmAgregarBienInmueble_Load(object sender, EventArgs e)
        {
            cboProvincia.DataSource = Enum.GetValues(typeof(Enums.Provincia));
            rdbPersonaF.Checked = true;
        }
    }
}
