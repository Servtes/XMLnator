using System.Windows.Forms;
using System.Xml;

namespace XMLNator
{
    /* Clase para las operaciones con archivos de entrada XML
     * Autor: Jose Carlos Sosa Mejia
     * Fecha de Creacion: lunes 21 de mayo de 2012
     *
     */

    internal class ConvertirXmlEnTexo
    {
        public void ProcesarArchivo(string rutaEntrada/*, string rutaSalida*/)
        {
            #region Declaracion de Variables que se enviaran por Parametro a la clase "botonguardar"

            /*Seccion de Encabezado*/
            string codigoProducto = "";
            string nombreProducto = "";
            string codigoPoliza = "";
            string numeroPoliza = "";
            string vigenciaInicial = "";
            string vigenciaFinal = "";
            string contratanteNombre = "";
            string contratanteNit = "";
            string contratanteDireccion = "";
            string direccionCobro = "";
            string aseguradoNombre = "";
            string aseguradoApellido = "";

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
            XmlDocument documentoXml = new XmlDocument();
            XmlTextReader tr = new XmlTextReader(rutaEntrada);
            //documentoXml.Load(reader);
            string hola = tr.GetAttribute("producto","codigo");
            
            MessageBox.Show(hola, "validando");

            string rutaSalida = "";
           /* documentoXml.Load(@rutaEntrada);
            //XmlNodeList listaPrincipalDeNodos = documentoXml.GetElementsByTagName("encabezado");
            XmlNodeList listaProductos = documentoXml.GetElementsByTagName("producto");
            foreach (XmlElement nodo in listaProductos)
            {
                XmlNodeList codigo = nodo.GetElementsByTagName("codigo");
                XmlNodeList nombre = nodo.GetElementsByTagName("nombre");
                codigoProducto = codigo[0].InnerText;
                nombreProducto = nombre[0].InnerText;
            }

            XmlNodeList poliza = documentoXml.GetElementsByTagName("producto");
            foreach (XmlElement nodo in poliza)
            {
                XmlNodeList numero = nodo.GetElementsByTagName("codigo");
                XmlNodeList codigo = nodo.GetElementsByTagName("nombre");
                numeroPoliza = numero[0].InnerText;
                codigoPoliza = codigo[0].InnerText;
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
            foreach (XmlElement nodo in contratante)
            {
                XmlNodeList nombre = nodo.GetElementsByTagName("nombre");
                XmlNodeList nit = nodo.GetElementsByTagName("nit");
                //contratanteNombre = nombre[0].InnerText;
                //contratanteNit = nit[0].InnerText;
            }*/

            

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
                    rutaSalida = guardarTexto.FileName;
                    archivoSalida.Formateartexto(rutaSalida, numeroPoliza, codigoProducto, nombreProducto, codigoPoliza,
                                                 vigenciaInicial, vigenciaFinal, contratanteNombre, contratanteNit,
                                                 contratanteDireccion, direccionCobro, aseguradoNombre,
                                                 aseguradoApellido,
                                                 numeroCertificado, nombreCertificado, sumaAsegurada, marca, modelo,
                                                 linea, chasis, placas, cobertura1, cobertura2, cobertura3);
                    break;
            }
        }
    }
}