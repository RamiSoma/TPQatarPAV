namespace TPQatarPAVI.Presentación
{
    partial class ABMCPaisForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbRegionFiltro = new System.Windows.Forms.ComboBox();
            this.TxtNombreFiltro = new System.Windows.Forms.TextBox();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.dGridUsrs = new System.Windows.Forms.DataGridView();
            this.btnEliminarPais = new System.Windows.Forms.Button();
            this.btnModificarPais = new System.Windows.Forms.Button();
            this.btnAgregarPais = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmbBoxRegion = new System.Windows.Forms.ComboBox();
            this.lblReg = new System.Windows.Forms.Label();
            this.TxtRanking = new System.Windows.Forms.TextBox();
            this.lblRank = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Continente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ranking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGridUsrs)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Region";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nombre pais:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmbRegionFiltro
            // 
            this.cmbRegionFiltro.FormattingEnabled = true;
            this.cmbRegionFiltro.Location = new System.Drawing.Point(59, 188);
            this.cmbRegionFiltro.Name = "cmbRegionFiltro";
            this.cmbRegionFiltro.Size = new System.Drawing.Size(86, 21);
            this.cmbRegionFiltro.TabIndex = 30;
            // 
            // TxtNombreFiltro
            // 
            this.TxtNombreFiltro.Location = new System.Drawing.Point(59, 142);
            this.TxtNombreFiltro.Name = "TxtNombreFiltro";
            this.TxtNombreFiltro.Size = new System.Drawing.Size(170, 20);
            this.TxtNombreFiltro.TabIndex = 29;
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.Location = new System.Drawing.Point(59, 475);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(179, 31);
            this.btnVolverMenu.TabIndex = 28;
            this.btnVolverMenu.Text = "Menu Principal";
            this.btnVolverMenu.UseVisualStyleBackColor = true;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // dGridUsrs
            // 
            this.dGridUsrs.AllowUserToAddRows = false;
            this.dGridUsrs.AllowUserToDeleteRows = false;
            this.dGridUsrs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dGridUsrs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridUsrs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Continente,
            this.Ranking});
            this.dGridUsrs.Location = new System.Drawing.Point(238, 123);
            this.dGridUsrs.Name = "dGridUsrs";
            this.dGridUsrs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridUsrs.Size = new System.Drawing.Size(343, 227);
            this.dGridUsrs.TabIndex = 27;
            // 
            // btnEliminarPais
            // 
            this.btnEliminarPais.Location = new System.Drawing.Point(607, 222);
            this.btnEliminarPais.Name = "btnEliminarPais";
            this.btnEliminarPais.Size = new System.Drawing.Size(150, 31);
            this.btnEliminarPais.TabIndex = 26;
            this.btnEliminarPais.Text = "Eliminar País";
            this.btnEliminarPais.UseVisualStyleBackColor = true;
            // 
            // btnModificarPais
            // 
            this.btnModificarPais.Location = new System.Drawing.Point(607, 182);
            this.btnModificarPais.Name = "btnModificarPais";
            this.btnModificarPais.Size = new System.Drawing.Size(150, 35);
            this.btnModificarPais.TabIndex = 25;
            this.btnModificarPais.Text = "Modificar País";
            this.btnModificarPais.UseVisualStyleBackColor = true;
            // 
            // btnAgregarPais
            // 
            this.btnAgregarPais.Location = new System.Drawing.Point(607, 142);
            this.btnAgregarPais.Name = "btnAgregarPais";
            this.btnAgregarPais.Size = new System.Drawing.Size(150, 32);
            this.btnAgregarPais.TabIndex = 24;
            this.btnAgregarPais.Text = "Agregar País";
            this.btnAgregarPais.UseVisualStyleBackColor = true;
            this.btnAgregarPais.Click += new System.EventHandler(this.btnAgregarPais_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(318, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "GESTION DE PAISES";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(59, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(235, 394);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(128, 20);
            this.txtNombre.TabIndex = 36;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(235, 374);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 35;
            this.lblNombre.Text = "Nombre";
            // 
            // cmbBoxRegion
            // 
            this.cmbBoxRegion.FormattingEnabled = true;
            this.cmbBoxRegion.Location = new System.Drawing.Point(378, 394);
            this.cmbBoxRegion.Name = "cmbBoxRegion";
            this.cmbBoxRegion.Size = new System.Drawing.Size(96, 21);
            this.cmbBoxRegion.TabIndex = 38;
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.Location = new System.Drawing.Point(378, 373);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(41, 13);
            this.lblReg.TabIndex = 37;
            this.lblReg.Text = "Region";
            // 
            // TxtRanking
            // 
            this.TxtRanking.Location = new System.Drawing.Point(495, 395);
            this.TxtRanking.Name = "TxtRanking";
            this.TxtRanking.Size = new System.Drawing.Size(67, 20);
            this.TxtRanking.TabIndex = 40;
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Location = new System.Drawing.Point(492, 373);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(72, 13);
            this.lblRank.TabIndex = 41;
            this.lblRank.Text = "Ranking FIFA";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(381, 440);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 43;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(490, 440);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 42;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Continente
            // 
            this.Continente.HeaderText = "Continente";
            this.Continente.Name = "Continente";
            // 
            // Ranking
            // 
            this.Ranking.HeaderText = "Ranking FIFA";
            this.Ranking.Name = "Ranking";
            // 
            // ABMCPaisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.TxtRanking);
            this.Controls.Add(this.cmbBoxRegion);
            this.Controls.Add(this.lblReg);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbRegionFiltro);
            this.Controls.Add(this.TxtNombreFiltro);
            this.Controls.Add(this.btnVolverMenu);
            this.Controls.Add(this.dGridUsrs);
            this.Controls.Add(this.btnEliminarPais);
            this.Controls.Add(this.btnModificarPais);
            this.Controls.Add(this.btnAgregarPais);
            this.Controls.Add(this.label4);
            this.Name = "ABMCPaisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionar Paises";
            ((System.ComponentModel.ISupportInitialize)(this.dGridUsrs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbRegionFiltro;
        private System.Windows.Forms.TextBox TxtNombreFiltro;
        private System.Windows.Forms.Button btnVolverMenu;
        private System.Windows.Forms.DataGridView dGridUsrs;
        private System.Windows.Forms.Button btnEliminarPais;
        private System.Windows.Forms.Button btnModificarPais;
        private System.Windows.Forms.Button btnAgregarPais;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cmbBoxRegion;
        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.TextBox TxtRanking;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Continente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ranking;
    }
}