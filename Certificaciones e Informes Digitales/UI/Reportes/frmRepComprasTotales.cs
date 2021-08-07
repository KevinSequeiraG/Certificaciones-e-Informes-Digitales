using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Certificaciones_e_Informes_Digitales.UI.Reportes
{
    public partial class frmRepComprasTotales : Form
    {
        public frmRepComprasTotales()
        {
            InitializeComponent();
        }

        private void frmRepComprasTotales_Load(object sender, EventArgs e)
        {
            CarritoBindingSource.DataSource = BLL.CarritoBLL.VerComprasDelMes();
            this.reportViewer1.RefreshReport();
        }
    }
}
