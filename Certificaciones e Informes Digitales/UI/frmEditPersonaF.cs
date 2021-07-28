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
    public partial class frmEditPersonaF : Form
    {
        BLL.PersonaFisicaBLL logica;
        public frmEditPersonaF()
        {
            InitializeComponent();
        }

        private void frmEditPersonaF_Load(object sender, EventArgs e)
        {
            logica = new BLL.PersonaFisicaBLL();
            Entities.PersonaFisica persona = logica.VerPorID(frmGestion.IdP);
            cboGenero.DataSource = Enum.GetValues(typeof(Enums.Genero));

            txtEmail.Text = persona.email;
            txtApellido1.Text = persona.Apellido1;
            txtApellido2.Text = persona.Apellido2;
            txtid.Text = persona.id;
            txtINombre.Text = persona.Nombre;
            CldFechaNac.SelectionStart = persona.FechaNacimiento;
            cboGenero.SelectedItem = persona.genero;

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            ImageConverter converter = new ImageConverter();
            pcbFoto.Image = (Image)converter.ConvertFrom(persona.Foto);

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream(); 
            pcbFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            logica.Editar(txtid.Text,txtINombre.Text, txtApellido1.Text,txtApellido2.Text,CldFechaNac.SelectionStart,(Enums.Genero)cboGenero.SelectedItem, ms.ToArray(),txtEmail.Text);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
