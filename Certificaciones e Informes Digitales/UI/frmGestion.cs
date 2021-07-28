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
    public partial class frmGestion : Form
    {
        internal static int ID;
        internal static string IdP;
        public frmGestion()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtID.Text))
                {                    
                    if (frmGestiones.GestionSeleccionada == 1)
                    {
                        List<Entities.PersonaFisica> lista = new List<Entities.PersonaFisica>();
                        IdP = txtID.Text;
                        BLL.PersonaFisicaBLL logica = new BLL.PersonaFisicaBLL();
                        lista.Add(logica.VerPorID(IdP));
                        dgvGestion.DataSource = lista;
                        if (lista[0]==null)
                        {
                            MessageBox.Show("No existe una persona fisica con ese ID");
                            actualizaTabla();
                        }
                    }
                    else if (frmGestiones.GestionSeleccionada == 2)
                    {
                        List<Entities.PersonaJuridica> lista = new List<Entities.PersonaJuridica>();
                        IdP = txtID.Text;
                        BLL.PersonaJuridicaBLL logica = new BLL.PersonaJuridicaBLL();
                        lista.Add(logica.VerPorID(IdP));
                        dgvGestion.DataSource = lista;
                        if (lista[0]==null)
                        {
                            MessageBox.Show("No existe una persona juridica con ese ID");
                            actualizaTabla();
                        }
                    }
                    else if (frmGestiones.GestionSeleccionada == 3)
                    {
                        List<Entities.Certificacion> lista = new List<Entities.Certificacion>();
                        ID = Convert.ToInt32(txtID.Text);
                        BLL.CertificacionBLL logica = new BLL.CertificacionBLL();
                        lista.Add(logica.VerPorID(ID));
                        dgvGestion.DataSource = lista;
                        if (lista[0]==null)
                        {
                            MessageBox.Show("No existe una certificacion con ese ID");
                            actualizaTabla();
                        }
                    }
                    else if (frmGestiones.GestionSeleccionada == 4)
                    {
                        List<Entities.BienesInmuebles> lista = new List<Entities.BienesInmuebles>();
                        ID = Convert.ToInt32(txtID.Text);
                        BLL.BienInmuebleBLL logica = new BLL.BienInmuebleBLL();
                        lista.Add(logica.VerPorID(ID));
                        dgvGestion.DataSource = lista;
                        if (lista[0]==null)
                        {
                            MessageBox.Show("No existe un bien inmueble con ese ID");
                            actualizaTabla();
                        }
                    }
                    else if (frmGestiones.GestionSeleccionada == 5)
                    {
                        List<Entities.BienesMuebles> lista = new List<Entities.BienesMuebles>();
                        ID = Convert.ToInt32(txtID.Text);
                        BLL.BienMueleBLL logica = new BLL.BienMueleBLL();
                        lista.Add(logica.VerPorID(ID));
                        dgvGestion.DataSource = lista;
                        if (lista[0]==null)
                        {
                            MessageBox.Show("No existe un bien mueble con ese ID");
                            actualizaTabla();
                        }
                    }
                    else if (frmGestiones.GestionSeleccionada == 6)
                    {
                        List<Entities.Catastro> lista = new List<Entities.Catastro>();
                        ID = Convert.ToInt32(txtID.Text);
                        BLL.CatastroBLL logica = new BLL.CatastroBLL();
                        lista.Add(logica.VerPorID(ID));
                        dgvGestion.DataSource = lista;
                        if (lista[0]==null)
                        {
                            MessageBox.Show("No existe un catastro con ese ID");
                            actualizaTabla();
                        }
                    }
                    txtID.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmGestion_Load(object sender, EventArgs e)
        {
            actualizaTabla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (frmGestiones.GestionSeleccionada == 1)
            {
                frmAgregarPersonasF ventana = new frmAgregarPersonasF();
                ventana.ShowDialog();
            }
            else if (frmGestiones.GestionSeleccionada == 2)
            {
                frmAgregarPersonaJ ventana = new frmAgregarPersonaJ();
                ventana.ShowDialog();
            }
            else if (frmGestiones.GestionSeleccionada == 3)
            {
                frmAgregarCerts ventana = new frmAgregarCerts();
                ventana.ShowDialog();
            }
            else if (frmGestiones.GestionSeleccionada == 4)
            {
                frmAgregarBienInmueble ventana = new frmAgregarBienInmueble();
                ventana.ShowDialog();
            }
            else if (frmGestiones.GestionSeleccionada == 5)
            {
                frmAgregarBienMueble ventana = new frmAgregarBienMueble();
                ventana.ShowDialog();
            }
            else if (frmGestiones.GestionSeleccionada == 6)
            {
                frmAgregarCatastro ventana = new frmAgregarCatastro();
                ventana.ShowDialog();
            }
        }

        private void frmGestion_Activated(object sender, EventArgs e)
        {
            actualizaTabla();
        }

        private void actualizaTabla()
        {
            if (frmGestiones.GestionSeleccionada == 1 || frmGestiones.GestionSeleccionada == 2)
            {
                lblID.Text = "Id de Persona:";
                if (frmGestiones.GestionSeleccionada == 1)
                {
                    BLL.PersonaFisicaBLL logica = new BLL.PersonaFisicaBLL();
                    dgvGestion.DataSource = logica.Ver();
                    ((DataGridViewImageColumn)dgvGestion.Columns[6]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
                if (frmGestiones.GestionSeleccionada == 2)
                {
                    BLL.PersonaJuridicaBLL logica = new BLL.PersonaJuridicaBLL();
                    dgvGestion.DataSource = logica.Ver();
                }
            }
            else if (frmGestiones.GestionSeleccionada == 3)
            {
                BLL.CertificacionBLL logica = new BLL.CertificacionBLL();
                lblID.Text = "Id de Certificación:";
                dgvGestion.DataSource = logica.Ver();
            }
            else if (frmGestiones.GestionSeleccionada == 4)
            {
                BLL.BienInmuebleBLL logica = new BLL.BienInmuebleBLL();
                lblID.Text = "Id del bien inmueble:";
                dgvGestion.DataSource = logica.Ver();
            }
            else if (frmGestiones.GestionSeleccionada == 5)
            {
                BLL.BienMueleBLL logica = new BLL.BienMueleBLL();
                lblID.Text = "Id del bien mueble:";
                dgvGestion.DataSource = logica.Ver();
            }
            else if (frmGestiones.GestionSeleccionada == 6)
            {
                BLL.CatastroBLL logica = new BLL.CatastroBLL();
                lblID.Text = "Id del catastro:";
                dgvGestion.DataSource = logica.Ver();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (frmGestiones.GestionSeleccionada == 1 || frmGestiones.GestionSeleccionada == 2)
            {
                if (frmGestiones.GestionSeleccionada == 1)
                {
                    BLL.PersonaFisicaBLL logica = new BLL.PersonaFisicaBLL(); 
                    
                    DialogResult result = MessageBox.Show("Seguro que desea eliminar la persona con el ID: " + dgvGestion.SelectedRows[0].Cells[0].Value.ToString() + "? ", "Eliminar Usuario", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        logica.Eliminar(dgvGestion.SelectedRows[0].Cells[0].Value.ToString());
                    }
                }
                if (frmGestiones.GestionSeleccionada == 2)
                {
                    BLL.PersonaJuridicaBLL logica = new BLL.PersonaJuridicaBLL();
                    DialogResult result = MessageBox.Show("Seguro que desea eliminar la persona con el ID: " + dgvGestion.SelectedRows[0].Cells[0].Value.ToString() + "? ", "Eliminar Usuario", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        logica.Eliminar(dgvGestion.SelectedRows[0].Cells[0].Value.ToString());
                    }
                }
            }
            else if (frmGestiones.GestionSeleccionada == 3)
            {
                BLL.CertificacionBLL logica = new BLL.CertificacionBLL();
                DialogResult result = MessageBox.Show("Seguro que desea eliminar la certificacion con el ID: " + dgvGestion.SelectedRows[0].Cells[0].Value.ToString() + "? ", "Eliminar Usuario", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    logica.Eliminar(Convert.ToInt32(dgvGestion.SelectedRows[0].Cells[0].Value));
                }
            }
            else if (frmGestiones.GestionSeleccionada == 4)
            {
                BLL.BienInmuebleBLL logica = new BLL.BienInmuebleBLL();
                DialogResult result = MessageBox.Show("Seguro que desea eliminar el bien inmueble con el ID: " + dgvGestion.SelectedRows[0].Cells[0].Value.ToString() + "? ", "Eliminar Usuario", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    logica.Eliminar(Convert.ToInt32(dgvGestion.SelectedRows[0].Cells[0].Value));
                }
            }
            else if (frmGestiones.GestionSeleccionada == 5)
            {
                BLL.BienMueleBLL logica = new BLL.BienMueleBLL();
                DialogResult result = MessageBox.Show("Seguro que desea eliminar el bien mueble con el ID: " + dgvGestion.SelectedRows[0].Cells[0].Value.ToString() + "? ", "Eliminar Usuario", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    logica.Eliminar(Convert.ToInt32(dgvGestion.SelectedRows[0].Cells[0].Value));
                }
            }
            else if (frmGestiones.GestionSeleccionada == 6)
            {
                BLL.CatastroBLL logica = new BLL.CatastroBLL();
                DialogResult result = MessageBox.Show("Seguro que dese eliminar el catastro con el ID: " + dgvGestion.SelectedRows[0].Cells[0].Value.ToString() + "? ", "Eliminar Usuario", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    logica.Eliminar(Convert.ToInt32(dgvGestion.SelectedRows[0].Cells[0].Value));
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (frmGestiones.GestionSeleccionada == 1 || frmGestiones.GestionSeleccionada == 2)
                {
                    IdP = dgvGestion.SelectedRows[0].Cells[0].Value.ToString();
                }
                else
                {
                    ID = Convert.ToInt32(dgvGestion.SelectedRows[0].Cells[0].Value);
                }

                if (frmGestiones.GestionSeleccionada == 1)
                {
                    frmEditPersonaF ventana = new frmEditPersonaF();
                    ventana.ShowDialog();
                }
                else if (frmGestiones.GestionSeleccionada == 2)
                {
                    frmEditPersonaJ ventana = new frmEditPersonaJ();
                    ventana.ShowDialog();
                }
                else if (frmGestiones.GestionSeleccionada == 3)
                {
                    frmEditCert ventana = new frmEditCert();
                    ventana.ShowDialog();
                }
                else if (frmGestiones.GestionSeleccionada == 4)
                {
                    frmEditBienInmueble ventana = new frmEditBienInmueble();
                    ventana.ShowDialog();
                }
                else if (frmGestiones.GestionSeleccionada == 5)
                {
                    frmEditBienMueble ventana = new frmEditBienMueble();
                    ventana.ShowDialog();
                }
                else if (frmGestiones.GestionSeleccionada == 6)
                {
                    frmEditCatastro ventana = new frmEditCatastro();
                    ventana.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
