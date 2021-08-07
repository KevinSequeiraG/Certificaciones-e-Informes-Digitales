
namespace Certificaciones_e_Informes_Digitales.UI
{
    partial class frmAgregarTarjeta
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
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblValorFiscal = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblMide = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTipoTarjeta = new System.Windows.Forms.ComboBox();
            this.lblAgregarCert = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.mcrFechaVenc = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // txtCVV
            // 
            this.txtCVV.BackColor = System.Drawing.Color.Firebrick;
            this.txtCVV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCVV.ForeColor = System.Drawing.Color.Silver;
            this.txtCVV.Location = new System.Drawing.Point(51, 416);
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(314, 31);
            this.txtCVV.TabIndex = 103;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.White;
            this.lblPrecio.Location = new System.Drawing.Point(47, 390);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(57, 23);
            this.lblPrecio.TabIndex = 102;
            this.lblPrecio.Text = "CVV:";
            // 
            // lblValorFiscal
            // 
            this.lblValorFiscal.AutoSize = true;
            this.lblValorFiscal.BackColor = System.Drawing.Color.Transparent;
            this.lblValorFiscal.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorFiscal.ForeColor = System.Drawing.Color.White;
            this.lblValorFiscal.Location = new System.Drawing.Point(44, 169);
            this.lblValorFiscal.Name = "lblValorFiscal";
            this.lblValorFiscal.Size = new System.Drawing.Size(265, 23);
            this.lblValorFiscal.TabIndex = 100;
            this.lblValorFiscal.Text = "Fecha de Vencimiento:";
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.Firebrick;
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.ForeColor = System.Drawing.Color.Silver;
            this.txtid.Location = new System.Drawing.Point(48, 120);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(314, 31);
            this.txtid.TabIndex = 99;
            // 
            // lblMide
            // 
            this.lblMide.AutoSize = true;
            this.lblMide.BackColor = System.Drawing.Color.Transparent;
            this.lblMide.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMide.ForeColor = System.Drawing.Color.White;
            this.lblMide.Location = new System.Drawing.Point(44, 94);
            this.lblMide.Name = "lblMide";
            this.lblMide.Size = new System.Drawing.Size(237, 23);
            this.lblMide.TabIndex = 98;
            this.lblMide.Text = "Numero de Tarjeta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 23);
            this.label1.TabIndex = 104;
            this.label1.Text = "Tipo:";
            // 
            // cboTipoTarjeta
            // 
            this.cboTipoTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic);
            this.cboTipoTarjeta.FormattingEnabled = true;
            this.cboTipoTarjeta.Location = new System.Drawing.Point(54, 498);
            this.cboTipoTarjeta.Name = "cboTipoTarjeta";
            this.cboTipoTarjeta.Size = new System.Drawing.Size(156, 33);
            this.cboTipoTarjeta.TabIndex = 105;
            // 
            // lblAgregarCert
            // 
            this.lblAgregarCert.AutoSize = true;
            this.lblAgregarCert.BackColor = System.Drawing.Color.Transparent;
            this.lblAgregarCert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAgregarCert.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarCert.ForeColor = System.Drawing.Color.White;
            this.lblAgregarCert.Location = new System.Drawing.Point(45, 25);
            this.lblAgregarCert.Name = "lblAgregarCert";
            this.lblAgregarCert.Size = new System.Drawing.Size(318, 34);
            this.lblAgregarCert.TabIndex = 106;
            this.lblAgregarCert.Text = "Agregar Tarjeta";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Maroon;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(51, 556);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(121, 60);
            this.btnVolver.TabIndex = 108;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Maroon;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(244, 556);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(121, 60);
            this.btnAceptar.TabIndex = 107;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // mcrFechaVenc
            // 
            this.mcrFechaVenc.Location = new System.Drawing.Point(51, 201);
            this.mcrFechaVenc.Name = "mcrFechaVenc";
            this.mcrFechaVenc.TabIndex = 109;
            // 
            // frmAgregarTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Certificaciones_e_Informes_Digitales.Properties.Resources.FondoCrearUser;
            this.ClientSize = new System.Drawing.Size(409, 649);
            this.Controls.Add(this.mcrFechaVenc);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblAgregarCert);
            this.Controls.Add(this.cboTipoTarjeta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCVV);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblValorFiscal);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblMide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregarTarjeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarTarjeta";
            this.Load += new System.EventHandler(this.frmAgregarTarjeta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblValorFiscal;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblMide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTipoTarjeta;
        private System.Windows.Forms.Label lblAgregarCert;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.MonthCalendar mcrFechaVenc;
    }
}