using Certificaciones_e_Informes_Digitales.Enums;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.Util
{
    class Utilities
    {
        public static List<string> lstTiposCert()
        {
            List<string> lista = new List<string>();
            lista.Add("Catastro");
            lista.Add("Personas Juridicas");
            lista.Add("Bienes Muebles");
            lista.Add("Bienes Inmuebles");
            return lista;
        }

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
        public static List<string> lstRReportes()
        {
            List<string> lista = new List<string>();
            lista.Add("Certificaciones por rango de fechas");
            lista.Add("Certificaciones vendidas en el último mes");
            lista.Add("Total de compras del último mes");
            return lista;
        }

        public static void EnviarPDFCorreo(string correoAEnviar, byte[] bytes)
        {
            using (var viewer = new LocalReport())
            {
                var correo = new MailMessage { From = new MailAddress("ksgsendemails@gmail.com", "Kevin Sequeira Garita") };

                correo.To.Add(new MailAddress(correoAEnviar, ""));
                correo.Subject = "Reporte como Correo";
                correo.Attachments.Add(new Attachment(new MemoryStream(bytes), "Reporte.pdf"));

                using (var smtp = new SmtpClient("smtp.gmail.com"))
                {
                    smtp.Port = 587;
                    smtp.Credentials = new System.Net.NetworkCredential("ksgsendemails@gmail.com", "ksg12345");
                    smtp.EnableSsl = true;
                    smtp.Send(correo);
                }

                Console.WriteLine("Correo enviado");
            }
        }
    }
}
