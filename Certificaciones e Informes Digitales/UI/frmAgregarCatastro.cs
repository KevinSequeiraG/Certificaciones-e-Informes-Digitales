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
    public partial class frmAgregarCatastro : Form
    {
        public frmAgregarCatastro()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                BLL.CatastroBLL logica = new BLL.CatastroBLL();
                Entities.Catastro catastro = new Entities.Catastro();

                catastro.id = Convert.ToInt32(txtid.Text);
                if (rdbPersonaF.Checked)
                {
                    catastro.idPersonaF = txtIDPersona.Text;
                    catastro.idPersonaJ = "";
                }
                else
                {
                    catastro.idPersonaJ = txtIDPersona.Text;
                    catastro.idPersonaF = "";
                }
                catastro.localizacion = txtLocalizacion.Text;
                catastro.usoLocal = txtUsoLocal.Text;
                catastro.annoConst = Convert.ToInt32(txtAnno.Text);
                catastro.tamanno = Convert.ToInt32(txtTamanno.Text);

                logica.Guardar(catastro);
                MessageBox.Show("Catastro guardado correctamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }
    }
}
