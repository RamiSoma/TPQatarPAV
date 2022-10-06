namespace TPQatarPAVI.Presentación
{
    partial class ABMCPartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABMCPartForm));
            this.cmbPaisFiltro = new System.Windows.Forms.ComboBox();
            this.lblPaisFiltro = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dGridPartido = new System.Windows.Forms.DataGridView();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblGestJug = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbPaisVisitante = new System.Windows.Forms.ComboBox();
            this.btnRestaurarSeleccion = new System.Windows.Forms.Button();
            this.btnCancelarRest = new System.Windows.Forms.Button();
            this.lblVisitante = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.cmbPaisLocal = new System.Windows.Forms.ComboBox();
            this.lblLocal = new System.Windows.Forms.Label();
            this.cmbArb = new System.Windows.Forms.ComboBox();
            this.lblArb = new System.Windows.Forms.Label();
            this.cmbEstadio = new System.Windows.Forms.ComboBox();
            this.lblEstadio = new System.Windows.Forms.Label();
            this.cmbRonda = new System.Windows.Forms.ComboBox();
            this.lblRonda = new System.Windows.Forms.Label();
            this.lblIdMostrar = new System.Windows.Forms.Label();
            this.cmbEstadioFiltro = new System.Windows.Forms.ComboBox();
            this.lblEstadioFIltro = new System.Windows.Forms.Label();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.lblTxtGrupo = new System.Windows.Forms.Label();
            this.cmbGrupoFiltro = new System.Windows.Forms.ComboBox();
            this.lblGrupoFiltro = new System.Windows.Forms.Label();
            this.cmbRondaFiltro = new System.Windows.Forms.ComboBox();
            this.lblRondaFiltro = new System.Windows.Forms.Label();
            this.calFecha = new System.Windows.Forms.MonthCalendar();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ronda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Local = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Visitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arbitro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estadio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGridPartido)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPaisFiltro
            // 
            this.cmbPaisFiltro.FormattingEnabled = true;
            this.cmbPaisFiltro.Location = new System.Drawing.Point(470, 74);
            this.cmbPaisFiltro.Name = "cmbPaisFiltro";
            this.cmbPaisFiltro.Size = new System.Drawing.Size(121, 21);
            this.cmbPaisFiltro.TabIndex = 79;
            this.cmbPaisFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbPaisFiltro_SelectedIndexChanged_1);
            // 
            // lblPaisFiltro
            // 
            this.lblPaisFiltro.AutoSize = true;
            this.lblPaisFiltro.Location = new System.Drawing.Point(467, 57);
            this.lblPaisFiltro.Name = "lblPaisFiltro";
            this.lblPaisFiltro.Size = new System.Drawing.Size(29, 13);
            this.lblPaisFiltro.TabIndex = 78;
            this.lblPaisFiltro.Text = "País";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(587, 527);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 72;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(675, 527);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 73;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dGridPartido
            // 
            this.dGridPartido.AllowUserToAddRows = false;
            this.dGridPartido.AllowUserToDeleteRows = false;
            this.dGridPartido.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dGridPartido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridPartido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Ronda,
            this.Local,
            this.Visitante,
            this.Fecha,
            this.Arbitro,
            this.Estadio,
            this.grupos});
            this.dGridPartido.Location = new System.Drawing.Point(181, 130);
            this.dGridPartido.Name = "dGridPartido";
            this.dGridPartido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridPartido.Size = new System.Drawing.Size(579, 222);
            this.dGridPartido.TabIndex = 63;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Location = new System.Drawing.Point(25, 282);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(150, 30);
            this.btnRestaurar.TabIndex = 60;
            this.btnRestaurar.Text = "Restaurar Partido";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.Location = new System.Drawing.Point(25, 465);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(150, 28);
            this.btnVolverMenu.TabIndex = 59;
            this.btnVolverMenu.Text = "Menu Principal";
            this.btnVolverMenu.UseVisualStyleBackColor = true;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(675, 72);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(51, 23);
            this.btnLimpiar.TabIndex = 58;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(611, 72);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(51, 23);
            this.btnBuscar.TabIndex = 57;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblGestJug
            // 
            this.lblGestJug.AutoSize = true;
            this.lblGestJug.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestJug.Location = new System.Drawing.Point(260, 28);
            this.lblGestJug.Name = "lblGestJug";
            this.lblGestJug.Size = new System.Drawing.Size(243, 24);
            this.lblGestJug.TabIndex = 54;
            this.lblGestJug.Text = "GESTION DE PARTIDOS";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(25, 181);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(150, 32);
            this.btnModificar.TabIndex = 53;
            this.btnModificar.Text = "Modificar Partido";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(25, 235);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 32);
            this.btnEliminar.TabIndex = 52;
            this.btnEliminar.Text = "Eliminar Partido";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(25, 130);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(150, 32);
            this.btnAgregar.TabIndex = 51;
            this.btnAgregar.Text = "Agregar Partido";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmbPaisVisitante
            // 
            this.cmbPaisVisitante.FormattingEnabled = true;
            this.cmbPaisVisitante.Location = new System.Drawing.Point(379, 428);
            this.cmbPaisVisitante.Name = "cmbPaisVisitante";
            this.cmbPaisVisitante.Size = new System.Drawing.Size(121, 21);
            this.cmbPaisVisitante.TabIndex = 91;
            // 
            // btnRestaurarSeleccion
            // 
            this.btnRestaurarSeleccion.Location = new System.Drawing.Point(634, 358);
            this.btnRestaurarSeleccion.Name = "btnRestaurarSeleccion";
            this.btnRestaurarSeleccion.Size = new System.Drawing.Size(96, 25);
            this.btnRestaurarSeleccion.TabIndex = 89;
            this.btnRestaurarSeleccion.Text = "Restaurar";
            this.btnRestaurarSeleccion.UseVisualStyleBackColor = true;
            this.btnRestaurarSeleccion.Click += new System.EventHandler(this.btnRestaurarSeleccion_Click);
            // 
            // btnCancelarRest
            // 
            this.btnCancelarRest.Location = new System.Drawing.Point(531, 358);
            this.btnCancelarRest.Name = "btnCancelarRest";
            this.btnCancelarRest.Size = new System.Drawing.Size(96, 25);
            this.btnCancelarRest.TabIndex = 88;
            this.btnCancelarRest.Text = "Cancelar";
            this.btnCancelarRest.UseVisualStyleBackColor = true;
            this.btnCancelarRest.Click += new System.EventHandler(this.btnCancelarRest_Click);
            // 
            // lblVisitante
            // 
            this.lblVisitante.AutoSize = true;
            this.lblVisitante.Location = new System.Drawing.Point(376, 411);
            this.lblVisitante.Name = "lblVisitante";
            this.lblVisitante.Size = new System.Drawing.Size(47, 13);
            this.lblVisitante.TabIndex = 84;
            this.lblVisitante.Text = "Visitante";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(190, 381);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 80;
            this.lblId.Text = "Id";
            // 
            // cmbPaisLocal
            // 
            this.cmbPaisLocal.FormattingEnabled = true;
            this.cmbPaisLocal.Location = new System.Drawing.Point(251, 428);
            this.cmbPaisLocal.Name = "cmbPaisLocal";
            this.cmbPaisLocal.Size = new System.Drawing.Size(121, 21);
            this.cmbPaisLocal.TabIndex = 93;
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Location = new System.Drawing.Point(248, 411);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(33, 13);
            this.lblLocal.TabIndex = 92;
            this.lblLocal.Text = "Local";
            // 
            // cmbArb
            // 
            this.cmbArb.FormattingEnabled = true;
            this.cmbArb.Location = new System.Drawing.Point(251, 469);
            this.cmbArb.Name = "cmbArb";
            this.cmbArb.Size = new System.Drawing.Size(121, 21);
            this.cmbArb.TabIndex = 95;
            // 
            // lblArb
            // 
            this.lblArb.AutoSize = true;
            this.lblArb.Location = new System.Drawing.Point(250, 452);
            this.lblArb.Name = "lblArb";
            this.lblArb.Size = new System.Drawing.Size(37, 13);
            this.lblArb.TabIndex = 94;
            this.lblArb.Text = "Arbitro";
            // 
            // cmbEstadio
            // 
            this.cmbEstadio.FormattingEnabled = true;
            this.cmbEstadio.Location = new System.Drawing.Point(379, 469);
            this.cmbEstadio.Name = "cmbEstadio";
            this.cmbEstadio.Size = new System.Drawing.Size(121, 21);
            this.cmbEstadio.TabIndex = 97;
            // 
            // lblEstadio
            // 
            this.lblEstadio.AutoSize = true;
            this.lblEstadio.Location = new System.Drawing.Point(376, 452);
            this.lblEstadio.Name = "lblEstadio";
            this.lblEstadio.Size = new System.Drawing.Size(42, 13);
            this.lblEstadio.TabIndex = 96;
            this.lblEstadio.Text = "Estadio";
            // 
            // cmbRonda
            // 
            this.cmbRonda.FormattingEnabled = true;
            this.cmbRonda.Location = new System.Drawing.Point(251, 378);
            this.cmbRonda.Name = "cmbRonda";
            this.cmbRonda.Size = new System.Drawing.Size(83, 21);
            this.cmbRonda.TabIndex = 99;
            this.cmbRonda.SelectionChangeCommitted += new System.EventHandler(this.cmbRonda_SelectedIndexChanged);
            // 
            // lblRonda
            // 
            this.lblRonda.AutoSize = true;
            this.lblRonda.Location = new System.Drawing.Point(248, 361);
            this.lblRonda.Name = "lblRonda";
            this.lblRonda.Size = new System.Drawing.Size(39, 13);
            this.lblRonda.TabIndex = 98;
            this.lblRonda.Text = "Ronda";
            // 
            // lblIdMostrar
            // 
            this.lblIdMostrar.AutoSize = true;
            this.lblIdMostrar.Location = new System.Drawing.Point(213, 381);
            this.lblIdMostrar.Name = "lblIdMostrar";
            this.lblIdMostrar.Size = new System.Drawing.Size(0, 13);
            this.lblIdMostrar.TabIndex = 100;
            // 
            // cmbEstadioFiltro
            // 
            this.cmbEstadioFiltro.FormattingEnabled = true;
            this.cmbEstadioFiltro.Location = new System.Drawing.Point(289, 74);
            this.cmbEstadioFiltro.Name = "cmbEstadioFiltro";
            this.cmbEstadioFiltro.Size = new System.Drawing.Size(175, 21);
            this.cmbEstadioFiltro.TabIndex = 104;
            // 
            // lblEstadioFIltro
            // 
            this.lblEstadioFIltro.AutoSize = true;
            this.lblEstadioFIltro.Location = new System.Drawing.Point(286, 57);
            this.lblEstadioFIltro.Name = "lblEstadioFIltro";
            this.lblEstadioFIltro.Size = new System.Drawing.Size(42, 13);
            this.lblEstadioFIltro.TabIndex = 103;
            this.lblEstadioFIltro.Text = "Estadio";
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.Location = new System.Drawing.Point(379, 378);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(83, 21);
            this.cmbGrupo.TabIndex = 106;
            this.cmbGrupo.SelectionChangeCommitted += new System.EventHandler(this.cmbGrupo_SelectedIndexChanged);
            // 
            // lblTxtGrupo
            // 
            this.lblTxtGrupo.AutoSize = true;
            this.lblTxtGrupo.Location = new System.Drawing.Point(376, 361);
            this.lblTxtGrupo.Name = "lblTxtGrupo";
            this.lblTxtGrupo.Size = new System.Drawing.Size(36, 13);
            this.lblTxtGrupo.TabIndex = 105;
            this.lblTxtGrupo.Text = "Grupo";
            // 
            // cmbGrupoFiltro
            // 
            this.cmbGrupoFiltro.FormattingEnabled = true;
            this.cmbGrupoFiltro.Location = new System.Drawing.Point(232, 101);
            this.cmbGrupoFiltro.Name = "cmbGrupoFiltro";
            this.cmbGrupoFiltro.Size = new System.Drawing.Size(91, 21);
            this.cmbGrupoFiltro.TabIndex = 108;
            this.cmbGrupoFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbGrupoFiltro_SelectedIndexChanged);
            this.cmbGrupoFiltro.SelectionChangeCommitted += new System.EventHandler(this.cmbPaisFiltro_SelectedIndexChanged);
            // 
            // lblGrupoFiltro
            // 
            this.lblGrupoFiltro.AutoSize = true;
            this.lblGrupoFiltro.Location = new System.Drawing.Point(190, 106);
            this.lblGrupoFiltro.Name = "lblGrupoFiltro";
            this.lblGrupoFiltro.Size = new System.Drawing.Size(36, 13);
            this.lblGrupoFiltro.TabIndex = 107;
            this.lblGrupoFiltro.Text = "Grupo";
            // 
            // cmbRondaFiltro
            // 
            this.cmbRondaFiltro.FormattingEnabled = true;
            this.cmbRondaFiltro.Location = new System.Drawing.Point(192, 74);
            this.cmbRondaFiltro.Name = "cmbRondaFiltro";
            this.cmbRondaFiltro.Size = new System.Drawing.Size(91, 21);
            this.cmbRondaFiltro.TabIndex = 110;
            this.cmbRondaFiltro.SelectionChangeCommitted += new System.EventHandler(this.cmbRondaFiltro_SelectionChangeCommitted);
            // 
            // lblRondaFiltro
            // 
            this.lblRondaFiltro.AutoSize = true;
            this.lblRondaFiltro.Location = new System.Drawing.Point(190, 57);
            this.lblRondaFiltro.Name = "lblRondaFiltro";
            this.lblRondaFiltro.Size = new System.Drawing.Size(39, 13);
            this.lblRondaFiltro.TabIndex = 109;
            this.lblRondaFiltro.Text = "Ronda";
            // 
            // calFecha
            // 
            this.calFecha.Location = new System.Drawing.Point(512, 358);
            this.calFecha.MinDate = new System.DateTime(2022, 10, 6, 0, 0, 0, 0);
            this.calFecha.Name = "calFecha";
            this.calFecha.TabIndex = 111;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 35;
            // 
            // Ronda
            // 
            this.Ronda.HeaderText = "Ronda";
            this.Ronda.Name = "Ronda";
            this.Ronda.Width = 45;
            // 
            // Local
            // 
            this.Local.HeaderText = "Local";
            this.Local.Name = "Local";
            this.Local.Width = 75;
            // 
            // Visitante
            // 
            this.Visitante.HeaderText = "Visitante";
            this.Visitante.Name = "Visitante";
            this.Visitante.Width = 75;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Arbitro
            // 
            this.Arbitro.HeaderText = "Arbitro";
            this.Arbitro.Name = "Arbitro";
            this.Arbitro.Width = 110;
            // 
            // Estadio
            // 
            this.Estadio.HeaderText = "Estadio";
            this.Estadio.Name = "Estadio";
            // 
            // grupos
            // 
            this.grupos.HeaderText = "Grupo";
            this.grupos.Name = "grupos";
            this.grupos.Visible = false;
            // 
            // ABMCPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.calFecha);
            this.Controls.Add(this.cmbRondaFiltro);
            this.Controls.Add(this.lblRondaFiltro);
            this.Controls.Add(this.cmbGrupoFiltro);
            this.Controls.Add(this.lblGrupoFiltro);
            this.Controls.Add(this.cmbGrupo);
            this.Controls.Add(this.lblTxtGrupo);
            this.Controls.Add(this.cmbEstadioFiltro);
            this.Controls.Add(this.lblEstadioFIltro);
            this.Controls.Add(this.lblIdMostrar);
            this.Controls.Add(this.cmbRonda);
            this.Controls.Add(this.lblRonda);
            this.Controls.Add(this.cmbEstadio);
            this.Controls.Add(this.lblEstadio);
            this.Controls.Add(this.cmbArb);
            this.Controls.Add(this.lblArb);
            this.Controls.Add(this.cmbPaisLocal);
            this.Controls.Add(this.lblLocal);
            this.Controls.Add(this.cmbPaisVisitante);
            this.Controls.Add(this.btnRestaurarSeleccion);
            this.Controls.Add(this.btnCancelarRest);
            this.Controls.Add(this.lblVisitante);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.cmbPaisFiltro);
            this.Controls.Add(this.lblPaisFiltro);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dGridPartido);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.btnVolverMenu);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblGestJug);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ABMCPartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionar Partidos";
            this.Load += new System.EventHandler(this.ABMCPartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridPartido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPaisFiltro;
        private System.Windows.Forms.Label lblPaisFiltro;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dGridPartido;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnVolverMenu;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblGestJug;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbPaisVisitante;
        private System.Windows.Forms.Button btnRestaurarSeleccion;
        private System.Windows.Forms.Button btnCancelarRest;
        private System.Windows.Forms.Label lblVisitante;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox cmbPaisLocal;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.ComboBox cmbArb;
        private System.Windows.Forms.Label lblArb;
        private System.Windows.Forms.ComboBox cmbEstadio;
        private System.Windows.Forms.Label lblEstadio;
        private System.Windows.Forms.ComboBox cmbRonda;
        private System.Windows.Forms.Label lblRonda;
        private System.Windows.Forms.Label lblIdMostrar;
        private System.Windows.Forms.ComboBox cmbEstadioFiltro;
        private System.Windows.Forms.Label lblEstadioFIltro;
        private System.Windows.Forms.ComboBox cmbGrupo;
        private System.Windows.Forms.Label lblTxtGrupo;
        private System.Windows.Forms.ComboBox cmbGrupoFiltro;
        private System.Windows.Forms.Label lblGrupoFiltro;
        private System.Windows.Forms.ComboBox cmbRondaFiltro;
        private System.Windows.Forms.Label lblRondaFiltro;
        private System.Windows.Forms.MonthCalendar calFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ronda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Local;
        private System.Windows.Forms.DataGridViewTextBoxColumn Visitante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arbitro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estadio;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupos;
    }
}