
namespace Certificaciones_e_Informes_Digitales.UI
{
    partial class frmFactura
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTot = new System.Windows.Forms.TextBox();
            this.txtImpuestos = new System.Windows.Forms.TextBox();
            this.lblImpuestos = new System.Windows.Forms.Label();
            this.txtTotalConImpuestos = new System.Windows.Forms.TextBox();
            this.lblTotalConImpuestos = new System.Windows.Forms.Label();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCarrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPersonaF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPersonaJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetalleCert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCarrito
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCarrito.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCarrito.Location = new System.Drawing.Point(76, 95);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.ReadOnly = true;
            this.dgvCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarrito.Size = new System.Drawing.Size(990, 288);
            this.dgvCarrito.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(80, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total sin impuestos:";
            // 
            // txtTot
            // 
            this.txtTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTot.Location = new System.Drawing.Point(257, 396);
            this.txtTot.Name = "txtTot";
            this.txtTot.Size = new System.Drawing.Size(147, 29);
            this.txtTot.TabIndex = 3;
            // 
            // txtImpuestos
            // 
            this.txtImpuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpuestos.Location = new System.Drawing.Point(550, 398);
            this.txtImpuestos.Name = "txtImpuestos";
            this.txtImpuestos.Size = new System.Drawing.Size(147, 29);
            this.txtImpuestos.TabIndex = 5;
            // 
            // lblImpuestos
            // 
            this.lblImpuestos.AutoSize = true;
            this.lblImpuestos.BackColor = System.Drawing.Color.Transparent;
            this.lblImpuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpuestos.ForeColor = System.Drawing.Color.White;
            this.lblImpuestos.Location = new System.Drawing.Point(443, 401);
            this.lblImpuestos.Name = "lblImpuestos";
            this.lblImpuestos.Size = new System.Drawing.Size(101, 24);
            this.lblImpuestos.TabIndex = 4;
            this.lblImpuestos.Text = "Impuestos:";
            // 
            // txtTotalConImpuestos
            // 
            this.txtTotalConImpuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalConImpuestos.Location = new System.Drawing.Point(907, 396);
            this.txtTotalConImpuestos.Name = "txtTotalConImpuestos";
            this.txtTotalConImpuestos.Size = new System.Drawing.Size(147, 29);
            this.txtTotalConImpuestos.TabIndex = 7;
            // 
            // lblTotalConImpuestos
            // 
            this.lblTotalConImpuestos.AutoSize = true;
            this.lblTotalConImpuestos.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalConImpuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalConImpuestos.ForeColor = System.Drawing.Color.White;
            this.lblTotalConImpuestos.Location = new System.Drawing.Point(730, 401);
            this.lblTotalConImpuestos.Name = "lblTotalConImpuestos";
            this.lblTotalConImpuestos.Size = new System.Drawing.Size(184, 24);
            this.lblTotalConImpuestos.TabIndex = 6;
            this.lblTotalConImpuestos.Text = "Total con impuestos:";
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
            this.idPersonaF.Width = 175;
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
            this.cant.Width = 120;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Maroon;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(504, 459);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(162, 60);
            this.btnVolver.TabIndex = 95;
            this.btnVolver.Text = "Volver al Inicio";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Certificaciones_e_Informes_Digitales.Properties.Resources.FondoCrearUser;
            this.ClientSize = new System.Drawing.Size(1143, 548);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtTotalConImpuestos);
            this.Controls.Add(this.lblTotalConImpuestos);
            this.Controls.Add(this.txtImpuestos);
            this.Controls.Add(this.lblImpuestos);
            this.Controls.Add(this.txtTot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCarrito);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFactura";
            this.Text = "frmFactura";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCert;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersonaF;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersonaJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetalleCert;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cant;
        private System.Windows.Forms.TextBox txtImpuestos;
        private System.Windows.Forms.Label lblImpuestos;
        private System.Windows.Forms.TextBox txtTotalConImpuestos;
        private System.Windows.Forms.Label lblTotalConImpuestos;
        private System.Windows.Forms.Button btnVolver;
    }
}