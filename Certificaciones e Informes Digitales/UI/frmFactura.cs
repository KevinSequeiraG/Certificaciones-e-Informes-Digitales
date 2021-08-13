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
    public partial class frmFactura : Form
    {
        public frmFactura()
        {
            InitializeComponent();
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            BLL.CarritoBLL logicaCarro = new BLL.CarritoBLL();
            dgvCarrito.AutoGenerateColumns = false;
            dgvCarrito.DataSource = logicaCarro.VerInfoCarrito(Util.CarritoSingleton.GetInstance().id);
            txtTot.Text = Util.CarritoSingleton.GetInstance().subtotal.ToString();
            txtImpuestos.Text = Util.CarritoSingleton.GetInstance().impuestos.ToString();
            txtTotalConImpuestos.Text = Util.CarritoSingleton.GetInstance().total.ToString();
            Util.Utilities.EnviarCertificaciones(logicaCarro.VerInfoCarrito(Util.CarritoSingleton.GetInstance().id));

            XML.xml xml = new XML.xml();
            xml.GenerarXml(Util.UsuarioSingleton.GetInstance(), Util.CarritoSingleton.GetInstance(), logicaCarro.VerInfoCarrito(Util.CarritoSingleton.GetInstance().id));
            
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmUsuario ventana = new frmUsuario();
            ventana.Show();
            this.Hide();
        }
    }
}
