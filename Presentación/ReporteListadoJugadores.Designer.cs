namespace TPQatarPAVI.Presentación
{
    partial class ReporteListadoJugadores
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
            this.reportJugs = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmbEstadisticas = new System.Windows.Forms.ComboBox();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.lblFiltrarPor = new System.Windows.Forms.Label();
            this.lblCantJugs = new System.Windows.Forms.Label();
            this.nmJugadores = new System.Windows.Forms.NumericUpDown();
            this.lblPais = new System.Windows.Forms.Label();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmJugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // reportJugs
            // 
            this.reportJugs.LocalReport.ReportEmbeddedResource = "TPQatarPAVI.Reportes.ListadoJugadores.rdlc";
            this.reportJugs.Location = new System.Drawing.Point(12, 139);
            this.reportJugs.Name = "reportJugs";
            this.reportJugs.ServerReport.BearerToken = null;
            this.reportJugs.Size = new System.Drawing.Size(776, 299);
            this.reportJugs.TabIndex = 0;
            this.reportJugs.Load += new System.EventHandler(this.reportJugs_Load);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(291, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(188, 20);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Reporte de Jugadores";
            // 
            // cmbEstadisticas
            // 
            this.cmbEstadisticas.FormattingEnabled = true;
            this.cmbEstadisticas.Location = new System.Drawing.Point(82, 88);
            this.cmbEstadisticas.Name = "cmbEstadisticas";
            this.cmbEstadisticas.Size = new System.Drawing.Size(121, 21);
            this.cmbEstadisticas.TabIndex = 3;
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Location = new System.Drawing.Point(656, 86);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(132, 23);
            this.btnGenerarReporte.TabIndex = 4;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // lblFiltrarPor
            // 
            this.lblFiltrarPor.AutoSize = true;
            this.lblFiltrarPor.Location = new System.Drawing.Point(23, 91);
            this.lblFiltrarPor.Name = "lblFiltrarPor";
            this.lblFiltrarPor.Size = new System.Drawing.Size(53, 13);
            this.lblFiltrarPor.TabIndex = 5;
            this.lblFiltrarPor.Text = "Filtrar por:";
            // 
            // lblCantJugs
            // 
            this.lblCantJugs.AutoSize = true;
            this.lblCantJugs.Location = new System.Drawing.Point(242, 91);
            this.lblCantJugs.Name = "lblCantJugs";
            this.lblCantJugs.Size = new System.Drawing.Size(168, 13);
            this.lblCantJugs.TabIndex = 6;
            this.lblCantJugs.Text = "¿Cuantos jugadores deseas traer?";
            // 
            // nmJugadores
            // 
            this.nmJugadores.Location = new System.Drawing.Point(416, 89);
            this.nmJugadores.Name = "nmJugadores";
            this.nmJugadores.Size = new System.Drawing.Size(40, 20);
            this.nmJugadores.TabIndex = 7;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(484, 91);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(30, 13);
            this.lblPais.TabIndex = 9;
            this.lblPais.Text = "Pais:";
            // 
            // cmbPais
            // 
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(520, 88);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(121, 21);
            this.cmbPais.TabIndex = 8;
            // 
            // ReporteListadoJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.cmbPais);
            this.Controls.Add(this.nmJugadores);
            this.Controls.Add(this.lblCantJugs);
            this.Controls.Add(this.lblFiltrarPor);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.cmbEstadisticas);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.reportJugs);
            this.Name = "ReporteListadoJugadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de jugadores";
            this.Load += new System.EventHandler(this.ReporteListadoJugadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmJugadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportJugs;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cmbEstadisticas;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.Label lblFiltrarPor;
        private System.Windows.Forms.Label lblCantJugs;
        private System.Windows.Forms.NumericUpDown nmJugadores;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.ComboBox cmbPais;
    }
}