namespace Gui_Presentacion
{
    partial class FormChildAgregarPersona
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
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbTipo = new System.Windows.Forms.ComboBox();
            this.LblProductos = new System.Windows.Forms.Label();
            this.CmbProductos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.CmbUnidad = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnGenerarFactura = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LblGuardar = new System.Windows.Forms.Label();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dtgvPersonas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(15, 62);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(118, 20);
            this.TxtNombre.TabIndex = 0;
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Geometr212 BkCn BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Geometr212 BkCn BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(136, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Apellidos";
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(139, 62);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(118, 20);
            this.TxtApellido.TabIndex = 11;
            this.TxtApellido.TextChanged += new System.EventHandler(this.TxtApellido_TextChanged);
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Geometr212 BkCn BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.ForeColor = System.Drawing.Color.Indigo;
            this.LblCantidad.Location = new System.Drawing.Point(136, 127);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(65, 16);
            this.LblCantidad.TabIndex = 14;
            this.LblCantidad.Text = "Cantidad";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(139, 145);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(43, 20);
            this.TxtCantidad.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Geometr212 BkCn BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tipo";
            // 
            // CmbTipo
            // 
            this.CmbTipo.FormattingEnabled = true;
            this.CmbTipo.Items.AddRange(new object[] {
            "Proveedor",
            "Deudor"});
            this.CmbTipo.Location = new System.Drawing.Point(15, 103);
            this.CmbTipo.Name = "CmbTipo";
            this.CmbTipo.Size = new System.Drawing.Size(118, 21);
            this.CmbTipo.TabIndex = 17;
            this.CmbTipo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // LblProductos
            // 
            this.LblProductos.AutoSize = true;
            this.LblProductos.Font = new System.Drawing.Font("Geometr212 BkCn BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProductos.ForeColor = System.Drawing.Color.Indigo;
            this.LblProductos.Location = new System.Drawing.Point(12, 127);
            this.LblProductos.Name = "LblProductos";
            this.LblProductos.Size = new System.Drawing.Size(71, 16);
            this.LblProductos.TabIndex = 19;
            this.LblProductos.Text = "Productos";
            this.LblProductos.Click += new System.EventHandler(this.label5_Click);
            // 
            // CmbProductos
            // 
            this.CmbProductos.FormattingEnabled = true;
            this.CmbProductos.Location = new System.Drawing.Point(15, 146);
            this.CmbProductos.Name = "CmbProductos";
            this.CmbProductos.Size = new System.Drawing.Size(118, 21);
            this.CmbProductos.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Geometr212 BkCn BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(136, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Identificacion";
            // 
            // TxtId
            // 
            this.TxtId.BackColor = System.Drawing.Color.Silver;
            this.TxtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(139, 104);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(118, 20);
            this.TxtId.TabIndex = 21;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Indigo;
            this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrchid;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Geometr212 BkCn BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAgregar.Location = new System.Drawing.Point(139, 172);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(117, 27);
            this.BtnAgregar.TabIndex = 23;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // CmbUnidad
            // 
            this.CmbUnidad.FormattingEnabled = true;
            this.CmbUnidad.Items.AddRange(new object[] {
            "Kilogramos",
            "Libras"});
            this.CmbUnidad.Location = new System.Drawing.Point(188, 145);
            this.CmbUnidad.Name = "CmbUnidad";
            this.CmbUnidad.Size = new System.Drawing.Size(68, 21);
            this.CmbUnidad.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Indigo;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrchid;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Geometr212 BkCn BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(597, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 27);
            this.button1.TabIndex = 26;
            this.button1.Text = "Terminar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnGenerarFactura
            // 
            this.BtnGenerarFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGenerarFactura.BackColor = System.Drawing.Color.Indigo;
            this.BtnGenerarFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGenerarFactura.FlatAppearance.BorderSize = 0;
            this.BtnGenerarFactura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrchid;
            this.BtnGenerarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGenerarFactura.Font = new System.Drawing.Font("Geometr212 BkCn BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerarFactura.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGenerarFactura.Location = new System.Drawing.Point(476, 206);
            this.BtnGenerarFactura.Name = "BtnGenerarFactura";
            this.BtnGenerarFactura.Size = new System.Drawing.Size(115, 27);
            this.BtnGenerarFactura.TabIndex = 27;
            this.BtnGenerarFactura.Text = "Agregar Productos";
            this.BtnGenerarFactura.UseVisualStyleBackColor = false;
            this.BtnGenerarFactura.Click += new System.EventHandler(this.BtnGenerarFactura_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Indigo;
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrchid;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Geometr212 BkCn BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGuardar.Location = new System.Drawing.Point(16, 173);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(117, 27);
            this.BtnGuardar.TabIndex = 29;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 30;
            // 
            // LblGuardar
            // 
            this.LblGuardar.AutoSize = true;
            this.LblGuardar.Font = new System.Drawing.Font("Geometr212 BkCn BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGuardar.ForeColor = System.Drawing.Color.DarkRed;
            this.LblGuardar.Location = new System.Drawing.Point(13, 212);
            this.LblGuardar.Name = "LblGuardar";
            this.LblGuardar.Size = new System.Drawing.Size(138, 14);
            this.LblGuardar.TabIndex = 31;
            this.LblGuardar.Text = "Guardado Correctamente";
            this.LblGuardar.Visible = false;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEdit.BackColor = System.Drawing.Color.Indigo;
            this.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEdit.FlatAppearance.BorderSize = 0;
            this.BtnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrchid;
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.Font = new System.Drawing.Font("Geometr212 BkCn BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEdit.Location = new System.Drawing.Point(538, 10);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(54, 27);
            this.BtnEdit.TabIndex = 33;
            this.BtnEdit.Text = "Editar";
            this.BtnEdit.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Indigo;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrchid;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Geometr212 BkCn BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(598, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(54, 27);
            this.button3.TabIndex = 32;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Indigo;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrchid;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Geometr212 BkCn BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(658, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 27);
            this.button2.TabIndex = 34;
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // dtgvPersonas
            // 
            this.dtgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPersonas.Location = new System.Drawing.Point(263, 50);
            this.dtgvPersonas.Name = "dtgvPersonas";
            this.dtgvPersonas.Size = new System.Drawing.Size(449, 150);
            this.dtgvPersonas.TabIndex = 35;
            // 
            // FormChildAgregarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(724, 260);
            this.Controls.Add(this.dtgvPersonas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.LblGuardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnGenerarFactura);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CmbUnidad);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.CmbProductos);
            this.Controls.Add(this.LblProductos);
            this.Controls.Add(this.CmbTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChildAgregarPersona";
            this.Text = "FormChildAgregarPersona";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbTipo;
        private System.Windows.Forms.Label LblProductos;
        private System.Windows.Forms.ComboBox CmbProductos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.ComboBox CmbUnidad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnGenerarFactura;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblGuardar;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dtgvPersonas;
    }
}