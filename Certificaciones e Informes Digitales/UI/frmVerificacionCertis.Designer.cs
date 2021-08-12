
namespace Certificaciones_e_Informes_Digitales.UI
{
    partial class frmVerificacionCertis
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
            this.lblCodCert = new System.Windows.Forms.Label();
            this.txtCodigoCert = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCodCert
            // 
            this.lblCodCert.AutoSize = true;
            this.lblCodCert.BackColor = System.Drawing.Color.Transparent;
            this.lblCodCert.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblCodCert.ForeColor = System.Drawing.Color.White;
            this.lblCodCert.Location = new System.Drawing.Point(21, 30);
            this.lblCodCert.Name = "lblCodCert";
            this.lblCodCert.Size = new System.Drawing.Size(417, 23);
            this.lblCodCert.TabIndex = 0;
            this.lblCodCert.Text = "Ingrese el codigo de Certificacion:";
            // 
            // txtCodigoCert
            // 
            this.txtCodigoCert.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtCodigoCert.Location = new System.Drawing.Point(24, 70);
            this.txtCodigoCert.Name = "txtCodigoCert";
            this.txtCodigoCert.Size = new System.Drawing.Size(269, 30);
            this.txtCodigoCert.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Maroon;
            this.btnAceptar.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAceptar.Location = new System.Drawing.Point(312, 133);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(157, 49);
            this.btnAceptar.TabIndex = 34;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Maroon;
            this.btnVolver.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVolver.Location = new System.Drawing.Point(24, 133);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(157, 49);
            this.btnVolver.TabIndex = 35;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // frmVerificacionCertis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Certificaciones_e_Informes_Digitales.Properties.Resources.FondoCrearUser;
            this.ClientSize = new System.Drawing.Size(496, 212);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtCodigoCert);
            this.Controls.Add(this.lblCodCert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVerificacionCertis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVerificacionCertis";
            this.Load += new System.EventHandler(this.frmVerificacionCertis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodCert;
        private System.Windows.Forms.TextBox txtCodigoCert;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnVolver;
    }
}