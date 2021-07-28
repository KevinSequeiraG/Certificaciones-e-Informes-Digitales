
namespace Certificaciones_e_Informes_Digitales.UI
{
    partial class frmNuevoPassword
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
            this.pnl_fondo = new System.Windows.Forms.Panel();
            this.btnListo = new System.Windows.Forms.Button();
            this.txtPassw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_fondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_fondo
            // 
            this.pnl_fondo.BackgroundImage = global::Certificaciones_e_Informes_Digitales.Properties.Resources.FondoCrearUser;
            this.pnl_fondo.Controls.Add(this.btnListo);
            this.pnl_fondo.Controls.Add(this.txtPassw);
            this.pnl_fondo.Controls.Add(this.label1);
            this.pnl_fondo.Location = new System.Drawing.Point(-2, -3);
            this.pnl_fondo.Name = "pnl_fondo";
            this.pnl_fondo.Size = new System.Drawing.Size(397, 185);
            this.pnl_fondo.TabIndex = 0;
            this.pnl_fondo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_fondo_Paint);
            this.pnl_fondo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_fondo_MouseDown);
            // 
            // btnListo
            // 
            this.btnListo.BackColor = System.Drawing.Color.Transparent;
            this.btnListo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListo.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnListo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListo.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListo.ForeColor = System.Drawing.Color.LightGray;
            this.btnListo.Location = new System.Drawing.Point(122, 123);
            this.btnListo.Name = "btnListo";
            this.btnListo.Size = new System.Drawing.Size(150, 39);
            this.btnListo.TabIndex = 5;
            this.btnListo.Text = "Listo";
            this.btnListo.UseVisualStyleBackColor = false;
            this.btnListo.Click += new System.EventHandler(this.btnListo_Click);
            // 
            // txtPassw
            // 
            this.txtPassw.BackColor = System.Drawing.Color.Black;
            this.txtPassw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassw.ForeColor = System.Drawing.Color.Silver;
            this.txtPassw.Location = new System.Drawing.Point(16, 70);
            this.txtPassw.Name = "txtPassw";
            this.txtPassw.Size = new System.Drawing.Size(363, 31);
            this.txtPassw.TabIndex = 4;
            this.txtPassw.Text = "Contraseña...";
            this.txtPassw.Enter += new System.EventHandler(this.txtPassw_Enter);
            this.txtPassw.Leave += new System.EventHandler(this.txtPassw_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nueva contraseña:";
            // 
            // frmNuevoPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 174);
            this.Controls.Add(this.pnl_fondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNuevoPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNuevoPassword";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmNuevoPassword_MouseDown);
            this.pnl_fondo.ResumeLayout(false);
            this.pnl_fondo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_fondo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassw;
        private System.Windows.Forms.Button btnListo;
    }
}