using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Certificaciones_e_Informes_Digitales.UI
{
    public partial class Loguin : Form
    {
        public Loguin()
        {
            InitializeComponent();
        }

        //Estos comandos son para poder mover la app sin el borde
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Loguin_Activated(object sender, EventArgs e)
        {
            lblLoguin.Focus();
        }


        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Correo Eléctronico...")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.LightGray;
            }

        }

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

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Correo Eléctronico...";
                txtEmail.ForeColor = Color.Silver;
            }
        }

        private void Loguin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnlFondo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lnkCrearUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCrearUsuario ventana = new frmCrearUsuario();
            ventana.Show();
            this.Hide();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            BLL.UsuarioBLL usuarioBLL = new BLL.UsuarioBLL();
            Entities.Usuario user = usuarioBLL.TraerUsuario(txtEmail.Text, txtPassw.Text);
            Util.UsuarioSingleton.setUser(user);

            if (user.tipo == Enums.TipoUsuario.cliente)
            {
                frmCompra ventana = new frmCompra();
                this.Hide();
                ventana.Show();
            }
            else
            {
                frmAdmin ventana = new frmAdmin();
                this.Hide();
                ventana.Show();
            }

        }

        private void lnkRecuperarContra_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRecuperarContra ventana = new frmRecuperarContra();
            ventana.Show();
            this.Hide();
        }
    }
}
