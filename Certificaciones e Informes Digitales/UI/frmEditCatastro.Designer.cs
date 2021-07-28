
namespace Certificaciones_e_Informes_Digitales.UI
{
    partial class frmEditCatastro
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
            this.rdbPersonaF = new System.Windows.Forms.RadioButton();
            this.rdbPersonaJ = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtTamanno = new System.Windows.Forms.MaskedTextBox();
            this.lblTamanno = new System.Windows.Forms.Label();
            this.txtAnno = new System.Windows.Forms.MaskedTextBox();
            this.lblannoContruccion = new System.Windows.Forms.Label();
            this.lblUsoLocal = new System.Windows.Forms.Label();
            this.lblLocalizacion = new System.Windows.Forms.Label();
            this.lblIdPersona = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblAgregarCat = new System.Windows.Forms.Label();
            this.txtUsoLocal = new System.Windows.Forms.TextBox();
            this.txtLocalizacion = new System.Windows.Forms.TextBox();
            this.txtIDPersona = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rdbPersonaF
            // 
            this.rdbPersonaF.AutoSize = true;
            this.rdbPersonaF.BackColor = System.Drawing.Color.Transparent;
            this.rdbPersonaF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPersonaF.ForeColor = System.Drawing.Color.White;
            this.rdbPersonaF.Location = new System.Drawing.Point(230, 192);
            this.rdbPersonaF.Name = "rdbPersonaF";
            this.rdbPersonaF.Size = new System.Drawing.Size(131, 24);
            this.rdbPersonaF.TabIndex = 121;
            this.rdbPersonaF.TabStop = true;
            this.rdbPersonaF.Text = "Persona Fisica";
            this.rdbPersonaF.UseVisualStyleBackColor = false;
            // 
            // rdbPersonaJ
            // 
            this.rdbPersonaJ.AutoSize = true;
            this.rdbPersonaJ.BackColor = System.Drawing.Color.Transparent;
            this.rdbPersonaJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPersonaJ.ForeColor = System.Drawing.Color.White;
            this.rdbPersonaJ.Location = new System.Drawing.Point(80, 192);
            this.rdbPersonaJ.Name = "rdbPersonaJ";
            this.rdbPersonaJ.Size = new System.Drawing.Size(144, 24);
            this.rdbPersonaJ.TabIndex = 120;
            this.rdbPersonaJ.TabStop = true;
            this.rdbPersonaJ.Text = "Persona Juridica";
            this.rdbPersonaJ.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Maroon;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(21, 615);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 60);
            this.btnCancelar.TabIndex = 119;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Maroon;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(349, 615);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(121, 60);
            this.btnAceptar.TabIndex = 118;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtTamanno
            // 
            this.txtTamanno.BackColor = System.Drawing.Color.Firebrick;
            this.txtTamanno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTamanno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic);
            this.txtTamanno.ForeColor = System.Drawing.Color.Silver;
            this.txtTamanno.Location = new System.Drawing.Point(78, 565);
            this.txtTamanno.Name = "txtTamanno";
            this.txtTamanno.Size = new System.Drawing.Size(100, 31);
            this.txtTamanno.TabIndex = 117;
            this.txtTamanno.Text = "00000";
            // 
            // lblTamanno
            // 
            this.lblTamanno.AutoSize = true;
            this.lblTamanno.BackColor = System.Drawing.Color.Transparent;
            this.lblTamanno.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamanno.ForeColor = System.Drawing.Color.White;
            this.lblTamanno.Location = new System.Drawing.Point(74, 538);
            this.lblTamanno.Name = "lblTamanno";
            this.lblTamanno.Size = new System.Drawing.Size(273, 23);
            this.lblTamanno.TabIndex = 116;
            this.lblTamanno.Text = "Superficie Construida:";
            // 
            // txtAnno
            // 
            this.txtAnno.BackColor = System.Drawing.Color.Firebrick;
            this.txtAnno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAnno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic);
            this.txtAnno.ForeColor = System.Drawing.Color.Silver;
            this.txtAnno.Location = new System.Drawing.Point(78, 493);
            this.txtAnno.Name = "txtAnno";
            this.txtAnno.Size = new System.Drawing.Size(100, 31);
            this.txtAnno.TabIndex = 115;
            this.txtAnno.Text = "0000";
            // 
            // lblannoContruccion
            // 
            this.lblannoContruccion.AutoSize = true;
            this.lblannoContruccion.BackColor = System.Drawing.Color.Transparent;
            this.lblannoContruccion.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblannoContruccion.ForeColor = System.Drawing.Color.White;
            this.lblannoContruccion.Location = new System.Drawing.Point(74, 466);
            this.lblannoContruccion.Name = "lblannoContruccion";
            this.lblannoContruccion.Size = new System.Drawing.Size(268, 23);
            this.lblannoContruccion.TabIndex = 114;
            this.lblannoContruccion.Text = "Año de construcción:";
            // 
            // lblUsoLocal
            // 
            this.lblUsoLocal.AutoSize = true;
            this.lblUsoLocal.BackColor = System.Drawing.Color.Transparent;
            this.lblUsoLocal.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsoLocal.ForeColor = System.Drawing.Color.White;
            this.lblUsoLocal.Location = new System.Drawing.Point(74, 388);
            this.lblUsoLocal.Name = "lblUsoLocal";
            this.lblUsoLocal.Size = new System.Drawing.Size(245, 23);
            this.lblUsoLocal.TabIndex = 113;
            this.lblUsoLocal.Text = "Uso local principal:";
            // 
            // lblLocalizacion
            // 
            this.lblLocalizacion.AutoSize = true;
            this.lblLocalizacion.BackColor = System.Drawing.Color.Transparent;
            this.lblLocalizacion.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalizacion.ForeColor = System.Drawing.Color.White;
            this.lblLocalizacion.Location = new System.Drawing.Point(74, 238);
            this.lblLocalizacion.Name = "lblLocalizacion";
            this.lblLocalizacion.Size = new System.Drawing.Size(171, 23);
            this.lblLocalizacion.TabIndex = 112;
            this.lblLocalizacion.Text = "Localización:";
            // 
            // lblIdPersona
            // 
            this.lblIdPersona.AutoSize = true;
            this.lblIdPersona.BackColor = System.Drawing.Color.Transparent;
            this.lblIdPersona.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPersona.ForeColor = System.Drawing.Color.White;
            this.lblIdPersona.Location = new System.Drawing.Point(74, 129);
            this.lblIdPersona.Name = "lblIdPersona";
            this.lblIdPersona.Size = new System.Drawing.Size(139, 23);
            this.lblIdPersona.TabIndex = 111;
            this.lblIdPersona.Text = "ID Persona:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(74, 60);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(155, 23);
            this.lblID.TabIndex = 110;
            this.lblID.Text = "ID Catastro:";
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.Firebrick;
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.ForeColor = System.Drawing.Color.Silver;
            this.txtid.Location = new System.Drawing.Point(78, 86);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(314, 31);
            this.txtid.TabIndex = 109;
            // 
            // lblAgregarCat
            // 
            this.lblAgregarCat.AutoSize = true;
            this.lblAgregarCat.BackColor = System.Drawing.Color.Transparent;
            this.lblAgregarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAgregarCat.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarCat.ForeColor = System.Drawing.Color.White;
            this.lblAgregarCat.Location = new System.Drawing.Point(72, 5);
            this.lblAgregarCat.Name = "lblAgregarCat";
            this.lblAgregarCat.Size = new System.Drawing.Size(312, 34);
            this.lblAgregarCat.TabIndex = 108;
            this.lblAgregarCat.Text = "Editar Catastro";
            // 
            // txtUsoLocal
            // 
            this.txtUsoLocal.BackColor = System.Drawing.Color.Firebrick;
            this.txtUsoLocal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsoLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsoLocal.ForeColor = System.Drawing.Color.Silver;
            this.txtUsoLocal.Location = new System.Drawing.Point(78, 414);
            this.txtUsoLocal.Name = "txtUsoLocal";
            this.txtUsoLocal.Size = new System.Drawing.Size(314, 31);
            this.txtUsoLocal.TabIndex = 107;
            // 
            // txtLocalizacion
            // 
            this.txtLocalizacion.BackColor = System.Drawing.Color.Firebrick;
            this.txtLocalizacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLocalizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalizacion.ForeColor = System.Drawing.Color.Silver;
            this.txtLocalizacion.Location = new System.Drawing.Point(78, 264);
            this.txtLocalizacion.Multiline = true;
            this.txtLocalizacion.Name = "txtLocalizacion";
            this.txtLocalizacion.Size = new System.Drawing.Size(314, 104);
            this.txtLocalizacion.TabIndex = 106;
            // 
            // txtIDPersona
            // 
            this.txtIDPersona.BackColor = System.Drawing.Color.Firebrick;
            this.txtIDPersona.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDPersona.ForeColor = System.Drawing.Color.Silver;
            this.txtIDPersona.Location = new System.Drawing.Point(78, 155);
            this.txtIDPersona.Name = "txtIDPersona";
            this.txtIDPersona.Size = new System.Drawing.Size(314, 31);
            this.txtIDPersona.TabIndex = 105;
            // 
            // frmEditCatastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Certificaciones_e_Informes_Digitales.Properties.Resources.FondoCrearUser;
            this.ClientSize = new System.Drawing.Size(491, 687);
            this.Controls.Add(this.rdbPersonaF);
            this.Controls.Add(this.rdbPersonaJ);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtTamanno);
            this.Controls.Add(this.lblTamanno);
            this.Controls.Add(this.txtAnno);
            this.Controls.Add(this.lblannoContruccion);
            this.Controls.Add(this.lblUsoLocal);
            this.Controls.Add(this.lblLocalizacion);
            this.Controls.Add(this.lblIdPersona);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblAgregarCat);
            this.Controls.Add(this.txtUsoLocal);
            this.Controls.Add(this.txtLocalizacion);
            this.Controls.Add(this.txtIDPersona);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditCatastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditCatastro";
            this.Load += new System.EventHandler(this.frmEditCatastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbPersonaF;
        private System.Windows.Forms.RadioButton rdbPersonaJ;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.MaskedTextBox txtTamanno;
        private System.Windows.Forms.Label lblTamanno;
        private System.Windows.Forms.MaskedTextBox txtAnno;
        private System.Windows.Forms.Label lblannoContruccion;
        private System.Windows.Forms.Label lblUsoLocal;
        private System.Windows.Forms.Label lblLocalizacion;
        private System.Windows.Forms.Label lblIdPersona;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblAgregarCat;
        private System.Windows.Forms.TextBox txtUsoLocal;
        private System.Windows.Forms.TextBox txtLocalizacion;
        private System.Windows.Forms.TextBox txtIDPersona;
    }
}