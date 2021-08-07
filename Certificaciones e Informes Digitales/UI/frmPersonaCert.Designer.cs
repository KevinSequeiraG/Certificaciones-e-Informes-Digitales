
namespace Certificaciones_e_Informes_Digitales.UI
{
    partial class frmPersonaCert
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
            this.rdbPersonaJ = new System.Windows.Forms.RadioButton();
            this.rdbPersonaF = new System.Windows.Forms.RadioButton();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbPersonaJ
            // 
            this.rdbPersonaJ.AutoSize = true;
            this.rdbPersonaJ.BackColor = System.Drawing.Color.Transparent;
            this.rdbPersonaJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPersonaJ.ForeColor = System.Drawing.Color.Silver;
            this.rdbPersonaJ.Location = new System.Drawing.Point(20, 112);
            this.rdbPersonaJ.Name = "rdbPersonaJ";
            this.rdbPersonaJ.Size = new System.Drawing.Size(168, 28);
            this.rdbPersonaJ.TabIndex = 0;
            this.rdbPersonaJ.TabStop = true;
            this.rdbPersonaJ.Text = "Persona Juridica";
            this.rdbPersonaJ.UseVisualStyleBackColor = false;
            // 
            // rdbPersonaF
            // 
            this.rdbPersonaF.AutoSize = true;
            this.rdbPersonaF.BackColor = System.Drawing.Color.Transparent;
            this.rdbPersonaF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPersonaF.ForeColor = System.Drawing.Color.Silver;
            this.rdbPersonaF.Location = new System.Drawing.Point(201, 112);
            this.rdbPersonaF.Name = "rdbPersonaF";
            this.rdbPersonaF.Size = new System.Drawing.Size(152, 28);
            this.rdbPersonaF.TabIndex = 1;
            this.rdbPersonaF.TabStop = true;
            this.rdbPersonaF.Text = "Persona Fisica";
            this.rdbPersonaF.UseVisualStyleBackColor = false;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(20, 60);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(190, 35);
            this.txtID.TabIndex = 2;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Silver;
            this.lblID.Location = new System.Drawing.Point(15, 28);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(195, 29);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "ID de la persona:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Firebrick;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(270, 157);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(91, 44);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Firebrick;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(12, 157);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(91, 44);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmPersonaCert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Certificaciones_e_Informes_Digitales.Properties.Resources.FondoCrearUser;
            this.ClientSize = new System.Drawing.Size(380, 213);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.rdbPersonaF);
            this.Controls.Add(this.rdbPersonaJ);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPersonaCert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPersonaCert";
            this.Load += new System.EventHandler(this.frmPersonaCert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbPersonaJ;
        private System.Windows.Forms.RadioButton rdbPersonaF;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnVolver;
    }
}