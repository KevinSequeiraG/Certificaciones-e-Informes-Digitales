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
    public partial class frmGestion : Form
    {
        public frmGestion()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void frmGestion_Load(object sender, EventArgs e)
        {
            if (frmGestiones.GestionSeleccionada == 1 || frmGestiones.GestionSeleccionada == 2)
            {
                lblID.Text = "Id de Persona:";
            }
            else if (frmGestiones.GestionSeleccionada == 3)
            {
                lblID.Text = "Id de Certificación:";
            }
            else if (frmGestiones.GestionSeleccionada == 4)
            {
                lblID.Text = "Id del bien inmueble:";
            }
            else if (frmGestiones.GestionSeleccionada == 5)
            {
                lblID.Text = "Id del bien mueble:";
                frmAgregarBienMueble ventana = new frmAgregarBienMueble();
                ventana.Show();

            }
            else if (frmGestiones.GestionSeleccionada == 6)
            {
                lblID.Text = "Id del catastro:";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (frmGestiones.GestionSeleccionada == 1)
            {
                frmAgregarPersonasF ventana = new frmAgregarPersonasF();
                ventana.ShowDialog();
            }
            else if (frmGestiones.GestionSeleccionada == 2)
            {
                frmAgregarPersonaJ ventana = new frmAgregarPersonaJ();
                ventana.ShowDialog();
            }
            else if (frmGestiones.GestionSeleccionada == 3)
            {
                frmAgregarCerts ventana = new frmAgregarCerts();
                ventana.ShowDialog();
            }
            else if (frmGestiones.GestionSeleccionada == 4)
            {
                frmAgregarBienInmueble ventana = new frmAgregarBienInmueble();
                ventana.ShowDialog();
            }
            else if (frmGestiones.GestionSeleccionada == 5)
            {
                frmAgregarBienMueble ventana = new frmAgregarBienMueble();
                ventana.ShowDialog();
            }
            else if (frmGestiones.GestionSeleccionada == 6)
            {
                frmAgregarCatastro ventana = new frmAgregarCatastro();
                ventana.ShowDialog();
            }
        }
    }
}
