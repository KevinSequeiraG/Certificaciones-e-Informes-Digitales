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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void btnGestiones_Click(object sender, EventArgs e)
        {
            frmCompra ventana = new frmCompra();
            ventana.Show();
            this.Hide();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {

            if (Util.UsuarioSingleton.GetInstance().changePassword)
            {
                frmNuevoPassword ventana = new frmNuevoPassword();
                ventana.ShowDialog();
            }
            BLL.CarritoBLL logicaCarro = new BLL.CarritoBLL();
            Entities.Carrito carro = new Entities.Carrito();
            carro.usuario = Util.UsuarioSingleton.GetInstance();
            carro.total = 0;
            carro.subtotal = 0;
            carro.impuestos = 0;
            carro.fecha = DateTime.Now;

            logicaCarro.Guardar(carro);
            carro = logicaCarro.VerUltimoCarrito(Util.UsuarioSingleton.GetInstance().email);//se llama de nuevo para conseguir el id del carro
            Util.CarritoSingleton.setCarro(carro);
        }

        private void tnVerificacion_Click(object sender, EventArgs e)
        {
            frmVerificacionCertis ventana = new frmVerificacionCertis();
            ventana.Show();
        }

        private void btnHistorialCerts_Click(object sender, EventArgs e)
        {
            frmHistorial ventana = new frmHistorial();
            ventana.Show();
            this.Hide();
        }
    }
}
