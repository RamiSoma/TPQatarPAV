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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVerDetallePartido = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStipUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStipPais = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCargarDetallePartido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TPQatarPAVI.Properties.Resources.LOGO_QATAR_2022_6;
            this.pictureBox1.Location = new System.Drawing.Point(200, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnVerDetallePartido
            // 
            this.btnVerDetallePartido.Location = new System.Drawing.Point(565, 290);
            this.btnVerDetallePartido.Name = "btnVerDetallePartido";
            this.btnVerDetallePartido.Size = new System.Drawing.Size(165, 26);
            this.btnVerDetallePartido.TabIndex = 17;
            this.btnVerDetallePartido.Text = "Ver Detalle Partidos";
            this.btnVerDetallePartido.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(607, 523);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(165, 26);
            this.btnCerrarSesion.TabIndex = 16;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionarToolStripMenuItem
            // 
            this.gestionarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStipUsuario,
            this.ToolStipPais});
            this.gestionarToolStripMenuItem.Name = "gestionarToolStripMenuItem";
            this.gestionarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.gestionarToolStripMenuItem.Text = "Gestionar";
            // 
            // ToolStipUsuario
            // 
            this.ToolStipUsuario.Name = "ToolStipUsuario";
            this.ToolStipUsuario.Size = new System.Drawing.Size(119, 22);
            this.ToolStipUsuario.Text = "Usuarios";
            this.ToolStipUsuario.Click += new System.EventHandler(this.ToolStipUsuario_Click);
            // 
            // ToolStipPais
            // 
            this.ToolStipPais.Name = "ToolStipPais";
            this.ToolStipPais.Size = new System.Drawing.Size(119, 22);
            this.ToolStipPais.Text = "Paises";
            this.ToolStipPais.Click += new System.EventHandler(this.ToolStipPais_Click);
            // 
            // btnCargarDetallePartido
            // 
            this.btnCargarDetallePartido.Location = new System.Drawing.Point(565, 333);
            this.btnCargarDetallePartido.Name = "btnCargarDetallePartido";
            this.btnCargarDetallePartido.Size = new System.Drawing.Size(165, 26);
            this.btnCargarDetallePartido.TabIndex = 18;
            this.btnCargarDetallePartido.Text = "Cargar Detalle Partido";
            this.btnCargarDetallePartido.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnCargarDetallePartido);
            this.Controls.Add(this.btnVerDetallePartido);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVerDetallePartido;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStipUsuario;
        private System.Windows.Forms.ToolStripMenuItem ToolStipPais;
        private System.Windows.Forms.Button btnCargarDetallePartido;
    }
}