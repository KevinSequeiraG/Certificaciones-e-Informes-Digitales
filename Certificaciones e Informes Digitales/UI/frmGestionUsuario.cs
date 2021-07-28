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
    public partial class frmGestionUsuario : Form
    {
        BLL.UsuarioBLL logica;
        
        public frmGestionUsuario()
        {
            InitializeComponent();
            logica = new BLL.UsuarioBLL();
        }
        internal static Entities.Usuario usuarioEscogido;
        internal static string email;
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtCorreo.Text))
                {
                    dgvUsuario.DataSource = logica.TraerUsuarioPorCorreo(txtCorreo.Text);
                    if(dgvUsuario.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("No existe un usuario con ese correo electronico");
                        dgvUsuario.DataSource = logica.VerUsuarios();
                    }
                    txtCorreo.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCorreo.Text))
            {
                email = txtCorreo.Text;
            }
            frmEditarUser ventana = new frmEditarUser();
            ventana.Activate();
            ventana.Show();

            email = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCorreo.Text))
                {
                    DialogResult result = MessageBox.Show("Seguro que dese eliminar el usuario de correo: " + usuarioEscogido.email +  "? ", "Eliminar Usuario", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        logica.EliminarUsuario(usuarioEscogido.email);
                        dgvUsuario.DataSource = logica.VerUsuarios();
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Seguro que dese eliminar el usuario de correo: " + txtCorreo.Text + "? ", "Eliminar Usuario", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        logica.EliminarUsuario(txtCorreo.Text);
                        dgvUsuario.DataSource = logica.VerUsuarios();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvUsuario_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuario.SelectedRows.Count > 0)
            {
                usuarioEscogido = (Entities.Usuario)dgvUsuario.SelectedRows[0].DataBoundItem;
            }
        }

        private void frmGestionUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                dgvUsuario.DataSource = logica.VerUsuarios();
                dgvUsuario.Columns[6].Visible = false;
                dgvUsuario.Columns[4].Width = 200;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
