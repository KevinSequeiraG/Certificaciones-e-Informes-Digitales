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
    public partial class frmEditPersonaJ : Form
    {
        BLL.PersonaJuridicaBLL logica;
        public frmEditPersonaJ()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            logica.Editar(txtid.Text, txtIRazonSoc.Text, (rdbActivo.Checked?true:false), clrFechaInsc.SelectionStart,Convert.ToInt32(txtTomo.Text), Convert.ToInt32(TxtAsiento.Text),txtDomicilio.Text,txtObjeto.Text);
            this.Close();
        }

        private void frmEditPersonaJ_Load(object sender, EventArgs e)
        {
            logica = new BLL.PersonaJuridicaBLL();
            Entities.PersonaJuridica persona = logica.VerPorID(frmGestion.IdP);
            if (persona.estado)
            {
                rdbActivo.Checked = true;
            }
            else
            {
                rdbInactivo.Checked = true;
            }
            txtIRazonSoc.Text = persona.razonSocial;
            clrFechaInsc.SelectionStart = persona.FechaInsc;
            txtDomicilio.Text = persona.domicilio;
            txtid.Text = persona.id;
            txtObjeto.Text = persona.objeto;
            txtTomo.Text = persona.tomo.ToString();
            TxtAsiento.Text = persona.asiento.ToString();
        }
    }
}
