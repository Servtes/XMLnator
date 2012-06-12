using System;
using System.IO;

/* Clase creada para formatear la salida de los documentos de texto
 * Auto: Pedro Jose Alonso
 */

namespace XMLNator
{
    internal class Botonguardar
    {
        public void Formateartexto(string ruta, string txtNumeroPoliza, string txtCodigoProducto,
                                   string txtNombreProducto,
                                   string txtCodigoPoliza, string txtVigenciaInicial, string txtVigenciaFinal,
                                   string txtContratanteNombre,
                                   string txtContratanteNit, string txtContratanteDireccion, string txtDireccionCobro,
                                   string txtAsuguradoNombre,string txtAseguradoApellido,
                                   string txtNumero, string txtNombreCertificado, string txtSumaAsegurada,
                                   string txtMarca, string txtModelo,
                                   string txtLinea, string txtChasis, string txtPlacas, string txtCobertura1,
                                   string txtCobertura2, string txtCobertura3)
        {
            var sw = new StreamWriter(ruta);

            // Add some text to the file.
            sw.Write("Codigo Producto: ");
            sw.Write(txtCodigoProducto + "\r\n");
            sw.Write("Nombre Producto: ");
            sw.Write(txtNombreProducto + "\r\n");
            sw.Write("Codigo Poliza: ");
            sw.Write(txtCodigoPoliza + "\r\n");
            sw.Write("Numero Poliza: ");
            sw.Write(txtNumeroPoliza + "\r\n");
            sw.Write("Vigencia Inicial: ");
            sw.Write(txtVigenciaInicial + "\r\n");
            sw.Write("Vigencia Final: ");
            sw.Write(txtVigenciaFinal + "\r\n");

            sw.Write("Contratante Nombre: ");
            sw.Write(txtContratanteNombre + "\r\n");
            sw.Write("Contratante Nit: ");
            sw.Write(txtContratanteNit + "\r\n");
            sw.Write("Contratante Direccion: ");
            sw.Write(txtContratanteDireccion + "\r\n");
            sw.Write("Direccion de Cobro: ");
            sw.Write(txtDireccionCobro + "\r\n");
            sw.Write("Asegurado Nombre: ");
            sw.Write(txtAsuguradoNombre + "\r\n");
            sw.Write("Asegurado Apellido: ");
            sw.Write(txtAseguradoApellido + "\r\n");

            sw.Write("Numero: ");
            sw.Write("              Nombre de Certificado: ");
            sw.Write("              Suma Asegurada: ");
            sw.Write("              Marca: ");
            sw.Write("              Modelo: ");
            sw.Write("              Linea: ");
            sw.Write("              Chasis: ");
            sw.Write("              Placas: ");
            sw.Write("              Cobertura 1: ");
            sw.Write("              Cobertura 2: ");
            sw.Write("              Cobertura 3: \r\n");

            String n = OperarCadenas.Izquierda(txtNumero);
            String sa = OperarCadenas.Izquierda(txtSumaAsegurada);
            String mo = OperarCadenas.Izquierda(txtModelo);

            String nombrecertificado = OperarCadenas.DividirCadena(txtNombreCertificado);
            String marca = OperarCadenas.DividirCadena(txtMarca);
            String linea = OperarCadenas.DividirCadena(txtLinea);
            String chasis = OperarCadenas.DividirCadena(txtChasis);
            String placas = OperarCadenas.DividirCadena(txtPlacas);
            String cobertura1 = OperarCadenas.DividirCadena(txtCobertura1);
            String cobertura2 = OperarCadenas.DividirCadena(txtCobertura2);
            String cobertura3 = OperarCadenas.DividirCadena(txtCobertura3);


            sw.Write(n + "          " + nombrecertificado + "                         " + sa + "                  " +
                     marca + "         " + mo + "          " + linea + "         " + chasis + "          " + placas +
                     "          " + cobertura1 + "               " + cobertura2 + "               " + cobertura3);

            while (txtNombreCertificado.Length > 12 || txtMarca.Length > 12 || txtLinea.Length > 12 ||
                   txtChasis.Length > 12 || txtPlacas.Length > 12 || txtCobertura1.Length > 12 ||
                   txtCobertura2.Length > 12 || txtCobertura3.Length > 12)
            {
                txtCobertura3 = txtCobertura3.Length > 12 ? txtCobertura3.Substring(12, txtCobertura3.Length - 12) : "";
                txtCobertura2 = txtCobertura2.Length > 12 ? txtCobertura2.Substring(12, txtCobertura2.Length - 12) : "";
                txtCobertura1 = txtCobertura1.Length > 12 ? txtCobertura1.Substring(12, txtCobertura1.Length - 12) : "";
                txtPlacas = txtPlacas.Length > 12 ? txtPlacas.Substring(12, txtPlacas.Length - 12) : "";
                txtChasis = txtChasis.Length > 12 ? txtChasis.Substring(12, txtChasis.Length - 12) : "";
                txtLinea = txtLinea.Length > 12 ? txtLinea.Substring(12, txtLinea.Length - 12) : "";
                txtMarca = txtMarca.Length > 12 ? txtMarca.Substring(12, txtMarca.Length - 12) : "";
                txtNombreCertificado = txtNombreCertificado.Length > 12 ? txtNombreCertificado.Substring(12, txtNombreCertificado.Length - 12) : "";


                String espacionombrecertificado = OperarCadenas.DividirCadena(txtNombreCertificado);
                String espaciomarca = OperarCadenas.DividirCadena(txtMarca);
                String espaciolinea = OperarCadenas.DividirCadena(txtLinea);
                String espaciochasis = OperarCadenas.DividirCadena(txtChasis);
                String espacioplacas = OperarCadenas.DividirCadena(txtPlacas);
                String espaciocobertura1 = OperarCadenas.DividirCadena(txtCobertura1);
                String espaciocobertura2 = OperarCadenas.DividirCadena(txtCobertura2);
                String espaciocobertura3 = OperarCadenas.DividirCadena(txtCobertura3);
                sw.Write("\r\n");
                sw.Write("                      " + espacionombrecertificado + "                         " +
                         "                              " + espaciomarca + "         " + "                      " +
                         espaciolinea + "         " + espaciochasis + "          " + espacioplacas + "          " +
                         espaciocobertura1 + "               " + espaciocobertura2 + "               " +
                         espaciocobertura3);
            }

            sw.Close();
        }
    }
}