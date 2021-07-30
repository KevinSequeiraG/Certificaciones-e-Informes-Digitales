
namespace Certificaciones_e_Informes_Digitales.UI
{
    partial class frmAgregarCerts
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
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblannoContruccion = new System.Windows.Forms.Label();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblAgregarCert = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.Firebrick;
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.ForeColor = System.Drawing.Color.Silver;
            this.txtPrecio.Location = new System.Drawing.Point(73, 345);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(314, 31);
            this.txtPrecio.TabIndex = 93;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Maroon;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(17, 420);
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
            this.btnAceptar.Location = new System.Drawing.Point(345, 420);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(121, 60);
            this.btnAceptar.TabIndex = 91;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblannoContruccion
            // 
            this.lblannoContruccion.AutoSize = true;
            this.lblannoContruccion.BackColor = System.Drawing.Color.Transparent;
            this.lblannoContruccion.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblannoContruccion.ForeColor = System.Drawing.Color.White;
            this.lblannoContruccion.Location = new System.Drawing.Point(69, 319);
            this.lblannoContruccion.Name = "lblannoContruccion";
            this.lblannoContruccion.Size = new System.Drawing.Size(90, 23);
            this.lblannoContruccion.TabIndex = 90;
            this.lblannoContruccion.Text = "Precio:";
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.BackColor = System.Drawing.Color.Transparent;
            this.lblDetalle.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.ForeColor = System.Drawing.Color.White;
            this.lblDetalle.Location = new System.Drawing.Point(69, 241);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(103, 23);
            this.lblDetalle.TabIndex = 89;
            this.lblDetalle.Text = "Detalle:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.Transparent;
            this.lblTipo.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.White;
            this.lblTipo.Location = new System.Drawing.Point(69, 164);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(262, 23);
            this.lblTipo.TabIndex = 88;
            this.lblTipo.Text = "Tipo de Certificación:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(69, 89);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(204, 23);
            this.lblID.TabIndex = 87;
            this.lblID.Text = "ID Certificación:";
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.Firebrick;
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.ForeColor = System.Drawing.Color.Silver;
            this.txtid.Location = new System.Drawing.Point(73, 115);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(314, 31);
            this.txtid.TabIndex = 86;
            // 
            // lblAgregarCert
            // 
            this.lblAgregarCert.AutoSize = true;
            this.lblAgregarCert.BackColor = System.Drawing.Color.Transparent;
            this.lblAgregarCert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAgregarCert.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarCert.ForeColor = System.Drawing.Color.White;
            this.lblAgregarCert.Location = new System.Drawing.Point(32, 32);
            this.lblAgregarCert.Name = "lblAgregarCert";
            this.lblAgregarCert.Size = new System.Drawing.Size(424, 34);
            this.lblAgregarCert.TabIndex = 85;
            this.lblAgregarCert.Text = "Agregar Certificación";
            // 
            // txtDetalle
            // 
            this.txtDetalle.BackColor = System.Drawing.Color.Firebrick;
            this.txtDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalle.ForeColor = System.Drawing.Color.Silver;
            this.txtDetalle.Location = new System.Drawing.Point(73, 267);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(314, 31);
            this.txtDetalle.TabIndex = 84;
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic);
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(73, 190);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(200, 33);
            this.cboTipo.TabIndex = 94;
            // 
            // frmAgregarCerts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Certificaciones_e_Informes_Digitales.Properties.Resources.FondoCrearUser;
            this.ClientSize = new System.Drawing.Size(495, 495);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblannoContruccion);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblAgregarCert);
            this.Controls.Add(this.txtDetalle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregarCerts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarCerts";
            this.Load += new System.EventHandler(this.frmAgregarCerts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblannoContruccion;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblAgregarCert;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.ComboBox cboTipo;
    }
}