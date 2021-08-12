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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
            menuStrip1.Renderer = new MyRenderer();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnGestiones_Click(object sender, EventArgs e)
        {
            frmGestiones ventana = new frmGestiones();
            ventana.Show();
            this.Hide();
        }

        private void picMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmAdmin_Activated(object sender, EventArgs e)
        {
            if (Util.UsuarioSingleton.GetInstance().changePassword)
            {
                frmNuevoPassword ventana = new frmNuevoPassword();
                ventana.ShowDialog();
            }
        }

        private void frmAdmin_FormClosed(object sender, FormClosedEventArgs e)
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

        private void frmAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnGestiones_MouseEnter(object sender, EventArgs e)
        {
            btnGestiones.BackColor = Color.IndianRed;
        }

        private void btnGestiones_MouseLeave(object sender, EventArgs e)
        {
            btnGestiones.BackColor = Color.Transparent;
        }

        private void btnComprador_MouseEnter(object sender, EventArgs e)
        {
            btnComprador.BackColor = Color.IndianRed;
        }

        private void btnComprador_MouseLeave(object sender, EventArgs e)
        {
            btnComprador.BackColor = Color.Transparent;
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Loguin ventana = new Loguin();
            ventana.Show();
            this.Hide();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            frmReportes ventana = new frmReportes();
            ventana.Show();
            this.Hide();
            Reportes.frmCertPersoneriaJuridica logica = new Reportes.frmCertPersoneriaJuridica();
            logica.Show();
            logica.Hide();
            Reportes.frmCertBienInmueblePersonaF ve = new Reportes.frmCertBienInmueblePersonaF();
            ve.Show();
            Reportes.frmCertBienMueble ven = new Reportes.frmCertBienMueble();
            ven.Show();
        }

        private void cambiarContraseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnReportes_MouseEnter(object sender, EventArgs e)
        {
            btnReportes.BackColor = Color.IndianRed;
        }

        private void btnReportes_MouseLeave(object sender, EventArgs e)
        {
            btnReportes.BackColor = Color.Transparent;
        }
    }
}
