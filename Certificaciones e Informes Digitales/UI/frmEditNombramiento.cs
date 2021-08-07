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
    public partial class frmEditNombramiento : Form
    {
        BLL.NombramientoBLL logica;
        public frmEditNombramiento()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            logica.Editar(Convert.ToInt32(txtid.Text), txtINombre.Text, txtCargo.Text, dtpFechaInsc.Value, dtpVigenciaIni.Value, dtpVigenciaVenc.Value, frmAgregarPersonaJ.idP);
            this.Close();
        }

        private void frmEditNombramiento_Load(object sender, EventArgs e)
        {
            logica = new BLL.NombramientoBLL();
            Entities.Nombramiento nombramiento = logica.VerPorID(frmNombramiento.idN);
            txtCargo.Text = nombramiento.Cargo;
            txtINombre.Text = nombramiento.Nombre;
            txtid.Text = nombramiento.id.ToString();
            frmAgregarPersonaJ.idP = nombramiento.idPersonaJuridica;
            dtpFechaInsc.Value = nombramiento.FechaInsc;
            dtpVigenciaIni.Value = nombramiento.VigenciaIni;
            dtpVigenciaVenc.Value = nombramiento.VigenciaVenc;
        }
    }
}
