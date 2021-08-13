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
    public partial class frmBienDestinado : Form
    {
        public frmBienDestinado()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            frmCompra.IDBien = Convert.ToInt32(txtID.Text);
            this.Hide();
        }

        private void frmBienDestinado_Load(object sender, EventArgs e)
        {
            if (frmCompra.certBienInmueble)
            {
                lblID.Text = "ID del Bien Inmueble";
            }
            else if (frmCompra.certBienMueble)
            {
                lblID.Text = "ID del Bien Mueble";
            }
            else if (frmCompra.certCatastro)
            {
                lblID.Text = "ID del Catastro";
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            throw new ApplicationException("No se ha seleccionado el id del bien al que va dirigida la certificacion");
            this.Close();
        }
    }
}
