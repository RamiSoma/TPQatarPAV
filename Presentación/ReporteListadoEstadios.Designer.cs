namespace TPQatarPAVI.Presentación
{
    partial class ReporteListadoEstadios
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
            this.reportEstadios = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBoxOrden = new System.Windows.Forms.ComboBox();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportEstadios
            // 
            this.reportEstadios.LocalReport.ReportEmbeddedResource = "TPQatarPAVI.Reportes.ListadoEstadios.rdlc";
            this.reportEstadios.Location = new System.Drawing.Point(29, 109);
            this.reportEstadios.Name = "reportEstadios";
            this.reportEstadios.ServerReport.BearerToken = null;
            this.reportEstadios.Size = new System.Drawing.Size(743, 315);
            this.reportEstadios.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ordenar de manera:";
            // 
            // cmbBoxOrden
            // 
            this.cmbBoxOrden.FormattingEnabled = true;
            this.cmbBoxOrden.Location = new System.Drawing.Point(220, 76);
            this.cmbBoxOrden.Name = "cmbBoxOrden";
            this.cmbBoxOrden.Size = new System.Drawing.Size(98, 21);
            this.cmbBoxOrden.TabIndex = 19;
            this.cmbBoxOrden.SelectedIndexChanged += new System.EventHandler(this.cmbBoxOrden_SelectedIndexChanged);
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Location = new System.Drawing.Point(627, 74);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(132, 23);
            this.btnGenerarReporte.TabIndex = 17;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(291, 27);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(174, 20);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Reporte de Estadios";
            // 
            // ReporteListadoEstadios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportEstadios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBoxOrden);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.lblTitulo);
            this.Name = "ReporteListadoEstadios";
            this.Text = "ReporteListadoEstadios";
            this.Load += new System.EventHandler(this.ReporteListadoEstadios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportEstadios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBoxOrden;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.Label lblTitulo;
    }
}