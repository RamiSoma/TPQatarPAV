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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABMCPaisForm));
            this.lblContFiltro = new System.Windows.Forms.Label();
            this.lblNomFiltro = new System.Windows.Forms.Label();
            this.btnBuscarPrfl = new System.Windows.Forms.Button();
            this.cmbContinenteFiltro = new System.Windows.Forms.ComboBox();
            this.txtFiltroNombre = new System.Windows.Forms.TextBox();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.dGridPaises = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Continente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ranking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminarPais = new System.Windows.Forms.Button();
            this.btnModificarPais = new System.Windows.Forms.Button();
            this.btnAgregarPais = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLimpiarFiltro = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmbBoxContinente = new System.Windows.Forms.ComboBox();
            this.lblReg = new System.Windows.Forms.Label();
            this.txtRanking = new System.Windows.Forms.TextBox();
            this.lblRank = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.cmbBoxGrupo = new System.Windows.Forms.ComboBox();
            this.btnCancelarRest = new System.Windows.Forms.Button();
            this.btnRestaurarSeleccion = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGridPaises)).BeginInit();
            this.SuspendLayout();
            // 
            // lblContFiltro
            // 
            this.lblContFiltro.AutoSize = true;
            this.lblContFiltro.Location = new System.Drawing.Point(30, 174);
            this.lblContFiltro.Name = "lblContFiltro";
            this.lblContFiltro.Size = new System.Drawing.Size(58, 13);
            this.lblContFiltro.TabIndex = 33;
            this.lblContFiltro.Text = "Continente";
            // 
            // lblNomFiltro
            // 
            this.lblNomFiltro.AutoSize = true;
            this.lblNomFiltro.Location = new System.Drawing.Point(30, 127);
            this.lblNomFiltro.Name = "lblNomFiltro";
            this.lblNomFiltro.Size = new System.Drawing.Size(69, 13);
            this.lblNomFiltro.TabIndex = 32;
            this.lblNomFiltro.Text = "Nombre pais:";
            // 
            // btnBuscarPrfl
            // 
            this.btnBuscarPrfl.Location = new System.Drawing.Point(30, 226);
            this.btnBuscarPrfl.Name = "btnBuscarPrfl";
            this.btnBuscarPrfl.Size = new System.Drawing.Size(69, 23);
            this.btnBuscarPrfl.TabIndex = 12;
            this.btnBuscarPrfl.Text = "Buscar";
            this.btnBuscarPrfl.UseVisualStyleBackColor = true;
            this.btnBuscarPrfl.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbContinenteFiltro
            // 
            this.cmbContinenteFiltro.FormattingEnabled = true;
            this.cmbContinenteFiltro.Location = new System.Drawing.Point(30, 188);
            this.cmbContinenteFiltro.Name = "cmbContinenteFiltro";
            this.cmbContinenteFiltro.Size = new System.Drawing.Size(121, 21);
            this.cmbContinenteFiltro.TabIndex = 11;
            // 
            // txtFiltroNombre
            // 
            this.txtFiltroNombre.Location = new System.Drawing.Point(30, 142);
            this.txtFiltroNombre.Name = "txtFiltroNombre";
            this.txtFiltroNombre.Size = new System.Drawing.Size(121, 20);
            this.txtFiltroNombre.TabIndex = 10;
            this.txtFiltroNombre.TextChanged += new System.EventHandler(this.txtFiltroNombre_TextChanged);
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.Location = new System.Drawing.Point(36, 497);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(179, 31);
            this.btnVolverMenu.TabIndex = 16;
            this.btnVolverMenu.Text = "Menu Principal";
            this.btnVolverMenu.UseVisualStyleBackColor = true;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // dGridPaises
            // 
            this.dGridPaises.AllowUserToAddRows = false;
            this.dGridPaises.AllowUserToDeleteRows = false;
            this.dGridPaises.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dGridPaises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridPaises.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Continente,
            this.Ranking,
            this.Grupo});
            this.dGridPaises.Location = new System.Drawing.Point(206, 123);
            this.dGridPaises.Name = "dGridPaises";
            this.dGridPaises.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridPaises.Size = new System.Drawing.Size(395, 227);
            this.dGridPaises.TabIndex = 27;
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
            this.Ranking.Width = 70;
            // 
            // Grupo
            // 
            this.Grupo.HeaderText = "Grupo";
            this.Grupo.Name = "Grupo";
            this.Grupo.Width = 80;
            // 
            // btnEliminarPais
            // 
            this.btnEliminarPais.Location = new System.Drawing.Point(607, 222);
            this.btnEliminarPais.Name = "btnEliminarPais";
            this.btnEliminarPais.Size = new System.Drawing.Size(150, 31);
            this.btnEliminarPais.TabIndex = 2;
            this.btnEliminarPais.Text = "Eliminar País";
            this.btnEliminarPais.UseVisualStyleBackColor = true;
            this.btnEliminarPais.Click += new System.EventHandler(this.btnEliminarPais_Click);
            // 
            // btnModificarPais
            // 
            this.btnModificarPais.Location = new System.Drawing.Point(607, 182);
            this.btnModificarPais.Name = "btnModificarPais";
            this.btnModificarPais.Size = new System.Drawing.Size(150, 35);
            this.btnModificarPais.TabIndex = 1;
            this.btnModificarPais.Text = "Modificar País";
            this.btnModificarPais.UseVisualStyleBackColor = true;
            this.btnModificarPais.Click += new System.EventHandler(this.btnModificarPais_Click);
            // 
            // btnAgregarPais
            // 
            this.btnAgregarPais.Location = new System.Drawing.Point(607, 142);
            this.btnAgregarPais.Name = "btnAgregarPais";
            this.btnAgregarPais.Size = new System.Drawing.Size(150, 32);
            this.btnAgregarPais.TabIndex = 0;
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
            // btnLimpiarFiltro
            // 
            this.btnLimpiarFiltro.Location = new System.Drawing.Point(30, 258);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(69, 23);
            this.btnLimpiarFiltro.TabIndex = 13;
            this.btnLimpiarFiltro.Text = "Limpiar";
            this.btnLimpiarFiltro.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltro.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(235, 394);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(128, 20);
            this.txtNombre.TabIndex = 4;
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
            // cmbBoxContinente
            // 
            this.cmbBoxContinente.FormattingEnabled = true;
            this.cmbBoxContinente.Location = new System.Drawing.Point(381, 393);
            this.cmbBoxContinente.Name = "cmbBoxContinente";
            this.cmbBoxContinente.Size = new System.Drawing.Size(96, 21);
            this.cmbBoxContinente.TabIndex = 5;
            this.cmbBoxContinente.SelectedIndexChanged += new System.EventHandler(this.cmbBoxRegion_SelectedIndexChanged);
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.Location = new System.Drawing.Point(381, 372);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(58, 13);
            this.lblReg.TabIndex = 37;
            this.lblReg.Text = "Continente";
            // 
            // txtRanking
            // 
            this.txtRanking.Location = new System.Drawing.Point(495, 395);
            this.txtRanking.Name = "txtRanking";
            this.txtRanking.Size = new System.Drawing.Size(67, 20);
            this.txtRanking.TabIndex = 6;
            this.txtRanking.TextChanged += new System.EventHandler(this.TxtRanking_TextChanged);
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
            this.btnCancelar.Location = new System.Drawing.Point(381, 449);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(490, 449);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(604, 374);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(36, 13);
            this.lblGrupo.TabIndex = 44;
            this.lblGrupo.Text = "Grupo";
            // 
            // cmbBoxGrupo
            // 
            this.cmbBoxGrupo.FormattingEnabled = true;
            this.cmbBoxGrupo.Location = new System.Drawing.Point(607, 393);
            this.cmbBoxGrupo.Name = "cmbBoxGrupo";
            this.cmbBoxGrupo.Size = new System.Drawing.Size(81, 21);
            this.cmbBoxGrupo.TabIndex = 7;
            // 
            // btnCancelarRest
            // 
            this.btnCancelarRest.Location = new System.Drawing.Point(277, 394);
            this.btnCancelarRest.Name = "btnCancelarRest";
            this.btnCancelarRest.Size = new System.Drawing.Size(150, 25);
            this.btnCancelarRest.TabIndex = 14;
            this.btnCancelarRest.Text = "Cancelar";
            this.btnCancelarRest.UseVisualStyleBackColor = true;
            this.btnCancelarRest.Click += new System.EventHandler(this.btnCancelarRest_Click);
            // 
            // btnRestaurarSeleccion
            // 
            this.btnRestaurarSeleccion.Location = new System.Drawing.Point(451, 393);
            this.btnRestaurarSeleccion.Name = "btnRestaurarSeleccion";
            this.btnRestaurarSeleccion.Size = new System.Drawing.Size(150, 25);
            this.btnRestaurarSeleccion.TabIndex = 15;
            this.btnRestaurarSeleccion.Text = "Restaurar";
            this.btnRestaurarSeleccion.UseVisualStyleBackColor = true;
            this.btnRestaurarSeleccion.Click += new System.EventHandler(this.btnRestaurarSeleccion_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Location = new System.Drawing.Point(607, 277);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(150, 30);
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.Text = "Restaurar Pais";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // ABMCPaisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnCancelarRest);
            this.Controls.Add(this.btnRestaurarSeleccion);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.cmbBoxGrupo);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.txtRanking);
            this.Controls.Add(this.cmbBoxContinente);
            this.Controls.Add(this.lblReg);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnLimpiarFiltro);
            this.Controls.Add(this.lblContFiltro);
            this.Controls.Add(this.lblNomFiltro);
            this.Controls.Add(this.btnBuscarPrfl);
            this.Controls.Add(this.cmbContinenteFiltro);
            this.Controls.Add(this.txtFiltroNombre);
            this.Controls.Add(this.btnVolverMenu);
            this.Controls.Add(this.dGridPaises);
            this.Controls.Add(this.btnEliminarPais);
            this.Controls.Add(this.btnModificarPais);
            this.Controls.Add(this.btnAgregarPais);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ABMCPaisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionar Paises";
            this.Load += new System.EventHandler(this.ABMCPaisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridPaises)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContFiltro;
        private System.Windows.Forms.Label lblNomFiltro;
        private System.Windows.Forms.Button btnBuscarPrfl;
        private System.Windows.Forms.ComboBox cmbContinenteFiltro;
        private System.Windows.Forms.TextBox txtFiltroNombre;
        private System.Windows.Forms.Button btnVolverMenu;
        private System.Windows.Forms.DataGridView dGridPaises;
        private System.Windows.Forms.Button btnEliminarPais;
        private System.Windows.Forms.Button btnModificarPais;
        private System.Windows.Forms.Button btnAgregarPais;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLimpiarFiltro;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cmbBoxContinente;
        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.TextBox txtRanking;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Continente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ranking;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupo;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.ComboBox cmbBoxGrupo;
        private System.Windows.Forms.Button btnCancelarRest;
        private System.Windows.Forms.Button btnRestaurarSeleccion;
        private System.Windows.Forms.Button btnRestaurar;
    }
}