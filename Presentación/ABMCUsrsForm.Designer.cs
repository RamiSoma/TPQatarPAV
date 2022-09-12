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
            this.IDUsr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NmbreUsr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PswdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbBoxPrfls = new System.Windows.Forms.ComboBox();
            this.lblIdUsr = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnVolverMenu = new System.Windows.Forms.Button();
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
            this.IDUsr,
            this.NmbreUsr,
            this.rolUsuario,
            this.PswdCol});
            this.dGridUsrs.Location = new System.Drawing.Point(260, 102);
            this.dGridUsrs.Name = "dGridUsrs";
            this.dGridUsrs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridUsrs.Size = new System.Drawing.Size(345, 290);
            this.dGridUsrs.TabIndex = 13;
            this.dGridUsrs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // IDUsr
            // 
            this.IDUsr.HeaderText = "Id Usuario";
            this.IDUsr.Name = "IDUsr";
            // 
            // NmbreUsr
            // 
            this.NmbreUsr.HeaderText = "Nombre Usuario";
            this.NmbreUsr.Name = "NmbreUsr";
            // 
            // rolUsuario
            // 
            this.rolUsuario.HeaderText = "Rol Usuario";
            this.rolUsuario.Name = "rolUsuario";
            // 
            // PswdCol
            // 
            this.PswdCol.HeaderText = "Contraseña";
            this.PswdCol.Name = "PswdCol";
            this.PswdCol.Visible = false;
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
            // ABMCUsrsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn IDUsr;
        private System.Windows.Forms.DataGridViewTextBoxColumn NmbreUsr;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn PswdCol;
        private System.Windows.Forms.Label lblIdUsr;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnVolverMenu;
    }
}