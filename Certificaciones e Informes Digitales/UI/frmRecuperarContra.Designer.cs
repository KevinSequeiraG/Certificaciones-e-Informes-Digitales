
namespace Certificaciones_e_Informes_Digitales.UI
{
    partial class frmRecuperarContra
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.picMin = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblLoguin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Certificaciones_e_Informes_Digitales.Properties.Resources.FondoCrearUser;
            this.panel1.Controls.Add(this.picMin);
            this.panel1.Controls.Add(this.picClose);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnSiguiente);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.lblLoguin);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 229);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // picMin
            // 
            this.picMin.BackColor = System.Drawing.Color.Transparent;
            this.picMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMin.Image = global::Certificaciones_e_Informes_Digitales.Properties.Resources.Minimize_Icon;
            this.picMin.Location = new System.Drawing.Point(408, 3);
            this.picMin.Name = "picMin";
            this.picMin.Size = new System.Drawing.Size(15, 15);
            this.picMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMin.TabIndex = 10;
            this.picMin.TabStop = false;
            this.picMin.Click += new System.EventHandler(this.picMin_Click);
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::Certificaciones_e_Informes_Digitales.Properties.Resources.Close_Icon;
            this.picClose.Location = new System.Drawing.Point(429, 3);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(15, 15);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 9;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(29, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 47);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Location = new System.Drawing.Point(257, 153);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(156, 47);
            this.btnSiguiente.TabIndex = 4;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(27, 83);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(306, 29);
            this.txtEmail.TabIndex = 3;
            // 
            // lblLoguin
            // 
            this.lblLoguin.AutoSize = true;
            this.lblLoguin.BackColor = System.Drawing.Color.Transparent;
            this.lblLoguin.Font = new System.Drawing.Font("Perpetua Titling MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoguin.ForeColor = System.Drawing.Color.White;
            this.lblLoguin.Location = new System.Drawing.Point(23, 39);
            this.lblLoguin.Name = "lblLoguin";
            this.lblLoguin.Size = new System.Drawing.Size(388, 24);
            this.lblLoguin.TabIndex = 2;
            this.lblLoguin.Text = "Ingrese su correo electrónico";
            // 
            // frmRecuperarContra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 224);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRecuperarContra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRecuperarContra";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmRecuperarContra_FormClosed);
            this.Load += new System.EventHandler(this.frmRecuperarContra_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmRecuperarContra_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblLoguin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox picMin;
        private System.Windows.Forms.PictureBox picClose;
    }
}