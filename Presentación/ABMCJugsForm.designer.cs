namespace TPQatarPAVI.Presentación
{
    partial class ABMCJugsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABMCJugsForm));
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblGestJug = new System.Windows.Forms.Label();
            this.lblFiltroNroDoc = new System.Windows.Forms.Label();
            this.txtFiltroDoc = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.cmbFiltroTipoDoc = new System.Windows.Forms.ComboBox();
            this.lblTipoDocFiltro = new System.Windows.Forms.Label();
            this.dGridJug = new System.Windows.Forms.DataGridView();
            this.NombreJug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoJug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaísJug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroDocJug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Goles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asistencias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amarillas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rojas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNomJug = new System.Windows.Forms.Label();
            this.txtApeJug = new System.Windows.Forms.TextBox();
            this.lblApeJug = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblTipoDocRes = new System.Windows.Forms.Label();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.lblNroDocRes = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelarRest = new System.Windows.Forms.Button();
            this.btnRestaurarSeleccion = new System.Windows.Forms.Button();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.cmbPaisMod = new System.Windows.Forms.ComboBox();
            this.cmbPaisFiltro = new System.Windows.Forms.ComboBox();
            this.lblPaisFiltro = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGridJug)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(25, 377);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(150, 32);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar Jugador";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(181, 381);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(150, 32);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar Jugador";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblGestJug
            // 
            this.lblGestJug.AutoSize = true;
            this.lblGestJug.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestJug.Location = new System.Drawing.Point(260, 26);
            this.lblGestJug.Name = "lblGestJug";
            this.lblGestJug.Size = new System.Drawing.Size(265, 24);
            this.lblGestJug.TabIndex = 7;
            this.lblGestJug.Text = "GESTION DE JUGADORES";
            // 
            // lblFiltroNroDoc
            // 
            this.lblFiltroNroDoc.AutoSize = true;
            this.lblFiltroNroDoc.Location = new System.Drawing.Point(362, 64);
            this.lblFiltroNroDoc.Name = "lblFiltroNroDoc";
            this.lblFiltroNroDoc.Size = new System.Drawing.Size(45, 13);
            this.lblFiltroNroDoc.TabIndex = 22;
            this.lblFiltroNroDoc.Text = "N° Doc:";
            // 
            // txtFiltroDoc
            // 
            this.txtFiltroDoc.Location = new System.Drawing.Point(365, 81);
            this.txtFiltroDoc.Name = "txtFiltroDoc";
            this.txtFiltroDoc.Size = new System.Drawing.Size(114, 20);
            this.txtFiltroDoc.TabIndex = 23;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(512, 81);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(51, 23);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(576, 81);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(51, 23);
            this.btnLimpiar.TabIndex = 25;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.Location = new System.Drawing.Point(25, 463);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(150, 28);
            this.btnVolverMenu.TabIndex = 26;
            this.btnVolverMenu.Text = "Menu Principal";
            this.btnVolverMenu.UseVisualStyleBackColor = true;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Location = new System.Drawing.Point(535, 385);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(150, 30);
            this.btnRestaurar.TabIndex = 27;
            this.btnRestaurar.Text = "Restaurar Jugador";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            // 
            // cmbFiltroTipoDoc
            // 
            this.cmbFiltroTipoDoc.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbFiltroTipoDoc.FormattingEnabled = true;
            this.cmbFiltroTipoDoc.Location = new System.Drawing.Point(247, 80);
            this.cmbFiltroTipoDoc.Name = "cmbFiltroTipoDoc";
            this.cmbFiltroTipoDoc.Size = new System.Drawing.Size(86, 21);
            this.cmbFiltroTipoDoc.TabIndex = 28;
            // 
            // lblTipoDocFiltro
            // 
            this.lblTipoDocFiltro.AutoSize = true;
            this.lblTipoDocFiltro.Location = new System.Drawing.Point(244, 64);
            this.lblTipoDocFiltro.Name = "lblTipoDocFiltro";
            this.lblTipoDocFiltro.Size = new System.Drawing.Size(51, 13);
            this.lblTipoDocFiltro.TabIndex = 29;
            this.lblTipoDocFiltro.Text = "Tipo Doc";
            // 
            // dGridJug
            // 
            this.dGridJug.AllowUserToAddRows = false;
            this.dGridJug.AllowUserToDeleteRows = false;
            this.dGridJug.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dGridJug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridJug.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreJug,
            this.ApellidoJug,
            this.PaísJug,
            this.TipoDoc,
            this.NroDocJug,
            this.Goles,
            this.Asistencias,
            this.Amarillas,
            this.Rojas});
            this.dGridJug.Location = new System.Drawing.Point(66, 134);
            this.dGridJug.Name = "dGridJug";
            this.dGridJug.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridJug.Size = new System.Drawing.Size(706, 222);
            this.dGridJug.TabIndex = 30;
            this.dGridJug.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridJug_CellContentClick);
            // 
            // NombreJug
            // 
            this.NombreJug.HeaderText = "Nombre";
            this.NombreJug.Name = "NombreJug";
            // 
            // ApellidoJug
            // 
            this.ApellidoJug.HeaderText = "Apellido";
            this.ApellidoJug.Name = "ApellidoJug";
            // 
            // PaísJug
            // 
            this.PaísJug.HeaderText = "País";
            this.PaísJug.Name = "PaísJug";
            this.PaísJug.Width = 70;
            // 
            // TipoDoc
            // 
            this.TipoDoc.HeaderText = "Tipo";
            this.TipoDoc.Name = "TipoDoc";
            this.TipoDoc.Width = 40;
            // 
            // NroDocJug
            // 
            this.NroDocJug.HeaderText = "N°Doc";
            this.NroDocJug.Name = "NroDocJug";
            // 
            // Goles
            // 
            this.Goles.HeaderText = "Goles";
            this.Goles.Name = "Goles";
            this.Goles.Width = 40;
            // 
            // Asistencias
            // 
            this.Asistencias.HeaderText = "Asistencias";
            this.Asistencias.Name = "Asistencias";
            this.Asistencias.Width = 75;
            // 
            // Amarillas
            // 
            this.Amarillas.HeaderText = "T.Amarillas";
            this.Amarillas.Name = "Amarillas";
            this.Amarillas.Width = 75;
            // 
            // Rojas
            // 
            this.Rojas.HeaderText = "T.Rojas";
            this.Rojas.Name = "Rojas";
            this.Rojas.Width = 60;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(368, 384);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 32;
            // 
            // lblNomJug
            // 
            this.lblNomJug.AutoSize = true;
            this.lblNomJug.Location = new System.Drawing.Point(365, 368);
            this.lblNomJug.Name = "lblNomJug";
            this.lblNomJug.Size = new System.Drawing.Size(44, 13);
            this.lblNomJug.TabIndex = 31;
            this.lblNomJug.Text = "Nombre";
            // 
            // txtApeJug
            // 
            this.txtApeJug.Location = new System.Drawing.Point(487, 384);
            this.txtApeJug.Name = "txtApeJug";
            this.txtApeJug.Size = new System.Drawing.Size(100, 20);
            this.txtApeJug.TabIndex = 34;
            // 
            // lblApeJug
            // 
            this.lblApeJug.AutoSize = true;
            this.lblApeJug.Location = new System.Drawing.Point(485, 368);
            this.lblApeJug.Name = "lblApeJug";
            this.lblApeJug.Size = new System.Drawing.Size(44, 13);
            this.lblApeJug.TabIndex = 33;
            this.lblApeJug.Text = "Apellido";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(605, 368);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(29, 13);
            this.lblPais.TabIndex = 35;
            this.lblPais.Text = "País";
            // 
            // lblTipoDocRes
            // 
            this.lblTipoDocRes.AutoSize = true;
            this.lblTipoDocRes.Location = new System.Drawing.Point(365, 414);
            this.lblTipoDocRes.Name = "lblTipoDocRes";
            this.lblTipoDocRes.Size = new System.Drawing.Size(51, 13);
            this.lblTipoDocRes.TabIndex = 40;
            this.lblTipoDocRes.Text = "Tipo Doc";
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Location = new System.Drawing.Point(487, 431);
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(114, 20);
            this.txtNumDoc.TabIndex = 42;
            // 
            // lblNroDocRes
            // 
            this.lblNroDocRes.AutoSize = true;
            this.lblNroDocRes.Location = new System.Drawing.Point(484, 414);
            this.lblNroDocRes.Name = "lblNroDocRes";
            this.lblNroDocRes.Size = new System.Drawing.Size(45, 13);
            this.lblNroDocRes.TabIndex = 41;
            this.lblNroDocRes.Text = "N° Doc:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(368, 468);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 43;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(488, 468);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 44;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelarRest
            // 
            this.btnCancelarRest.Location = new System.Drawing.Point(212, 381);
            this.btnCancelarRest.Name = "btnCancelarRest";
            this.btnCancelarRest.Size = new System.Drawing.Size(150, 25);
            this.btnCancelarRest.TabIndex = 45;
            this.btnCancelarRest.Text = "Cancelar";
            this.btnCancelarRest.UseVisualStyleBackColor = true;
            // 
            // btnRestaurarSeleccion
            // 
            this.btnRestaurarSeleccion.Location = new System.Drawing.Point(212, 426);
            this.btnRestaurarSeleccion.Name = "btnRestaurarSeleccion";
            this.btnRestaurarSeleccion.Size = new System.Drawing.Size(150, 25);
            this.btnRestaurarSeleccion.TabIndex = 46;
            this.btnRestaurarSeleccion.Text = "Restaurar";
            this.btnRestaurarSeleccion.UseVisualStyleBackColor = true;
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(362, 434);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(164, 13);
            this.lblTipoDoc.TabIndex = 47;
            this.lblTipoDoc.Text = "El tipo queda seteado con el pais";
            // 
            // cmbPaisMod
            // 
            this.cmbPaisMod.FormattingEnabled = true;
            this.cmbPaisMod.Location = new System.Drawing.Point(608, 385);
            this.cmbPaisMod.Name = "cmbPaisMod";
            this.cmbPaisMod.Size = new System.Drawing.Size(121, 21);
            this.cmbPaisMod.TabIndex = 48;
            // 
            // cmbPaisFiltro
            // 
            this.cmbPaisFiltro.FormattingEnabled = true;
            this.cmbPaisFiltro.Location = new System.Drawing.Point(120, 80);
            this.cmbPaisFiltro.Name = "cmbPaisFiltro";
            this.cmbPaisFiltro.Size = new System.Drawing.Size(121, 21);
            this.cmbPaisFiltro.TabIndex = 50;
            // 
            // lblPaisFiltro
            // 
            this.lblPaisFiltro.AutoSize = true;
            this.lblPaisFiltro.Location = new System.Drawing.Point(117, 63);
            this.lblPaisFiltro.Name = "lblPaisFiltro";
            this.lblPaisFiltro.Size = new System.Drawing.Size(29, 13);
            this.lblPaisFiltro.TabIndex = 49;
            this.lblPaisFiltro.Text = "País";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(351, 381);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 32);
            this.btnEliminar.TabIndex = 51;
            this.btnEliminar.Text = "Eliminar Jugador";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // ABMCJugsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.cmbPaisFiltro);
            this.Controls.Add(this.lblPaisFiltro);
            this.Controls.Add(this.cmbPaisMod);
            this.Controls.Add(this.lblTipoDoc);
            this.Controls.Add(this.btnRestaurarSeleccion);
            this.Controls.Add(this.btnCancelarRest);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNumDoc);
            this.Controls.Add(this.lblNroDocRes);
            this.Controls.Add(this.lblTipoDocRes);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.txtApeJug);
            this.Controls.Add(this.lblApeJug);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNomJug);
            this.Controls.Add(this.dGridJug);
            this.Controls.Add(this.lblTipoDocFiltro);
            this.Controls.Add(this.cmbFiltroTipoDoc);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.btnVolverMenu);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtFiltroDoc);
            this.Controls.Add(this.lblFiltroNroDoc);
            this.Controls.Add(this.lblGestJug);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ABMCJugsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionar Jugadores";
            this.Load += new System.EventHandler(this.ABMCArbForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridJug)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblGestJug;
        private System.Windows.Forms.Label lblFiltroNroDoc;
        private System.Windows.Forms.TextBox txtFiltroDoc;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolverMenu;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.ComboBox cmbFiltroTipoDoc;
        private System.Windows.Forms.Label lblTipoDocFiltro;
        private System.Windows.Forms.DataGridView dGridJug;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNomJug;
        private System.Windows.Forms.TextBox txtApeJug;
        private System.Windows.Forms.Label lblApeJug;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblTipoDocRes;
        private System.Windows.Forms.TextBox txtNumDoc;
        private System.Windows.Forms.Label lblNroDocRes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelarRest;
        private System.Windows.Forms.Button btnRestaurarSeleccion;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.ComboBox cmbPaisMod;
        private System.Windows.Forms.ComboBox cmbPaisFiltro;
        private System.Windows.Forms.Label lblPaisFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreJug;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoJug;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaísJug;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDocJug;
        private System.Windows.Forms.DataGridViewTextBoxColumn Goles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asistencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amarillas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rojas;
        private System.Windows.Forms.Button btnEliminar;
    }
}