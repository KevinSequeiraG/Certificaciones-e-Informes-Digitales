
namespace Certificaciones_e_Informes_Digitales.UI
{
    partial class frmCompra
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblTipoProd = new System.Windows.Forms.Label();
            this.lblCompra = new System.Windows.Forms.Label();
            this.cmbTipos = new System.Windows.Forms.ComboBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.BackgroundImage = global::Certificaciones_e_Informes_Digitales.Properties.Resources.fondoCompra;
            this.panel1.Controls.Add(this.picMin);
            this.panel1.Controls.Add(this.picClose);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblTipoProd);
            this.panel1.Controls.Add(this.lblCompra);
            this.panel1.Controls.Add(this.cmbTipos);
            this.panel1.Controls.Add(this.btnVolver);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 395);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // picMin
            // 
            this.picMin.BackColor = System.Drawing.Color.Transparent;
            this.picMin.Image = global::Certificaciones_e_Informes_Digitales.Properties.Resources.Minimize_Icon;
            this.picMin.Location = new System.Drawing.Point(587, 7);
            this.picMin.Name = "picMin";
            this.picMin.Size = new System.Drawing.Size(15, 15);
            this.picMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMin.TabIndex = 8;
            this.picMin.TabStop = false;
            this.picMin.Click += new System.EventHandler(this.picMin_Click);
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.Image = global::Certificaciones_e_Informes_Digitales.Properties.Resources.Close_Icon;
            this.picClose.Location = new System.Drawing.Point(608, 7);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(15, 15);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 7;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(474, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 61);
            this.button1.TabIndex = 4;
            this.button1.Text = "Comprar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTipoProd
            // 
            this.lblTipoProd.AutoSize = true;
            this.lblTipoProd.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoProd.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTipoProd.Location = new System.Drawing.Point(131, 89);
            this.lblTipoProd.Name = "lblTipoProd";
            this.lblTipoProd.Size = new System.Drawing.Size(164, 24);
            this.lblTipoProd.TabIndex = 3;
            this.lblTipoProd.Text = "Tipos de producto";
            // 
            // lblCompra
            // 
            this.lblCompra.AutoSize = true;
            this.lblCompra.BackColor = System.Drawing.Color.Transparent;
            this.lblCompra.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompra.ForeColor = System.Drawing.Color.White;
            this.lblCompra.Location = new System.Drawing.Point(65, 23);
            this.lblCompra.Name = "lblCompra";
            this.lblCompra.Size = new System.Drawing.Size(508, 34);
            this.lblCompra.TabIndex = 2;
            this.lblCompra.Text = "Compra tus certificaciones";
            // 
            // cmbTipos
            // 
            this.cmbTipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipos.FormattingEnabled = true;
            this.cmbTipos.Location = new System.Drawing.Point(321, 86);
            this.cmbTipos.Name = "cmbTipos";
            this.cmbTipos.Size = new System.Drawing.Size(174, 32);
            this.cmbTipos.TabIndex = 1;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Maroon;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(36, 300);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(130, 61);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 389);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCompra";
            this.Activated += new System.EventHandler(this.frmCompra_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCompra_FormClosed);
            this.Load += new System.EventHandler(this.frmCompra_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmCompra_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbTipos;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblCompra;
        private System.Windows.Forms.Label lblTipoProd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picMin;
        private System.Windows.Forms.PictureBox picClose;
    }
}