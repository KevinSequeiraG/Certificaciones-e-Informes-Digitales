
namespace Certificaciones_e_Informes_Digitales.UI
{
    partial class frmHistorial
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleCert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QR = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEnviarPdf = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblCompra = new System.Windows.Forms.Label();
            this.picMin = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.pdf,
            this.idUsuario,
            this.fecha,
            this.detalleCert,
            this.QR});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridView1.Location = new System.Drawing.Point(39, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(690, 341);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Codigo de Certificacion";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 175;
            // 
            // pdf
            // 
            this.pdf.DataPropertyName = "pdf";
            this.pdf.HeaderText = "pdf";
            this.pdf.Name = "pdf";
            this.pdf.ReadOnly = true;
            this.pdf.Visible = false;
            // 
            // idUsuario
            // 
            this.idUsuario.DataPropertyName = "idUser";
            this.idUsuario.HeaderText = "Email Usuario";
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.ReadOnly = true;
            this.idUsuario.Visible = false;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "Fecha de Compra";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 130;
            // 
            // detalleCert
            // 
            this.detalleCert.DataPropertyName = "detalleCert";
            this.detalleCert.HeaderText = "Detalle de Certificacion";
            this.detalleCert.Name = "detalleCert";
            this.detalleCert.ReadOnly = true;
            this.detalleCert.Width = 200;
            // 
            // QR
            // 
            this.QR.HeaderText = "QR";
            this.QR.Name = "QR";
            this.QR.ReadOnly = true;
            this.QR.Text = "";
            this.QR.UseColumnTextForButtonValue = true;
            this.QR.Width = 140;
            // 
            // btnEnviarPdf
            // 
            this.btnEnviarPdf.BackColor = System.Drawing.Color.Maroon;
            this.btnEnviarPdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviarPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarPdf.ForeColor = System.Drawing.Color.White;
            this.btnEnviarPdf.Location = new System.Drawing.Point(533, 472);
            this.btnEnviarPdf.Name = "btnEnviarPdf";
            this.btnEnviarPdf.Size = new System.Drawing.Size(196, 89);
            this.btnEnviarPdf.TabIndex = 5;
            this.btnEnviarPdf.Text = "Enviar PDF por correo";
            this.btnEnviarPdf.UseVisualStyleBackColor = false;
            this.btnEnviarPdf.Click += new System.EventHandler(this.btnEnviarPdf_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Maroon;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(39, 472);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(160, 89);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblCompra
            // 
            this.lblCompra.AutoSize = true;
            this.lblCompra.BackColor = System.Drawing.Color.Transparent;
            this.lblCompra.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompra.ForeColor = System.Drawing.Color.White;
            this.lblCompra.Location = new System.Drawing.Point(187, 24);
            this.lblCompra.Name = "lblCompra";
            this.lblCompra.Size = new System.Drawing.Size(398, 34);
            this.lblCompra.TabIndex = 7;
            this.lblCompra.Text = "Historial de Compras";
            // 
            // picMin
            // 
            this.picMin.BackColor = System.Drawing.Color.Black;
            this.picMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMin.Image = global::Certificaciones_e_Informes_Digitales.Properties.Resources.Minimize_Icon;
            this.picMin.Location = new System.Drawing.Point(731, 5);
            this.picMin.Name = "picMin";
            this.picMin.Size = new System.Drawing.Size(15, 15);
            this.picMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMin.TabIndex = 17;
            this.picMin.TabStop = false;
            this.picMin.Click += new System.EventHandler(this.picMin_Click);
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Black;
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::Certificaciones_e_Informes_Digitales.Properties.Resources.Close_Icon;
            this.picClose.Location = new System.Drawing.Point(752, 5);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(15, 15);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 16;
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
            this.menuStrip1.Size = new System.Drawing.Size(774, 28);
            this.menuStrip1.TabIndex = 18;
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
            // frmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Certificaciones_e_Informes_Digitales.Properties.Resources.FondoCrearUser;
            this.ClientSize = new System.Drawing.Size(774, 592);
            this.Controls.Add(this.picMin);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblCompra);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnEnviarPdf);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHistorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHistorial";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHistorial_FormClosed);
            this.Load += new System.EventHandler(this.frmHistorial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdf;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleCert;
        private System.Windows.Forms.DataGridViewButtonColumn QR;
        private System.Windows.Forms.Button btnEnviarPdf;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblCompra;
        private System.Windows.Forms.PictureBox picMin;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseToolStripMenuItem;
    }
}