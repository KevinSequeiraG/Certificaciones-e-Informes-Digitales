
namespace Certificaciones_e_Informes_Digitales.UI.Reportes
{
    partial class frmVentasCertsFecha
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.SP_VerVentasCertsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dpVentasCertsFecha = new Certificaciones_e_Informes_Digitales.dpVentasCertsFecha();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sPVerVentasCertsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_VerVentasCertsTableAdapter = new Certificaciones_e_Informes_Digitales.dpVentasCertsFechaTableAdapters.SP_VerVentasCertsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SP_VerVentasCertsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpVentasCertsFecha)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPVerVentasCertsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SP_VerVentasCertsBindingSource
            // 
            this.SP_VerVentasCertsBindingSource.DataMember = "SP_VerVentasCerts";
            this.SP_VerVentasCertsBindingSource.DataSource = this.dpVentasCertsFecha;
            // 
            // dpVentasCertsFecha
            // 
            this.dpVentasCertsFecha.DataSetName = "dpVentasCertsFecha";
            this.dpVentasCertsFecha.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpHasta);
            this.panel1.Controls.Add(this.lblHasta);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.dtpDesde);
            this.panel1.Controls.Add(this.lblDesde);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 10;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(65, 56);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 14;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(24, 63);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(38, 13);
            this.lblHasta.TabIndex = 13;
            this.lblHasta.Text = "Hasta:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(288, 29);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(73, 38);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(65, 25);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 11;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(24, 29);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(41, 13);
            this.lblDesde.TabIndex = 10;
            this.lblDesde.Text = "Desde:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsVentasCertsFecha";
            reportDataSource1.Value = this.SP_VerVentasCertsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Certificaciones_e_Informes_Digitales.UI.Reportes.repVentasCertsFecha.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 100);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 350);
            this.reportViewer1.TabIndex = 11;
            // 
            // sPVerVentasCertsBindingSource
            // 
            this.sPVerVentasCertsBindingSource.DataMember = "SP_VerVentasCerts";
            this.sPVerVentasCertsBindingSource.DataSource = this.dpVentasCertsFecha;
            // 
            // sP_VerVentasCertsTableAdapter
            // 
            this.sP_VerVentasCertsTableAdapter.ClearBeforeFill = true;
            // 
            // frmVentasCertsFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "frmVentasCertsFecha";
            this.Text = "frmVentasCertsFecha";
            this.Load += new System.EventHandler(this.frmVentasCertsFecha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SP_VerVentasCertsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpVentasCertsFecha)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPVerVentasCertsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.BindingSource SP_VerVentasCertsBindingSource;
        private dpVentasCertsFecha dpVentasCertsFecha;
        private System.Windows.Forms.BindingSource sPVerVentasCertsBindingSource;
        private dpVentasCertsFechaTableAdapters.SP_VerVentasCertsTableAdapter sP_VerVentasCertsTableAdapter;
    }
}