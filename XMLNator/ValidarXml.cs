using System;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;

/* Clase para la validacion de los archivos Xml.
 * Los documentos xml se validan contra un esquema Xsd, la valdacion
 * debe ser positiva para poder procesar el xml y convertirlo en Texto Plano
 * Autor:               Jose Carlos Sosa Mejia
 * Fecha de Creacion:   miercoles 30 de mayo de 2012
 */

namespace XMLNator
{
    internal class ValidarXml
    {
        private static bool _isValid = true;
        /*Validar archivo XML Contra Esquema XSD*/

        public  void Validar(string rutaFicheroXml)
        {
            var r = new XmlTextReader(rutaFicheroXml);
            var v = new XmlValidatingReader(r) {ValidationType = ValidationType.Schema};
            v.ValidationEventHandler += ValidarControlEventos;
            var procesarXml = new ConvertirXmlEnTexo();
            procesarXml.ProcesarArchivo(rutaFicheroXml/*,@"D:\pruebas.txt"*/);
            try
            {
                while (v.Read())
                {
                }
               

                // Comprobar si el documento es válido o no.
                //return _isValid ? "true" : "false";
               // var procesarXml = new ConvertirXmlEnTexo();
               // procesarXml.ProcesarArchivo(rutaFicheroXml/*,@"D:\pruebas.txt"*/);
                v.Close();
                
            }
            catch (Exception e)
            {
                //ValidarControlEventos(null, null);
                // _isValid = false;
                // MessageBox.Show("Evento de validación\r\n" + e.Message, @"Validacion de XML",
                // MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ////v.ValidationEventHandler += new ValidationEventHandler(ValidarControlEventos);
                //return "true";
            }
        }

        public static void ValidarControlEventos(object sender, ValidationEventArgs e)
        {
            _isValid = false;
            MessageBox.Show("Evento de validación\r\n" + e.Message, @"Validacion de XML",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}