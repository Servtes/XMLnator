using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

/* Clase creada para la validacion de XML, si esta es verdadera procede a leer el XML para luego 
 * guardar un Texto Plano sin etiquetas
 * Autor: Jose Carlos Sosa Mejia
 *
 */

namespace XMLNator
{
    class ValidarArchivos
    {
        public void Xml(string ruta)
        {
            #region Declaracion de Variables que se enviaran por Parametro a la clase "botonguardar"

            /*Seccion de Encabezado*/
            string codigoProducto = @"";
            string nombreProducto = @"";
            string codigoPoliza = @"";
            string numeroPoliza = @"";
            string vigenciaInicial = @"";
            string vigenciaFinal = @"";
            string contratanteNombre = @"";
            string contratanteNit = @"";
            string contratanteDireccion = @"";
            string direccionCobro = @"";
            string aseguradoNombre = @"";
            string aseguradoApellido = @"";

            /*Seccion Detalles del Certificado*/
            string numeroCertificado = "";
            string nombreCertificado = "";
            string sumaAsegurada = "";
            string marca = "";
            string modelo = "";
            string linea = "";
            string chasis = "";
            string placas = "";
            string cobertura1 = "";
            string cobertura2 = "";
            string cobertura3 = "";

            #endregion

             try
            {
            var xml = new XmlTextReader(ruta);
            var documentoXml = new XmlDocument();
            var reader = new XmlValidatingReader(xml);
            documentoXml.Load(reader);

            XmlNodeList listaProductos = documentoXml.GetElementsByTagName("producto");
            foreach (XmlElement nodo in listaProductos)
            {
                XmlNodeList codigo = nodo.GetElementsByTagName("codigo");
                codigoProducto = codigo[0].InnerText;
                XmlNodeList nombre = nodo.GetElementsByTagName("nombre");
                nombreProducto = nombre[0].InnerText;
            }
            XmlNodeList poliza = documentoXml.GetElementsByTagName("poliza");
            foreach (XmlElement nodo in poliza)
            {

                XmlNodeList pnumero = nodo.GetElementsByTagName("pnumero");
                numeroPoliza = pnumero[0].InnerText;
                XmlNodeList pcodigo = nodo.GetElementsByTagName("pcodigo");
                codigoPoliza = pcodigo[0].InnerText;
            }

            XmlNodeList vigencia = documentoXml.GetElementsByTagName("vigencia");
            foreach (XmlElement nodo in vigencia)
            {
                XmlNodeList inicial = nodo.GetElementsByTagName("inicial");
                XmlNodeList final = nodo.GetElementsByTagName("final");
                vigenciaInicial = inicial[0].InnerText;
                vigenciaFinal = final[0].InnerText;
            }

            XmlNodeList contratante = documentoXml.GetElementsByTagName("contratante");
            foreach(XmlElement nodo in contratante)
            {
                XmlNodeList nombre = nodo.GetElementsByTagName("cnombre");
                contratanteNombre = nombre[0].InnerText;
                XmlNodeList nit = nodo.GetElementsByTagName("nit");
                contratanteNit = nit[0].InnerText;
            }
                       
            XmlNodeList dir = documentoXml.GetElementsByTagName("direccion");
            foreach (XmlElement nodoDir in dir)
            {
                XmlNodeList contratanteDir = nodoDir.GetElementsByTagName("dcontratante");
                contratanteDireccion = contratanteDir[0].InnerText;
                XmlNodeList cobroDir = nodoDir.GetElementsByTagName("cobro");
                direccionCobro = cobroDir[0].InnerText;
            }

            XmlNodeList asegurado = documentoXml.GetElementsByTagName("asegurado");
            foreach (XmlElement nodoDir in asegurado)
            {
                XmlNodeList anombre = nodoDir.GetElementsByTagName("anombre");
                aseguradoNombre = anombre[0].InnerText;
                XmlNodeList apellido = nodoDir.GetElementsByTagName("apellido");
                aseguradoApellido = apellido[0].InnerText;
            }

            XmlNodeList certificado = documentoXml.GetElementsByTagName("certificado");
            foreach (XmlElement nodoDir in certificado)
            {
                XmlNodeList enombre = nodoDir.GetElementsByTagName("enombre");
                nombreCertificado = enombre[0].InnerText;
                XmlNodeList numero = nodoDir.GetElementsByTagName("numero");
                numeroCertificado = numero[0].InnerText;
                XmlNodeList csuma = nodoDir.GetElementsByTagName("suma");
                sumaAsegurada = csuma[0].InnerText;
            }

            XmlNodeList vehiculo = documentoXml.GetElementsByTagName("vehiculo");
            foreach (XmlElement nodoDir in vehiculo)
            {
                XmlNodeList vmarca = nodoDir.GetElementsByTagName("marca");
                marca = vmarca[0].InnerText;
                XmlNodeList vmodelo = nodoDir.GetElementsByTagName("modelo");
                modelo = vmodelo[0].InnerText;
                XmlNodeList vlinea = nodoDir.GetElementsByTagName("linea");
                linea = vlinea[0].InnerText;
                XmlNodeList vchasis = nodoDir.GetElementsByTagName("chasis");
                chasis = vchasis[0].InnerText;
                XmlNodeList vplacas = nodoDir.GetElementsByTagName("placas");
                placas = vplacas[0].InnerText;

                XmlNodeList vcobertura1 = nodoDir.GetElementsByTagName("cobertura1");
                cobertura1 = vcobertura1[0].InnerText;
                XmlNodeList vcobertura2 = nodoDir.GetElementsByTagName("cobertura2");
                cobertura2 = vcobertura2[0].InnerText;
                XmlNodeList vcobertura3 = nodoDir.GetElementsByTagName("cobertura3");
                cobertura3 = vcobertura3[0].InnerText;
            }

            var guardarTexto = new SaveFileDialog
            {
                Filter = "Archivos de Texto|*.txt",
                RestoreDirectory = true,
                Title = "Guardar Fichero de Salida"
            };

            var archivoSalida = new Botonguardar();
            switch (guardarTexto.ShowDialog())
            {
                case DialogResult.OK:
                                string rutaSalida = guardarTexto.FileName;
                                archivoSalida.Formateartexto(rutaSalida, numeroPoliza, codigoProducto, nombreProducto, codigoPoliza,
                                                             vigenciaInicial, vigenciaFinal, contratanteNombre, contratanteNit,
                                                             contratanteDireccion, direccionCobro, aseguradoNombre,
                                                             aseguradoApellido,
                                                             numeroCertificado, nombreCertificado, sumaAsegurada, marca, modelo,
                                                             linea, chasis, placas, cobertura1, cobertura2, cobertura3);
                break;
            }
        }
            catch (Exception e)
            {

                MessageBox.Show("Evento de validación\r\n" + e.Message, @"Validacion de XML",
                           MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
