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
    public partial class frmNombramiento : Form
    {
        BLL.NombramientoBLL logica;
        internal static int idN;
        public frmNombramiento()
        {
            InitializeComponent();
            menuStrip1.Renderer = new MyRenderer();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarNombramiento ventana = new frmAgregarNombramiento();
            ventana.ShowDialog();
            dgvNombramiento.DataSource = logica.VerPorIDPersona(frmGestion.IdP);
        }

        private void frmAgregarNombramiento_Load(object sender, EventArgs e)
        {
            logica = new BLL.NombramientoBLL();
            dgvNombramiento.DataSource = logica.VerPorIDPersona(frmGestion.IdP);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            idN = Convert.ToInt32(dgvNombramiento.SelectedRows[0].Cells[0].Value);
            frmEditNombramiento ventana = new frmEditNombramiento();
            ventana.ShowDialog();
            dgvNombramiento.DataSource = logica.VerPorIDPersona(frmGestion.IdP);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            idN = Convert.ToInt32(dgvNombramiento.SelectedRows[0].Cells[0].Value);
            logica.Eliminar(idN);
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Loguin ventana = new Loguin();
            ventana.Show();
            this.Hide();
        }

        private void cambiarContraseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevoPassword ventana = new frmNuevoPassword();
            ventana.ShowDialog();
        }
    }
}
