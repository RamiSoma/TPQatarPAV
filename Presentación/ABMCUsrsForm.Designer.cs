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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPswd = new System.Windows.Forms.Label();
            this.lblPrfl = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPswd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dGridUsrs = new System.Windows.Forms.DataGridView();
            this.cmbBoxPrfls = new System.Windows.Forms.ComboBox();
            this.lblIdUsr = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbBoxPerfilFiltro = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colIDUsr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNmbreUsr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRolUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PswdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGridUsrs)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(626, 136);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblPswd
            // 
            this.lblPswd.AutoSize = true;
            this.lblPswd.Location = new System.Drawing.Point(626, 191);
            this.lblPswd.Name = "lblPswd";
            this.lblPswd.Size = new System.Drawing.Size(61, 13);
            this.lblPswd.TabIndex = 1;
            this.lblPswd.Text = "Contraseña";
            // 
            // lblPrfl
            // 
            this.lblPrfl.AutoSize = true;
            this.lblPrfl.Location = new System.Drawing.Point(626, 261);
            this.lblPrfl.Name = "lblPrfl";
            this.lblPrfl.Size = new System.Drawing.Size(30, 13);
            this.lblPrfl.TabIndex = 2;
            this.lblPrfl.Text = "Perfil";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(626, 156);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(128, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtPswd
            // 
            this.txtPswd.Location = new System.Drawing.Point(626, 211);
            this.txtPswd.Name = "txtPswd";
            this.txtPswd.Size = new System.Drawing.Size(128, 20);
            this.txtPswd.TabIndex = 4;
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
            this.btnAgregarUsuario.Location = new System.Drawing.Point(54, 125);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(179, 32);
            this.btnAgregarUsuario.TabIndex = 7;
            this.btnAgregarUsuario.Text = "Agregar Usuario";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.Location = new System.Drawing.Point(54, 165);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(179, 35);
            this.btnModificarUsuario.TabIndex = 8;
            this.btnModificarUsuario.Text = "Modificar Usuario";
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Location = new System.Drawing.Point(54, 205);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(179, 31);
            this.btnEliminarUsuario.TabIndex = 9;
            this.btnEliminarUsuario.Text = "Eliminar Usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(626, 397);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(708, 396);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button5_Click);
            // 
            // dGridUsrs
            // 
            this.dGridUsrs.AllowUserToAddRows = false;
            this.dGridUsrs.AllowUserToDeleteRows = false;
            this.dGridUsrs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dGridUsrs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridUsrs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDUsr,
            this.colNmbreUsr,
            this.colApellido,
            this.colMail,
            this.colUsuario,
            this.colRolUsuario,
            this.PswdCol});
            this.dGridUsrs.Location = new System.Drawing.Point(239, 159);
            this.dGridUsrs.Name = "dGridUsrs";
            this.dGridUsrs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridUsrs.Size = new System.Drawing.Size(366, 227);
            this.dGridUsrs.TabIndex = 13;
            this.dGridUsrs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // cmbBoxPrfls
            // 
            this.cmbBoxPrfls.FormattingEnabled = true;
            this.cmbBoxPrfls.Location = new System.Drawing.Point(626, 281);
            this.cmbBoxPrfls.Name = "cmbBoxPrfls";
            this.cmbBoxPrfls.Size = new System.Drawing.Size(128, 21);
            this.cmbBoxPrfls.TabIndex = 14;
            // 
            // lblIdUsr
            // 
            this.lblIdUsr.AutoSize = true;
            this.lblIdUsr.Location = new System.Drawing.Point(626, 102);
            this.lblIdUsr.Name = "lblIdUsr";
            this.lblIdUsr.Size = new System.Drawing.Size(75, 13);
            this.lblIdUsr.TabIndex = 15;
            this.lblIdUsr.Text = "Id del Usuario:";
            this.lblIdUsr.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(719, 102);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 16;
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.Location = new System.Drawing.Point(54, 281);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(179, 31);
            this.btnVolverMenu.TabIndex = 17;
            this.btnVolverMenu.Text = "Menu Principal";
            this.btnVolverMenu.UseVisualStyleBackColor = true;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(260, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 18;
            // 
            // cmbBoxPerfilFiltro
            // 
            this.cmbBoxPerfilFiltro.FormattingEnabled = true;
            this.cmbBoxPerfilFiltro.Location = new System.Drawing.Point(447, 130);
            this.cmbBoxPerfilFiltro.Name = "cmbBoxPerfilFiltro";
            this.cmbBoxPerfilFiltro.Size = new System.Drawing.Size(86, 21);
            this.cmbBoxPerfilFiltro.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(554, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre, usuario o mail:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Perfil";
            // 
            // colIDUsr
            // 
            this.colIDUsr.HeaderText = "Id";
            this.colIDUsr.MinimumWidth = 2;
            this.colIDUsr.Name = "colIDUsr";
            this.colIDUsr.Width = 30;
            // 
            // colNmbreUsr
            // 
            this.colNmbreUsr.HeaderText = "Nombre";
            this.colNmbreUsr.Name = "colNmbreUsr";
            // 
            // colApellido
            // 
            this.colApellido.HeaderText = "Apellido";
            this.colApellido.Name = "colApellido";
            // 
            // colMail
            // 
            this.colMail.HeaderText = "Mail";
            this.colMail.Name = "colMail";
            this.colMail.Width = 200;
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
            // 
            // PswdCol
            // 
            this.PswdCol.HeaderText = "Contraseña";
            this.PswdCol.Name = "PswdCol";
            this.PswdCol.Visible = false;
            // 
            // ABMCUsrsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1177, 458);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbBoxPerfilFiltro);
            this.Controls.Add(this.textBox1);
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
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblPrfl);
            this.Controls.Add(this.lblPswd);
            this.Controls.Add(this.lblNombre);
            this.Name = "ABMCUsrsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionDeUsuario";
            this.Load += new System.EventHandler(this.ABMCUsrsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridUsrs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPswd;
        private System.Windows.Forms.Label lblPrfl;
        private System.Windows.Forms.TextBox txtNombre;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbBoxPerfilFiltro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDUsr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNmbreUsr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRolUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn PswdCol;
    }
}