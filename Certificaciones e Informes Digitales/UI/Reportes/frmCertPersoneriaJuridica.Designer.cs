
namespace Certificaciones_e_Informes_Digitales.UI.Reportes
{
    partial class frmCertPersoneriaJuridica
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
            this.dsPersonaJConNombramiento = new Certificaciones_e_Informes_Digitales.dsPersonaJConNombramiento();
            this.sPPersonaJConNombramientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_PersonaJConNombramientoTableAdapter = new Certificaciones_e_Informes_Digitales.dsPersonaJConNombramientoTableAdapters.SP_PersonaJConNombramientoTableAdapter();
            this.SP_PersonaJConNombramientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsPersonaJConNombramiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPPersonaJConNombramientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_PersonaJConNombramientoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsPersonaConNombramiento";
            reportDataSource1.Value = this.SP_PersonaJConNombramientoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Certificaciones_e_Informes_Digitales.UI.Reportes.docCertPersoneriaJuridica.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(641, 722);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsPersonaJConNombramiento
            // 
            this.dsPersonaJConNombramiento.DataSetName = "dsPersonaJConNombramiento";
            this.dsPersonaJConNombramiento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPPersonaJConNombramientoBindingSource
            // 
            this.sPPersonaJConNombramientoBindingSource.DataMember = "SP_PersonaJConNombramiento";
            this.sPPersonaJConNombramientoBindingSource.DataSource = this.dsPersonaJConNombramiento;
            // 
            // sP_PersonaJConNombramientoTableAdapter
            // 
            this.sP_PersonaJConNombramientoTableAdapter.ClearBeforeFill = true;
            // 
            // SP_PersonaJConNombramientoBindingSource
            // 
            this.SP_PersonaJConNombramientoBindingSource.DataMember = "SP_PersonaJConNombramiento";
            this.SP_PersonaJConNombramientoBindingSource.DataSource = this.dsPersonaJConNombramiento;
            // 
            // frmCertPersoneriaJuridica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 722);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmCertPersoneriaJuridica";
            this.Text = "frmCertPersoneriaJuridica";
            this.Load += new System.EventHandler(this.frmCertPersoneriaJuridica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPersonaJConNombramiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPPersonaJConNombramientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_PersonaJConNombramientoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_PersonaJConNombramientoBindingSource;
        private dsPersonaJConNombramiento dsPersonaJConNombramiento;
        private System.Windows.Forms.BindingSource sPPersonaJConNombramientoBindingSource;
        private dsPersonaJConNombramientoTableAdapters.SP_PersonaJConNombramientoTableAdapter sP_PersonaJConNombramientoTableAdapter;
    }
}