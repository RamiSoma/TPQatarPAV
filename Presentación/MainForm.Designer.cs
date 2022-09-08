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
            this.SuspendLayout();
            // 
            // btnGestUsu
            // 
            this.btnGestUsu.Location = new System.Drawing.Point(63, 118);
            this.btnGestUsu.Name = "btnGestUsu";
            this.btnGestUsu.Size = new System.Drawing.Size(148, 23);
            this.btnGestUsu.TabIndex = 0;
            this.btnGestUsu.Text = "Gestion Usuarios";
            this.btnGestUsu.UseVisualStyleBackColor = true;
            this.btnGestUsu.Click += new System.EventHandler(this.btnGestUsu_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGestUsu);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGestUsu;
    }
}