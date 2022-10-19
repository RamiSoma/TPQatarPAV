namespace TPQatarPAVI.Presentación
{
    partial class DetallePartidoForm
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
            this.lblDetallePartido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMostrarFecha = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dGridEventos = new System.Windows.Forms.DataGridView();
            this.col_Minuto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NroDocJug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblIdPart = new System.Windows.Forms.Label();
            this.lblMostrarId = new System.Windows.Forms.Label();
            this.ck_nomb_local = new System.Windows.Forms.CheckBox();
            this.ck_nomb_visita = new System.Windows.Forms.CheckBox();
            this.lblMostrarRonda = new System.Windows.Forms.Label();
            this.lblMostrarGrupo = new System.Windows.Forms.Label();
            this.lblMostrarArb = new System.Windows.Forms.Label();
            this.lblMostrarEstadio = new System.Windows.Forms.Label();
            this.lblMinutoAM = new System.Windows.Forms.Label();
            this.cmbEventoAM = new System.Windows.Forms.ComboBox();
            this.cmbJugadoresAM = new System.Windows.Forms.ComboBox();
            this.btnCancelarAM = new System.Windows.Forms.Button();
            this.btnGuardarAM = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.lblEventoAM = new System.Windows.Forms.Label();
            this.lblJugAM = new System.Windows.Forms.Label();
            this.lblPaisAM = new System.Windows.Forms.Label();
            this.NumAM = new System.Windows.Forms.NumericUpDown();
            this.lblGolesLocal = new System.Windows.Forms.Label();
            this.lblGolesVisita = new System.Windows.Forms.Label();
            this.btnFinalizarPartido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGridEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumAM)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDetallePartido
            // 
            this.lblDetallePartido.AutoSize = true;
            this.lblDetallePartido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetallePartido.Location = new System.Drawing.Point(294, 23);
            this.lblDetallePartido.Name = "lblDetallePartido";
            this.lblDetallePartido.Size = new System.Drawing.Size(207, 31);
            this.lblDetallePartido.TabIndex = 0;
            this.lblDetallePartido.Text = "Detalle Partido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Equipo Local";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(549, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Equipo Visita";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ronda";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Grupo";
            // 
            // lblMostrarFecha
            // 
            this.lblMostrarFecha.AutoSize = true;
            this.lblMostrarFecha.Location = new System.Drawing.Point(57, 156);
            this.lblMostrarFecha.Name = "lblMostrarFecha";
            this.lblMostrarFecha.Size = new System.Drawing.Size(85, 13);
            this.lblMostrarFecha.TabIndex = 7;
            this.lblMostrarFecha.Text = "Aca iría la fecha";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Arbitro";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Estadio";
            // 
            // dGridEventos
            // 
            this.dGridEventos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dGridEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Minuto,
            this.col_NroDocJug,
            this.Nombre,
            this.col_Evento,
            this.idEvento});
            this.dGridEventos.Location = new System.Drawing.Point(263, 103);
            this.dGridEventos.MultiSelect = false;
            this.dGridEventos.Name = "dGridEventos";
            this.dGridEventos.ReadOnly = true;
            this.dGridEventos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGridEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridEventos.Size = new System.Drawing.Size(484, 274);
            this.dGridEventos.TabIndex = 10;
            this.dGridEventos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridEventos_CellContentClick);
            // 
            // col_Minuto
            // 
            this.col_Minuto.HeaderText = "Minuto";
            this.col_Minuto.Name = "col_Minuto";
            this.col_Minuto.ReadOnly = true;
            // 
            // col_NroDocJug
            // 
            this.col_NroDocJug.HeaderText = "Nro Doc Jugador";
            this.col_NroDocJug.Name = "col_NroDocJug";
            this.col_NroDocJug.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // col_Evento
            // 
            this.col_Evento.HeaderText = "Evento";
            this.col_Evento.Name = "col_Evento";
            this.col_Evento.ReadOnly = true;
            // 
            // idEvento
            // 
            this.idEvento.HeaderText = "idEvento";
            this.idEvento.Name = "idEvento";
            this.idEvento.ReadOnly = true;
            this.idEvento.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(486, 411);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 32);
            this.btnEliminar.TabIndex = 62;
            this.btnEliminar.Text = "Eliminar Evento";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(344, 411);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 32);
            this.btnAgregar.TabIndex = 61;
            this.btnAgregar.Text = "Agregar Evento";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblIdPart
            // 
            this.lblIdPart.AutoSize = true;
            this.lblIdPart.Location = new System.Drawing.Point(48, 79);
            this.lblIdPart.Name = "lblIdPart";
            this.lblIdPart.Size = new System.Drawing.Size(51, 13);
            this.lblIdPart.TabIndex = 64;
            this.lblIdPart.Text = "Id partido";
            this.lblIdPart.Click += new System.EventHandler(this.label10_Click);
            // 
            // lblMostrarId
            // 
            this.lblMostrarId.AutoSize = true;
            this.lblMostrarId.Location = new System.Drawing.Point(127, 79);
            this.lblMostrarId.Name = "lblMostrarId";
            this.lblMostrarId.Size = new System.Drawing.Size(80, 13);
            this.lblMostrarId.TabIndex = 65;
            this.lblMostrarId.Text = "Aca se muestra";
            // 
            // ck_nomb_local
            // 
            this.ck_nomb_local.AutoSize = true;
            this.ck_nomb_local.Location = new System.Drawing.Point(401, 79);
            this.ck_nomb_local.Name = "ck_nomb_local";
            this.ck_nomb_local.Size = new System.Drawing.Size(48, 17);
            this.ck_nomb_local.TabIndex = 66;
            this.ck_nomb_local.Text = "local";
            this.ck_nomb_local.UseVisualStyleBackColor = true;
            this.ck_nomb_local.CheckedChanged += new System.EventHandler(this.ck_nomb_local_CheckedChanged);
            // 
            // ck_nomb_visita
            // 
            this.ck_nomb_visita.AutoSize = true;
            this.ck_nomb_visita.Location = new System.Drawing.Point(623, 78);
            this.ck_nomb_visita.Name = "ck_nomb_visita";
            this.ck_nomb_visita.Size = new System.Drawing.Size(66, 17);
            this.ck_nomb_visita.TabIndex = 67;
            this.ck_nomb_visita.Text = "Visitante";
            this.ck_nomb_visita.UseVisualStyleBackColor = true;
            this.ck_nomb_visita.CheckedChanged += new System.EventHandler(this.ck_nomb_visita_CheckedChanged);
            // 
            // lblMostrarRonda
            // 
            this.lblMostrarRonda.AutoSize = true;
            this.lblMostrarRonda.Location = new System.Drawing.Point(137, 103);
            this.lblMostrarRonda.Name = "lblMostrarRonda";
            this.lblMostrarRonda.Size = new System.Drawing.Size(106, 13);
            this.lblMostrarRonda.TabIndex = 68;
            this.lblMostrarRonda.Text = "Label Mostrar Ronda";
            // 
            // lblMostrarGrupo
            // 
            this.lblMostrarGrupo.AutoSize = true;
            this.lblMostrarGrupo.Location = new System.Drawing.Point(138, 129);
            this.lblMostrarGrupo.Name = "lblMostrarGrupo";
            this.lblMostrarGrupo.Size = new System.Drawing.Size(96, 13);
            this.lblMostrarGrupo.TabIndex = 69;
            this.lblMostrarGrupo.Text = "label mostrar grupo";
            // 
            // lblMostrarArb
            // 
            this.lblMostrarArb.AutoSize = true;
            this.lblMostrarArb.Location = new System.Drawing.Point(138, 185);
            this.lblMostrarArb.Name = "lblMostrarArb";
            this.lblMostrarArb.Size = new System.Drawing.Size(65, 13);
            this.lblMostrarArb.TabIndex = 70;
            this.lblMostrarArb.Text = "Label arbitro";
            // 
            // lblMostrarEstadio
            // 
            this.lblMostrarEstadio.AutoSize = true;
            this.lblMostrarEstadio.Location = new System.Drawing.Point(138, 215);
            this.lblMostrarEstadio.Name = "lblMostrarEstadio";
            this.lblMostrarEstadio.Size = new System.Drawing.Size(70, 13);
            this.lblMostrarEstadio.TabIndex = 71;
            this.lblMostrarEstadio.Text = "Label estadio";
            // 
            // lblMinutoAM
            // 
            this.lblMinutoAM.AutoSize = true;
            this.lblMinutoAM.Location = new System.Drawing.Point(48, 289);
            this.lblMinutoAM.Name = "lblMinutoAM";
            this.lblMinutoAM.Size = new System.Drawing.Size(39, 13);
            this.lblMinutoAM.TabIndex = 72;
            this.lblMinutoAM.Text = "Minuto";
            // 
            // cmbEventoAM
            // 
            this.cmbEventoAM.FormattingEnabled = true;
            this.cmbEventoAM.Location = new System.Drawing.Point(51, 327);
            this.cmbEventoAM.Name = "cmbEventoAM";
            this.cmbEventoAM.Size = new System.Drawing.Size(121, 21);
            this.cmbEventoAM.TabIndex = 74;
            this.cmbEventoAM.SelectedIndexChanged += new System.EventHandler(this.cmbEventoAM_SelectedIndexChanged);
            // 
            // cmbJugadoresAM
            // 
            this.cmbJugadoresAM.FormattingEnabled = true;
            this.cmbJugadoresAM.Location = new System.Drawing.Point(51, 371);
            this.cmbJugadoresAM.Name = "cmbJugadoresAM";
            this.cmbJugadoresAM.Size = new System.Drawing.Size(121, 21);
            this.cmbJugadoresAM.TabIndex = 75;
            // 
            // btnCancelarAM
            // 
            this.btnCancelarAM.Location = new System.Drawing.Point(48, 420);
            this.btnCancelarAM.Name = "btnCancelarAM";
            this.btnCancelarAM.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarAM.TabIndex = 76;
            this.btnCancelarAM.Text = "Cancelar";
            this.btnCancelarAM.UseVisualStyleBackColor = true;
            this.btnCancelarAM.Click += new System.EventHandler(this.btnCancelarAM_Click);
            // 
            // btnGuardarAM
            // 
            this.btnGuardarAM.Location = new System.Drawing.Point(130, 420);
            this.btnGuardarAM.Name = "btnGuardarAM";
            this.btnGuardarAM.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarAM.TabIndex = 77;
            this.btnGuardarAM.Text = "Guardar";
            this.btnGuardarAM.UseVisualStyleBackColor = true;
            this.btnGuardarAM.Click += new System.EventHandler(this.btnGuardarAM_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Location = new System.Drawing.Point(627, 411);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(120, 32);
            this.btnRestaurar.TabIndex = 78;
            this.btnRestaurar.Text = "Restaurar Evento";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.Location = new System.Drawing.Point(40, 500);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(150, 35);
            this.btnVolverMenu.TabIndex = 79;
            this.btnVolverMenu.Text = "Menu Principal";
            this.btnVolverMenu.UseVisualStyleBackColor = true;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // lblEventoAM
            // 
            this.lblEventoAM.AutoSize = true;
            this.lblEventoAM.Location = new System.Drawing.Point(48, 311);
            this.lblEventoAM.Name = "lblEventoAM";
            this.lblEventoAM.Size = new System.Drawing.Size(41, 13);
            this.lblEventoAM.TabIndex = 80;
            this.lblEventoAM.Text = "Evento";
            // 
            // lblJugAM
            // 
            this.lblJugAM.AutoSize = true;
            this.lblJugAM.Location = new System.Drawing.Point(48, 355);
            this.lblJugAM.Name = "lblJugAM";
            this.lblJugAM.Size = new System.Drawing.Size(45, 13);
            this.lblJugAM.TabIndex = 81;
            this.lblJugAM.Text = "Jugador";
            // 
            // lblPaisAM
            // 
            this.lblPaisAM.AutoSize = true;
            this.lblPaisAM.Location = new System.Drawing.Point(48, 261);
            this.lblPaisAM.Name = "lblPaisAM";
            this.lblPaisAM.Size = new System.Drawing.Size(65, 13);
            this.lblPaisAM.TabIndex = 82;
            this.lblPaisAM.Text = "Pais Mostrar";
            // 
            // NumAM
            // 
            this.NumAM.Location = new System.Drawing.Point(99, 289);
            this.NumAM.Name = "NumAM";
            this.NumAM.Size = new System.Drawing.Size(43, 20);
            this.NumAM.TabIndex = 83;
            // 
            // lblGolesLocal
            // 
            this.lblGolesLocal.AutoSize = true;
            this.lblGolesLocal.Location = new System.Drawing.Point(471, 80);
            this.lblGolesLocal.Name = "lblGolesLocal";
            this.lblGolesLocal.Size = new System.Drawing.Size(13, 13);
            this.lblGolesLocal.TabIndex = 84;
            this.lblGolesLocal.Text = "0";
            this.lblGolesLocal.Click += new System.EventHandler(this.lblGolesLocal_Click);
            // 
            // lblGolesVisita
            // 
            this.lblGolesVisita.AutoSize = true;
            this.lblGolesVisita.Location = new System.Drawing.Point(711, 80);
            this.lblGolesVisita.Name = "lblGolesVisita";
            this.lblGolesVisita.Size = new System.Drawing.Size(13, 13);
            this.lblGolesVisita.TabIndex = 85;
            this.lblGolesVisita.Text = "0";
            // 
            // btnFinalizarPartido
            // 
            this.btnFinalizarPartido.Location = new System.Drawing.Point(486, 464);
            this.btnFinalizarPartido.Name = "btnFinalizarPartido";
            this.btnFinalizarPartido.Size = new System.Drawing.Size(120, 32);
            this.btnFinalizarPartido.TabIndex = 86;
            this.btnFinalizarPartido.Text = "Finalizar Partido";
            this.btnFinalizarPartido.UseVisualStyleBackColor = true;
            this.btnFinalizarPartido.Click += new System.EventHandler(this.btnFinalizarPartido_Click);
            // 
            // DetallePartidoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnFinalizarPartido);
            this.Controls.Add(this.lblGolesVisita);
            this.Controls.Add(this.lblGolesLocal);
            this.Controls.Add(this.NumAM);
            this.Controls.Add(this.lblPaisAM);
            this.Controls.Add(this.lblJugAM);
            this.Controls.Add(this.lblEventoAM);
            this.Controls.Add(this.btnVolverMenu);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.btnGuardarAM);
            this.Controls.Add(this.btnCancelarAM);
            this.Controls.Add(this.cmbJugadoresAM);
            this.Controls.Add(this.cmbEventoAM);
            this.Controls.Add(this.lblMinutoAM);
            this.Controls.Add(this.lblMostrarEstadio);
            this.Controls.Add(this.lblMostrarArb);
            this.Controls.Add(this.lblMostrarGrupo);
            this.Controls.Add(this.lblMostrarRonda);
            this.Controls.Add(this.ck_nomb_visita);
            this.Controls.Add(this.ck_nomb_local);
            this.Controls.Add(this.lblMostrarId);
            this.Controls.Add(this.lblIdPart);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dGridEventos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblMostrarFecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDetallePartido);
            this.Name = "DetallePartidoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles Partido";
            this.Load += new System.EventHandler(this.DetallePartidoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumAM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDetallePartido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMostrarFecha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dGridEventos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblIdPart;
        private System.Windows.Forms.Label lblMostrarId;
        private System.Windows.Forms.CheckBox ck_nomb_local;
        private System.Windows.Forms.CheckBox ck_nomb_visita;
        private System.Windows.Forms.Label lblMostrarRonda;
        private System.Windows.Forms.Label lblMostrarGrupo;
        private System.Windows.Forms.Label lblMostrarArb;
        private System.Windows.Forms.Label lblMostrarEstadio;
        private System.Windows.Forms.Label lblMinutoAM;
        private System.Windows.Forms.ComboBox cmbEventoAM;
        private System.Windows.Forms.ComboBox cmbJugadoresAM;
        private System.Windows.Forms.Button btnCancelarAM;
        private System.Windows.Forms.Button btnGuardarAM;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnVolverMenu;
        private System.Windows.Forms.Label lblEventoAM;
        private System.Windows.Forms.Label lblJugAM;
        private System.Windows.Forms.Label lblPaisAM;
        private System.Windows.Forms.NumericUpDown NumAM;
        private System.Windows.Forms.Label lblGolesLocal;
        private System.Windows.Forms.Label lblGolesVisita;
        private System.Windows.Forms.Button btnFinalizarPartido;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Minuto;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NroDocJug;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEvento;
    }
}