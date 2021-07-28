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
    public partial class frmAgregarPersonasF : Form
    {
        public frmAgregarPersonasF()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Entities.PersonaFisica persona = new Entities.PersonaFisica();
                persona.id = txtid.Text;
                persona.Nombre = txtINombre.Text;
                persona.Apellido1 = txtApellido1.Text;
                persona.Apellido2 = txtApellido2.Text;
                persona.FechaNacimiento = CldFechaNac.SelectionStart;
                persona.genero = (Enums.Genero)cboGenero.SelectedItem;

                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                pcbFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                persona.Foto = ms.ToArray();
                persona.email = txtEmail.Text;

                BLL.PersonaFisicaBLL logica = new BLL.PersonaFisicaBLL();
                logica.Guardar(persona);
                MessageBox.Show("Persona Agregada correctamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnBuscarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog foto = new OpenFileDialog();
            DialogResult dialogResult = foto.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                pcbFoto.Image = Image.FromFile(foto.FileName);
            }
        }

        private void frmAgregarPersonasF_Load(object sender, EventArgs e)
        {
            cboGenero.DataSource = Enum.GetValues(typeof(Enums.Genero));
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAgregarPersonasF_Activated(object sender, EventArgs e)
        {
            cboGenero.DataSource = Enum.GetValues(typeof(Enums.Genero));
        }
    }
}
