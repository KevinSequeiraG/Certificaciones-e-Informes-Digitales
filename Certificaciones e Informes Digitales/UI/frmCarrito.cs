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
    public partial class frmCarrito : Form
    {
        public frmCarrito()
        {
            InitializeComponent();
            menuStrip1.Renderer = new MyRenderer();
        }

        private void frmCarrito_Load(object sender, EventArgs e)
        {
            BLL.CarritoBLL logicaCarro = new BLL.CarritoBLL();
            dgvCarrito.AutoGenerateColumns = false;
            dgvCarrito.DataSource = logicaCarro.VerInfoCarrito(Util.CarritoSingleton.GetInstance().id);
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmCompra ventana = new frmCompra();
            ventana.Show();
            this.Close();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            frmTarjetaPago ventana = new frmTarjetaPago();
            ventana.Show();
            this.Close();
        }

        private void picMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
