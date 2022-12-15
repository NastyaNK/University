
namespace University.UI
{
    partial class Report
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
            this.university_ds = new University.Data.university_ds();
            this.universitydsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Баллы_по_группамBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.баллы_по_группамTableAdapter = new University.Data.university_dsTableAdapters.Баллы_по_группамTableAdapter();
            this.tableAdapterManager = new University.Data.university_dsTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.university_ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universitydsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Баллы_по_группамBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Баллы_по_группамBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "University.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1143, 676);
            this.reportViewer1.TabIndex = 0;
            // 
            // university_ds
            // 
            this.university_ds.DataSetName = "university_ds";
            this.university_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // universitydsBindingSource
            // 
            this.universitydsBindingSource.DataSource = this.university_ds;
            this.universitydsBindingSource.Position = 0;
            // 
            // Баллы_по_группамBindingSource
            // 
            this.Баллы_по_группамBindingSource.DataMember = "Баллы по группам";
            this.Баллы_по_группамBindingSource.DataSource = this.university_ds;
            // 
            // баллы_по_группамTableAdapter
            // 
            this.баллы_по_группамTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = University.Data.university_dsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Ведомость_ПреподаTableAdapter = null;
            this.tableAdapterManager.ВедомостьTableAdapter = null;
            this.tableAdapterManager.ГруппыTableAdapter = null;
            this.tableAdapterManager.ДисциплиныTableAdapter = null;
            this.tableAdapterManager.КафедрыTableAdapter = null;
            this.tableAdapterManager.ПользователиTableAdapter = null;
            this.tableAdapterManager.ПреподавателиTableAdapter = null;
            this.tableAdapterManager.СпециальностиTableAdapter = null;
            this.tableAdapterManager.СтудентыTableAdapter = null;
            this.tableAdapterManager.Учебный_планTableAdapter = null;
            this.tableAdapterManager.ФакультетыTableAdapter = null;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 676);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.university_ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universitydsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Баллы_по_группамBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Баллы_по_группамBindingSource;
        private Data.university_ds university_ds;
        private System.Windows.Forms.BindingSource universitydsBindingSource;
        private Data.university_dsTableAdapters.Баллы_по_группамTableAdapter баллы_по_группамTableAdapter;
        private Data.university_dsTableAdapters.TableAdapterManager tableAdapterManager;
    }
}