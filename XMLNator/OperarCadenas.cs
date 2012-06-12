namespace XMLNator
{
    /* Clase para las operaciones sobre las cadenas de texto en el software.
     *  Autor: Jose Carlos Sosa Mejia
     *  Fecha de Creacion: miercoles 23 de mayo de 2012
     *  Modificaciones:
     *  Funciones:
     *  Dividir cadenas que pasen de 12 elementos de largo en carias cadenas de la misma
     *  longitud,
     *  Rellenar con ceros a la izquierda cadenas que tengan menos de 12 caracteres, hasta
     *  obtener un largo de 12. Solo a cadenas que asi lo requieran.
     *  Modificaciones: 
     *  Pedro Jose Alonso
     *  Modificacion para el formateo de las columnas en el area Detalles del Certificado
     */

    internal class OperarCadenas
    {
        /*Rellenar con ceros a la izquierda hasta llegar a 12 elementos*/

        public static string Izquierda(string texto)
        {
            string cadena = texto;
            texto = cadena.PadLeft(12, '0');
            return texto;
        }



        /*Dividir cadenas largas en cadenas mas pequeñas*/

        public static string DividirCadena(string cadena)
        {
            if (cadena.Length <= 12)
            {
                string espacios = cadena;
                cadena = espacios.PadRight(12, ' ');/*Agregado por: Pedro Jose Alonso
                                                        *Para formatear las columnas de la seccion
                                                        *"Detalles del Certificado"
                                                        */
                return cadena;
            }
            else
            {
                string cadenaAuxiliar = cadena.Substring(0, 12);
                //cadena = cadena.Substring(10, cadena.Length);
                return DividirCadena(cadenaAuxiliar);
            }
        }
    }
}