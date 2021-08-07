
namespace Certificaciones_e_Informes_Digitales.UI
{
    partial class frmCarrito
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCarrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPersonaF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPersonaJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetalleCert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.picMin = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.lblCarrito = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCarrito
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo,
            this.id,
            this.idCarrito,
            this.idCert,
            this.idPersonaF,
            this.idPersonaJ,
            this.DetalleCert,
            this.Precio,
            this.cant});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCarrito.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCarrito.Location = new System.Drawing.Point(53, 101);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.ReadOnly = true;
            this.dgvCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarrito.Size = new System.Drawing.Size(918, 288);
            this.dgvCarrito.TabIndex = 0;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "TipoCert";
            this.Tipo.HeaderText = "Tipo de Certificacion";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 200;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // idCarrito
            // 
            this.idCarrito.DataPropertyName = "idCarrito";
            this.idCarrito.HeaderText = "idCarrito";
            this.idCarrito.Name = "idCarrito";
            this.idCarrito.ReadOnly = true;
            this.idCarrito.Visible = false;
            // 
            // idCert
            // 
            this.idCert.DataPropertyName = "idCert";
            this.idCert.HeaderText = "idCert";
            this.idCert.Name = "idCert";
            this.idCert.ReadOnly = true;
            this.idCert.Visible = false;
            // 
            // idPersonaF
            // 
            this.idPersonaF.DataPropertyName = "idPersonaF";
            this.idPersonaF.HeaderText = "ID Persona Fisica";
            this.idPersonaF.Name = "idPersonaF";
            this.idPersonaF.ReadOnly = true;
            this.idPersonaF.Width = 125;
            // 
            // idPersonaJ
            // 
            this.idPersonaJ.DataPropertyName = "idPersonaJ";
            this.idPersonaJ.HeaderText = "ID Persona Juridica";
            this.idPersonaJ.Name = "idPersonaJ";
            this.idPersonaJ.ReadOnly = true;
            this.idPersonaJ.Width = 125;
            // 
            // DetalleCert
            // 
            this.DetalleCert.DataPropertyName = "DetalleCert";
            this.DetalleCert.HeaderText = "Detalle";
            this.DetalleCert.Name = "DetalleCert";
            this.DetalleCert.ReadOnly = true;
            this.DetalleCert.Width = 200;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "PrecioCert";
            this.Precio.HeaderText = "Precio por unidad";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 125;
            // 
            // cant
            // 
            this.cant.DataPropertyName = "cant";
            this.cant.HeaderText = "Cantidad";
            this.cant.Name = "cant";
            this.cant.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(1015, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
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
            this.cambiarContraseToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseToolStripMenuItem_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Maroon;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(53, 432);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(153, 74);
            this.btnVolver.TabIndex = 13;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.Maroon;
            this.btnComprar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.ForeColor = System.Drawing.Color.White;
            this.btnComprar.Location = new System.Drawing.Point(827, 432);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(144, 74);
            this.btnComprar.TabIndex = 12;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // picMin
            // 
            this.picMin.BackColor = System.Drawing.Color.Black;
            this.picMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMin.Image = global::Certificaciones_e_Informes_Digitales.Properties.Resources.Minimize_Icon;
            this.picMin.Location = new System.Drawing.Point(974, 6);
            this.picMin.Name = "picMin";
            this.picMin.Size = new System.Drawing.Size(15, 15);
            this.picMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMin.TabIndex = 15;
            this.picMin.TabStop = false;
            this.picMin.Click += new System.EventHandler(this.picMin_Click);
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Black;
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::Certificaciones_e_Informes_Digitales.Properties.Resources.Close_Icon;
            this.picClose.Location = new System.Drawing.Point(995, 6);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(15, 15);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 14;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // lblCarrito
            // 
            this.lblCarrito.AutoSize = true;
            this.lblCarrito.BackColor = System.Drawing.Color.Transparent;
            this.lblCarrito.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblCarrito.ForeColor = System.Drawing.Color.Silver;
            this.lblCarrito.Location = new System.Drawing.Point(441, 42);
            this.lblCarrito.Name = "lblCarrito";
            this.lblCarrito.Size = new System.Drawing.Size(160, 34);
            this.lblCarrito.TabIndex = 16;
            this.lblCarrito.Text = "Carrito";
            // 
            // frmCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Certificaciones_e_Informes_Digitales.Properties.Resources.FondoCrearUser;
            this.ClientSize = new System.Drawing.Size(1015, 541);
            this.Controls.Add(this.lblCarrito);
            this.Controls.Add(this.picMin);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvCarrito);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCarrito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCarrito";
            this.Load += new System.EventHandler(this.frmCarrito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseToolStripMenuItem;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.PictureBox picMin;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Label lblCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCert;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersonaF;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersonaJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetalleCert;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cant;
    }
}