using Certificaciones_e_Informes_Digitales.Util;
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
    public partial class frmRecuperarContra : Form
    {
        Utilities utilities;
        public frmRecuperarContra()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void button2_Click(object sender, EventArgs e)
        {
            Loguin ventana = new Loguin();
            ventana.Show();
            this.Hide();
        }

        private void frmRecuperarContra_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmRecuperarContra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSiguiente_Click(object senderw, EventArgs e)
        {
            try
            {
                BLL.UsuarioBLL logica = new BLL.UsuarioBLL();
                string contra;
                contra = utilities.contrasennaTemp();
                utilities.correoRecuperacion(txtEmail.Text, contra);

                logica.editarContrasenna(txtEmail.Text, contra, true);

                MessageBox.Show("Se ha enviado un correo con una contraseña temporal \n\nFavor regrese e ingrese a su perfil nuevamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error - "+ex.Message);
            }            
        }

        private void frmRecuperarContra_Load(object sender, EventArgs e)
        {
            utilities = new Utilities();
        }
    }
}
