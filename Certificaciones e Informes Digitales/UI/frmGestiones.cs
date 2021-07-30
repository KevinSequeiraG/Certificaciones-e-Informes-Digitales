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
    public partial class frmGestiones : Form
    {
        public frmGestiones()
        {
            InitializeComponent();
            menuStrip1.Renderer = new MyRenderer();
        }
        internal static int GestionSeleccionada;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void frmGestiones_Load(object sender, EventArgs e)
        {
            Util.Utilities logica = new Util.Utilities();
            cboObjetosGestion.DataSource = logica.lstGestiones();
        }

        private void picMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void frmGestiones_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cboObjetosGestion_SelectedValueChanged(object sender, EventArgs e)
        {
            GestionSeleccionada = cboObjetosGestion.SelectedIndex;
            pnlFrames.Controls.Clear();
            if (cboObjetosGestion.SelectedIndex == 0)//usuarios
            {
                frmGestionUsuario ventana = new frmGestionUsuario();
                ventana.TopLevel = false;
                pnlFrames.Controls.Add(ventana);
                ventana.Show();
            }
            else //Cualquier otra Gestion
            {
                frmGestion ventana = new frmGestion();
                ventana.TopLevel = false;
                pnlFrames.Controls.Add(ventana);
                ventana.Show();
            }
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Loguin ventana = new Loguin();
            ventana.Show();
            this.Close();
        }

        private void cambiarContraseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevoPassword ventana = new frmNuevoPassword();
            ventana.ShowDialog();
        }
    }
}
