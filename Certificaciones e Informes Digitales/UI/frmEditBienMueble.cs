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
    public partial class frmEditBienMueble : Form
    {
        public frmEditBienMueble()
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
                BLL.BienMueleBLL logica = new BLL.BienMueleBLL();
                string personaF = "";
                string personaJ = "";
                if (rdbPersonaF.Checked)
                {
                    personaF = txtIDPersona.Text;
                }
                else
                {
                    personaJ = txtIDPersona.Text;
                }
                logica.Editar(Convert.ToInt32(txtid.Text), personaJ, personaF, txtMarca.Text, txtCat.Text, txtSerie.Text, txtTraccion.Text, Convert.ToInt32(txtAnnoFab.Text), (Enums.Usos)cboUso.SelectedItem, txtColor.Text, Convert.ToInt32(txtCapacidad.Text), Convert.ToDouble(txtValorHacienda.Text), rdbInscrito.Checked ? true : false, (Enums.Moneda)cboMoneda.SelectedItem);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void frmEditBienMueble_Load(object sender, EventArgs e)
        {
            this.ActiveControl = lblIDPersona;
            cboMoneda.DataSource = Enum.GetValues(typeof(Enums.Moneda));
            cboUso.DataSource = Enum.GetValues(typeof(Enums.Usos));
            BLL.BienMueleBLL logica = new BLL.BienMueleBLL();
            Entities.BienesMuebles bien = logica.VerPorID(frmGestion.ID);
            txtid.Text = bien.id.ToString();
            if (bien.idPersonaJ != "")
            {
                rdbPersonaJ.Checked = true;
                txtIDPersona.Text = bien.idPersonaJ;
            }
            if (bien.idPersonaF != "")
            {
                rdbPersonaF.Checked = true;
                txtIDPersona.Text = bien.idPersonaF;
            }
            txtMarca.Text = bien.marca;
            txtCat.Text = bien.Categoria;
            txtSerie.Text = bien.serie;
            txtTraccion.Text = bien.traccion;
            txtAnnoFab.Text = bien.annoFabricacion.ToString();
            txtColor.Text = bien.Color;
            txtCapacidad.Text = bien.capacidad.ToString();
            txtValorHacienda.Text = bien.valorHacienda.ToString();
            if (bien.estado)
            {
                rdbInscrito.Checked = true;
            }
            else
            {
                rdbNoInscrito.Checked = true;
            }
            cboUso.SelectedIndex = (int)bien.uso;
            cboMoneda.SelectedIndex = (int)bien.moneda;
        }
    }
}
