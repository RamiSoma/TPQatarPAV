namespace TPQatarPAVI.Presentación
{
    partial class MainForm
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
            this.btnGestUsu = new System.Windows.Forms.Button();
            this.lblMenuPrincipal = new System.Windows.Forms.Label();
            this.btnCrearPartido = new System.Windows.Forms.Button();
            this.btnDetallePartido = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGestUsu
            // 
            this.btnGestUsu.Location = new System.Drawing.Point(90, 80);
            this.btnGestUsu.Name = "btnGestUsu";
            this.btnGestUsu.Size = new System.Drawing.Size(165, 26);
            this.btnGestUsu.TabIndex = 0;
            this.btnGestUsu.Text = "Gestion Usuarios";
            this.btnGestUsu.UseVisualStyleBackColor = true;
            this.btnGestUsu.Click += new System.EventHandler(this.btnGestUsu_Click);
            // 
            // lblMenuPrincipal
            // 
            this.lblMenuPrincipal.AutoSize = true;
            this.lblMenuPrincipal.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuPrincipal.Location = new System.Drawing.Point(90, 30);
            this.lblMenuPrincipal.Name = "lblMenuPrincipal";
            this.lblMenuPrincipal.Size = new System.Drawing.Size(169, 20);
            this.lblMenuPrincipal.TabIndex = 6;
            this.lblMenuPrincipal.Text = "MENU PRINCIPAL";
            this.lblMenuPrincipal.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnCrearPartido
            // 
            this.btnCrearPartido.Location = new System.Drawing.Point(90, 130);
            this.btnCrearPartido.Name = "btnCrearPartido";
            this.btnCrearPartido.Size = new System.Drawing.Size(165, 26);
            this.btnCrearPartido.TabIndex = 7;
            this.btnCrearPartido.Text = "Crear Partido";
            this.btnCrearPartido.UseVisualStyleBackColor = true;
            // 
            // btnDetallePartido
            // 
            this.btnDetallePartido.Location = new System.Drawing.Point(90, 180);
            this.btnDetallePartido.Name = "btnDetallePartido";
            this.btnDetallePartido.Size = new System.Drawing.Size(165, 26);
            this.btnDetallePartido.TabIndex = 8;
            this.btnDetallePartido.Text = "Cargar Detalle Partido";
            this.btnDetallePartido.UseVisualStyleBackColor = true;
            this.btnDetallePartido.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(90, 230);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(165, 26);
            this.btnCerrarSesion.TabIndex = 9;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnDetallePartido);
            this.Controls.Add(this.btnCrearPartido);
            this.Controls.Add(this.lblMenuPrincipal);
            this.Controls.Add(this.btnGestUsu);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGestUsu;
        private System.Windows.Forms.Label lblMenuPrincipal;
        private System.Windows.Forms.Button btnCrearPartido;
        private System.Windows.Forms.Button btnDetallePartido;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}