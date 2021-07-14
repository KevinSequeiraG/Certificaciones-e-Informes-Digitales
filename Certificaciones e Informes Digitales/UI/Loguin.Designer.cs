
namespace Certificaciones_e_Informes_Digitales.UI
{
    partial class Loguin
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
            this.lblLoguin = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassw = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lnkCrearUser = new System.Windows.Forms.LinkLabel();
            this.lnkRecuperarContra = new System.Windows.Forms.LinkLabel();
            this.picMin = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.pnlFondo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoguin
            // 
            this.lblLoguin.AutoSize = true;
            this.lblLoguin.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoguin.ForeColor = System.Drawing.Color.White;
            this.lblLoguin.Location = new System.Drawing.Point(491, 31);
            this.lblLoguin.Name = "lblLoguin";
            this.lblLoguin.Size = new System.Drawing.Size(127, 38);
            this.lblLoguin.TabIndex = 1;
            this.lblLoguin.Text = "LOGIN";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Firebrick;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Silver;
            this.txtEmail.Location = new System.Drawing.Point(325, 113);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(440, 31);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Text = "Correo Eléctronico...";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtPassw
            // 
            this.txtPassw.BackColor = System.Drawing.Color.Firebrick;
            this.txtPassw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassw.ForeColor = System.Drawing.Color.Silver;
            this.txtPassw.Location = new System.Drawing.Point(325, 198);
            this.txtPassw.Name = "txtPassw";
            this.txtPassw.Size = new System.Drawing.Size(440, 31);
            this.txtPassw.TabIndex = 3;
            this.txtPassw.Text = "Contraseña...";
            this.txtPassw.Enter += new System.EventHandler(this.txtPassw_Enter);
            this.txtPassw.Leave += new System.EventHandler(this.txtPassw_Leave);
            // 
            // btnIngresar
            // 
            this.btnIngresar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.LightGray;
            this.btnIngresar.Location = new System.Drawing.Point(376, 269);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(351, 51);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lnkCrearUser
            // 
            this.lnkCrearUser.AutoSize = true;
            this.lnkCrearUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkCrearUser.ForeColor = System.Drawing.SystemColors.Control;
            this.lnkCrearUser.LinkColor = System.Drawing.Color.DarkGray;
            this.lnkCrearUser.Location = new System.Drawing.Point(461, 341);
            this.lnkCrearUser.Name = "lnkCrearUser";
            this.lnkCrearUser.Size = new System.Drawing.Size(201, 16);
            this.lnkCrearUser.TabIndex = 7;
            this.lnkCrearUser.TabStop = true;
            this.lnkCrearUser.Text = "¿Desea crear un nuevo usuario?";
            this.lnkCrearUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCrearUser_LinkClicked);
            // 
            // lnkRecuperarContra
            // 
            this.lnkRecuperarContra.AutoSize = true;
            this.lnkRecuperarContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkRecuperarContra.LinkColor = System.Drawing.Color.DarkGray;
            this.lnkRecuperarContra.Location = new System.Drawing.Point(456, 323);
            this.lnkRecuperarContra.Name = "lnkRecuperarContra";
            this.lnkRecuperarContra.Size = new System.Drawing.Size(211, 16);
            this.lnkRecuperarContra.TabIndex = 8;
            this.lnkRecuperarContra.TabStop = true;
            this.lnkRecuperarContra.Text = "¿Desea recuperar su contraseña?";
            this.lnkRecuperarContra.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRecuperarContra_LinkClicked);
            // 
            // picMin
            // 
            this.picMin.Image = global::Certificaciones_e_Informes_Digitales.Properties.Resources.Minimize_Icon;
            this.picMin.Location = new System.Drawing.Point(754, 6);
            this.picMin.Name = "picMin";
            this.picMin.Size = new System.Drawing.Size(15, 15);
            this.picMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMin.TabIndex = 6;
            this.picMin.TabStop = false;
            this.picMin.Click += new System.EventHandler(this.picMin_Click);
            // 
            // picClose
            // 
            this.picClose.Image = global::Certificaciones_e_Informes_Digitales.Properties.Resources.Close_Icon;
            this.picClose.Location = new System.Drawing.Point(779, 6);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(15, 15);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 5;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // pnlFondo
            // 
            this.pnlFondo.BackColor = System.Drawing.Color.DarkRed;
            this.pnlFondo.BackgroundImage = global::Certificaciones_e_Informes_Digitales.Properties.Resources.fondoLoguin;
            this.pnlFondo.Location = new System.Drawing.Point(-3, 0);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(298, 378);
            this.pnlFondo.TabIndex = 0;
            this.pnlFondo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlFondo_MouseDown);
            // 
            // Loguin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(800, 378);
            this.Controls.Add(this.lnkRecuperarContra);
            this.Controls.Add(this.lnkCrearUser);
            this.Controls.Add(this.picMin);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtPassw);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblLoguin);
            this.Controls.Add(this.pnlFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loguin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loguin";
            this.Activated += new System.EventHandler(this.Loguin_Activated);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Loguin_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFondo;
        private System.Windows.Forms.Label lblLoguin;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassw;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picMin;
        private System.Windows.Forms.LinkLabel lnkCrearUser;
        private System.Windows.Forms.LinkLabel lnkRecuperarContra;
    }
}