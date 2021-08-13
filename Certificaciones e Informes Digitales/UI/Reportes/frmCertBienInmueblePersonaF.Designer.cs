﻿namespace Certificaciones_e_Informes_Digitales.UI.Reportes
{
    partial class frmCertBienInmueblePersonaF
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.BienesInmueblesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PersonaFisicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PersonaJuridicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HistorialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BienesInmueblesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonaFisicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonaJuridicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistorialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BienesInmueblesBindingSource
            // 
            this.BienesInmueblesBindingSource.DataSource = typeof(Certificaciones_e_Informes_Digitales.Entities.BienesInmuebles);
            // 
            // PersonaFisicaBindingSource
            // 
            this.PersonaFisicaBindingSource.DataSource = typeof(Certificaciones_e_Informes_Digitales.Entities.PersonaFisica);
            // 
            // PersonaJuridicaBindingSource
            // 
            this.PersonaJuridicaBindingSource.DataSource = typeof(Certificaciones_e_Informes_Digitales.Entities.PersonaJuridica);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.BienesInmueblesBindingSource;
            reportDataSource2.Name = "dsPersonaFisica";
            reportDataSource2.Value = this.PersonaFisicaBindingSource;
            reportDataSource3.Name = "dsPersonaJuridica";
            reportDataSource3.Value = this.PersonaJuridicaBindingSource;
            reportDataSource4.Name = "dsHis";
            reportDataSource4.Value = this.HistorialBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Certificaciones_e_Informes_Digitales.UI.Reportes.CertBienInmueble.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(654, 511);
            this.reportViewer1.TabIndex = 0;
            // 
            // HistorialBindingSource
            // 
            this.HistorialBindingSource.DataSource = typeof(Certificaciones_e_Informes_Digitales.Entities.Historial);
            // 
            // frmCertBienInmueblePersonaF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 511);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmCertBienInmueblePersonaF";
            this.Text = "frmCertBienInmueblePersonaF";
            this.Load += new System.EventHandler(this.frmCertBienInmueblePersonaF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BienesInmueblesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonaFisicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonaJuridicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistorialBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BienesInmueblesBindingSource;
        private System.Windows.Forms.BindingSource PersonaFisicaBindingSource;
        private System.Windows.Forms.BindingSource PersonaJuridicaBindingSource;
        private System.Windows.Forms.BindingSource HistorialBindingSource;
    }
}