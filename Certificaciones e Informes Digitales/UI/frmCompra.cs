using Certificaciones_e_Informes_Digitales.Enums;
using Certificaciones_e_Informes_Digitales.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Certificaciones_e_Informes_Digitales.UI
{
    public partial class frmCompra : Form
    {
        Entities.Carrito carro;
        public frmCompra()
        {
            InitializeComponent();
            menuStrip1.Renderer = new MyRenderer();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Loguin ventana = new Loguin();
            ventana.Show();
            this.Hide();
        }

        private void frmCompra_Load(object sender, EventArgs e)
        {
            cboTipos.DataSource = Util.Utilities.lstTiposCert();
            BLL.CarritoBLL logica = new BLL.CarritoBLL();
            carro = new Entities.Carrito();
            carro.usuario = Util.UsuarioSingleton.GetInstance();
            carro.total = 0;
            carro.subtotal = 0;
            carro.impuestos = 0;
            logica.Guardar(carro);
            carro = logica.VerUltimoCarrito(Util.UsuarioSingleton.GetInstance().email);
        }

        private void frmCompra_Activated(object sender, EventArgs e)
        {
            lblCompra.BringToFront();

            if (Util.UsuarioSingleton.GetInstance().changePassword)
            {
                frmNuevoPassword ventana = new frmNuevoPassword();
                ventana.ShowDialog();
            }
        }

        private void frmCompra_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmCompra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void cuentaToolStripMenuItem_BackColorChanged(object sender, EventArgs e)
        {
            cuentaToolStripMenuItem.ForeColor = Color.Black;
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Loguin ventana = new Loguin();
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

        private void btnComprar_Click(object sender, EventArgs e)
        {

        }

        private void cambiarContraseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevoPassword ventana = new frmNuevoPassword();
            ventana.ShowDialog();
        }

        private void cmbTipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            BLL.CertificacionBLL logica = new BLL.CertificacionBLL();
            if (cboTipos.SelectedIndex == 0)
            {
                dgvProductos.DataSource = logica.VerPorTipo("Catastro");
            }
            else if (cboTipos.SelectedIndex == 1)
            {
                dgvProductos.DataSource = logica.VerPorTipo("Personas Juridicas");
            }
            else if (cboTipos.SelectedIndex == 2)
            {
                dgvProductos.DataSource = logica.VerPorTipo("Bienes Muebles");
            }
            else if (cboTipos.SelectedIndex == 3)
            {
                dgvProductos.DataSource = logica.VerPorTipo("Bienes Inmuebles");
            }
        }

        private void dgvProductos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.carrrito.Width;
                var h = Properties.Resources.carrrito.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.carrrito, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                BLL.LineaDetalleBLL logicaLinea = new BLL.LineaDetalleBLL();
                Entities.LineaDetalle linea = new Entities.LineaDetalle();

                linea.idPersonaF = "1";
                linea.idPersonaJ = "";

                linea.idCarrito = carro.id;

                linea.idCert = Convert.ToInt32(dgvProductos["ID", e.RowIndex].Value.ToString());
                linea.cant = 1;

                logicaLinea.Guardar(linea);
                MessageBox.Show("'Se agrega al carro'");
            }
        }
    }
}
