using System.Windows.Forms;

namespace XMLNator
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.guardarXmlTexto = new System.Windows.Forms.SaveFileDialog();
            this.abrirXML = new System.Windows.Forms.OpenFileDialog();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label26 = new System.Windows.Forms.Label();
            this.lblEstadoArchivo = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAbrirXml = new System.Windows.Forms.Button();
            this.txtRutaXML = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtRutaTXT = new System.Windows.Forms.TextBox();
            this.btnGenerarTxt = new System.Windows.Forms.Button();
            this.groupBoxValidacion = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblResultados = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGuardarTextoBase = new System.Windows.Forms.Button();
            this.txtCobertura3 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtCobertura2 = new System.Windows.Forms.TextBox();
            this.txtPlacas = new System.Windows.Forms.TextBox();
            this.txtLinea = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtNombreCertificado = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtCobertura1 = new System.Windows.Forms.TextBox();
            this.txtChasis = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtSumaAsegurada = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAsuguradoNombre = new System.Windows.Forms.TextBox();
            this.txtAseguradoApellido = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDireccionCobro = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtContratanteDireccion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtContratanteNit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtContratanteNombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtVigenciaFinal = new System.Windows.Forms.TextBox();
            this.txtCodigoPoliza = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVigenciaInicial = new System.Windows.Forms.TextBox();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumeroPoliza = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnAcercaDe = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.guardarTextoBase = new System.Windows.Forms.SaveFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBoxValidacion.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.AccessibleDescription = "Sale del Programa";
            this.btnCerrar.AccessibleName = "Salir";
            this.btnCerrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCerrar.Location = new System.Drawing.Point(730, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(31, 31);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrarClick1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(316, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "XmlNator";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.ForeColor = System.Drawing.Color.DimGray;
            this.label25.Location = new System.Drawing.Point(622, 405);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(126, 13);
            this.label25.TabIndex = 4;
            this.label25.Text = "2do. Grupo Compiladores";
            // 
            // guardarXmlTexto
            // 
            this.guardarXmlTexto.Filter = "Archivos de Texto|*.txt";
            // 
            // abrirXML
            // 
            this.abrirXML.Filter = "Archivos XML (*.xml) | *.XML| todos los archivos (*.*)|*.*";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.label26);
            this.tabPage3.Controls.Add(this.lblEstadoArchivo);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBoxValidacion);
            this.tabPage3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.ForeColor = System.Drawing.Color.DimGray;
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(714, 348);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Xml a Texto";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(403, 17);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(289, 60);
            this.label26.TabIndex = 90;
            this.label26.Text = "XmlNator verificara que el archivo Xml objetivo \r\ncumpla con los estandares de va" +
    "lidacion, que \r\ncumpla con el esquema de la poliza de seguro\r\ny validara todas l" +
    "as etiquetas contenidas en el mismo.";
            this.label26.UseMnemonic = false;
            // 
            // lblEstadoArchivo
            // 
            this.lblEstadoArchivo.AutoSize = true;
            this.lblEstadoArchivo.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoArchivo.ForeColor = System.Drawing.Color.DimGray;
            this.lblEstadoArchivo.Location = new System.Drawing.Point(6, 17);
            this.lblEstadoArchivo.Name = "lblEstadoArchivo";
            this.lblEstadoArchivo.Size = new System.Drawing.Size(331, 54);
            this.lblEstadoArchivo.TabIndex = 0;
            this.lblEstadoArchivo.Text = "Elija un Archivo...";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAbrirXml);
            this.groupBox3.Controls.Add(this.txtRutaXML);
            this.groupBox3.Location = new System.Drawing.Point(24, 116);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(329, 142);
            this.groupBox3.TabIndex = 93;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Validacion de Documento Xml";
            // 
            // btnAbrirXml
            // 
            this.btnAbrirXml.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAbrirXml.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAbrirXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirXml.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirXml.ForeColor = System.Drawing.Color.White;
            this.btnAbrirXml.Location = new System.Drawing.Point(16, 52);
            this.btnAbrirXml.Name = "btnAbrirXml";
            this.btnAbrirXml.Size = new System.Drawing.Size(297, 72);
            this.btnAbrirXml.TabIndex = 3;
            this.btnAbrirXml.Text = "Abrir Archivo XML";
            this.btnAbrirXml.UseVisualStyleBackColor = false;
            this.btnAbrirXml.Click += new System.EventHandler(this.btnAbrirXml_Click);
            // 
            // txtRutaXML
            // 
            this.txtRutaXML.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRutaXML.Location = new System.Drawing.Point(16, 22);
            this.txtRutaXML.Name = "txtRutaXML";
            this.txtRutaXML.ReadOnly = true;
            this.txtRutaXML.Size = new System.Drawing.Size(297, 16);
            this.txtRutaXML.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtRutaTXT);
            this.groupBox5.Controls.Add(this.btnGenerarTxt);
            this.groupBox5.Location = new System.Drawing.Point(359, 116);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(329, 142);
            this.groupBox5.TabIndex = 94;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Conversion a Texto Plano";
            // 
            // txtRutaTXT
            // 
            this.txtRutaTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRutaTXT.Location = new System.Drawing.Point(16, 22);
            this.txtRutaTXT.Name = "txtRutaTXT";
            this.txtRutaTXT.ReadOnly = true;
            this.txtRutaTXT.Size = new System.Drawing.Size(297, 16);
            this.txtRutaTXT.TabIndex = 2;
            // 
            // btnGenerarTxt
            // 
            this.btnGenerarTxt.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGenerarTxt.Enabled = false;
            this.btnGenerarTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarTxt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarTxt.ForeColor = System.Drawing.Color.White;
            this.btnGenerarTxt.Location = new System.Drawing.Point(16, 52);
            this.btnGenerarTxt.Name = "btnGenerarTxt";
            this.btnGenerarTxt.Size = new System.Drawing.Size(297, 72);
            this.btnGenerarTxt.TabIndex = 4;
            this.btnGenerarTxt.Text = "Generar Archivo TXT";
            this.btnGenerarTxt.UseVisualStyleBackColor = false;
            this.btnGenerarTxt.Click += new System.EventHandler(this.btnGenerarTxt_Click);
            // 
            // groupBoxValidacion
            // 
            this.groupBoxValidacion.Controls.Add(this.btnReset);
            this.groupBoxValidacion.Controls.Add(this.lblResultados);
            this.groupBoxValidacion.Controls.Add(this.progressBar1);
            this.groupBoxValidacion.Location = new System.Drawing.Point(24, 265);
            this.groupBoxValidacion.Name = "groupBoxValidacion";
            this.groupBoxValidacion.Size = new System.Drawing.Size(664, 77);
            this.groupBoxValidacion.TabIndex = 97;
            this.groupBoxValidacion.TabStop = false;
            this.groupBoxValidacion.Text = "Estado de Validacion";
            this.groupBoxValidacion.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(468, 19);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(184, 29);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reiniciar";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Location = new System.Drawing.Point(13, 19);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(13, 15);
            this.lblResultados.TabIndex = 96;
            this.lblResultados.Text = "ll";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(468, 54);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(184, 17);
            this.progressBar1.Step = 5;
            this.progressBar1.TabIndex = 91;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(714, 348);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Texto a Xml";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(714, 348);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crear Txt Base";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnGuardarTextoBase);
            this.groupBox4.Controls.Add(this.txtCobertura3);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.txtCobertura2);
            this.groupBox4.Controls.Add(this.txtPlacas);
            this.groupBox4.Controls.Add(this.txtLinea);
            this.groupBox4.Controls.Add(this.txtMarca);
            this.groupBox4.Controls.Add(this.txtNombreCertificado);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.txtCobertura1);
            this.groupBox4.Controls.Add(this.txtChasis);
            this.groupBox4.Controls.Add(this.txtModelo);
            this.groupBox4.Controls.Add(this.txtSumaAsegurada);
            this.groupBox4.Controls.Add(this.txtNumero);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(12, 187);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(685, 148);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Detalles del Certificado";
            // 
            // btnGuardarTextoBase
            // 
            this.btnGuardarTextoBase.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGuardarTextoBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarTextoBase.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarTextoBase.ForeColor = System.Drawing.Color.White;
            this.btnGuardarTextoBase.Location = new System.Drawing.Point(444, 104);
            this.btnGuardarTextoBase.Name = "btnGuardarTextoBase";
            this.btnGuardarTextoBase.Size = new System.Drawing.Size(220, 40);
            this.btnGuardarTextoBase.TabIndex = 32;
            this.btnGuardarTextoBase.Text = "Guardar Texto Base";
            this.btnGuardarTextoBase.UseVisualStyleBackColor = false;
            this.btnGuardarTextoBase.Click += new System.EventHandler(this.btnGuardarTextoBase_Click);
            // 
            // txtCobertura3
            // 
            this.txtCobertura3.Location = new System.Drawing.Point(329, 104);
            this.txtCobertura3.MaxLength = 100;
            this.txtCobertura3.Name = "txtCobertura3";
            this.txtCobertura3.Size = new System.Drawing.Size(100, 23);
            this.txtCobertura3.TabIndex = 23;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(234, 107);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(72, 15);
            this.label24.TabIndex = 31;
            this.label24.Text = "Cobertura 3:";
            // 
            // txtCobertura2
            // 
            this.txtCobertura2.Location = new System.Drawing.Point(124, 104);
            this.txtCobertura2.MaxLength = 100;
            this.txtCobertura2.Name = "txtCobertura2";
            this.txtCobertura2.Size = new System.Drawing.Size(100, 23);
            this.txtCobertura2.TabIndex = 22;
            // 
            // txtPlacas
            // 
            this.txtPlacas.Location = new System.Drawing.Point(329, 76);
            this.txtPlacas.MaxLength = 100;
            this.txtPlacas.Name = "txtPlacas";
            this.txtPlacas.Size = new System.Drawing.Size(100, 23);
            this.txtPlacas.TabIndex = 20;
            // 
            // txtLinea
            // 
            this.txtLinea.Location = new System.Drawing.Point(563, 50);
            this.txtLinea.MaxLength = 100;
            this.txtLinea.Name = "txtLinea";
            this.txtLinea.Size = new System.Drawing.Size(100, 23);
            this.txtLinea.TabIndex = 18;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(124, 50);
            this.txtMarca.MaxLength = 100;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 23);
            this.txtMarca.TabIndex = 16;
            // 
            // txtNombreCertificado
            // 
            this.txtNombreCertificado.Location = new System.Drawing.Point(329, 24);
            this.txtNombreCertificado.MaxLength = 100;
            this.txtNombreCertificado.Multiline = true;
            this.txtNombreCertificado.Name = "txtNombreCertificado";
            this.txtNombreCertificado.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCertificado.TabIndex = 14;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 107);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 15);
            this.label19.TabIndex = 26;
            this.label19.Text = "Cobertura 2:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(234, 79);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(43, 15);
            this.label20.TabIndex = 25;
            this.label20.Text = "Placas:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(445, 53);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(38, 15);
            this.label21.TabIndex = 24;
            this.label21.Text = "Linea:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(12, 53);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(43, 15);
            this.label22.TabIndex = 23;
            this.label22.Text = "Marca:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(234, 25);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(51, 13);
            this.label23.TabIndex = 21;
            this.label23.Text = "Nombre:";
            // 
            // txtCobertura1
            // 
            this.txtCobertura1.Location = new System.Drawing.Point(563, 76);
            this.txtCobertura1.MaxLength = 100;
            this.txtCobertura1.Name = "txtCobertura1";
            this.txtCobertura1.Size = new System.Drawing.Size(100, 23);
            this.txtCobertura1.TabIndex = 21;
            // 
            // txtChasis
            // 
            this.txtChasis.Location = new System.Drawing.Point(124, 76);
            this.txtChasis.MaxLength = 100;
            this.txtChasis.Name = "txtChasis";
            this.txtChasis.Size = new System.Drawing.Size(100, 23);
            this.txtChasis.TabIndex = 19;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(329, 50);
            this.txtModelo.MaxLength = 12;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 23);
            this.txtModelo.TabIndex = 17;
            // 
            // txtSumaAsegurada
            // 
            this.txtSumaAsegurada.Location = new System.Drawing.Point(563, 24);
            this.txtSumaAsegurada.MaxLength = 12;
            this.txtSumaAsegurada.Name = "txtSumaAsegurada";
            this.txtSumaAsegurada.Size = new System.Drawing.Size(100, 23);
            this.txtSumaAsegurada.TabIndex = 15;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(124, 24);
            this.txtNumero.MaxLength = 12;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 23);
            this.txtNumero.TabIndex = 13;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(445, 79);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 15);
            this.label18.TabIndex = 16;
            this.label18.Text = "Cobertura 1:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 79);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 15);
            this.label17.TabIndex = 15;
            this.label17.Text = "Chasis:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(234, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 15);
            this.label16.TabIndex = 14;
            this.label16.Text = "Modelo:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(445, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 15);
            this.label15.TabIndex = 13;
            this.label15.Text = "Suma Asegurada:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 15);
            this.label14.TabIndex = 12;
            this.label14.Text = "Numero:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAsuguradoNombre);
            this.groupBox2.Controls.Add(this.txtAseguradoApellido);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtDireccionCobro);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtContratanteDireccion);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtContratanteNit);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtContratanteNombre);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(685, 84);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles Contratante | Asegurado";
            // 
            // txtAsuguradoNombre
            // 
            this.txtAsuguradoNombre.Location = new System.Drawing.Point(329, 46);
            this.txtAsuguradoNombre.MaxLength = 100;
            this.txtAsuguradoNombre.Name = "txtAsuguradoNombre";
            this.txtAsuguradoNombre.Size = new System.Drawing.Size(100, 23);
            this.txtAsuguradoNombre.TabIndex = 11;
            // 
            // txtAseguradoApellido
            // 
            this.txtAseguradoApellido.Location = new System.Drawing.Point(563, 46);
            this.txtAseguradoApellido.MaxLength = 100;
            this.txtAseguradoApellido.Name = "txtAseguradoApellido";
            this.txtAseguradoApellido.Size = new System.Drawing.Size(100, 23);
            this.txtAseguradoApellido.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(234, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 12);
            this.label12.TabIndex = 13;
            this.label12.Text = "Asegurado Nombre:";
            // 
            // txtDireccionCobro
            // 
            this.txtDireccionCobro.Location = new System.Drawing.Point(124, 43);
            this.txtDireccionCobro.MaxLength = 100;
            this.txtDireccionCobro.Name = "txtDireccionCobro";
            this.txtDireccionCobro.Size = new System.Drawing.Size(100, 23);
            this.txtDireccionCobro.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(445, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Asegurado Apellido:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 15);
            this.label11.TabIndex = 16;
            this.label11.Text = "Direccion de Cobro:";
            // 
            // txtContratanteDireccion
            // 
            this.txtContratanteDireccion.Location = new System.Drawing.Point(563, 17);
            this.txtContratanteDireccion.MaxLength = 100;
            this.txtContratanteDireccion.Name = "txtContratanteDireccion";
            this.txtContratanteDireccion.Size = new System.Drawing.Size(100, 23);
            this.txtContratanteDireccion.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(445, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Contratante Direccion";
            // 
            // txtContratanteNit
            // 
            this.txtContratanteNit.Location = new System.Drawing.Point(329, 17);
            this.txtContratanteNit.MaxLength = 12;
            this.txtContratanteNit.Name = "txtContratanteNit";
            this.txtContratanteNit.Size = new System.Drawing.Size(100, 23);
            this.txtContratanteNit.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(230, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Contratante Nit:";
            // 
            // txtContratanteNombre
            // 
            this.txtContratanteNombre.Location = new System.Drawing.Point(124, 17);
            this.txtContratanteNombre.MaxLength = 100;
            this.txtContratanteNombre.Name = "txtContratanteNombre";
            this.txtContratanteNombre.Size = new System.Drawing.Size(100, 23);
            this.txtContratanteNombre.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Contratante Nombre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtVigenciaFinal);
            this.groupBox1.Controls.Add(this.txtCodigoPoliza);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtVigenciaInicial);
            this.groupBox1.Controls.Add(this.txtCodigoProducto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNumeroPoliza);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNombreProducto);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 82);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // txtVigenciaFinal
            // 
            this.txtVigenciaFinal.Location = new System.Drawing.Point(563, 54);
            this.txtVigenciaFinal.MaxLength = 100;
            this.txtVigenciaFinal.Name = "txtVigenciaFinal";
            this.txtVigenciaFinal.Size = new System.Drawing.Size(100, 23);
            this.txtVigenciaFinal.TabIndex = 6;
            // 
            // txtCodigoPoliza
            // 
            this.txtCodigoPoliza.Location = new System.Drawing.Point(563, 25);
            this.txtCodigoPoliza.MaxLength = 12;
            this.txtCodigoPoliza.Name = "txtCodigoPoliza";
            this.txtCodigoPoliza.Size = new System.Drawing.Size(100, 23);
            this.txtCodigoPoliza.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(445, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Vigencia Final:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo Producto:";
            // 
            // txtVigenciaInicial
            // 
            this.txtVigenciaInicial.Location = new System.Drawing.Point(329, 51);
            this.txtVigenciaInicial.MaxLength = 100;
            this.txtVigenciaInicial.Name = "txtVigenciaInicial";
            this.txtVigenciaInicial.Size = new System.Drawing.Size(100, 23);
            this.txtVigenciaInicial.TabIndex = 5;
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(124, 25);
            this.txtCodigoProducto.MaxLength = 12;
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(100, 23);
            this.txtCodigoProducto.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Vigencia Inicial:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(230, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Producto:";
            // 
            // txtNumeroPoliza
            // 
            this.txtNumeroPoliza.Location = new System.Drawing.Point(124, 51);
            this.txtNumeroPoliza.MaxLength = 12;
            this.txtNumeroPoliza.Name = "txtNumeroPoliza";
            this.txtNumeroPoliza.Size = new System.Drawing.Size(100, 23);
            this.txtNumeroPoliza.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Codigo Poliza:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Numero Poliza:";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(329, 25);
            this.txtNombreProducto.MaxLength = 100;
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(100, 23);
            this.txtNombreProducto.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(19, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(722, 376);
            this.tabControl1.TabIndex = 30;
            this.tabControl1.TabStop = false;
            // 
            // btnAyuda
            // 
            this.btnAyuda.AccessibleDescription = "Muestra la ayuda del Programa";
            this.btnAyuda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.ForeColor = System.Drawing.Color.Turquoise;
            this.btnAyuda.Location = new System.Drawing.Point(668, 0);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(31, 31);
            this.btnAyuda.TabIndex = 31;
            this.btnAyuda.Text = "?";
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnAcercaDe
            // 
            this.btnAcercaDe.AccessibleDescription = "Muestra la ayuda del Programa";
            this.btnAcercaDe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAcercaDe.FlatAppearance.BorderSize = 0;
            this.btnAcercaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcercaDe.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcercaDe.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAcercaDe.Location = new System.Drawing.Point(637, -4);
            this.btnAcercaDe.Name = "btnAcercaDe";
            this.btnAcercaDe.Size = new System.Drawing.Size(31, 35);
            this.btnAcercaDe.TabIndex = 32;
            this.btnAcercaDe.Text = "!";
            this.btnAcercaDe.UseVisualStyleBackColor = false;
            this.btnAcercaDe.Click += new System.EventHandler(this.btnAcercaDe_Click);
            // 
            // button1
            // 
            this.button1.AccessibleDescription = "Muestra la ayuda del Programa";
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightBlue;
            this.button1.Location = new System.Drawing.Point(699, -20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 51);
            this.button1.TabIndex = 33;
            this.button1.Text = "_";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // guardarTextoBase
            // 
            this.guardarTextoBase.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.guardarTextoBase.InitialDirectory = "C:\\\\";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(700, 142);
            this.textBox1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(3, 299);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(350, 43);
            this.button3.TabIndex = 3;
            this.button3.Text = "Cargar TXT";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(357, 299);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(349, 43);
            this.button4.TabIndex = 4;
            this.button4.Text = "Crear XML";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 151);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(700, 142);
            this.textBox2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(760, 425);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAcercaDe);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "<name>XmlNator</name>";
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBoxValidacion.ResumeLayout(false);
            this.groupBoxValidacion.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCerrar;
        private Label label1;
        private Label label25;
        private SaveFileDialog guardarXmlTexto;
        private OpenFileDialog abrirXML;
        private TabPage tabPage3;
        private Button btnGenerarTxt;
        private Button btnAbrirXml;
        private TextBox txtRutaTXT;
        private TextBox txtRutaXML;
        public Label lblEstadoArchivo;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private GroupBox groupBox4;
        private Button btnGuardarTextoBase;
        private TextBox txtCobertura3;
        private Label label24;
        private TextBox txtCobertura2;
        private TextBox txtPlacas;
        private TextBox txtLinea;
        private TextBox txtMarca;
        private TextBox txtNombreCertificado;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private TextBox txtCobertura1;
        private TextBox txtChasis;
        private TextBox txtModelo;
        private TextBox txtSumaAsegurada;
        private TextBox txtNumero;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private GroupBox groupBox2;
        private TextBox txtAsuguradoNombre;
        private TextBox txtAseguradoApellido;
        private Label label12;
        private TextBox txtDireccionCobro;
        private Label label13;
        private Label label11;
        private TextBox txtContratanteDireccion;
        private Label label10;
        private TextBox txtContratanteNit;
        private Label label9;
        private TextBox txtContratanteNombre;
        private Label label8;
        private GroupBox groupBox1;
        private TextBox txtVigenciaFinal;
        private TextBox txtCodigoPoliza;
        private Label label7;
        private Label label2;
        private TextBox txtVigenciaInicial;
        private TextBox txtCodigoProducto;
        private Label label6;
        private Label label3;
        private TextBox txtNumeroPoliza;
        private Label label4;
        private Label label5;
        private TextBox txtNombreProducto;
        private TabControl tabControl1;
        private Button btnAyuda;
        private Button btnAcercaDe;
        private Button button1;
        private Label label26;
        private SaveFileDialog guardarTextoBase;
        private ProgressBar progressBar1;
        private GroupBox groupBox3;
        private GroupBox groupBox5;
        private GroupBox groupBoxValidacion;
        private Label lblResultados;
        private Button btnReset;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button4;
        private Button button3;

    }
}

