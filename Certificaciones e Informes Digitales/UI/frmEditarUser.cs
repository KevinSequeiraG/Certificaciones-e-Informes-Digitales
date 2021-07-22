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
    public partial class frmEditarUser : Form
    {
        BLL.UsuarioBLL logica;
        public frmEditarUser()
        {
            InitializeComponent();
        }

        private void frmEditarUser_Load(object sender, EventArgs e)
        {
            logica = new BLL.UsuarioBLL();
            if (!string.IsNullOrEmpty(frmGestionUsuario.email))
            {
                Entities.Usuario user = logica.TraerUsuarioPorCorreo(frmGestionUsuario.email)[0];

                txtName.Text = user.Nombre;
                txtApellido1.Text = user.Apellido1;
                txtApellido2.Text = user.Apellido2;
                txtNumeroTelefonico.Text = user.telefono.ToString();
                txtPass.Text = user.password;
                if (user.tipo == Enums.TipoUsuario.administrador)
                {
                    rdbAdmin.Checked = true;
                }
                else
                {
                    rdbCliente.Checked = true;
                }
            }
            else
            {
                txtName.Text = frmGestionUsuario.usuarioEscogido.Nombre;
                txtApellido1.Text = frmGestionUsuario.usuarioEscogido.Apellido1;
                txtApellido2.Text = frmGestionUsuario.usuarioEscogido.Apellido2;
                txtNumeroTelefonico.Text = frmGestionUsuario.usuarioEscogido.telefono.ToString();
                txtPass.Text = frmGestionUsuario.usuarioEscogido.password;
                if (frmGestionUsuario.usuarioEscogido.tipo == Enums.TipoUsuario.administrador)
                {
                    rdbAdmin.Checked = true;
                }
                else
                {
                    rdbCliente.Checked = true;
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                logica.editarUsuario(txtName.Text, txtApellido1.Text, txtApellido2.Text, Convert.ToInt32(txtNumeroTelefonico.Text), frmGestionUsuario.usuarioEscogido.email, txtPass.Text, false, (rdbAdmin.Checked?Enums.TipoUsuario.administrador: Enums.TipoUsuario.cliente));
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
