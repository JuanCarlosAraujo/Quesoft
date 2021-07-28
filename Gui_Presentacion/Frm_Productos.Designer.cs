namespace Gui_Presentacion
{
    partial class Frm_Productos
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.LblGuardar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnGenerarFactura = new System.Windows.Forms.Button();
            this.CmbUnidad = new System.Windows.Forms.ComboBox();
            this.LabelIdentificacion = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.CmbProductos = new System.Windows.Forms.ComboBox();
            this.LblProductos = new System.Windows.Forms.Label();
            this.CmbTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OliveDrab;
            this.label2.Location = new System.Drawing.Point(353, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Facturas";
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button4.BackColor = System.Drawing.Color.MidnightBlue;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(554, 426);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Finanzas";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.Indigo;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(399, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Proveedores y Deuda";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button5.BackColor = System.Drawing.Color.OliveDrab;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(244, 409);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(155, 40);
            this.button5.TabIndex = 19;
            this.button5.Text = "Registrar Compras";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button6.BackColor = System.Drawing.Color.Goldenrod;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(89, 426);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(155, 23);
            this.button6.TabIndex = 20;
            this.button6.Text = "Almacen";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreo.ForeColor = System.Drawing.Color.OliveDrab;
            this.labelCorreo.Location = new System.Drawing.Point(421, 172);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(49, 16);
            this.labelCorreo.TabIndex = 57;
            this.labelCorreo.Text = "Correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.Enabled = false;
            this.txtCorreo.Location = new System.Drawing.Point(424, 191);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(337, 20);
            this.txtCorreo.TabIndex = 56;
            // 
            // LblGuardar
            // 
            this.LblGuardar.AutoSize = true;
            this.LblGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGuardar.ForeColor = System.Drawing.Color.DarkRed;
            this.LblGuardar.Location = new System.Drawing.Point(421, 296);
            this.LblGuardar.Name = "LblGuardar";
            this.LblGuardar.Size = new System.Drawing.Size(126, 13);
            this.LblGuardar.TabIndex = 54;
            this.LblGuardar.Text = "Guardado Correctamente";
            this.LblGuardar.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(371, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 53;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.OliveDrab;
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrchid;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGuardar.Location = new System.Drawing.Point(424, 266);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(156, 27);
            this.BtnGuardar.TabIndex = 52;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            // 
            // BtnGenerarFactura
            // 
            this.BtnGenerarFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGenerarFactura.BackColor = System.Drawing.Color.OliveDrab;
            this.BtnGenerarFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGenerarFactura.FlatAppearance.BorderSize = 0;
            this.BtnGenerarFactura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrchid;
            this.BtnGenerarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGenerarFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerarFactura.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGenerarFactura.Location = new System.Drawing.Point(424, 313);
            this.BtnGenerarFactura.Name = "BtnGenerarFactura";
            this.BtnGenerarFactura.Size = new System.Drawing.Size(156, 27);
            this.BtnGenerarFactura.TabIndex = 51;
            this.BtnGenerarFactura.Text = "Agregar Productos";
            this.BtnGenerarFactura.UseVisualStyleBackColor = false;
            // 
            // CmbUnidad
            // 
            this.CmbUnidad.FormattingEnabled = true;
            this.CmbUnidad.Items.AddRange(new object[] {
            "Kilogramos",
            "Libras"});
            this.CmbUnidad.Location = new System.Drawing.Point(114, 232);
            this.CmbUnidad.Name = "CmbUnidad";
            this.CmbUnidad.Size = new System.Drawing.Size(263, 21);
            this.CmbUnidad.TabIndex = 50;
            // 
            // LabelIdentificacion
            // 
            this.LabelIdentificacion.AutoSize = true;
            this.LabelIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIdentificacion.ForeColor = System.Drawing.Color.OliveDrab;
            this.LabelIdentificacion.Location = new System.Drawing.Point(421, 130);
            this.LabelIdentificacion.Name = "LabelIdentificacion";
            this.LabelIdentificacion.Size = new System.Drawing.Size(86, 16);
            this.LabelIdentificacion.TabIndex = 49;
            this.LabelIdentificacion.Text = "Identificacion";
            // 
            // TxtId
            // 
            this.TxtId.BackColor = System.Drawing.Color.White;
            this.TxtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtId.Location = new System.Drawing.Point(424, 149);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(337, 20);
            this.TxtId.TabIndex = 48;
            // 
            // CmbProductos
            // 
            this.CmbProductos.FormattingEnabled = true;
            this.CmbProductos.Location = new System.Drawing.Point(65, 191);
            this.CmbProductos.Name = "CmbProductos";
            this.CmbProductos.Size = new System.Drawing.Size(312, 21);
            this.CmbProductos.TabIndex = 47;
            // 
            // LblProductos
            // 
            this.LblProductos.AutoSize = true;
            this.LblProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProductos.ForeColor = System.Drawing.Color.OliveDrab;
            this.LblProductos.Location = new System.Drawing.Point(62, 172);
            this.LblProductos.Name = "LblProductos";
            this.LblProductos.Size = new System.Drawing.Size(69, 16);
            this.LblProductos.TabIndex = 46;
            this.LblProductos.Text = "Productos";
            // 
            // CmbTipo
            // 
            this.CmbTipo.FormattingEnabled = true;
            this.CmbTipo.Items.AddRange(new object[] {
            "Proveedor",
            "Deudor"});
            this.CmbTipo.Location = new System.Drawing.Point(65, 148);
            this.CmbTipo.Name = "CmbTipo";
            this.CmbTipo.Size = new System.Drawing.Size(312, 21);
            this.CmbTipo.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(62, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "Tipo";
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.ForeColor = System.Drawing.Color.OliveDrab;
            this.LblCantidad.Location = new System.Drawing.Point(62, 215);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(62, 16);
            this.LblCantidad.TabIndex = 43;
            this.LblCantidad.Text = "Cantidad";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(65, 233);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(43, 20);
            this.TxtCantidad.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OliveDrab;
            this.label3.Location = new System.Drawing.Point(421, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "Apellidos";
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(424, 107);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(337, 20);
            this.TxtApellido.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OliveDrab;
            this.label5.Location = new System.Drawing.Point(63, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "Nombres";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(65, 107);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(312, 20);
            this.TxtNombre.TabIndex = 38;
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(65, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(311, 74);
            this.dataGridView1.TabIndex = 58;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.OliveDrab;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrchid;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(605, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 27);
            this.button2.TabIndex = 59;
            this.button2.Text = "Eliminar Productos";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.OliveDrab;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrchid;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(605, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 27);
            this.button3.TabIndex = 60;
            this.button3.Text = "Verificar Identificacion";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Frm_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelCorreo);
            this.Controls.Add(this.txtCorreo);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Productos";
            this.Text = "Frm_Productos";
            this.Load += new System.EventHandler(this.Frm_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label LblGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnGenerarFactura;
        private System.Windows.Forms.ComboBox CmbUnidad;
        private System.Windows.Forms.Label LabelIdentificacion;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.ComboBox CmbProductos;
        private System.Windows.Forms.Label LblProductos;
        private System.Windows.Forms.ComboBox CmbTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}