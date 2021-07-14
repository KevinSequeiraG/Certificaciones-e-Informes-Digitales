﻿using Certificaciones_e_Informes_Digitales.Enums;
using System;
using System.Collections.Generic;
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
        public List<string> lstTiposCert()
        {
            List<string> lista = new List<string>();
            lista.Add("Catastro");
            lista.Add("Personas Juridicas");
            lista.Add("Bienes Muebles");
            lista.Add("Bienes Inmuebles");
            return lista;
        }

        public List<string> lstProvincias()
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
        public void correoRecuperacion(string correoAenviar, string contra)
        {
            MailMessage mensaje = new MailMessage();
            mensaje.IsBodyHtml = true;
            mensaje.Subject = "Contranseña Temporal";
            mensaje.Body = "La contraseña temporal para acceder a su cuenta es: "+contra;
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
    }

}