
namespace Certificaciones_e_Informes_Digitales.UI
{
    partial class frmAgregarBienMueble
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMueble = new System.Windows.Forms.Label();
            this.lblAgregarBien = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboMoneda = new System.Windows.Forms.ComboBox();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.cboUso = new System.Windows.Forms.ComboBox();
            this.lblUso = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblAnnoFab = new System.Windows.Forms.Label();
            this.txtAnnoFab = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtValorHacienda = new System.Windows.Forms.TextBox();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.lblValorhacienda = new System.Windows.Forms.Label();
            this.txtTraccion = new System.Windows.Forms.TextBox();
            this.lblTraccion = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.lblSerie = new System.Windows.Forms.Label();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.lblMide = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblIDPersona = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtIDPersona = new System.Windows.Forms.TextBox();
            this.rdbInscrito = new System.Windows.Forms.RadioButton();
            this.rdbNoInscrito = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMueble
            // 
            this.lblMueble.AutoSize = true;
            this.lblMueble.BackColor = System.Drawing.Color.Transparent;
            this.lblMueble.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMueble.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMueble.ForeColor = System.Drawing.Color.White;
            this.lblMueble.Location = new System.Drawing.Point(175, 55);
            this.lblMueble.Name = "lblMueble";
            this.lblMueble.Size = new System.Drawing.Size(141, 34);
            this.lblMueble.TabIndex = 100;
            this.lblMueble.Text = "Mueble";
            // 
            // lblAgregarBien
            // 
            this.lblAgregarBien.AutoSize = true;
            this.lblAgregarBien.BackColor = System.Drawing.Color.Transparent;
            this.lblAgregarBien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAgregarBien.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarBien.ForeColor = System.Drawing.Color.White;
            this.lblAgregarBien.Location = new System.Drawing.Point(128, 21);
            this.lblAgregarBien.Name = "lblAgregarBien";
            this.lblAgregarBien.Size = new System.Drawing.Size(254, 34);
            this.lblAgregarBien.TabIndex = 99;
            this.lblAgregarBien.Text = "Agregar Bien";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Maroon;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(22, 624);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 60);
            this.btnCancelar.TabIndex = 109;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Maroon;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(361, 624);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(121, 60);
            this.btnAceptar.TabIndex = 108;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.rdbNoInscrito);
            this.panel1.Controls.Add(this.rdbInscrito);
            this.panel1.Controls.Add(this.cboMoneda);
            this.panel1.Controls.Add(this.lblMoneda);
            this.panel1.Controls.Add(this.cboUso);
            this.panel1.Controls.Add(this.lblUso);
            this.panel1.Controls.Add(this.lblEstado);
            this.panel1.Controls.Add(this.lblAnnoFab);
            this.panel1.Controls.Add(this.txtAnnoFab);
            this.panel1.Controls.Add(this.lblColor);
            this.panel1.Controls.Add(this.txtValorHacienda);
            this.panel1.Controls.Add(this.lblCapacidad);
            this.panel1.Controls.Add(this.txtColor);
            this.panel1.Controls.Add(this.txtCapacidad);
            this.panel1.Controls.Add(this.lblValorhacienda);
            this.panel1.Controls.Add(this.txtTraccion);
            this.panel1.Controls.Add(this.lblTraccion);
            this.panel1.Controls.Add(this.txtSerie);
            this.panel1.Controls.Add(this.lblSerie);
            this.panel1.Controls.Add(this.txtCat);
            this.panel1.Controls.Add(this.lblMide);
            this.panel1.Controls.Add(this.lblMarca);
            this.panel1.Controls.Add(this.lblIDPersona);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.txtMarca);
            this.panel1.Controls.Add(this.txtIDPersona);
            this.panel1.Location = new System.Drawing.Point(22, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 469);
            this.panel1.TabIndex = 224;
            // 
            // cboMoneda
            // 
            this.cboMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic);
            this.cboMoneda.FormattingEnabled = true;
            this.cboMoneda.Location = new System.Drawing.Point(41, 971);
            this.cboMoneda.Name = "cboMoneda";
            this.cboMoneda.Size = new System.Drawing.Size(147, 33);
            this.cboMoneda.TabIndex = 243;
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.BackColor = System.Drawing.Color.Transparent;
            this.lblMoneda.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneda.ForeColor = System.Drawing.Color.White;
            this.lblMoneda.Location = new System.Drawing.Point(37, 937);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(108, 23);
            this.lblMoneda.TabIndex = 242;
            this.lblMoneda.Text = "Moneda:";
            // 
            // cboUso
            // 
            this.cboUso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic);
            this.cboUso.FormattingEnabled = true;
            this.cboUso.Location = new System.Drawing.Point(41, 893);
            this.cboUso.Name = "cboUso";
            this.cboUso.Size = new System.Drawing.Size(147, 33);
            this.cboUso.TabIndex = 241;
            // 
            // lblUso
            // 
            this.lblUso.AutoSize = true;
            this.lblUso.BackColor = System.Drawing.Color.Transparent;
            this.lblUso.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUso.ForeColor = System.Drawing.Color.White;
            this.lblUso.Location = new System.Drawing.Point(37, 859);
            this.lblUso.Name = "lblUso";
            this.lblUso.Size = new System.Drawing.Size(57, 23);
            this.lblUso.TabIndex = 240;
            this.lblUso.Text = "Uso:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(37, 781);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(96, 23);
            this.lblEstado.TabIndex = 238;
            this.lblEstado.Text = "Estado:";
            // 
            // lblAnnoFab
            // 
            this.lblAnnoFab.AutoSize = true;
            this.lblAnnoFab.BackColor = System.Drawing.Color.Transparent;
            this.lblAnnoFab.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnoFab.ForeColor = System.Drawing.Color.White;
            this.lblAnnoFab.Location = new System.Drawing.Point(37, 476);
            this.lblAnnoFab.Name = "lblAnnoFab";
            this.lblAnnoFab.Size = new System.Drawing.Size(245, 23);
            this.lblAnnoFab.TabIndex = 233;
            this.lblAnnoFab.Text = "Año de Fabricación:";
            // 
            // txtAnnoFab
            // 
            this.txtAnnoFab.BackColor = System.Drawing.Color.Firebrick;
            this.txtAnnoFab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAnnoFab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnnoFab.ForeColor = System.Drawing.Color.Silver;
            this.txtAnnoFab.Location = new System.Drawing.Point(41, 502);
            this.txtAnnoFab.Name = "txtAnnoFab";
            this.txtAnnoFab.Size = new System.Drawing.Size(314, 31);
            this.txtAnnoFab.TabIndex = 232;
            this.txtAnnoFab.Text = "Año de Fabricación...";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.BackColor = System.Drawing.Color.Transparent;
            this.lblColor.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.Color.White;
            this.lblColor.Location = new System.Drawing.Point(37, 551);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(87, 23);
            this.lblColor.TabIndex = 234;
            this.lblColor.Text = "Color:";
            // 
            // txtValorHacienda
            // 
            this.txtValorHacienda.BackColor = System.Drawing.Color.Firebrick;
            this.txtValorHacienda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorHacienda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtValorHacienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorHacienda.ForeColor = System.Drawing.Color.Silver;
            this.txtValorHacienda.Location = new System.Drawing.Point(41, 732);
            this.txtValorHacienda.Name = "txtValorHacienda";
            this.txtValorHacienda.Size = new System.Drawing.Size(314, 31);
            this.txtValorHacienda.TabIndex = 237;
            this.txtValorHacienda.Text = "Valor de Hacienda...";
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.BackColor = System.Drawing.Color.Transparent;
            this.lblCapacidad.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidad.ForeColor = System.Drawing.Color.White;
            this.lblCapacidad.Location = new System.Drawing.Point(37, 628);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(139, 23);
            this.lblCapacidad.TabIndex = 235;
            this.lblCapacidad.Text = "Capacidad:";
            // 
            // txtColor
            // 
            this.txtColor.BackColor = System.Drawing.Color.Firebrick;
            this.txtColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.ForeColor = System.Drawing.Color.Silver;
            this.txtColor.Location = new System.Drawing.Point(41, 577);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(314, 31);
            this.txtColor.TabIndex = 230;
            this.txtColor.Text = "Color...";
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.BackColor = System.Drawing.Color.Firebrick;
            this.txtCapacidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacidad.ForeColor = System.Drawing.Color.Silver;
            this.txtCapacidad.Location = new System.Drawing.Point(41, 654);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(314, 31);
            this.txtCapacidad.TabIndex = 231;
            this.txtCapacidad.Text = "Capacidad...";
            // 
            // lblValorhacienda
            // 
            this.lblValorhacienda.AutoSize = true;
            this.lblValorhacienda.BackColor = System.Drawing.Color.Transparent;
            this.lblValorhacienda.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorhacienda.ForeColor = System.Drawing.Color.White;
            this.lblValorhacienda.Location = new System.Drawing.Point(37, 706);
            this.lblValorhacienda.Name = "lblValorhacienda";
            this.lblValorhacienda.Size = new System.Drawing.Size(235, 23);
            this.lblValorhacienda.TabIndex = 236;
            this.lblValorhacienda.Text = "Valor de Hacienda:";
            // 
            // txtTraccion
            // 
            this.txtTraccion.BackColor = System.Drawing.Color.Firebrick;
            this.txtTraccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTraccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTraccion.ForeColor = System.Drawing.Color.Silver;
            this.txtTraccion.Location = new System.Drawing.Point(41, 421);
            this.txtTraccion.Name = "txtTraccion";
            this.txtTraccion.Size = new System.Drawing.Size(314, 31);
            this.txtTraccion.TabIndex = 229;
            this.txtTraccion.Text = "Tracción...";
            // 
            // lblTraccion
            // 
            this.lblTraccion.AutoSize = true;
            this.lblTraccion.BackColor = System.Drawing.Color.Transparent;
            this.lblTraccion.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraccion.ForeColor = System.Drawing.Color.White;
            this.lblTraccion.Location = new System.Drawing.Point(37, 395);
            this.lblTraccion.Name = "lblTraccion";
            this.lblTraccion.Size = new System.Drawing.Size(125, 23);
            this.lblTraccion.TabIndex = 228;
            this.lblTraccion.Text = "Tracción:";
            // 
            // txtSerie
            // 
            this.txtSerie.BackColor = System.Drawing.Color.Firebrick;
            this.txtSerie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerie.ForeColor = System.Drawing.Color.Silver;
            this.txtSerie.Location = new System.Drawing.Point(41, 343);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(314, 31);
            this.txtSerie.TabIndex = 227;
            this.txtSerie.Text = "Serie...";
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.BackColor = System.Drawing.Color.Transparent;
            this.lblSerie.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.ForeColor = System.Drawing.Color.White;
            this.lblSerie.Location = new System.Drawing.Point(37, 317);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(69, 23);
            this.lblSerie.TabIndex = 226;
            this.lblSerie.Text = "Serie:";
            // 
            // txtCat
            // 
            this.txtCat.BackColor = System.Drawing.Color.Firebrick;
            this.txtCat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCat.ForeColor = System.Drawing.Color.Silver;
            this.txtCat.Location = new System.Drawing.Point(41, 268);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(314, 31);
            this.txtCat.TabIndex = 225;
            this.txtCat.Text = "Categoría...";
            // 
            // lblMide
            // 
            this.lblMide.AutoSize = true;
            this.lblMide.BackColor = System.Drawing.Color.Transparent;
            this.lblMide.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMide.ForeColor = System.Drawing.Color.White;
            this.lblMide.Location = new System.Drawing.Point(37, 242);
            this.lblMide.Name = "lblMide";
            this.lblMide.Size = new System.Drawing.Size(136, 23);
            this.lblMide.TabIndex = 224;
            this.lblMide.Text = "Categoría:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblMarca.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.White;
            this.lblMarca.Location = new System.Drawing.Point(37, 162);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(93, 23);
            this.lblMarca.TabIndex = 209;
            this.lblMarca.Text = "Marca:";
            // 
            // lblIDPersona
            // 
            this.lblIDPersona.AutoSize = true;
            this.lblIDPersona.BackColor = System.Drawing.Color.Transparent;
            this.lblIDPersona.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDPersona.ForeColor = System.Drawing.Color.White;
            this.lblIDPersona.Location = new System.Drawing.Point(37, 85);
            this.lblIDPersona.Name = "lblIDPersona";
            this.lblIDPersona.Size = new System.Drawing.Size(139, 23);
            this.lblIDPersona.TabIndex = 208;
            this.lblIDPersona.Text = "ID Persona:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(37, 10);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(38, 23);
            this.lblID.TabIndex = 207;
            this.lblID.Text = "ID:";
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.Firebrick;
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.ForeColor = System.Drawing.Color.Silver;
            this.txtid.Location = new System.Drawing.Point(41, 36);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(314, 31);
            this.txtid.TabIndex = 206;
            this.txtid.Text = "ID...";
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.Color.Firebrick;
            this.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.ForeColor = System.Drawing.Color.Silver;
            this.txtMarca.Location = new System.Drawing.Point(41, 188);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(314, 31);
            this.txtMarca.TabIndex = 205;
            this.txtMarca.Text = "Marca...";
            // 
            // txtIDPersona
            // 
            this.txtIDPersona.BackColor = System.Drawing.Color.Firebrick;
            this.txtIDPersona.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDPersona.ForeColor = System.Drawing.Color.Silver;
            this.txtIDPersona.Location = new System.Drawing.Point(41, 111);
            this.txtIDPersona.Name = "txtIDPersona";
            this.txtIDPersona.Size = new System.Drawing.Size(314, 31);
            this.txtIDPersona.TabIndex = 204;
            this.txtIDPersona.Text = "ID Persona...";
            // 
            // rdbInscrito
            // 
            this.rdbInscrito.AutoSize = true;
            this.rdbInscrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic);
            this.rdbInscrito.ForeColor = System.Drawing.Color.White;
            this.rdbInscrito.Location = new System.Drawing.Point(48, 817);
            this.rdbInscrito.Name = "rdbInscrito";
            this.rdbInscrito.Size = new System.Drawing.Size(99, 29);
            this.rdbInscrito.TabIndex = 244;
            this.rdbInscrito.TabStop = true;
            this.rdbInscrito.Text = "Inscrito";
            this.rdbInscrito.UseVisualStyleBackColor = true;
            // 
            // rdbNoInscrito
            // 
            this.rdbNoInscrito.AutoSize = true;
            this.rdbNoInscrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic);
            this.rdbNoInscrito.ForeColor = System.Drawing.Color.White;
            this.rdbNoInscrito.Location = new System.Drawing.Point(228, 817);
            this.rdbNoInscrito.Name = "rdbNoInscrito";
            this.rdbNoInscrito.Size = new System.Drawing.Size(132, 29);
            this.rdbNoInscrito.TabIndex = 245;
            this.rdbNoInscrito.TabStop = true;
            this.rdbNoInscrito.Text = "No Inscrito";
            this.rdbNoInscrito.UseVisualStyleBackColor = true;
            // 
            // frmAgregarBienMueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::Certificaciones_e_Informes_Digitales.Properties.Resources.FondoCrearUser;
            this.ClientSize = new System.Drawing.Size(505, 720);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblMueble);
            this.Controls.Add(this.lblAgregarBien);
            this.Name = "frmAgregarBienMueble";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarBienMueble";
            this.Load += new System.EventHandler(this.frmAgregarBienMueble_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMueble;
        private System.Windows.Forms.Label lblAgregarBien;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboMoneda;
        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.ComboBox cboUso;
        private System.Windows.Forms.Label lblUso;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblAnnoFab;
        private System.Windows.Forms.TextBox txtAnnoFab;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtValorHacienda;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.Label lblValorhacienda;
        private System.Windows.Forms.TextBox txtTraccion;
        private System.Windows.Forms.Label lblTraccion;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.Label lblMide;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblIDPersona;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtIDPersona;
        private System.Windows.Forms.RadioButton rdbNoInscrito;
        private System.Windows.Forms.RadioButton rdbInscrito;
    }
}