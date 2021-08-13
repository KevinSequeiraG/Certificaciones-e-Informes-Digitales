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
    public partial class frmHistorial : Form
    {
        public frmHistorial()
        {
            InitializeComponent();
        }

        private void frmHistorial_Load(object sender, EventArgs e)
        {
            BLL.HistorialBLL logica = new BLL.HistorialBLL();
            dataGridView1.DataSource = logica.VerHistorialUsuario(Util.UsuarioSingleton.GetInstance().email);
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.qr.Width;
                var h = Properties.Resources.qr.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) /2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) /2;

                e.Graphics.DrawImage(Properties.Resources.qr, new Rectangle(x, y, w-1, h-1));
                e.Handled = true;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmUsuario ventana = new frmUsuario();
            ventana.Show();
            this.Hide();
        }

        private void btnEnviarPdf_Click(object sender, EventArgs e)
        {
            try
            {
                Entities.Historial hist = (Entities.Historial)dataGridView1.SelectedRows[0].DataBoundItem;
                if (hist.fecha.Date < DateTime.Now.AddMonths(-1).Date)
                {
                    throw new ApplicationException("Ya vencio el mes valido para generar el PDF");
                }
                else
                {
                    Util.Utilities.EnviarPDFCorreo(Util.UsuarioSingleton.GetInstance().email, hist.pdf, hist.id);
                    MessageBox.Show("Correo Enviado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void frmHistorial_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Entities.Historial hist = (Entities.Historial)dataGridView1.SelectedRows[0].DataBoundItem;
            frmQR ventana = new frmQR(hist.id.ToString());
            ventana.ShowDialog();
        }
    }
}
