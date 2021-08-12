
namespace Certificaciones_e_Informes_Digitales.UI
{
    partial class frmUsuario
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
            this.btnGestiones = new System.Windows.Forms.Button();
            this.tnVerificacion = new System.Windows.Forms.Button();
            this.btnHistorialCerts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGestiones
            // 
            this.btnGestiones.BackColor = System.Drawing.Color.Transparent;
            this.btnGestiones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestiones.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnGestiones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestiones.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestiones.ForeColor = System.Drawing.Color.LightGray;
            this.btnGestiones.Location = new System.Drawing.Point(63, 54);
            this.btnGestiones.Name = "btnGestiones";
            this.btnGestiones.Size = new System.Drawing.Size(240, 110);
            this.btnGestiones.TabIndex = 8;
            this.btnGestiones.Text = "Ventana de Compras";
            this.btnGestiones.UseVisualStyleBackColor = false;
            this.btnGestiones.Click += new System.EventHandler(this.btnGestiones_Click);
            // 
            // tnVerificacion
            // 
            this.tnVerificacion.BackColor = System.Drawing.Color.Transparent;
            this.tnVerificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tnVerificacion.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.tnVerificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tnVerificacion.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnVerificacion.ForeColor = System.Drawing.Color.LightGray;
            this.tnVerificacion.Location = new System.Drawing.Point(63, 208);
            this.tnVerificacion.Name = "tnVerificacion";
            this.tnVerificacion.Size = new System.Drawing.Size(240, 110);
            this.tnVerificacion.TabIndex = 9;
            this.tnVerificacion.Text = "Ventana de Verificacion de Certificacion";
            this.tnVerificacion.UseVisualStyleBackColor = false;
            this.tnVerificacion.Click += new System.EventHandler(this.tnVerificacion_Click);
            // 
            // btnHistorialCerts
            // 
            this.btnHistorialCerts.BackColor = System.Drawing.Color.Transparent;
            this.btnHistorialCerts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorialCerts.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnHistorialCerts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorialCerts.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorialCerts.ForeColor = System.Drawing.Color.LightGray;
            this.btnHistorialCerts.Location = new System.Drawing.Point(63, 360);
            this.btnHistorialCerts.Name = "btnHistorialCerts";
            this.btnHistorialCerts.Size = new System.Drawing.Size(240, 110);
            this.btnHistorialCerts.TabIndex = 10;
            this.btnHistorialCerts.Text = "Historial de Certificaciones";
            this.btnHistorialCerts.UseVisualStyleBackColor = false;
            this.btnHistorialCerts.Click += new System.EventHandler(this.btnHistorialCerts_Click);
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Certificaciones_e_Informes_Digitales.Properties.Resources.FondoCrearUser;
            this.ClientSize = new System.Drawing.Size(381, 525);
            this.Controls.Add(this.btnHistorialCerts);
            this.Controls.Add(this.tnVerificacion);
            this.Controls.Add(this.btnGestiones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUsuario";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGestiones;
        private System.Windows.Forms.Button tnVerificacion;
        private System.Windows.Forms.Button btnHistorialCerts;
    }
}