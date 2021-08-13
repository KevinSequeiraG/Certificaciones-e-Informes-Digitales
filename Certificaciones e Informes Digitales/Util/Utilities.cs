using Certificaciones_e_Informes_Digitales.Enums;
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Certificaciones_e_Informes_Digitales.Util
{
    class Utilities
    {
        /// <summary>
        /// Funcion para generar lista de todos los tipos de Certificacion
        /// </summary>
        /// <returns></returns>
        public static List<string> lstTiposCert()
        {
            List<string> lista = new List<string>();
            lista.Add("Catastro");
            lista.Add("Personas Juridicas");
            lista.Add("Bienes Muebles");
            lista.Add("Bienes Inmuebles");
            return lista;
        }
        /// <summary>
        /// Funcion para generar lista de todas las provincias de Costa Rica
        /// </summary>
        /// <returns></returns>
        public static List<string> lstProvincias()
        {
            List<string> lista = new List<string>();
            foreach (Provincia item in Enum.GetValues(typeof(Provincia)))
            {
                if (item == Provincia.SanJose)
                {
                    lista.Add("San José");
                }
                else
                {
                    lista.Add(item.ToString());
                }
            }
            return lista;
        }
        /// <summary>
        /// Funcion para generar lista de las posibles gestiones del administrador
        /// </summary>
        /// <returns></returns>
        public List<string> lstGestiones()
        {
            List<string> lista = new List<string>();
            foreach (Gestiones item in Enum.GetValues(typeof(Gestiones)))
            {
                if (item == Gestiones.BienesInmuebles)
                {
                    lista.Add("Bienes Inmuebles");
                }
                if (item == Gestiones.BienesMuebles)
                {
                    lista.Add("Bienes Muebles");
                }
                if (item == Gestiones.PersonasFisicas)
                {
                    lista.Add("Personas Físicas");
                }
                if (item == Gestiones.PersonasJuridicas)
                {
                    lista.Add("Personas Jurídicas");
                }
                if (item != Gestiones.BienesInmuebles && item != Gestiones.BienesMuebles && item != Gestiones.PersonasFisicas && item != Gestiones.PersonasJuridicas)
                {
                    lista.Add(item.ToString());
                }
            }
            return lista;
        }
        /// <summary>
        /// Funcion que envia correo con contraseña nueva para usuario especifico
        /// </summary>
        /// <param name="correoAenviar">Correo el cual sufrira el cambio de contraseña</param>
        /// <param name="contra">Nueva contraseña temporal</param>
        public void correoRecuperacion(string correoAenviar, string contra)
        {
            MailMessage mensaje = new MailMessage();
            mensaje.IsBodyHtml = true;
            mensaje.Subject = "Contranseña Temporal";
            mensaje.Body = "La contraseña temporal para acceder a su cuenta es: " + contra;
            mensaje.From = new MailAddress("ksgsendemails@gmail.com");
            mensaje.To.Add(correoAenviar);
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential("ksgsendemails@gmail.com", "ksg12345");
            smtp.EnableSsl = true;
            smtp.Send(mensaje);
        }
        /// <summary>
        /// Genera un string aleatorio para una contraseña temporal
        /// </summary>
        /// <returns></returns>
        public string contrasennaTemp()
        {
            string contraseña = string.Empty;
            string[] letras = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z",
                                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};
            Random EleccionAleatoria = new Random();

            for (int i = 0; i < 9; i++)
            {
                int LetraAleatoria = EleccionAleatoria.Next(0, 100);
                int NumeroAleatorio = EleccionAleatoria.Next(0, 9);

                if (LetraAleatoria < letras.Length)
                {
                    contraseña += letras[LetraAleatoria];
                }
                else
                {
                    contraseña += NumeroAleatorio.ToString();
                }
            }
            return contraseña;
        }
        /// <summary>
        /// Funcion que genera una lista de los tipos de resportes disponibles para el administrador
        /// </summary>
        /// <returns></returns>
        public static List<string> lstRReportes()
        {
            List<string> lista = new List<string>();
            lista.Add("Certificaciones por rango de fechas");
            lista.Add("Certificaciones vendidas en el último mes");
            lista.Add("Total de compras del último mes");
            return lista;
        }
        /// <summary>
        /// Funcion que permite enviar los certificados por correo
        /// </summary>
        /// <param name="correoAEnviar">Correo destinado</param>
        /// <param name="bytes">PDF convertido a bytes[]</param>
        /// <param name="idCertPDF">id de la certificacion</param>
        public static void EnviarPDFCorreo(string correoAEnviar, byte[] bytes, int idCertPDF)
        {
            using (var viewer = new LocalReport())
            {
                var correo = new MailMessage { From = new MailAddress("ksgsendemails@gmail.com", "Kevin Sequeira Garita") };

                correo.To.Add(new MailAddress(correoAEnviar, ""));
                correo.Subject = "Reporte como Correo";
                correo.Body = "El ID necesario en caso de querer buscar el PDF en su historial es el siguiente: " + idCertPDF;
                correo.Attachments.Add(new Attachment(new MemoryStream(bytes), "Registro Nacional.pdf"));

                using (var smtp = new SmtpClient("smtp.gmail.com"))
                {
                    smtp.Port = 587;
                    smtp.Credentials = new System.Net.NetworkCredential("ksgsendemails@gmail.com", "ksg12345");
                    smtp.EnableSsl = true;
                    smtp.Send(correo);
                }
            }
        }
        /// <summary>
        /// Funcion abre los frames ya que los loads de estos tienen las funciones necesarias para enviar la certificacion
        /// </summary>
        /// <param name="lineaDetalle">Lista de lineas de detalle</param>
        public static void EnviarCertificaciones(List<Entities.LineaDetalle> lineaDetalle)
        {
            try
            {
                foreach (Entities.LineaDetalle item in lineaDetalle)
                {
                    switch (item.idCert)
                    {
                        case 1:
                            for (int i = 0; i < item.cant; i++)
                            {
                                UI.Reportes.frmCertBienMueble logica = new UI.Reportes.frmCertBienMueble((item.idPersonaF != "" ? true : false), (item.idPersonaF != "" ? item.idPersonaF : item.idPersonaJ), item.idBien, item.DetalleCert);
                                logica.Show();
                                logica.Hide();
                            }
                            break;
                        case 2:
                            for (int i = 0; i < item.cant; i++)
                            {
                                UI.Reportes.frmCertBienInmueblePersonaF logicaBienI = new UI.Reportes.frmCertBienInmueblePersonaF((item.idPersonaF != "" ? true : false), (item.idPersonaF != "" ? item.idPersonaF : item.idPersonaJ), item.idBien, item.DetalleCert);
                                logicaBienI.Show();
                                logicaBienI.Hide();
                            }
                            break;
                        case 3:
                            for (int i = 0; i < item.cant; i++)
                            {
                                UI.Reportes.frmCertPersoneriaJuridica logicaPersona = new UI.Reportes.frmCertPersoneriaJuridica(item.idPersonaJ, item.DetalleCert);
                                logicaPersona.Show();
                                logicaPersona.Hide();
                            }
                            break;
                        case 4:
                            for (int i = 0; i < item.cant; i++)
                            {
                                UI.Reportes.frmCertCatastro logicaCat = new UI.Reportes.frmCertCatastro((item.idPersonaF != "" ? true : false), (item.idPersonaF != "" ? item.idPersonaF : item.idPersonaJ), item.idBien, item.DetalleCert);
                                logicaCat.Show();
                                logicaCat.Hide();
                            }
                            break;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Funcion que genera Codigo QR de un string
        /// </summary>
        /// <param name="CodigoCert">Codigo a convertir en QR</param>
        /// <returns></returns>
        public static Bitmap VerQR(string CodigoCert)
        {
            QrEncoder qrEncoder = new QrEncoder();
            QrCode qrCode = new QrCode();
            qrEncoder.TryEncode(CodigoCert, out qrCode);
            GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero), Brushes.Black, Brushes.White);
            MemoryStream ms = new MemoryStream();
            renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
            var imageTemporal = new Bitmap(ms);
            var imagen = new Bitmap(imageTemporal, new Size(new Point(200, 200)));
            return imagen;
        }
        /// <summary>
        /// Convierte una imagen en un array de Bytes
        /// </summary>
        /// <param name="img">Imagen a convertir</param>
        /// <returns></returns>
        public static Byte[] ImageToByteArray(Image img)
        {
            using (var stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }
    }
}
