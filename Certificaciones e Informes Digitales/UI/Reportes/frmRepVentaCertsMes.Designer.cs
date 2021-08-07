
namespace Certificaciones_e_Informes_Digitales.UI.Reportes
{
    partial class frmRepVentaCertsMes
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dpVentasCertsFecha = new Certificaciones_e_Informes_Digitales.dpVentasCertsFecha();
            this.sPVerVentasCertsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_VerVentasCertsTableAdapter = new Certificaciones_e_Informes_Digitales.dpVentasCertsFechaTableAdapters.SP_VerVentasCertsTableAdapter();
            this.SP_VerVentasCertsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dpVentasCertsFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPVerVentasCertsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_VerVentasCertsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsVentasCertsFecha";
            reportDataSource1.Value = this.SP_VerVentasCertsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Certificaciones_e_Informes_Digitales.UI.Reportes.repVentasCertsMes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(642, 530);
            this.reportViewer1.TabIndex = 0;
            // 
            // dpVentasCertsFecha
            // 
            this.dpVentasCertsFecha.DataSetName = "dpVentasCertsFecha";
            this.dpVentasCertsFecha.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // SP_VerVentasCertsBindingSource
            // 
            this.SP_VerVentasCertsBindingSource.DataMember = "SP_VerVentasCerts";
            this.SP_VerVentasCertsBindingSource.DataSource = this.dpVentasCertsFecha;
            // 
            // frmRepVentaCertsMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 530);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRepVentaCertsMes";
            this.Text = "frmRepVentaCertsMes";
            this.Load += new System.EventHandler(this.frmRepVentaCertsMes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dpVentasCertsFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPVerVentasCertsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_VerVentasCertsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_VerVentasCertsBindingSource;
        private dpVentasCertsFecha dpVentasCertsFecha;
        private System.Windows.Forms.BindingSource sPVerVentasCertsBindingSource;
        private dpVentasCertsFechaTableAdapters.SP_VerVentasCertsTableAdapter sP_VerVentasCertsTableAdapter;
    }
}