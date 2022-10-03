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
            this.btnAgregarArb = new System.Windows.Forms.Button();
            this.btnEliminarArb = new System.Windows.Forms.Button();
            this.btnModificarArb = new System.Windows.Forms.Button();
            this.lblGestArb = new System.Windows.Forms.Label();
            this.lblFiltroIDArb = new System.Windows.Forms.Label();
            this.txtFiltroDoc = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.cmbFiltroTipoDoc = new System.Windows.Forms.ComboBox();
            this.lblTipoDocFiltro = new System.Windows.Forms.Label();
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelarRest = new System.Windows.Forms.Button();
            this.btnRestaurarSeleccion = new System.Windows.Forms.Button();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.cmbPaisMod = new System.Windows.Forms.ComboBox();
            this.cmbPaisFiltro = new System.Windows.Forms.ComboBox();
            this.lblPaisFiltro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGridArb)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarArb
            // 
            this.btnAgregarArb.Location = new System.Drawing.Point(25, 134);
            this.btnAgregarArb.Name = "btnAgregarArb";
            this.btnAgregarArb.Size = new System.Drawing.Size(150, 32);
            this.btnAgregarArb.TabIndex = 1;
            this.btnAgregarArb.Text = "Agregar Arbitro";
            this.btnAgregarArb.UseVisualStyleBackColor = true;
            // 
            // btnEliminarArb
            // 
            this.btnEliminarArb.Location = new System.Drawing.Point(25, 246);
            this.btnEliminarArb.Name = "btnEliminarArb";
            this.btnEliminarArb.Size = new System.Drawing.Size(150, 32);
            this.btnEliminarArb.TabIndex = 3;
            this.btnEliminarArb.Text = "Eliminar Arbitro";
            this.btnEliminarArb.UseVisualStyleBackColor = true;
            // 
            // btnModificarArb
            // 
            this.btnModificarArb.Location = new System.Drawing.Point(25, 192);
            this.btnModificarArb.Name = "btnModificarArb";
            this.btnModificarArb.Size = new System.Drawing.Size(150, 32);
            this.btnModificarArb.TabIndex = 4;
            this.btnModificarArb.Text = "Modificar Arbitro";
            this.btnModificarArb.UseVisualStyleBackColor = true;
            this.btnModificarArb.Click += new System.EventHandler(this.button3_Click);
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
            // lblFiltroIDArb
            // 
            this.lblFiltroIDArb.AutoSize = true;
            this.lblFiltroIDArb.Location = new System.Drawing.Point(362, 64);
            this.lblFiltroIDArb.Name = "lblFiltroIDArb";
            this.lblFiltroIDArb.Size = new System.Drawing.Size(45, 13);
            this.lblFiltroIDArb.TabIndex = 22;
            this.lblFiltroIDArb.Text = "N° Doc:";
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
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Location = new System.Drawing.Point(25, 297);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(150, 30);
            this.btnRestaurar.TabIndex = 27;
            this.btnRestaurar.Text = "Restaurar Arbitro";
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
            this.txtNombre.Location = new System.Drawing.Point(368, 384);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 32;
            // 
            // lblNomArb
            // 
            this.lblNomArb.AutoSize = true;
            this.lblNomArb.Location = new System.Drawing.Point(365, 368);
            this.lblNomArb.Name = "lblNomArb";
            this.lblNomArb.Size = new System.Drawing.Size(44, 13);
            this.lblNomArb.TabIndex = 31;
            this.lblNomArb.Text = "Nombre";
            // 
            // txtApeArb
            // 
            this.txtApeArb.Location = new System.Drawing.Point(487, 384);
            this.txtApeArb.Name = "txtApeArb";
            this.txtApeArb.Size = new System.Drawing.Size(100, 20);
            this.txtApeArb.TabIndex = 34;
            // 
            // lblApeArb
            // 
            this.lblApeArb.AutoSize = true;
            this.lblApeArb.Location = new System.Drawing.Point(485, 368);
            this.lblApeArb.Name = "lblApeArb";
            this.lblApeArb.Size = new System.Drawing.Size(44, 13);
            this.lblApeArb.TabIndex = 33;
            this.lblApeArb.Text = "Apellido";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Tipo Doc";
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Location = new System.Drawing.Point(487, 431);
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(114, 20);
            this.txtNumDoc.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "N° Doc:";
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
            // ABMCArbForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.cmbPaisFiltro);
            this.Controls.Add(this.lblPaisFiltro);
            this.Controls.Add(this.cmbPaisMod);
            this.Controls.Add(this.lblTipoDoc);
            this.Controls.Add(this.btnRestaurarSeleccion);
            this.Controls.Add(this.btnCancelarRest);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNumDoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.txtApeArb);
            this.Controls.Add(this.lblApeArb);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNomArb);
            this.Controls.Add(this.dGridArb);
            this.Controls.Add(this.lblTipoDocFiltro);
            this.Controls.Add(this.cmbFiltroTipoDoc);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.btnVolverMenu);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtFiltroDoc);
            this.Controls.Add(this.lblFiltroIDArb);
            this.Controls.Add(this.lblGestArb);
            this.Controls.Add(this.btnModificarArb);
            this.Controls.Add(this.btnEliminarArb);
            this.Controls.Add(this.btnAgregarArb);
            this.Name = "ABMCArbForm";
            this.Text = "ABMCArbForm";
            this.Load += new System.EventHandler(this.ABMCArbForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridArb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarArb;
        private System.Windows.Forms.Button btnEliminarArb;
        private System.Windows.Forms.Button btnModificarArb;
        private System.Windows.Forms.Label lblGestArb;
        private System.Windows.Forms.Label lblFiltroIDArb;
        private System.Windows.Forms.TextBox txtFiltroDoc;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolverMenu;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.ComboBox cmbFiltroTipoDoc;
        private System.Windows.Forms.Label lblTipoDocFiltro;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumDoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelarRest;
        private System.Windows.Forms.Button btnRestaurarSeleccion;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.ComboBox cmbPaisMod;
        private System.Windows.Forms.ComboBox cmbPaisFiltro;
        private System.Windows.Forms.Label lblPaisFiltro;
    }
}