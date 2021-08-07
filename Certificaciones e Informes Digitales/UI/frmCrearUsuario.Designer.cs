
namespace Certificaciones_e_Informes_Digitales.UI
{
    partial class frmCrearUsuario
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblCrearUser = new System.Windows.Forms.Label();
            this.btnCancela = new System.Windows.Forms.Button();
            this.txtNumeroTelefonico = new System.Windows.Forms.TextBox();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.rdbCliente = new System.Windows.Forms.RadioButton();
            this.rdbAdmin = new System.Windows.Forms.RadioButton();
            this.picMin = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Certificaciones_e_Informes_Digitales.Properties.Resources.FondoCrearUser;
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.lblCrearUser);
            this.panel1.Controls.Add(this.btnCancela);
            this.panel1.Controls.Add(this.txtNumeroTelefonico);
            this.panel1.Controls.Add(this.txtApellido2);
            this.panel1.Controls.Add(this.rdbCliente);
            this.panel1.Controls.Add(this.rdbAdmin);
            this.panel1.Controls.Add(this.picMin);
            this.panel1.Controls.Add(this.picClose);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtApellido1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 636);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Firebrick;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Silver;
            this.txtNombre.Location = new System.Drawing.Point(79, 107);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(440, 31);
            this.txtNombre.TabIndex = 41;
            this.txtNombre.Text = "Nombre...";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.Firebrick;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.Silver;
            this.txtPass.Location = new System.Drawing.Point(79, 447);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(440, 31);
            this.txtPass.TabIndex = 40;
            this.txtPass.Text = "Contraseña...";
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // lblCrearUser
            // 
            this.lblCrearUser.AutoSize = true;
            this.lblCrearUser.BackColor = System.Drawing.Color.Transparent;
            this.lblCrearUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCrearUser.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearUser.ForeColor = System.Drawing.Color.White;
            this.lblCrearUser.Location = new System.Drawing.Point(163, 39);
            this.lblCrearUser.Name = "lblCrearUser";
            this.lblCrearUser.Size = new System.Drawing.Size(278, 34);
            this.lblCrearUser.TabIndex = 39;
            this.lblCrearUser.Text = "Crear Usuario";
            // 
            // btnCancela
            // 
            this.btnCancela.BackColor = System.Drawing.Color.Maroon;
            this.btnCancela.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancela.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancela.Location = new System.Drawing.Point(61, 562);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(157, 49);
            this.btnCancela.TabIndex = 34;
            this.btnCancela.Text = "Cancelar";
            this.btnCancela.UseVisualStyleBackColor = false;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // txtNumeroTelefonico
            // 
            this.txtNumeroTelefonico.BackColor = System.Drawing.Color.Firebrick;
            this.txtNumeroTelefonico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroTelefonico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroTelefonico.ForeColor = System.Drawing.Color.Silver;
            this.txtNumeroTelefonico.Location = new System.Drawing.Point(82, 306);
            this.txtNumeroTelefonico.Name = "txtNumeroTelefonico";
            this.txtNumeroTelefonico.Size = new System.Drawing.Size(440, 31);
            this.txtNumeroTelefonico.TabIndex = 30;
            this.txtNumeroTelefonico.Text = "Número Telefónico...";
            this.txtNumeroTelefonico.Enter += new System.EventHandler(this.txtNumeroTelefonico_Enter);
            this.txtNumeroTelefonico.Leave += new System.EventHandler(this.txtNumeroTelefonico_Leave);
            // 
            // txtApellido2
            // 
            this.txtApellido2.BackColor = System.Drawing.Color.Firebrick;
            this.txtApellido2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido2.ForeColor = System.Drawing.Color.Silver;
            this.txtApellido2.Location = new System.Drawing.Point(82, 241);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(440, 31);
            this.txtApellido2.TabIndex = 29;
            this.txtApellido2.Text = "Segundo Apellido...";
            this.txtApellido2.Enter += new System.EventHandler(this.txtApellido2_Enter);
            this.txtApellido2.Leave += new System.EventHandler(this.txtApellido2_Leave);
            // 
            // rdbCliente
            // 
            this.rdbCliente.AutoSize = true;
            this.rdbCliente.BackColor = System.Drawing.Color.Transparent;
            this.rdbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCliente.ForeColor = System.Drawing.Color.Silver;
            this.rdbCliente.Location = new System.Drawing.Point(79, 514);
            this.rdbCliente.Name = "rdbCliente";
            this.rdbCliente.Size = new System.Drawing.Size(76, 24);
            this.rdbCliente.TabIndex = 37;
            this.rdbCliente.TabStop = true;
            this.rdbCliente.Text = "Cliente";
            this.rdbCliente.UseVisualStyleBackColor = false;
            // 
            // rdbAdmin
            // 
            this.rdbAdmin.AutoSize = true;
            this.rdbAdmin.BackColor = System.Drawing.Color.Transparent;
            this.rdbAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAdmin.ForeColor = System.Drawing.Color.Silver;
            this.rdbAdmin.Location = new System.Drawing.Point(394, 515);
            this.rdbAdmin.Name = "rdbAdmin";
            this.rdbAdmin.Size = new System.Drawing.Size(125, 24);
            this.rdbAdmin.TabIndex = 38;
            this.rdbAdmin.TabStop = true;
            this.rdbAdmin.Text = "Administrador";
            this.rdbAdmin.UseVisualStyleBackColor = false;
            // 
            // picMin
            // 
            this.picMin.BackColor = System.Drawing.Color.Transparent;
            this.picMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMin.Image = global::Certificaciones_e_Informes_Digitales.Properties.Resources.Minimize_Icon;
            this.picMin.Location = new System.Drawing.Point(579, 10);
            this.picMin.Name = "picMin";
            this.picMin.Size = new System.Drawing.Size(15, 15);
            this.picMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMin.TabIndex = 36;
            this.picMin.TabStop = false;
            this.picMin.Click += new System.EventHandler(this.picMin_Click);
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::Certificaciones_e_Informes_Digitales.Properties.Resources.Close_Icon;
            this.picClose.Location = new System.Drawing.Point(600, 10);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(15, 15);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 35;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Maroon;
            this.btnAceptar.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAceptar.Location = new System.Drawing.Point(381, 562);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(157, 49);
            this.btnAceptar.TabIndex = 33;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Firebrick;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Silver;
            this.txtEmail.Location = new System.Drawing.Point(82, 376);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(440, 31);
            this.txtEmail.TabIndex = 31;
            this.txtEmail.Text = "Correo Electrónico...";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtApellido1
            // 
            this.txtApellido1.BackColor = System.Drawing.Color.Firebrick;
            this.txtApellido1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido1.ForeColor = System.Drawing.Color.Silver;
            this.txtApellido1.Location = new System.Drawing.Point(82, 174);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(440, 31);
            this.txtApellido1.TabIndex = 28;
            this.txtApellido1.Text = "Primer Apellido...";
            this.txtApellido1.Enter += new System.EventHandler(this.txtApellido1_Enter);
            this.txtApellido1.Leave += new System.EventHandler(this.txtApellido1_Leave);
            // 
            // frmCrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 631);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCrearUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCrearUsuario";
            this.Activated += new System.EventHandler(this.frmCrearUsuario_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCrearUsuario_FormClosed);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmCrearUsuario_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.TextBox txtNumeroTelefonico;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.RadioButton rdbCliente;
        private System.Windows.Forms.RadioButton rdbAdmin;
        private System.Windows.Forms.PictureBox picMin;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.Label lblCrearUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtNombre;
    }
}