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
    public partial class frmCrearUsuario : Form
    {
        public frmCrearUsuario()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre...")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.LightGray;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre...";
                txtNombre.ForeColor = Color.Silver;
            }
        }

        private void txtApellido1_Enter(object sender, EventArgs e)
        {
            if (txtApellido1.Text == "Primer Apellido...")
            {
                txtApellido1.Text = "";
                txtApellido1.ForeColor = Color.LightGray;
            }
        }

        private void txtApellido2_Enter(object sender, EventArgs e)
        {
            if (txtApellido2.Text == "Segundo Apellido...")
            {
                txtApellido2.Text = "";
                txtApellido2.ForeColor = Color.LightGray;
            }
        }

        private void txtNumeroTelefonico_Enter(object sender, EventArgs e)
        {
            if (txtNumeroTelefonico.Text == "Número Telefónico...")
            {
                txtNumeroTelefonico.Text = "";
                txtApellido2.ForeColor = Color.LightGray;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Correo Electrónico...")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.LightGray;
            }
        }

        private void txtApellido1_Leave(object sender, EventArgs e)
        {
            if (txtApellido1.Text == "")
            {
                txtApellido1.Text = "Primer Apellido...";
                txtApellido1.ForeColor = Color.Silver;
            }
        }

        private void txtApellido2_Leave(object sender, EventArgs e)
        {
            if (txtApellido2.Text == "")
            {
                txtApellido2.Text = "Segundo Apellido...";
                txtApellido2.ForeColor = Color.Silver;
            }
        }

        private void txtNumeroTelefonico_Leave(object sender, EventArgs e)
        {
            if (txtNumeroTelefonico.Text == "")
            {
                txtNumeroTelefonico.Text = "Número Telefónico...";
                txtNumeroTelefonico.ForeColor = Color.Silver;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Correo Electrónico...";
                txtEmail.ForeColor = Color.Silver;
            }
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            Loguin ventana = new Loguin();
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

        private void frmCrearUsuario_Activated(object sender, EventArgs e)
        {
            lblCrearUser.Focus();
            lblCrearUser.BringToFront();
        }

        private void frmCrearUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmCrearUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Contraseña...")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.Silver;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Contraseña...";
                txtPass.ForeColor = Color.Silver;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                BLL.UsuarioBLL logica = new BLL.UsuarioBLL();

                Entities.Usuario usuario = new Entities.Usuario();
                usuario.Nombre = txtNombre.Text;
                usuario.Apellido1 = txtApellido1.Text;
                usuario.Apellido2 = txtApellido2.Text;
                usuario.telefono = int.Parse(txtNumeroTelefonico.Text);
                usuario.email = txtEmail.Text;
                usuario.password = txtPass.Text;
                usuario.changePassword = false;
                if (rdbAdmin.Checked)
                {
                    usuario.tipo = Enums.TipoUsuario.administrador;
                }
                else
                {
                    usuario.tipo = Enums.TipoUsuario.cliente;
                }

                logica.Guardar(usuario);

                MessageBox.Show("Usuario guardado con éxito", "Certificaciones e Informes Digitales", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (ApplicationException appEx)
            {
                MessageBox.Show(appEx.Message, "Certificaciones e Informes Digitales", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no controlado: " + ex.Message, "Certificaciones e Informes Digitales", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
