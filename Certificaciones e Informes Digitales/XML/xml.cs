using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Xml;

namespace Certificaciones_e_Informes_Digitales.XML
{
    class xml
    {
        public void GenerarXml(Entities.Usuario receptor, Entities.Carrito carro, List<Entities.LineaDetalle> listaDetalles)
        {
            XmlDocument doc = new XmlDocument();

            // LoadXml carga un string con formato xml
            doc.LoadXml("<FacturaElectronica></FacturaElectronica>");

            XmlElement root = doc.DocumentElement;
            
            //Emisor
            XmlElement emisor = doc.CreateElement("Emisor");
            root.AppendChild(emisor);

            //NombreEmisor
            XmlElement NombreEmisor = doc.CreateElement("Nombre");
            NombreEmisor.InnerText = "Registro Nacional de Costa Rica";
            emisor.AppendChild(NombreEmisor);

            //Identificacion
            XmlElement IdentificacionEmisor = doc.CreateElement("Identificacion");
            emisor.AppendChild(IdentificacionEmisor);

            //Tipo Identificacion
            XmlElement TipoIdeEmisor = doc.CreateElement("Tipo");
            TipoIdeEmisor.InnerText = "Local";
            IdentificacionEmisor.AppendChild(TipoIdeEmisor);

            //Tipo Identificacion
            XmlElement NumeroIdeEmisor = doc.CreateElement("Numero");
            NumeroIdeEmisor.InnerText = "117370294";
            IdentificacionEmisor.AppendChild(NumeroIdeEmisor);

            //UbicacionEmisor
            XmlElement Ubicacion = doc.CreateElement("Ubicacion");
            emisor.AppendChild(Ubicacion);

            //Provincia
            XmlElement ProvinciaEmisor = doc.CreateElement("Provincia");
            ProvinciaEmisor.InnerText = "Alajuela";
            Ubicacion.AppendChild(ProvinciaEmisor);

            //Canton
            XmlElement CantonEmisor = doc.CreateElement("Canton");
            CantonEmisor.InnerText = "Alajuela";
            Ubicacion.AppendChild(CantonEmisor);

            //Distrito
            XmlElement DistritoEmisor = doc.CreateElement("Distrito");
            DistritoEmisor.InnerText = "San Jose";
            Ubicacion.AppendChild(DistritoEmisor);

            //OtrasSenas
            XmlElement OtrasSenasEmisor = doc.CreateElement("OtrasSenas");
            OtrasSenasEmisor.InnerText = "200m de la entrada de la Urb. Monte Rocoso";
            Ubicacion.AppendChild(OtrasSenasEmisor);

            //Telefono
            XmlElement telefonoEmisor = doc.CreateElement("Telefono");
            emisor.AppendChild(telefonoEmisor);

            //Codigo Pais Telefono
            XmlElement CodigoPaisEmisor = doc.CreateElement("CodigoPais");
            CodigoPaisEmisor.InnerText = "506";
            telefonoEmisor.AppendChild(CodigoPaisEmisor);

            //Telefono de emisor
            XmlElement NumTelefonoEmisor = doc.CreateElement("NumTelefono");
            NumTelefonoEmisor.InnerText = "84525658";
            telefonoEmisor.AppendChild(NumTelefonoEmisor);

            //CorreoElectronico
            XmlElement CorreoEmisor = doc.CreateElement("CorreoElectronico");
            CorreoEmisor.InnerText = "ksgsendemails@gmail.com";
            emisor.AppendChild(CorreoEmisor);

            //Receptor
            XmlElement Receptor = doc.CreateElement("Receptor");
            root.AppendChild(Receptor);

            //Nombre Receptor
            XmlElement NombreReceptor = doc.CreateElement("Nombre");
            NombreReceptor.InnerText = receptor.Nombre + " " + receptor.Apellido1 +" " + receptor.Apellido2;
            Receptor.AppendChild(NombreReceptor);

            //Telefono Receptor
            XmlElement telefonoReceptor = doc.CreateElement("Telefono");
            Receptor.AppendChild(telefonoReceptor);

            //NumTelefono Receptor
            XmlElement NumTelefonoReceptor = doc.CreateElement("NumTelefono");
            NumTelefonoReceptor.InnerText = receptor.telefono.ToString();
            telefonoReceptor.AppendChild(NumTelefonoReceptor);

            //CorreoElectronico
            XmlElement CorreoReceptor = doc.CreateElement("CorreoElectronico");
            CorreoReceptor.InnerText = receptor.email;
            Receptor.AppendChild(CorreoReceptor);

            //Carrito
            XmlElement Carrito = doc.CreateElement("Carrito");
            Carrito.SetAttribute("idCarrito", carro.id.ToString());
            Carrito.SetAttribute("fecha", carro.fecha.Date.ToString());
            root.AppendChild(Carrito);

            //Lineas de Detalle
            XmlElement lineasDeDetalle = doc.CreateElement("LineasDetalle");
            Carrito.AppendChild(lineasDeDetalle);

            //llenar las lineas
            foreach (Entities.LineaDetalle linea in listaDetalles)
            {
                //Linea de detalle
                XmlElement lineaDetalle = doc.CreateElement("LineaDetalle");
                lineaDetalle.SetAttribute("idLineaDetalle", linea.id.ToString());
                lineasDeDetalle.AppendChild(lineaDetalle);

                //Certificacion comprada
                XmlElement Certificacion = doc.CreateElement("Certificacion");
                Certificacion.SetAttribute("TipoCertificacion", linea.TipoCert);
                lineaDetalle.AppendChild(Certificacion);

                //Detalle Certificacion
                XmlElement DetalleCertificacion = doc.CreateElement("DetalleCertificacion");
                DetalleCertificacion.InnerText= linea.DetalleCert.ToString();
                lineaDetalle.AppendChild(DetalleCertificacion);

                //Precio Certificacion
                XmlElement PrecioCertificacion = doc.CreateElement("PrecioCertificacion");
                PrecioCertificacion.InnerText = linea.PrecioCert.ToString();
                lineaDetalle.AppendChild(PrecioCertificacion);
            }

            //SubTotal carrito
            XmlElement subTotalCarrito = doc.CreateElement("Subtotal");
            subTotalCarrito.SetAttribute("Subtotal", carro.subtotal.ToString());
            Carrito.AppendChild(subTotalCarrito);

            //Impuestos carrito
            XmlElement ImpuestosDetalle = doc.CreateElement("Impuestos");
            ImpuestosDetalle.SetAttribute("Impuestos", carro.impuestos.ToString());
            Carrito.AppendChild(ImpuestosDetalle);

            //Total carrito
            XmlElement TotalDetalle = doc.CreateElement("TotalConImpuestos");
            TotalDetalle.SetAttribute("TotalConImpuestos", carro.total.ToString());
            Carrito.AppendChild(TotalDetalle);

            CspParameters cspParams = new CspParameters();
            cspParams.KeyContainerName = "XML_DSIG_RSA_KEY";

            RSACryptoServiceProvider rsaKey = new RSACryptoServiceProvider(cspParams);
            SignXml(doc, rsaKey);

            BLL.CarritoBLL logicaCarro = new BLL.CarritoBLL();
            logicaCarro.ActualizaXmlDeCarro(Util.CarritoSingleton.GetInstance().id, doc.OuterXml);

            doc.Save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\BoletosXml.xml");
        }

        public static void SignXml(XmlDocument xmlDoc, RSA rsaKey)
        {
            // Check arguments.
            if (xmlDoc == null)
                throw new ArgumentException(nameof(xmlDoc));
            if (rsaKey == null)
                throw new ArgumentException(nameof(rsaKey));

            // Create a SignedXml object.
            SignedXml signedXml = new SignedXml(xmlDoc);

            // Add the key to the SignedXml document.
            signedXml.SigningKey = rsaKey;

            // Create a reference to be signed.
            Reference reference = new Reference();
            reference.Uri = "";

            // Add an enveloped transformation to the reference.
            XmlDsigEnvelopedSignatureTransform env = new XmlDsigEnvelopedSignatureTransform();
            reference.AddTransform(env);

            // Add the reference to the SignedXml object.
            signedXml.AddReference(reference);

            // Compute the signature.
            signedXml.ComputeSignature();

            // Get the XML representation of the signature and save
            // it to an XmlElement object.
            XmlElement xmlDigitalSignature = signedXml.GetXml();

            // Append the element to the XML document.
            xmlDoc.DocumentElement.AppendChild(xmlDoc.ImportNode(xmlDigitalSignature, true));
        }
    }
}
