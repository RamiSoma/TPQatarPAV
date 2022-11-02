namespace TPQatarPAVI.Presentación
{
    partial class ReporteListadoArbitros
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.lblFiltrarPor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBoxOrden = new System.Windows.Forms.ComboBox();
            this.reportArbs = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmbEstadisticas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(293, 41);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(167, 20);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Reporte de Arbitros";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Location = new System.Drawing.Point(628, 94);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(132, 23);
            this.btnGenerarReporte.TabIndex = 5;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // lblFiltrarPor
            // 
            this.lblFiltrarPor.AutoSize = true;
            this.lblFiltrarPor.Location = new System.Drawing.Point(117, 99);
            this.lblFiltrarPor.Name = "lblFiltrarPor";
            this.lblFiltrarPor.Size = new System.Drawing.Size(53, 13);
            this.lblFiltrarPor.TabIndex = 8;
            this.lblFiltrarPor.Text = "Filtrar por:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ordenar de manera:";
            // 
            // cmbBoxOrden
            // 
            this.cmbBoxOrden.FormattingEnabled = true;
            this.cmbBoxOrden.Location = new System.Drawing.Point(514, 96);
            this.cmbBoxOrden.Name = "cmbBoxOrden";
            this.cmbBoxOrden.Size = new System.Drawing.Size(98, 21);
            this.cmbBoxOrden.TabIndex = 12;
            // 
            // reportArbs
            // 
            this.reportArbs.LocalReport.ReportEmbeddedResource = "TPQatarPAVI.Reportes.ListadoArbitros.rdlc";
            this.reportArbs.Location = new System.Drawing.Point(31, 123);
            this.reportArbs.Name = "reportArbs";
            this.reportArbs.ServerReport.BearerToken = null;
            this.reportArbs.Size = new System.Drawing.Size(743, 315);
            this.reportArbs.TabIndex = 14;
            this.reportArbs.Load += new System.EventHandler(this.reportAbs_Load);
            // 
            // cmbEstadisticas
            // 
            this.cmbEstadisticas.FormattingEnabled = true;
            this.cmbEstadisticas.Location = new System.Drawing.Point(176, 96);
            this.cmbEstadisticas.Name = "cmbEstadisticas";
            this.cmbEstadisticas.Size = new System.Drawing.Size(121, 21);
            this.cmbEstadisticas.TabIndex = 15;
            // 
            // ReporteListadoArbitros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbEstadisticas);
            this.Controls.Add(this.reportArbs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBoxOrden);
            this.Controls.Add(this.lblFiltrarPor);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.lblTitulo);
            this.Name = "ReporteListadoArbitros";
            this.Text = "ReporteListadoArbitros";
            this.Load += new System.EventHandler(this.ReporteListadoArbitros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.Label lblFiltrarPor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBoxOrden;
        private Microsoft.Reporting.WinForms.ReportViewer reportArbs;
        private System.Windows.Forms.ComboBox cmbEstadisticas;
    }
}