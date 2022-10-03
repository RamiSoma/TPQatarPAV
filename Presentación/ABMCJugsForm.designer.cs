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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
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
            this.lblTipoDocFijo = new System.Windows.Forms.Label();
            this.cmbPaisMod = new System.Windows.Forms.ComboBox();
            this.cmbPaisFiltro = new System.Windows.Forms.ComboBox();
            this.lblPaisFiltro = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGridJug)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(90, 380);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(150, 32);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar Jugador";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(260, 380);
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
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(415, 81);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(51, 23);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(479, 81);
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
            this.btnRestaurar.Location = new System.Drawing.Point(600, 380);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(150, 30);
            this.btnRestaurar.TabIndex = 27;
            this.btnRestaurar.Text = "Restaurar Jugador";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
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
            this.dGridJug.Location = new System.Drawing.Point(36, 120);
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
            this.txtNombre.Location = new System.Drawing.Point(220, 380);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 32;
            // 
            // lblNomJug
            // 
            this.lblNomJug.AutoSize = true;
            this.lblNomJug.Location = new System.Drawing.Point(220, 365);
            this.lblNomJug.Name = "lblNomJug";
            this.lblNomJug.Size = new System.Drawing.Size(44, 13);
            this.lblNomJug.TabIndex = 31;
            this.lblNomJug.Text = "Nombre";
            // 
            // txtApeJug
            // 
            this.txtApeJug.Location = new System.Drawing.Point(340, 380);
            this.txtApeJug.Name = "txtApeJug";
            this.txtApeJug.Size = new System.Drawing.Size(100, 20);
            this.txtApeJug.TabIndex = 34;
            // 
            // lblApeJug
            // 
            this.lblApeJug.AutoSize = true;
            this.lblApeJug.Location = new System.Drawing.Point(340, 365);
            this.lblApeJug.Name = "lblApeJug";
            this.lblApeJug.Size = new System.Drawing.Size(44, 13);
            this.lblApeJug.TabIndex = 33;
            this.lblApeJug.Text = "Apellido";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(460, 365);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(29, 13);
            this.lblPais.TabIndex = 35;
            this.lblPais.Text = "País";
            // 
            // lblTipoDocRes
            // 
            this.lblTipoDocRes.AutoSize = true;
            this.lblTipoDocRes.Location = new System.Drawing.Point(240, 420);
            this.lblTipoDocRes.Name = "lblTipoDocRes";
            this.lblTipoDocRes.Size = new System.Drawing.Size(51, 13);
            this.lblTipoDocRes.TabIndex = 40;
            this.lblTipoDocRes.Text = "Tipo Doc";
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Location = new System.Drawing.Point(390, 420);
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(100, 20);
            this.txtNumDoc.TabIndex = 42;
            // 
            // lblNroDocRes
            // 
            this.lblNroDocRes.AutoSize = true;
            this.lblNroDocRes.Location = new System.Drawing.Point(340, 420);
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
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(488, 468);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 44;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelarRest
            // 
            this.btnCancelarRest.Location = new System.Drawing.Point(430, 417);
            this.btnCancelarRest.Name = "btnCancelarRest";
            this.btnCancelarRest.Size = new System.Drawing.Size(150, 25);
            this.btnCancelarRest.TabIndex = 45;
            this.btnCancelarRest.Text = "Cancelar";
            this.btnCancelarRest.UseVisualStyleBackColor = true;
            this.btnCancelarRest.Click += new System.EventHandler(this.btnCancelarRest_Click);
            // 
            // btnRestaurarSeleccion
            // 
            this.btnRestaurarSeleccion.Location = new System.Drawing.Point(592, 417);
            this.btnRestaurarSeleccion.Name = "btnRestaurarSeleccion";
            this.btnRestaurarSeleccion.Size = new System.Drawing.Size(150, 25);
            this.btnRestaurarSeleccion.TabIndex = 46;
            this.btnRestaurarSeleccion.Text = "Restaurar";
            this.btnRestaurarSeleccion.UseVisualStyleBackColor = true;
            this.btnRestaurarSeleccion.Click += new System.EventHandler(this.btnRestaurarSeleccion_Click);
            // 
            // lblTipoDocFijo
            // 
            this.lblTipoDocFijo.AutoSize = true;
            this.lblTipoDocFijo.Location = new System.Drawing.Point(300, 420);
            this.lblTipoDocFijo.Name = "lblTipoDocFijo";
            this.lblTipoDocFijo.Size = new System.Drawing.Size(0, 13);
            this.lblTipoDocFijo.TabIndex = 47;
            // 
            // cmbPaisMod
            // 
            this.cmbPaisMod.FormattingEnabled = true;
            this.cmbPaisMod.Location = new System.Drawing.Point(460, 380);
            this.cmbPaisMod.Name = "cmbPaisMod";
            this.cmbPaisMod.Size = new System.Drawing.Size(100, 21);
            this.cmbPaisMod.TabIndex = 48;
            // 
            // cmbPaisFiltro
            // 
            this.cmbPaisFiltro.FormattingEnabled = true;
            this.cmbPaisFiltro.Location = new System.Drawing.Point(264, 81);
            this.cmbPaisFiltro.Name = "cmbPaisFiltro";
            this.cmbPaisFiltro.Size = new System.Drawing.Size(121, 21);
            this.cmbPaisFiltro.TabIndex = 50;
            // 
            // lblPaisFiltro
            // 
            this.lblPaisFiltro.AutoSize = true;
            this.lblPaisFiltro.Location = new System.Drawing.Point(261, 64);
            this.lblPaisFiltro.Name = "lblPaisFiltro";
            this.lblPaisFiltro.Size = new System.Drawing.Size(29, 13);
            this.lblPaisFiltro.TabIndex = 49;
            this.lblPaisFiltro.Text = "País";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(430, 380);
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
            this.Controls.Add(this.lblTipoDocFijo);
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
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.btnVolverMenu);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
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
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolverMenu;
        private System.Windows.Forms.Button btnRestaurar;
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
        private System.Windows.Forms.Label lblTipoDocFijo;
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