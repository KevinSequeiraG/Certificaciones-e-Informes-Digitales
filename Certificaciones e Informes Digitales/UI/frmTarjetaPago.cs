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
    public partial class frmTarjetaPago : Form
    {
        BLL.TarjetaBLL logica;
        public frmTarjetaPago()
        {
            InitializeComponent();
            menuStrip1.Renderer = new MyRenderer();
        }

        private void frmTarjetaPago_Load(object sender, EventArgs e)
        {
            dgvTarjetas.AutoGenerateColumns = false;
            logica = new BLL.TarjetaBLL();
            dgvTarjetas.DataSource = logica.VerTarjetasUsuario(Util.UsuarioSingleton.GetInstance().email);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarTarjeta_Click(object sender, EventArgs e)
        {
            frmAgregarTarjeta ventana = new frmAgregarTarjeta();
            ventana.ShowDialog();
            dgvTarjetas.DataSource = logica.VerTarjetasUsuario(Util.UsuarioSingleton.GetInstance().email);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmCompra ventana = new frmCompra();
            ventana.Show();
            this.Close();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            BLL.CarritoBLL logicaCarro = new BLL.CarritoBLL();
            if (Util.CarritoSingleton.GetInstance().total == 0)
            {
                logicaCarro.Eliminar(Util.CarritoSingleton.GetInstance().id);
            }
            Application.Exit();
        }

        private void picMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            BLL.CarritoBLL logicaParaTotales = new BLL.CarritoBLL();
            Util.CarritoSingleton.GetInstance().subtotal = logicaParaTotales.CalcularTotal(Util.CarritoSingleton.GetInstance().id);
            Util.CarritoSingleton.GetInstance().impuestos = logicaParaTotales.CalcularTotal(Util.CarritoSingleton.GetInstance().id) * 0.13;
            Util.CarritoSingleton.GetInstance().total = logicaParaTotales.CalculaTotalConImpuestos(Util.CarritoSingleton.GetInstance().id);
            logicaParaTotales.Editar(Util.CarritoSingleton.GetInstance().id, Util.CarritoSingleton.GetInstance().usuario, Util.CarritoSingleton.GetInstance().total, Util.CarritoSingleton.GetInstance().subtotal, Util.CarritoSingleton.GetInstance().impuestos);
            frmFactura ventana = new frmFactura();
            ventana.Show();
            this.Hide();
        }
        private class MyRenderer : ToolStripProfessionalRenderer
        {
            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
                Color c = e.Item.Selected ? Color.Gray : Color.Black;
                using (SolidBrush brush = new SolidBrush(c))
                    e.Graphics.FillRectangle(brush, rc);
            }
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Loguin ventana = new Loguin();
            ventana.Show();
            this.Hide();
        }

        private void cambiarContraseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevoPassword ventana = new frmNuevoPassword();
            ventana.ShowDialog();
        }
    }
}
