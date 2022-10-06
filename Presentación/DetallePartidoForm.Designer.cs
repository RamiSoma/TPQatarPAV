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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dGridEventos = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblIdPart = new System.Windows.Forms.Label();
            this.lblMostrarId = new System.Windows.Forms.Label();
            this.col_Minuto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TipoDocJg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NroDocJug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGridEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDetallePartido
            // 
            this.lblDetallePartido.AutoSize = true;
            this.lblDetallePartido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetallePartido.Location = new System.Drawing.Point(278, 39);
            this.lblDetallePartido.Name = "lblDetallePartido";
            this.lblDetallePartido.Size = new System.Drawing.Size(207, 31);
            this.lblDetallePartido.TabIndex = 0;
            this.lblDetallePartido.Text = "Detalle Partido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Equipo Local";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Argentina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Alemania";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Equipo Visita";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ronda";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Grupo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Aca iría la fecha";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Arbitro";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Estadio";
            // 
            // dGridEventos
            // 
            this.dGridEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Minuto,
            this.col_TipoDocJg,
            this.col_NroDocJug,
            this.col_Evento});
            this.dGridEventos.Location = new System.Drawing.Point(316, 94);
            this.dGridEventos.Name = "dGridEventos";
            this.dGridEventos.Size = new System.Drawing.Size(437, 274);
            this.dGridEventos.TabIndex = 10;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(404, 391);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(150, 32);
            this.btnModificar.TabIndex = 63;
            this.btnModificar.Text = "Modificar Evento";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(718, 391);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(56, 32);
            this.btnEliminar.TabIndex = 62;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(245, 391);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(133, 32);
            this.btnAgregar.TabIndex = 61;
            this.btnAgregar.Text = "Agregar Evento";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblIdPart
            // 
            this.lblIdPart.AutoSize = true;
            this.lblIdPart.Location = new System.Drawing.Point(64, 70);
            this.lblIdPart.Name = "lblIdPart";
            this.lblIdPart.Size = new System.Drawing.Size(51, 13);
            this.lblIdPart.TabIndex = 64;
            this.lblIdPart.Text = "Id partido";
            this.lblIdPart.Click += new System.EventHandler(this.label10_Click);
            // 
            // lblMostrarId
            // 
            this.lblMostrarId.AutoSize = true;
            this.lblMostrarId.Location = new System.Drawing.Point(143, 70);
            this.lblMostrarId.Name = "lblMostrarId";
            this.lblMostrarId.Size = new System.Drawing.Size(80, 13);
            this.lblMostrarId.TabIndex = 65;
            this.lblMostrarId.Text = "Aca se muestra";
            // 
            // col_Minuto
            // 
            this.col_Minuto.HeaderText = "Minuto";
            this.col_Minuto.Name = "col_Minuto";
            // 
            // col_TipoDocJg
            // 
            this.col_TipoDocJg.HeaderText = "Tipo Doc Jug";
            this.col_TipoDocJg.Name = "col_TipoDocJg";
            // 
            // col_NroDocJug
            // 
            this.col_NroDocJug.HeaderText = "Nro Doc Jugador";
            this.col_NroDocJug.Name = "col_NroDocJug";
            // 
            // col_Evento
            // 
            this.col_Evento.HeaderText = "Evento";
            this.col_Evento.Name = "col_Evento";
            // 
            // DetallePartidoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMostrarId);
            this.Controls.Add(this.lblIdPart);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dGridEventos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDetallePartido);
            this.Name = "DetallePartidoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaDetallePartido";
            this.Load += new System.EventHandler(this.DetallePartidoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridEventos)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dGridEventos;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblIdPart;
        private System.Windows.Forms.Label lblMostrarId;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Minuto;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TipoDocJg;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NroDocJug;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Evento;
    }
}