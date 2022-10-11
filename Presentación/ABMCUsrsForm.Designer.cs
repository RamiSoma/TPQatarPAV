namespace TPQatarPAVI.Presentación
{
    partial class ABMCUsrsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABMCUsrsForm));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPswd = new System.Windows.Forms.Label();
            this.lblPrfl = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPswd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dGridUsrs = new System.Windows.Forms.DataGridView();
            this.colIDUsr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNmbreUsr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRolUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PswdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbBoxPrfls = new System.Windows.Forms.ComboBox();
            this.lblIdUsr = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.txtFiltroNombre = new System.Windows.Forms.TextBox();
            this.cmbFiltroPerfil = new System.Windows.Forms.ComboBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblMailFijo = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnRestaurarSeleccion = new System.Windows.Forms.Button();
            this.btnCancelarRest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGridUsrs)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(297, 378);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblPswd
            // 
            this.lblPswd.AutoSize = true;
            this.lblPswd.Location = new System.Drawing.Point(442, 378);
            this.lblPswd.Name = "lblPswd";
            this.lblPswd.Size = new System.Drawing.Size(61, 13);
            this.lblPswd.TabIndex = 1;
            this.lblPswd.Text = "Contraseña";
            // 
            // lblPrfl
            // 
            this.lblPrfl.AutoSize = true;
            this.lblPrfl.Location = new System.Drawing.Point(576, 378);
            this.lblPrfl.Name = "lblPrfl";
            this.lblPrfl.Size = new System.Drawing.Size(30, 13);
            this.lblPrfl.TabIndex = 2;
            this.lblPrfl.Text = "Perfil";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(297, 398);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(128, 20);
            this.txtUsuario.TabIndex = 8;
            // 
            // txtPswd
            // 
            this.txtPswd.Location = new System.Drawing.Point(442, 398);
            this.txtPswd.Name = "txtPswd";
            this.txtPswd.Size = new System.Drawing.Size(128, 20);
            this.txtPswd.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(304, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "GESTION DE USUARIOS";
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Location = new System.Drawing.Point(10, 168);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(150, 30);
            this.btnAgregarUsuario.TabIndex = 0;
            this.btnAgregarUsuario.Text = "Agregar Usuario";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.Location = new System.Drawing.Point(10, 217);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(150, 30);
            this.btnModificarUsuario.TabIndex = 1;
            this.btnModificarUsuario.Text = "Modificar Usuario";
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Location = new System.Drawing.Point(10, 268);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(150, 30);
            this.btnEliminarUsuario.TabIndex = 2;
            this.btnEliminarUsuario.Text = "Eliminar Usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(556, 505);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(447, 505);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button5_Click);
            // 
            // dGridUsrs
            // 
            this.dGridUsrs.AllowUserToAddRows = false;
            this.dGridUsrs.AllowUserToDeleteRows = false;
            this.dGridUsrs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGridUsrs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dGridUsrs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridUsrs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDUsr,
            this.colNmbreUsr,
            this.Apellido,
            this.colMail,
            this.colUsuario,
            this.colRolUsuario,
            this.PswdCol});
            this.dGridUsrs.Location = new System.Drawing.Point(179, 138);
            this.dGridUsrs.Name = "dGridUsrs";
            this.dGridUsrs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridUsrs.Size = new System.Drawing.Size(576, 237);
            this.dGridUsrs.TabIndex = 13;
            this.dGridUsrs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // colIDUsr
            // 
            this.colIDUsr.HeaderText = "Id";
            this.colIDUsr.MinimumWidth = 2;
            this.colIDUsr.Name = "colIDUsr";
            this.colIDUsr.Width = 25;
            // 
            // colNmbreUsr
            // 
            this.colNmbreUsr.HeaderText = "Nombre";
            this.colNmbreUsr.Name = "colNmbreUsr";
            this.colNmbreUsr.Width = 80;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.Width = 80;
            // 
            // colMail
            // 
            this.colMail.HeaderText = "Mail";
            this.colMail.Name = "colMail";
            this.colMail.Width = 170;
            // 
            // colUsuario
            // 
            this.colUsuario.HeaderText = "Usuario";
            this.colUsuario.Name = "colUsuario";
            // 
            // colRolUsuario
            // 
            this.colRolUsuario.HeaderText = "Rol";
            this.colRolUsuario.Name = "colRolUsuario";
            this.colRolUsuario.Width = 80;
            // 
            // PswdCol
            // 
            this.PswdCol.HeaderText = "Contraseña";
            this.PswdCol.Name = "PswdCol";
            this.PswdCol.Visible = false;
            this.PswdCol.Width = 80;
            // 
            // cmbBoxPrfls
            // 
            this.cmbBoxPrfls.FormattingEnabled = true;
            this.cmbBoxPrfls.Location = new System.Drawing.Point(576, 398);
            this.cmbBoxPrfls.Name = "cmbBoxPrfls";
            this.cmbBoxPrfls.Size = new System.Drawing.Size(128, 21);
            this.cmbBoxPrfls.TabIndex = 10;
            // 
            // lblIdUsr
            // 
            this.lblIdUsr.AutoSize = true;
            this.lblIdUsr.Location = new System.Drawing.Point(176, 378);
            this.lblIdUsr.Name = "lblIdUsr";
            this.lblIdUsr.Size = new System.Drawing.Size(75, 13);
            this.lblIdUsr.TabIndex = 15;
            this.lblIdUsr.Text = "Id del Usuario:";
            this.lblIdUsr.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(268, 378);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 16;
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.Location = new System.Drawing.Point(40, 500);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(150, 35);
            this.btnVolverMenu.TabIndex = 18;
            this.btnVolverMenu.Text = "Menu Principal";
            this.btnVolverMenu.UseVisualStyleBackColor = true;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // txtFiltroNombre
            // 
            this.txtFiltroNombre.Location = new System.Drawing.Point(205, 95);
            this.txtFiltroNombre.Name = "txtFiltroNombre";
            this.txtFiltroNombre.Size = new System.Drawing.Size(170, 20);
            this.txtFiltroNombre.TabIndex = 4;
            this.txtFiltroNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmbFiltroPerfil
            // 
            this.cmbFiltroPerfil.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbFiltroPerfil.FormattingEnabled = true;
            this.cmbFiltroPerfil.Location = new System.Drawing.Point(392, 95);
            this.cmbFiltroPerfil.Name = "cmbFiltroPerfil";
            this.cmbFiltroPerfil.Size = new System.Drawing.Size(86, 21);
            this.cmbFiltroPerfil.TabIndex = 5;
            this.cmbFiltroPerfil.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroPerfil_SelectedIndexChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(202, 75);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(117, 13);
            this.lblFiltro.TabIndex = 21;
            this.lblFiltro.Text = "Nombre, usuario o mail:";
            this.lblFiltro.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Location = new System.Drawing.Point(389, 75);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(30, 13);
            this.lblPerfil.TabIndex = 22;
            this.lblPerfil.Text = "Perfil";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(556, 95);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(51, 23);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(442, 451);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(128, 20);
            this.txtNombre.TabIndex = 12;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(442, 431);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(584, 451);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(120, 20);
            this.txtApellido.TabIndex = 13;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(587, 431);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 26;
            this.lblApellido.Text = "Apellido";
            // 
            // lblMailFijo
            // 
            this.lblMailFijo.AutoSize = true;
            this.lblMailFijo.Location = new System.Drawing.Point(176, 431);
            this.lblMailFijo.Name = "lblMailFijo";
            this.lblMailFijo.Size = new System.Drawing.Size(29, 13);
            this.lblMailFijo.TabIndex = 28;
            this.lblMailFijo.Text = "Mail:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(176, 454);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(0, 13);
            this.lblMail.TabIndex = 29;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(499, 95);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(51, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(179, 451);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(193, 20);
            this.txtMail.TabIndex = 11;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Location = new System.Drawing.Point(10, 320);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(150, 30);
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.Text = "Restaurar Usuarios";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnRestaurarSeleccion
            // 
            this.btnRestaurarSeleccion.Location = new System.Drawing.Point(605, 394);
            this.btnRestaurarSeleccion.Name = "btnRestaurarSeleccion";
            this.btnRestaurarSeleccion.Size = new System.Drawing.Size(150, 25);
            this.btnRestaurarSeleccion.TabIndex = 17;
            this.btnRestaurarSeleccion.Text = "Restaurar";
            this.btnRestaurarSeleccion.UseVisualStyleBackColor = true;
            this.btnRestaurarSeleccion.Click += new System.EventHandler(this.btnRestaurarSeleccion_Click);
            // 
            // btnCancelarRest
            // 
            this.btnCancelarRest.Location = new System.Drawing.Point(431, 395);
            this.btnCancelarRest.Name = "btnCancelarRest";
            this.btnCancelarRest.Size = new System.Drawing.Size(150, 25);
            this.btnCancelarRest.TabIndex = 16;
            this.btnCancelarRest.Text = "Cancelar";
            this.btnCancelarRest.UseVisualStyleBackColor = true;
            this.btnCancelarRest.Click += new System.EventHandler(this.btnCancelarRest_Click);
            // 
            // ABMCUsrsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnCancelarRest);
            this.Controls.Add(this.btnRestaurarSeleccion);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblMailFijo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.cmbFiltroPerfil);
            this.Controls.Add(this.txtFiltroNombre);
            this.Controls.Add(this.btnVolverMenu);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblIdUsr);
            this.Controls.Add(this.cmbBoxPrfls);
            this.Controls.Add(this.dGridUsrs);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnModificarUsuario);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPswd);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblPrfl);
            this.Controls.Add(this.lblPswd);
            this.Controls.Add(this.lblUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ABMCUsrsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gesionar Usuarios";
            this.Load += new System.EventHandler(this.ABMCUsrsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridUsrs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPswd;
        private System.Windows.Forms.Label lblPrfl;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPswd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dGridUsrs;
        private System.Windows.Forms.ComboBox cmbBoxPrfls;
        private System.Windows.Forms.Label lblIdUsr;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnVolverMenu;
        private System.Windows.Forms.TextBox txtFiltroNombre;
        private System.Windows.Forms.ComboBox cmbFiltroPerfil;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDUsr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNmbreUsr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRolUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn PswdCol;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblMailFijo;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnRestaurarSeleccion;
        private System.Windows.Forms.Button btnCancelarRest;
    }
}