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
    }
}
