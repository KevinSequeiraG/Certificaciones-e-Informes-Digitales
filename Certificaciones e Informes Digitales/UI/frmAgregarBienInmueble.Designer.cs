
namespace Certificaciones_e_Informes_Digitales.UI
{
    partial class frmAgregarBienInmueble
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
            this.txtMide = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblMide = new System.Windows.Forms.Label();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.lblIDPersona = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblAgregarCert = new System.Windows.Forms.Label();
            this.txtIDPersona = new System.Windows.Forms.TextBox();
            this.txtValorFiscal = new System.Windows.Forms.TextBox();
            this.lblValorFiscal = new System.Windows.Forms.Label();
            this.txtNaturaleza = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbID = new System.Windows.Forms.MaskedTextBox();
            this.cboProvincia = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtMide
            // 
            this.txtMide.BackColor = System.Drawing.Color.Firebrick;
            this.txtMide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMide.ForeColor = System.Drawing.Color.Silver;
            this.txtMide.Location = new System.Drawing.Point(94, 384);
            this.txtMide.Name = "txtMide";
            this.txtMide.Size = new System.Drawing.Size(314, 31);
            this.txtMide.TabIndex = 93;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Maroon;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(44, 604);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 60);
            this.btnCancelar.TabIndex = 92;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Maroon;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(372, 604);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(121, 60);
            this.btnAceptar.TabIndex = 91;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblMide
            // 
            this.lblMide.AutoSize = true;
            this.lblMide.BackColor = System.Drawing.Color.Transparent;
            this.lblMide.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMide.ForeColor = System.Drawing.Color.White;
            this.lblMide.Location = new System.Drawing.Point(90, 358);
            this.lblMide.Name = "lblMide";
            this.lblMide.Size = new System.Drawing.Size(68, 23);
            this.lblMide.TabIndex = 90;
            this.lblMide.Text = "Mide:";
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.BackColor = System.Drawing.Color.Transparent;
            this.lblDetalle.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.ForeColor = System.Drawing.Color.White;
            this.lblDetalle.Location = new System.Drawing.Point(90, 280);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(131, 23);
            this.lblDetalle.TabIndex = 89;
            this.lblDetalle.Text = "Provincia:";
            // 
            // lblIDPersona
            // 
            this.lblIDPersona.AutoSize = true;
            this.lblIDPersona.BackColor = System.Drawing.Color.Transparent;
            this.lblIDPersona.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDPersona.ForeColor = System.Drawing.Color.White;
            this.lblIDPersona.Location = new System.Drawing.Point(90, 203);
            this.lblIDPersona.Name = "lblIDPersona";
            this.lblIDPersona.Size = new System.Drawing.Size(139, 23);
            this.lblIDPersona.TabIndex = 88;
            this.lblIDPersona.Text = "ID Persona:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(90, 128);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(38, 23);
            this.lblID.TabIndex = 87;
            this.lblID.Text = "ID:";
            // 
            // lblAgregarCert
            // 
            this.lblAgregarCert.AutoSize = true;
            this.lblAgregarCert.BackColor = System.Drawing.Color.Transparent;
            this.lblAgregarCert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAgregarCert.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarCert.ForeColor = System.Drawing.Color.White;
            this.lblAgregarCert.Location = new System.Drawing.Point(140, 24);
            this.lblAgregarCert.Name = "lblAgregarCert";
            this.lblAgregarCert.Size = new System.Drawing.Size(254, 34);
            this.lblAgregarCert.TabIndex = 85;
            this.lblAgregarCert.Text = "Agregar Bien";
            // 
            // txtIDPersona
            // 
            this.txtIDPersona.BackColor = System.Drawing.Color.Firebrick;
            this.txtIDPersona.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDPersona.ForeColor = System.Drawing.Color.Silver;
            this.txtIDPersona.Location = new System.Drawing.Point(94, 229);
            this.txtIDPersona.Name = "txtIDPersona";
            this.txtIDPersona.Size = new System.Drawing.Size(314, 31);
            this.txtIDPersona.TabIndex = 83;
            // 
            // txtValorFiscal
            // 
            this.txtValorFiscal.BackColor = System.Drawing.Color.Firebrick;
            this.txtValorFiscal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorFiscal.ForeColor = System.Drawing.Color.Silver;
            this.txtValorFiscal.Location = new System.Drawing.Point(94, 459);
            this.txtValorFiscal.Name = "txtValorFiscal";
            this.txtValorFiscal.Size = new System.Drawing.Size(314, 31);
            this.txtValorFiscal.TabIndex = 95;
            // 
            // lblValorFiscal
            // 
            this.lblValorFiscal.AutoSize = true;
            this.lblValorFiscal.BackColor = System.Drawing.Color.Transparent;
            this.lblValorFiscal.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorFiscal.ForeColor = System.Drawing.Color.White;
            this.lblValorFiscal.Location = new System.Drawing.Point(90, 433);
            this.lblValorFiscal.Name = "lblValorFiscal";
            this.lblValorFiscal.Size = new System.Drawing.Size(160, 23);
            this.lblValorFiscal.TabIndex = 94;
            this.lblValorFiscal.Text = "Valor Fiscal:";
            // 
            // txtNaturaleza
            // 
            this.txtNaturaleza.BackColor = System.Drawing.Color.Firebrick;
            this.txtNaturaleza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNaturaleza.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaturaleza.ForeColor = System.Drawing.Color.Silver;
            this.txtNaturaleza.Location = new System.Drawing.Point(94, 537);
            this.txtNaturaleza.Name = "txtNaturaleza";
            this.txtNaturaleza.Size = new System.Drawing.Size(314, 31);
            this.txtNaturaleza.TabIndex = 97;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.White;
            this.lblPrecio.Location = new System.Drawing.Point(90, 511);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(156, 23);
            this.lblPrecio.TabIndex = 96;
            this.lblPrecio.Text = "Naturaleza:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(180, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 34);
            this.label3.TabIndex = 98;
            this.label3.Text = "Inmueble";
            // 
            // mtbID
            // 
            this.mtbID.BackColor = System.Drawing.Color.Firebrick;
            this.mtbID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic);
            this.mtbID.ForeColor = System.Drawing.Color.White;
            this.mtbID.Location = new System.Drawing.Point(94, 164);
            this.mtbID.Mask = "000000000000000000000000000000000";
            this.mtbID.Name = "mtbID";
            this.mtbID.Size = new System.Drawing.Size(314, 31);
            this.mtbID.TabIndex = 99;
            // 
            // cboProvincia
            // 
            this.cboProvincia.BackColor = System.Drawing.Color.Firebrick;
            this.cboProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic);
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Location = new System.Drawing.Point(94, 306);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(179, 33);
            this.cboProvincia.TabIndex = 100;
            // 
            // frmAgregarBienInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Certificaciones_e_Informes_Digitales.Properties.Resources.FondoCrearUser;
            this.ClientSize = new System.Drawing.Size(516, 691);
            this.Controls.Add(this.cboProvincia);
            this.Controls.Add(this.mtbID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNaturaleza);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtValorFiscal);
            this.Controls.Add(this.lblValorFiscal);
            this.Controls.Add(this.txtMide);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblMide);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.lblIDPersona);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblAgregarCert);
            this.Controls.Add(this.txtIDPersona);
            this.Name = "frmAgregarBienInmueble";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarBienInmueble";
            this.Load += new System.EventHandler(this.frmAgregarBienInmueble_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMide;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblMide;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Label lblIDPersona;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblAgregarCert;
        private System.Windows.Forms.TextBox txtIDPersona;
        private System.Windows.Forms.TextBox txtValorFiscal;
        private System.Windows.Forms.Label lblValorFiscal;
        private System.Windows.Forms.TextBox txtNaturaleza;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbID;
        private System.Windows.Forms.ComboBox cboProvincia;
    }
}