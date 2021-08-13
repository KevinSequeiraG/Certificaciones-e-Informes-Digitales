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
            ventana.ShowDialog();
        }

        private void btnHistorialCerts_Click(object sender, EventArgs e)
        {
            frmHistorial ventana = new frmHistorial();
            ventana.Show();
            this.Hide();
        }

        private void picMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            BLL.CarritoBLL logicaCarro = new BLL.CarritoBLL();
            if (Util.CarritoSingleton.GetInstance().total == 0)
            {
                logicaCarro.Eliminar(Util.CarritoSingleton.GetInstance().id);
            }
            Application.Exit();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Loguin loguin = new Loguin();
            loguin.Show();
            this.Hide();
        }

        private void cambiarContraseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevoPassword ventana = new frmNuevoPassword();
            ventana.ShowDialog();
        }

        private void btnGestiones_MouseEnter(object sender, EventArgs e)
        {
            btnGestiones.BackColor = Color.IndianRed;
        }

        private void btnGestiones_MouseLeave(object sender, EventArgs e)
        {
            btnGestiones.BackColor = Color.Transparent;
        }

        private void tnVerificacion_MouseEnter(object sender, EventArgs e)
        {
            tnVerificacion.BackColor = Color.IndianRed;
        }

        private void tnVerificacion_MouseLeave(object sender, EventArgs e)
        {
            tnVerificacion.BackColor = Color.Transparent;
        }

        private void btnHistorialCerts_MouseEnter(object sender, EventArgs e)
        {
            btnHistorialCerts.BackColor = Color.IndianRed;
        }

        private void btnHistorialCerts_MouseLeave(object sender, EventArgs e)
        {
            btnHistorialCerts.BackColor = Color.Transparent;
        }

        private void frmUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
