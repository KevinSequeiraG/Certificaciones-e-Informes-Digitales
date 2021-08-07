
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTot = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
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
            this.dgvCarrito.Location = new System.Drawing.Point(101, 113);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.ReadOnly = true;
            this.dgvCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarrito.Size = new System.Drawing.Size(918, 288);
            this.dgvCarrito.TabIndex = 1;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total sin impuestos";
            // 
            // txtTot
            // 
            this.txtTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTot.Location = new System.Drawing.Point(389, 416);
            this.txtTot.Name = "txtTot";
            this.txtTot.Size = new System.Drawing.Size(147, 40);
            this.txtTot.TabIndex = 3;
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Certificaciones_e_Informes_Digitales.Properties.Resources.FondoCrearUser;
            this.ClientSize = new System.Drawing.Size(1143, 595);
            this.Controls.Add(this.txtTot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCarrito);
            this.Name = "frmFactura";
            this.Text = "frmFactura";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCert;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersonaF;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersonaJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetalleCert;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTot;
    }
}