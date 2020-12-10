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
            this.LabelIdentificacion = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.CmbUnidad = new System.Windows.Forms.ComboBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LblGuardar = new System.Windows.Forms.Label();
            this.dtgvPersonas = new System.Windows.Forms.DataGridView();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.BtnGenerarFactura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(15, 31);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(121, 20);
            this.TxtNombre.TabIndex = 0;
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Geometr212 BkCn BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(12, 12);
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
            this.label1.Location = new System.Drawing.Point(139, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Apellidos";
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(142, 31);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(132, 20);
            this.TxtApellido.TabIndex = 11;
            this.TxtApellido.TextChanged += new System.EventHandler(this.TxtApellido_TextChanged);
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Geometr212 BkCn BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.ForeColor = System.Drawing.Color.Indigo;
            this.LblCantidad.Location = new System.Drawing.Point(12, 139);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(65, 16);
            this.LblCantidad.TabIndex = 14;
            this.LblCantidad.Text = "Cantidad";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(15, 157);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(43, 20);
            this.TxtCantidad.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Geometr212 BkCn BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(12, 54);
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
            this.CmbTipo.Location = new System.Drawing.Point(15, 72);
            this.CmbTipo.Name = "CmbTipo";
            this.CmbTipo.Size = new System.Drawing.Size(121, 21);
            this.CmbTipo.TabIndex = 17;
            this.CmbTipo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // LblProductos
            // 
            this.LblProductos.AutoSize = true;
            this.LblProductos.Font = new System.Drawing.Font("Geometr212 BkCn BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProductos.ForeColor = System.Drawing.Color.Indigo;
            this.LblProductos.Location = new System.Drawing.Point(12, 96);
            this.LblProductos.Name = "LblProductos";
            this.LblProductos.Size = new System.Drawing.Size(71, 16);
            this.LblProductos.TabIndex = 19;
            this.LblProductos.Text = "Productos";
            this.LblProductos.Click += new System.EventHandler(this.label5_Click);
            // 
            // CmbProductos
            // 
            this.CmbProductos.FormattingEnabled = true;
            this.CmbProductos.Location = new System.Drawing.Point(15, 115);
            this.CmbProductos.Name = "CmbProductos";
            this.CmbProductos.Size = new System.Drawing.Size(121, 21);
            this.CmbProductos.TabIndex = 20;
            // 
            // LabelIdentificacion
            // 
            this.LabelIdentificacion.AutoSize = true;
            this.LabelIdentificacion.Font = new System.Drawing.Font("Geometr212 BkCn BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIdentificacion.ForeColor = System.Drawing.Color.Indigo;
            this.LabelIdentificacion.Location = new System.Drawing.Point(139, 54);
            this.LabelIdentificacion.Name = "LabelIdentificacion";
            this.LabelIdentificacion.Size = new System.Drawing.Size(93, 16);
            this.LabelIdentificacion.TabIndex = 22;
            this.LabelIdentificacion.Text = "Identificacion";
            // 
            // TxtId
            // 
            this.TxtId.BackColor = System.Drawing.Color.White;
            this.TxtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtId.Location = new System.Drawing.Point(142, 73);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(132, 20);
            this.TxtId.TabIndex = 21;
            // 
            // CmbUnidad
            // 
            this.CmbUnidad.FormattingEnabled = true;
            this.CmbUnidad.Items.AddRange(new object[] {
            "Kilogramos",
            "Libras"});
            this.CmbUnidad.Location = new System.Drawing.Point(64, 156);
            this.CmbUnidad.Name = "CmbUnidad";
            this.CmbUnidad.Size = new System.Drawing.Size(68, 21);
            this.CmbUnidad.TabIndex = 25;
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
            this.BtnGuardar.Location = new System.Drawing.Point(142, 150);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(61, 27);
            this.BtnGuardar.TabIndex = 29;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 30;
            // 
            // LblGuardar
            // 
            this.LblGuardar.AutoSize = true;
            this.LblGuardar.Font = new System.Drawing.Font("Geometr212 BkCn BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGuardar.ForeColor = System.Drawing.Color.DarkRed;
            this.LblGuardar.Location = new System.Drawing.Point(136, 180);
            this.LblGuardar.Name = "LblGuardar";
            this.LblGuardar.Size = new System.Drawing.Size(138, 14);
            this.LblGuardar.TabIndex = 31;
            this.LblGuardar.Text = "Guardado Correctamente";
            this.LblGuardar.Visible = false;
            // 
            // dtgvPersonas
            // 
            this.dtgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPersonas.Location = new System.Drawing.Point(280, 12);
            this.dtgvPersonas.Name = "dtgvPersonas";
            this.dtgvPersonas.Size = new System.Drawing.Size(432, 236);
            this.dtgvPersonas.TabIndex = 35;
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Font = new System.Drawing.Font("Geometr212 BkCn BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreo.ForeColor = System.Drawing.Color.Indigo;
            this.labelCorreo.Location = new System.Drawing.Point(139, 96);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(48, 16);
            this.labelCorreo.TabIndex = 37;
            this.labelCorreo.Text = "Correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.Enabled = false;
            this.txtCorreo.Location = new System.Drawing.Point(142, 115);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(132, 20);
            this.txtCorreo.TabIndex = 36;
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
            this.BtnGenerarFactura.Location = new System.Drawing.Point(209, 150);
            this.BtnGenerarFactura.Name = "BtnGenerarFactura";
            this.BtnGenerarFactura.Size = new System.Drawing.Size(61, 27);
            this.BtnGenerarFactura.TabIndex = 27;
            this.BtnGenerarFactura.Text = "Agregar Productos";
            this.BtnGenerarFactura.UseVisualStyleBackColor = false;
            this.BtnGenerarFactura.Click += new System.EventHandler(this.BtnGenerarFactura_Click);
            // 
            // FormChildAgregarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(724, 260);
            this.Controls.Add(this.labelCorreo);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.dtgvPersonas);
            this.Controls.Add(this.LblGuardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnGenerarFactura);
            this.Controls.Add(this.CmbUnidad);
            this.Controls.Add(this.LabelIdentificacion);
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
        private System.Windows.Forms.Label LabelIdentificacion;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.ComboBox CmbUnidad;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblGuardar;
        private System.Windows.Forms.DataGridView dtgvPersonas;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button BtnGenerarFactura;
    }
}