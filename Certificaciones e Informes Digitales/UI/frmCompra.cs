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
        internal static string IDpersonaF;
        internal static string IDpersonaJ;
        internal static bool certPersonaJ;
        internal static bool certBienMueble;
        internal static bool certBienInmueble;
        internal static int IDBien;
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
        }

        private void frmCompra_Activated(object sender, EventArgs e)
        {
            lblCompra.BringToFront();
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
            frmTarjetaPago ventana = new frmTarjetaPago();
            ventana.Show();
            this.Close();
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
                certPersonaJ = true;
                certBienInmueble = false;
                certBienMueble = false;
            }
            else if (cboTipos.SelectedIndex == 2)
            {
                dgvProductos.DataSource = logica.VerPorTipo("Bienes Muebles");
                certBienMueble = true;
                certBienInmueble = false;
                certPersonaJ = false;
            }
            else if (cboTipos.SelectedIndex == 3)
            {
                dgvProductos.DataSource = logica.VerPorTipo("Bienes Inmuebles");
                certBienInmueble = true;
                certBienMueble = false;
                certPersonaJ = false;
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
            try
            {
                if (e.ColumnIndex == 0 && e.RowIndex >= 0)
                {
                    frmPersonaCert ventana = new frmPersonaCert();
                    ventana.ShowDialog();

                    if (certBienInmueble || certBienMueble)
                    {
                        frmBienDestinado ventanaBien = new frmBienDestinado();
                        ventanaBien.ShowDialog();
                    }

                    BLL.LineaDetalleBLL logicaLinea = new BLL.LineaDetalleBLL();
                    Entities.LineaDetalle linea = new Entities.LineaDetalle();

                    linea.idPersonaF = IDpersonaF;
                    linea.idPersonaJ = IDpersonaJ;
                    linea.idCarrito = Util.CarritoSingleton.GetInstance().id;
                    linea.idCert = Convert.ToInt32(dgvProductos["ID", e.RowIndex].Value.ToString());
                    linea.cant = 1;

                    if (certBienMueble)
                    {
                        BLL.BienMueleBLL logicaBienMueble = new BLL.BienMueleBLL();
                        Entities.BienesMuebles bienM = new Entities.BienesMuebles();
                        bienM = logicaBienMueble.VerPorID(IDBien);
                        if (bienM != null && (bienM.idPersonaF == linea.idPersonaF && bienM.idPersonaJ == linea.idPersonaJ))
                        {
                            linea.idBien = IDBien;
                            logicaLinea.Guardar(linea);
                            MessageBox.Show("Se agrega la certificacion al carrito");
                        }
                        else
                        {
                            throw new ApplicationException("El ID ingresado para el Bien no pertenece a la persona requerida");
                        }
                    }
                    else if (certBienInmueble)
                    {
                        BLL.BienInmuebleBLL logicaBienMueble = new BLL.BienInmuebleBLL();
                        Entities.BienesInmuebles bienI = new Entities.BienesInmuebles();
                        bienI = logicaBienMueble.VerPorID(IDBien);
                        if (bienI != null && (bienI.idPersonaF == linea.idPersonaF && bienI.idPersonaJ == linea.idPersonaJ))
                        {
                            linea.idBien = IDBien;
                            logicaLinea.Guardar(linea);
                            MessageBox.Show("Se agrega la certificacion al carrito");
                        }
                        else
                        {
                            throw new ApplicationException("El ID ingresado para el Bien no pertenece a la persona requerida");
                        }
                    }
                    else
                    {
                        logicaLinea.Guardar(linea);
                        MessageBox.Show("Se agrega la certificacion al carrito");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            frmCarrito ventana = new frmCarrito();
            ventana.Show();
            this.Hide();
        }
    }
}
