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
    public partial class frmAgregarBienMueble : Form
    {
        public frmAgregarBienMueble()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Entities.BienesMuebles bien = new Entities.BienesMuebles();
                bien.id = Convert.ToInt32(txtid.Text);
                bien.idPersona = txtIDPersona.Text;
                bien.annoFabricacion =Convert.ToInt32(txtAnnoFab.Text);
                bien.capacidad = Convert.ToInt32(txtCapacidad.Text);
                bien.Categoria = txtCat.Text;
                bien.Color = txtColor.Text;
                bien.estado = rdbInscrito.Checked?true:false;
                bien.marca = txtMarca.Text;
                bien.moneda = (Enums.Moneda)cboMoneda.SelectedItem;
                bien.serie = txtSerie.Text;
                bien.traccion = txtTraccion.Text;
                bien.uso = (Enums.Usos)cboUso.SelectedItem;
                bien.valorHacienda = Convert.ToDouble(txtValorHacienda.Text);
                  

                BLL.BienMueleBLL.Guardar(bien);
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

        private void frmAgregarBienMueble_Load(object sender, EventArgs e)
        {
            cboMoneda.DataSource = Enum.GetValues(typeof(Enums.Moneda));
            cboUso.DataSource = Enum.GetValues(typeof(Enums.Usos));
        }
    }
}
