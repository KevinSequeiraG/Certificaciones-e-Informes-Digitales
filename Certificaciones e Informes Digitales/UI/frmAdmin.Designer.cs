
namespace Certificaciones_e_Informes_Digitales.UI
{
    partial class frmAdmin
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
            this.btnComprador = new System.Windows.Forms.Button();
            this.btnGestiones = new System.Windows.Forms.Button();
            this.picMin = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnComprador
            // 
            this.btnComprador.BackColor = System.Drawing.Color.Transparent;
            this.btnComprador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComprador.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnComprador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprador.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprador.ForeColor = System.Drawing.Color.LightGray;
            this.btnComprador.Location = new System.Drawing.Point(163, 213);
            this.btnComprador.Name = "btnComprador";
            this.btnComprador.Size = new System.Drawing.Size(200, 110);
            this.btnComprador.TabIndex = 6;
            this.btnComprador.Text = "Ventana de comprador";
            this.btnComprador.UseVisualStyleBackColor = false;
            this.btnComprador.MouseEnter += new System.EventHandler(this.btnComprador_MouseEnter);
            this.btnComprador.MouseLeave += new System.EventHandler(this.btnComprador_MouseLeave);
            // 
            // btnGestiones
            // 
            this.btnGestiones.BackColor = System.Drawing.Color.Transparent;
            this.btnGestiones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestiones.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnGestiones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestiones.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestiones.ForeColor = System.Drawing.Color.LightGray;
            this.btnGestiones.Location = new System.Drawing.Point(163, 68);
            this.btnGestiones.Name = "btnGestiones";
            this.btnGestiones.Size = new System.Drawing.Size(200, 110);
            this.btnGestiones.TabIndex = 7;
            this.btnGestiones.Text = "Ventana de gestiones ";
            this.btnGestiones.UseVisualStyleBackColor = false;
            this.btnGestiones.Click += new System.EventHandler(this.btnGestiones_Click);
            this.btnGestiones.MouseEnter += new System.EventHandler(this.btnGestiones_MouseEnter);
            this.btnGestiones.MouseLeave += new System.EventHandler(this.btnGestiones_MouseLeave);
            // 
            // picMin
            // 
            this.picMin.BackColor = System.Drawing.Color.Black;
            this.picMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMin.Image = global::Certificaciones_e_Informes_Digitales.Properties.Resources.Minimize_Icon;
            this.picMin.Location = new System.Drawing.Point(493, 7);
            this.picMin.Name = "picMin";
            this.picMin.Size = new System.Drawing.Size(15, 15);
            this.picMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMin.TabIndex = 11;
            this.picMin.TabStop = false;
            this.picMin.Click += new System.EventHandler(this.picMin_Click);
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Black;
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::Certificaciones_e_Informes_Digitales.Properties.Resources.Close_Icon;
            this.picClose.Location = new System.Drawing.Point(514, 7);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(15, 15);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 10;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(535, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            // 
            // cuentaToolStripMenuItem
            // 
            this.cuentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem,
            this.cambiarContraseToolStripMenuItem});
            this.cuentaToolStripMenuItem.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuentaToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.cuentaToolStripMenuItem.Name = "cuentaToolStripMenuItem";
            this.cuentaToolStripMenuItem.Size = new System.Drawing.Size(78, 28);
            this.cuentaToolStripMenuItem.Text = "Cuenta";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.cerrarSesionToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(244, 28);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // cambiarContraseToolStripMenuItem
            // 
            this.cambiarContraseToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.cambiarContraseToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.cambiarContraseToolStripMenuItem.Name = "cambiarContraseToolStripMenuItem";
            this.cambiarContraseToolStripMenuItem.Size = new System.Drawing.Size(244, 28);
            this.cambiarContraseToolStripMenuItem.Text = "Cambiar Contraseña";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Certificaciones_e_Informes_Digitales.Properties.Resources.FondoCrearUser;
            this.ClientSize = new System.Drawing.Size(535, 376);
            this.Controls.Add(this.picMin);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnGestiones);
            this.Controls.Add(this.btnComprador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmin";
            this.Activated += new System.EventHandler(this.frmAdmin_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdmin_FormClosed);
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmAdmin_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComprador;
        private System.Windows.Forms.Button btnGestiones;
        private System.Windows.Forms.PictureBox picMin;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseToolStripMenuItem;
    }
}