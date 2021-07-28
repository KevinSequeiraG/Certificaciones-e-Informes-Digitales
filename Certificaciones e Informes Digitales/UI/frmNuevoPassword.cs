using Certificaciones_e_Informes_Digitales.BLL;
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
    public partial class frmNuevoPassword : Form
    {
        public frmNuevoPassword()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void txtPassw_Enter(object sender, EventArgs e)
        {
            if (txtPassw.Text == "Contraseña...")
            {
                txtPassw.Text = "";
                txtPassw.ForeColor = Color.LightGray;
                txtPassw.UseSystemPasswordChar = true;
            }
        }

        private void txtPassw_Leave(object sender, EventArgs e)
        {
            if (txtPassw.Text == "")
            {
                txtPassw.Text = "Contraseña...";
                txtPassw.ForeColor = Color.Silver;
                txtPassw.UseSystemPasswordChar = false;
            }
        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassw.Text == "Contraseña...")
                {
                    MessageBox.Show("Debe ingresar una nueva contraseña");
                    return;
                }
                UsuarioBLL logica = new UsuarioBLL();
                logica.editarContrasenna(Util.UsuarioSingleton.GetInstance().email, txtPassw.Text, false);
                Util.UsuarioSingleton.GetInstance().changePassword = false;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error - " + ex.Message);
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmNuevoPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmNuevoPassword_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnl_fondo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnl_fondo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
