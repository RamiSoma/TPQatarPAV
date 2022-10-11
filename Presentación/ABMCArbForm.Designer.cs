namespace TPQatarPAVI.Presentación
{
    partial class ABMCArbForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABMCArbForm));
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblGestArb = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.dGridArb = new System.Windows.Forms.DataGridView();
            this.NombreArb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoArb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaísArb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocArb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroDocArb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNomArb = new System.Windows.Forms.Label();
            this.txtApeArb = new System.Windows.Forms.TextBox();
            this.lblApeArb = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblTipoDocMod = new System.Windows.Forms.Label();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.lblNumDocMod = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelarRest = new System.Windows.Forms.Button();
            this.btnRestaurarSeleccion = new System.Windows.Forms.Button();
            this.cmbPaisMod = new System.Windows.Forms.ComboBox();
            this.cmbPaisFiltro = new System.Windows.Forms.ComboBox();
            this.lblPaisFiltro = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblNombreFiltro = new System.Windows.Forms.Label();
            this.txtNombreFiltro = new System.Windows.Forms.TextBox();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGridArb)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(25, 134);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(150, 32);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar Arbitro";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(25, 246);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 32);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar Arbitro";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // lblGestArb
            // 
            this.lblGestArb.AutoSize = true;
            this.lblGestArb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestArb.Location = new System.Drawing.Point(260, 26);
            this.lblGestArb.Name = "lblGestArb";
            this.lblGestArb.Size = new System.Drawing.Size(243, 24);
            this.lblGestArb.TabIndex = 7;
            this.lblGestArb.Text = "GESTION DE ARBITROS";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(512, 81);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(51, 23);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(576, 81);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(51, 23);
            this.btnLimpiar.TabIndex = 25;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.Location = new System.Drawing.Point(40, 500);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(150, 35);
            this.btnVolverMenu.TabIndex = 26;
            this.btnVolverMenu.Text = "Menu Principal";
            this.btnVolverMenu.UseVisualStyleBackColor = true;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Location = new System.Drawing.Point(25, 297);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(150, 30);
            this.btnRestaurar.TabIndex = 27;
            this.btnRestaurar.Text = "Restaurar Arbitro";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // dGridArb
            // 
            this.dGridArb.AllowUserToAddRows = false;
            this.dGridArb.AllowUserToDeleteRows = false;
            this.dGridArb.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dGridArb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridArb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreArb,
            this.ApellidoArb,
            this.PaísArb,
            this.TipoDocArb,
            this.NroDocArb});
            this.dGridArb.Location = new System.Drawing.Point(214, 134);
            this.dGridArb.Name = "dGridArb";
            this.dGridArb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridArb.Size = new System.Drawing.Size(494, 222);
            this.dGridArb.TabIndex = 30;
            // 
            // NombreArb
            // 
            this.NombreArb.HeaderText = "Nombre";
            this.NombreArb.Name = "NombreArb";
            // 
            // ApellidoArb
            // 
            this.ApellidoArb.HeaderText = "Apellido";
            this.ApellidoArb.Name = "ApellidoArb";
            // 
            // PaísArb
            // 
            this.PaísArb.HeaderText = "País";
            this.PaísArb.Name = "PaísArb";
            this.PaísArb.Width = 70;
            // 
            // TipoDocArb
            // 
            this.TipoDocArb.HeaderText = "TipoDoc";
            this.TipoDocArb.Name = "TipoDocArb";
            this.TipoDocArb.Width = 80;
            // 
            // NroDocArb
            // 
            this.NroDocArb.HeaderText = "N°Doc";
            this.NroDocArb.Name = "NroDocArb";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(214, 380);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 32;
            // 
            // lblNomArb
            // 
            this.lblNomArb.AutoSize = true;
            this.lblNomArb.Location = new System.Drawing.Point(211, 364);
            this.lblNomArb.Name = "lblNomArb";
            this.lblNomArb.Size = new System.Drawing.Size(44, 13);
            this.lblNomArb.TabIndex = 31;
            this.lblNomArb.Text = "Nombre";
            // 
            // txtApeArb
            // 
            this.txtApeArb.Location = new System.Drawing.Point(333, 380);
            this.txtApeArb.Name = "txtApeArb";
            this.txtApeArb.Size = new System.Drawing.Size(100, 20);
            this.txtApeArb.TabIndex = 34;
            // 
            // lblApeArb
            // 
            this.lblApeArb.AutoSize = true;
            this.lblApeArb.Location = new System.Drawing.Point(331, 364);
            this.lblApeArb.Name = "lblApeArb";
            this.lblApeArb.Size = new System.Drawing.Size(44, 13);
            this.lblApeArb.TabIndex = 33;
            this.lblApeArb.Text = "Apellido";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(451, 364);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(29, 13);
            this.lblPais.TabIndex = 35;
            this.lblPais.Text = "País";
            // 
            // lblTipoDocMod
            // 
            this.lblTipoDocMod.AutoSize = true;
            this.lblTipoDocMod.Location = new System.Drawing.Point(211, 410);
            this.lblTipoDocMod.Name = "lblTipoDocMod";
            this.lblTipoDocMod.Size = new System.Drawing.Size(51, 13);
            this.lblTipoDocMod.TabIndex = 40;
            this.lblTipoDocMod.Text = "Tipo Doc";
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Location = new System.Drawing.Point(333, 427);
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(114, 20);
            this.txtNumDoc.TabIndex = 42;
            // 
            // lblNumDocMod
            // 
            this.lblNumDocMod.AutoSize = true;
            this.lblNumDocMod.Location = new System.Drawing.Point(330, 410);
            this.lblNumDocMod.Name = "lblNumDocMod";
            this.lblNumDocMod.Size = new System.Drawing.Size(45, 13);
            this.lblNumDocMod.TabIndex = 41;
            this.lblNumDocMod.Text = "N° Doc:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(463, 427);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 43;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(544, 427);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 44;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelarRest
            // 
            this.btnCancelarRest.Location = new System.Drawing.Point(388, 396);
            this.btnCancelarRest.Name = "btnCancelarRest";
            this.btnCancelarRest.Size = new System.Drawing.Size(150, 25);
            this.btnCancelarRest.TabIndex = 45;
            this.btnCancelarRest.Text = "Cancelar";
            this.btnCancelarRest.UseVisualStyleBackColor = true;
            this.btnCancelarRest.Click += new System.EventHandler(this.btnCancelarRest_Click);
            // 
            // btnRestaurarSeleccion
            // 
            this.btnRestaurarSeleccion.Location = new System.Drawing.Point(544, 398);
            this.btnRestaurarSeleccion.Name = "btnRestaurarSeleccion";
            this.btnRestaurarSeleccion.Size = new System.Drawing.Size(150, 25);
            this.btnRestaurarSeleccion.TabIndex = 46;
            this.btnRestaurarSeleccion.Text = "Restaurar";
            this.btnRestaurarSeleccion.UseVisualStyleBackColor = true;
            this.btnRestaurarSeleccion.Click += new System.EventHandler(this.btnRestaurarSeleccion_Click);
            // 
            // cmbPaisMod
            // 
            this.cmbPaisMod.FormattingEnabled = true;
            this.cmbPaisMod.Location = new System.Drawing.Point(454, 381);
            this.cmbPaisMod.Name = "cmbPaisMod";
            this.cmbPaisMod.Size = new System.Drawing.Size(121, 21);
            this.cmbPaisMod.TabIndex = 48;
            this.cmbPaisMod.SelectionChangeCommitted += new System.EventHandler(this.cmbPaisMod_SelectionChangeCommitted);
            // 
            // cmbPaisFiltro
            // 
            this.cmbPaisFiltro.FormattingEnabled = true;
            this.cmbPaisFiltro.Location = new System.Drawing.Point(359, 83);
            this.cmbPaisFiltro.Name = "cmbPaisFiltro";
            this.cmbPaisFiltro.Size = new System.Drawing.Size(121, 21);
            this.cmbPaisFiltro.TabIndex = 50;
            // 
            // lblPaisFiltro
            // 
            this.lblPaisFiltro.AutoSize = true;
            this.lblPaisFiltro.Location = new System.Drawing.Point(356, 66);
            this.lblPaisFiltro.Name = "lblPaisFiltro";
            this.lblPaisFiltro.Size = new System.Drawing.Size(29, 13);
            this.lblPaisFiltro.TabIndex = 49;
            this.lblPaisFiltro.Text = "País";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(25, 188);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(150, 32);
            this.btnModificar.TabIndex = 51;
            this.btnModificar.Text = "Modificar Arbitro";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblNombreFiltro
            // 
            this.lblNombreFiltro.AutoSize = true;
            this.lblNombreFiltro.Location = new System.Drawing.Point(211, 66);
            this.lblNombreFiltro.Name = "lblNombreFiltro";
            this.lblNombreFiltro.Size = new System.Drawing.Size(44, 13);
            this.lblNombreFiltro.TabIndex = 52;
            this.lblNombreFiltro.Text = "Nombre";
            // 
            // txtNombreFiltro
            // 
            this.txtNombreFiltro.Location = new System.Drawing.Point(214, 83);
            this.txtNombreFiltro.Name = "txtNombreFiltro";
            this.txtNombreFiltro.Size = new System.Drawing.Size(100, 20);
            this.txtNombreFiltro.TabIndex = 53;
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(214, 426);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(100, 21);
            this.cmbTipoDoc.TabIndex = 54;
            // 
            // ABMCArbForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.cmbTipoDoc);
            this.Controls.Add(this.txtNombreFiltro);
            this.Controls.Add(this.lblNombreFiltro);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.cmbPaisFiltro);
            this.Controls.Add(this.lblPaisFiltro);
            this.Controls.Add(this.cmbPaisMod);
            this.Controls.Add(this.btnRestaurarSeleccion);
            this.Controls.Add(this.btnCancelarRest);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNumDoc);
            this.Controls.Add(this.lblNumDocMod);
            this.Controls.Add(this.lblTipoDocMod);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.txtApeArb);
            this.Controls.Add(this.lblApeArb);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNomArb);
            this.Controls.Add(this.dGridArb);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.btnVolverMenu);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblGestArb);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ABMCArbForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionar Arbitros";
            this.Load += new System.EventHandler(this.ABMCArbForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridArb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblGestArb;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolverMenu;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.DataGridView dGridArb;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreArb;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoArb;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaísArb;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocArb;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDocArb;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNomArb;
        private System.Windows.Forms.TextBox txtApeArb;
        private System.Windows.Forms.Label lblApeArb;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblTipoDocMod;
        private System.Windows.Forms.TextBox txtNumDoc;
        private System.Windows.Forms.Label lblNumDocMod;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelarRest;
        private System.Windows.Forms.Button btnRestaurarSeleccion;
        private System.Windows.Forms.ComboBox cmbPaisMod;
        private System.Windows.Forms.ComboBox cmbPaisFiltro;
        private System.Windows.Forms.Label lblPaisFiltro;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblNombreFiltro;
        private System.Windows.Forms.TextBox txtNombreFiltro;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
    }
}