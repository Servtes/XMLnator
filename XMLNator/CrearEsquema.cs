using System.IO;

/*Clase creada para adjuntar esquema de validacion de los archivos XML Generados por
 *Por el programa.
 *Autor:                Jose Carlos Sosa Mejia
 *Fecha de Creacion:    martes 29 de mayo de 2012
 */

namespace XMLNator
{
    internal class CrearEsquema
    {
        public static void EsquemaXsd(string rutaArchivo)
        {
            var esquema = new StreamWriter(rutaArchivo);

            #region Esquema de Pruebas
           /* esquema.WriteLine("<?xml version='1.0' encoding='utf-8'?>");
            esquema.WriteLine(
                "<xs:schema xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' attributeFormDefault='unqualified' elementFormDefault='qualified' xmlns:xs='http://www.w3.org/2001/XMLSchema'>");
            esquema.WriteLine("                  <xs:element name='xml'>");
            esquema.WriteLine("                    <xs:complexType>");
            esquema.WriteLine("                      <xs:sequence>");
            esquema.WriteLine("                        <xs:element name='encabezado'>");
            esquema.WriteLine("                          <xs:complexType>");
            esquema.WriteLine("                            <xs:sequence>");
            esquema.WriteLine("                              <xs:element name='producto'>");
            esquema.WriteLine("                                <xs:complexType>");
            esquema.WriteLine("                                  <xs:sequence>");
            esquema.WriteLine("                                    <xs:element name='codigo' type='xs:unsignedByte' />");
            esquema.WriteLine("                                    <xs:element name='nombre' type='xs:string' />");
            esquema.WriteLine("                                  </xs:sequence>");
            esquema.WriteLine("                                </xs:complexType>");
            esquema.WriteLine("                              </xs:element>");
            esquema.WriteLine("                              <xs:element name='poliza'>");
            esquema.WriteLine("                                <xs:complexType>");
            esquema.WriteLine("                                  <xs:sequence>");
            esquema.WriteLine("                                    <xs:element name='numero' type='xs:unsignedShort' />");
            esquema.WriteLine("                                    <xs:element name='codigo' type='xs:string' />");
            esquema.WriteLine("                                  </xs:sequence>");
            esquema.WriteLine("                                </xs:complexType>");
            esquema.WriteLine("                              </xs:element>");
            esquema.WriteLine("                              <xs:element name='vigencia'>");
            esquema.WriteLine("                                <xs:complexType>");
            esquema.WriteLine("                                  <xs:sequence>");
            esquema.WriteLine("                                    <xs:element name='inicial' type='xs:string' />");
            esquema.WriteLine("                                    <xs:element name='final' type='xs:string' />");
            esquema.WriteLine("                                  </xs:sequence>");
            esquema.WriteLine("                                </xs:complexType>");
            esquema.WriteLine("                              </xs:element>");
            esquema.WriteLine("                              <xs:element name='contratante'>");
            esquema.WriteLine("                                <xs:complexType>");
            esquema.WriteLine("                                  <xs:sequence>");
            esquema.WriteLine("                                    <xs:element name='nombre' type='xs:string' />");
            esquema.WriteLine("                                    <xs:element name='nit' type='xs:unsignedInt' />");
            esquema.WriteLine("                                    <xs:element name='direccion'>");
            esquema.WriteLine("                                      <xs:complexType>");
            esquema.WriteLine("                                        <xs:sequence>");
            esquema.WriteLine("                                          <xs:element name='contratante' type='xs:string' />");
            esquema.WriteLine("                                          <xs:element name='cobro' type='xs:string' />");
            esquema.WriteLine("                                        </xs:sequence>");
            esquema.WriteLine("                                      </xs:complexType>");
            esquema.WriteLine("                                    </xs:element>");
            esquema.WriteLine("                                  </xs:sequence>");
            esquema.WriteLine("                                </xs:complexType>");
            esquema.WriteLine("                              </xs:element>");
            esquema.WriteLine("                              <xs:element name='asegurado'>");
            esquema.WriteLine("                                <xs:complexType>");
            esquema.WriteLine("                                  <xs:sequence>");
            esquema.WriteLine("                                    <xs:element name='nombre' type='xs:string' />");
            esquema.WriteLine("                                    <xs:element name='apellido' type='xs:string' />");
            esquema.WriteLine("                                  </xs:sequence>");
            esquema.WriteLine("                                </xs:complexType>");
            esquema.WriteLine("                              </xs:element>");
            esquema.WriteLine("                            </xs:sequence>");
            esquema.WriteLine("                          </xs:complexType>");
            esquema.WriteLine("                        </xs:element>");
            esquema.WriteLine("                        <xs:element name='detalles'>");
            esquema.WriteLine("                          <xs:complexType>");
            esquema.WriteLine("                            <xs:sequence>");
            esquema.WriteLine("                              <xs:element name='certificado'>");
            esquema.WriteLine("                                <xs:complexType>");
            esquema.WriteLine("                                  <xs:sequence>");
            esquema.WriteLine("                                    <xs:element name='numero' type='xs:unsignedShort' />");
            esquema.WriteLine("                                    <xs:element name='nombre' type='xs:string' />");
            esquema.WriteLine("                                    <xs:element name='suma' type='xs:unsignedInt' />");
            esquema.WriteLine("                                  </xs:sequence>");
            esquema.WriteLine("                                </xs:complexType>");
            esquema.WriteLine("                              </xs:element>");
            esquema.WriteLine("                              <xs:element name='vehiculo'>");
            esquema.WriteLine("                                <xs:complexType>");
            esquema.WriteLine("                                  <xs:sequence>");
            esquema.WriteLine("                                    <xs:element name='marca' type='xs:string' />");
            esquema.WriteLine("                                    <xs:element name='modelo' type='xs:unsignedShort' />");
            esquema.WriteLine("                                    <xs:element name='linea' type='xs:string' />");
            esquema.WriteLine("                                    <xs:element name='chasis' type='xs:string' />");
            esquema.WriteLine("                                    <xs:element name='placas' type='xs:string' />");
            esquema.WriteLine("                                    <xs:element name='cobertura1' type='xs:string' />");
            esquema.WriteLine("                                    <xs:element name='cobertura2' type='xs:string' />");
            esquema.WriteLine("                                    <xs:element name='cobertura3' type='xs:string' />");
            esquema.WriteLine("                                  </xs:sequence>");
            esquema.WriteLine("                                </xs:complexType>");
            esquema.WriteLine("                              </xs:element>");
            esquema.WriteLine("                            </xs:sequence>");
            esquema.WriteLine("                          </xs:complexType>");
            esquema.WriteLine("                        </xs:element>");
            esquema.WriteLine("                      </xs:sequence>");
            esquema.WriteLine("                    </xs:complexType>");
            esquema.WriteLine("                  </xs:element>");
            esquema.WriteLine("                </xs:schema>");*/
            #endregion

            esquema.Write(@"<?xml version='1.0' encoding='utf-8'?>
                        <xs:schema xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' attributeFormDefault='unqualified' elementFormDefault='qualified' xmlns:xs='http://www.w3.org/2001/XMLSchema'>
                          <xs:element name='xml'>
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name='encabezado'>
                                  <xs:complexType>
                                    <xs:sequence>
                                      <xs:element name='producto'>
                                        <xs:complexType>
                                          <xs:sequence>
                                            <xs:element name='codigo' type='xs:unsignedByte' />
                                            <xs:element name='nombre' type='xs:string' />
                                          </xs:sequence>
                                        </xs:complexType>
                                      </xs:element>
                                      <xs:element name='poliza'>
                                        <xs:complexType>
                                          <xs:sequence>
                                            <xs:element name='pnumero' type='xs:unsignedShort' />
                                            <xs:element name='pcodigo' type='xs:string' />
                                          </xs:sequence>
                                        </xs:complexType>
                                      </xs:element>
                                      <xs:element name='vigencia'>
                                        <xs:complexType>
                                          <xs:sequence>
                                            <xs:element name='inicial' type='xs:string' />
                                            <xs:element name='final' type='xs:string' />
                                          </xs:sequence>
                                        </xs:complexType>
                                      </xs:element>
                                      <xs:element name='contratante'>
                                        <xs:complexType>
                                          <xs:sequence>
                                            <xs:element name='cnombre' type='xs:string' />
                                            <xs:element name='nit' type='xs:unsignedInt' />
                                          </xs:sequence>
                                        </xs:complexType>
                                      </xs:element>
                                      <xs:element name='direccion'>
                                        <xs:complexType>
                                          <xs:sequence>
                                            <xs:element name='dcontratante' type='xs:string' />
                                            <xs:element name='cobro' type='xs:string' />
                                          </xs:sequence>
                                        </xs:complexType>
                                      </xs:element>
                                      <xs:element name='asegurado'>
                                        <xs:complexType>
                                          <xs:sequence>
                                            <xs:element name='anombre' type='xs:string' />
                                            <xs:element name='apellido' type='xs:string' />
                                          </xs:sequence>
                                        </xs:complexType>
                                      </xs:element>
                                    </xs:sequence>
                                  </xs:complexType>
                                </xs:element>
                                <xs:element name='detalles'>
                                  <xs:complexType>
                                    <xs:sequence>
                                      <xs:element name='certificado'>
                                        <xs:complexType>
                                          <xs:sequence>
                                            <xs:element name='numero' type='xs:unsignedShort' />
                                            <xs:element name='enombre' type='xs:string' />
                                            <xs:element name='suma' type='xs:unsignedInt' />
                                          </xs:sequence>
                                        </xs:complexType>
                                      </xs:element>
                                      <xs:element name='vehiculo'>
                                        <xs:complexType>
                                          <xs:sequence>
                                            <xs:element name='marca' type='xs:string' />
                                            <xs:element name='modelo' type='xs:unsignedShort' />
                                            <xs:element name='linea' type='xs:string' />
                                            <xs:element name='chasis' type='xs:string' />
                                            <xs:element name='placas' type='xs:string' />
                                            <xs:element name='cobertura1' type='xs:string' />
                                            <xs:element name='cobertura2' type='xs:string' />
                                            <xs:element name='cobertura3' type='xs:string' />
                                          </xs:sequence>
                                        </xs:complexType>
                                      </xs:element>
                                    </xs:sequence>
                                  </xs:complexType>
                                </xs:element>
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                        </xs:schema>");
            esquema.Close();
        }
    }
}