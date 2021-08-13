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
    public partial class frmQR : Form
    {
        string Codigo;
        public frmQR(string codigo)
        {
            InitializeComponent();
            this.Codigo = codigo;
        }

        private void frmQR_Load(object sender, EventArgs e)
        {
            pnlQR.BackgroundImage = Util.Utilities.VerQR(Codigo);
        }
    }
}
