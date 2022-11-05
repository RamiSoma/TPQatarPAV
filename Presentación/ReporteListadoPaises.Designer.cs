namespace TPQatarPAVI.Presentación
{
    partial class ReporteListadoPaises
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
            this.reportPaises = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBoxOrden = new System.Windows.Forms.ComboBox();
            this.nmPaises = new System.Windows.Forms.NumericUpDown();
            this.lblCantJugs = new System.Windows.Forms.Label();
            this.lblFiltrarPor = new System.Windows.Forms.Label();
            this.cmbEstadisticas = new System.Windows.Forms.ComboBox();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmPaises)).BeginInit();
            this.SuspendLayout();
            // 
            // reportPaises
            // 
            this.reportPaises.LocalReport.ReportEmbeddedResource = "TPQatarPAVI.Reportes.ListadoPaises.rdlc";
            this.reportPaises.Location = new System.Drawing.Point(30, 155);
            this.reportPaises.Name = "reportPaises";
            this.reportPaises.ServerReport.BearerToken = null;
            this.reportPaises.Size = new System.Drawing.Size(742, 452);
            this.reportPaises.TabIndex = 26;
            this.reportPaises.Load += new System.EventHandler(this.reportPaises_Load);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(291, 27);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(157, 20);
            this.lblTitulo.TabIndex = 22;
            this.lblTitulo.Text = "Reporte de Paises";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Ordenar de manera:";
            // 
            // cmbBoxOrden
            // 
            this.cmbBoxOrden.FormattingEnabled = true;
            this.cmbBoxOrden.Location = new System.Drawing.Point(477, 112);
            this.cmbBoxOrden.Name = "cmbBoxOrden";
            this.cmbBoxOrden.Size = new System.Drawing.Size(98, 21);
            this.cmbBoxOrden.TabIndex = 33;
            // 
            // nmPaises
            // 
            this.nmPaises.Location = new System.Drawing.Point(201, 113);
            this.nmPaises.Name = "nmPaises";
            this.nmPaises.Size = new System.Drawing.Size(40, 20);
            this.nmPaises.TabIndex = 30;
            // 
            // lblCantJugs
            // 
            this.lblCantJugs.AutoSize = true;
            this.lblCantJugs.Location = new System.Drawing.Point(27, 115);
            this.lblCantJugs.Name = "lblCantJugs";
            this.lblCantJugs.Size = new System.Drawing.Size(152, 13);
            this.lblCantJugs.TabIndex = 29;
            this.lblCantJugs.Text = "¿Cuantos paises deseas traer?";
            // 
            // lblFiltrarPor
            // 
            this.lblFiltrarPor.AutoSize = true;
            this.lblFiltrarPor.Location = new System.Drawing.Point(27, 77);
            this.lblFiltrarPor.Name = "lblFiltrarPor";
            this.lblFiltrarPor.Size = new System.Drawing.Size(53, 13);
            this.lblFiltrarPor.TabIndex = 28;
            this.lblFiltrarPor.Text = "Filtrar por:";
            // 
            // cmbEstadisticas
            // 
            this.cmbEstadisticas.FormattingEnabled = true;
            this.cmbEstadisticas.Location = new System.Drawing.Point(120, 74);
            this.cmbEstadisticas.Name = "cmbEstadisticas";
            this.cmbEstadisticas.Size = new System.Drawing.Size(121, 21);
            this.cmbEstadisticas.TabIndex = 27;
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Location = new System.Drawing.Point(646, 110);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(126, 23);
            this.btnGenerarReporte.TabIndex = 35;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // ReporteListadoPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 619);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBoxOrden);
            this.Controls.Add(this.nmPaises);
            this.Controls.Add(this.lblCantJugs);
            this.Controls.Add(this.lblFiltrarPor);
            this.Controls.Add(this.cmbEstadisticas);
            this.Controls.Add(this.reportPaises);
            this.Controls.Add(this.lblTitulo);
            this.Name = "ReporteListadoPaises";
            this.Text = "ReporteListadoPaises";
            this.Load += new System.EventHandler(this.ReporteListadoPaises_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmPaises)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportPaises;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBoxOrden;
        private System.Windows.Forms.NumericUpDown nmPaises;
        private System.Windows.Forms.Label lblCantJugs;
        private System.Windows.Forms.Label lblFiltrarPor;
        private System.Windows.Forms.ComboBox cmbEstadisticas;
        private System.Windows.Forms.Button btnGenerarReporte;
    }
}