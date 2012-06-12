using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using XMLNator.Properties;

namespace XMLNator
{
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();
            MouseMove += Form1MouseMove;
        }

        #region Funciones necesarias para mover la ventana sin barra de titulo [Jose Sosa]

        //
        // Declaraciones del API de Windows (y constantes usadas para mover el form)
        //
        private const int WM_SYSCOMMAND = 0x112;
        private const int MOUSE_MOVE = 0xF012;
        //
        // Declaraciones del API
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        // función privada usada para mover el formulario actual
        private void MoverForm()
        {
            ReleaseCapture();
            SendMessage(Handle, WM_SYSCOMMAND, MOUSE_MOVE, 0);
        }


        private void Form1MouseMove(object sender, MouseEventArgs e)
        {
            MoverForm();
        }

        private void BtnCerrarClick1(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Eventos de Validacion de Archivos Xml [Jose Sosa]

        private string _estadoValidacion = "";
        private string _strFileName = "";

        private void btnAbrirXml_Click(object sender, EventArgs e)
        {
            groupBoxValidacion.Visible = true;
            abrirXML.InitialDirectory = Directory.GetCurrentDirectory();
            abrirXML.Title = "Seleccione un archivo";

            switch (abrirXML.ShowDialog())
            {
                case DialogResult.OK:
                    AnimarProgressBar();
                    _strFileName = abrirXML.FileName;
                    txtRutaXML.Text = _strFileName;
                    var procesarArchivo = new ValidarArchivos();
                    procesarArchivo.Xml(_strFileName);
                    break;
            }
        }

        /*Pruebas de la Clase CrearEsquema.cs*/

        private void button2_Click(object sender, EventArgs e)
        {
            CrearEsquema.EsquemaXsd(@"D:\esquema.xsd");
        }

        /*Funcion para la animacion de la barra de progreso*/

        private void AnimarProgressBar()
        {
            progressBar1.Maximum = 100000;
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;
            progressBar1.Step = 1;
            for (int i = progressBar1.Minimum; i < progressBar1.Maximum; i = i + progressBar1.Step)
            {
                progressBar1.PerformStep();
            }
        }

        #endregion

        #region Botones de Control del Formulario

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            DialogResult show =
                MessageBox.Show(
                    Resources.Form1_btnAyuda_Click_
                    , caption: "XmlNator", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            DialogResult show =
                MessageBox.Show(
                    Resources.Form1_btnAcercaDe_Click_
                    , caption: "Acerca de", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.None);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region Guardar Archivo de Texto Base por: Pedro Alonso

        private void btnGuardarTextoBase_Click(object sender, EventArgs e)
        {
            string ruta = "";
            var prueba = new Botonguardar();
            if (guardarTextoBase.ShowDialog() == DialogResult.OK)
                ruta = guardarTextoBase.FileName;

            prueba.Formateartexto(ruta, txtNumeroPoliza.Text, txtCodigoProducto.Text, txtNombreProducto.Text,
                                  txtCodigoPoliza.Text, txtVigenciaInicial.Text, txtVigenciaFinal.Text,
                                  txtContratanteNombre.Text, txtAseguradoApellido.Text,
                                  txtContratanteNit.Text, txtContratanteDireccion.Text, txtDireccionCobro.Text,
                                  txtAsuguradoNombre.Text,
                                  txtNumero.Text, txtNombreCertificado.Text, txtSumaAsegurada.Text, txtMarca.Text,
                                  txtModelo.Text,
                                  txtLinea.Text, txtChasis.Text, txtPlacas.Text, txtCobertura1.Text, txtCobertura2.Text,
                                  txtCobertura3.Text);
        }

        #endregion

        private void btnReset_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            btnAbrirXml.Enabled = true;
            btnGenerarTxt.Enabled = false;
            lblEstadoArchivo.Text = "Elija un Archivo...";
            lblEstadoArchivo.ForeColor = Color.DimGray;
            lblResultados.Text = "...";
            _strFileName = "";
            _estadoValidacion = "true";
        }

        public void btnGenerarTxt_Click(object sender, EventArgs e)
        {
            string ruta = "";
            if (guardarXmlTexto.ShowDialog() == DialogResult.OK)
            {
                ruta = guardarXmlTexto.FileName;
            }
            var convertirXml = new ConvertirXmlEnTexo();
            convertirXml.ProcesarArchivo(/*txtRutaXML.Text*/_strFileName);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog cargarTexto = new OpenFileDialog();
            cargarTexto.Title = "Seleccione un Archivo de Texto";
            cargarTexto.Filter = "Archivos de Texto|*.txt";
            cargarTexto.RestoreDirectory = true;
            if (cargarTexto.ShowDialog() == DialogResult.OK)
            {
                string UrlArchivo1 = cargarTexto.FileName;
                FileStream fs = new FileStream(UrlArchivo1, FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                textBox1.Text = sr.ReadToEnd();
                fs.Close();
                sr.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string xml = "";
            foreach (string t in textBox1.Lines)
            {
                string aux = "";
                string aux2 = "";
                string texto = t;
                for (int x = 0; x < texto.Length; x++)
                {
                    if (texto[x] != ':')
                        aux = aux + texto[x];
                    else
                    {
                        aux2 = aux.Replace(" ", "");
                        xml = xml + "<" + aux2 + "> " + texto.Substring(x + 1, (texto.Length - x) - 1) + " </" + aux2 + ">" + char.ConvertFromUtf32(13) + char.ConvertFromUtf32(10);
                        break;
                    }
                }

            }
            const string quote = "\"";
            string enca = "xmlns:xsi=" + Convert.ToString('"') + "http://www.w3.org/2001/XMLSchema-instance" + Convert.ToString('"') + " xsi:noNamespaceSchemaLocation=" + Convert.ToString('"') + "esquema.xsd" + Convert.ToString('"');
            string xml2 = "<xml " + enca + ">" + xml + "</xml>";

            var guardarTexto = new SaveFileDialog
            {
                Filter = "Archivos XML|*.xml",
                RestoreDirectory = true,
                Title = "Guardar Fichero de Salida"
            };

            switch (guardarTexto.ShowDialog())
            {
                case DialogResult.OK:
                    string rutaSalida = guardarTexto.FileName;
                    textBox2.Text = xml2;
                    XmlDocument doc = new XmlDocument();
                    doc.LoadXml(xml2);
                    XmlTextWriter writer = new XmlTextWriter(rutaSalida, null) {Formatting = Formatting.Indented};
                    doc.Save(writer);
                    break;
            }
            
 
        }
    }
}