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
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
            menuStrip1.Renderer = new MyRenderer();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {            
            if (cboReportes.SelectedIndex == 0)
            {
                Reportes.frmVentasCertsFecha ventana = new Reportes.frmVentasCertsFecha();
                ventana.Show();
            }
            else if (cboReportes.SelectedIndex == 1)
            {
                Reportes.frmRepVentaCertsMes ventana2 = new Reportes.frmRepVentaCertsMes();
                ventana2.Show();
            }
            else if (cboReportes.SelectedIndex == 2)
            {
                Reportes.frmRepComprasTotales ventana1 = new Reportes.frmRepComprasTotales();
                ventana1.Show();
            }
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            cboReportes.DataSource = Util.Utilities.lstRReportes();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmAdmin ventana = new frmAdmin();
            ventana.Show();
            this.Hide();
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

        private void picMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
