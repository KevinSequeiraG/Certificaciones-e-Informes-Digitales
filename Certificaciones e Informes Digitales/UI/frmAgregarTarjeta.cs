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
    public partial class frmAgregarTarjeta : Form
    {
        public frmAgregarTarjeta()
        {
            InitializeComponent();
        }

        private void frmAgregarTarjeta_Load(object sender, EventArgs e)
        {
            cboTipoTarjeta.DataSource = Enum.GetValues(typeof(Enums.TipoTarjeta));
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                BLL.TarjetaBLL logica = new BLL.TarjetaBLL();
                Entities.Tarjeta tarjeta = new Entities.Tarjeta();
                tarjeta.id = Convert.ToInt32(txtid.Text);
                tarjeta.idUser = Util.UsuarioSingleton.GetInstance().email;
                tarjeta.tipo = (Enums.TipoTarjeta)cboTipoTarjeta.SelectedItem;
                tarjeta.cvv = Convert.ToInt32(txtCVV.Text);
                tarjeta.fechaVenc = mcrFechaVenc.SelectionStart;
                logica.Guardar(tarjeta);
                MessageBox.Show("Tarjeta agregada a su usuario");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
