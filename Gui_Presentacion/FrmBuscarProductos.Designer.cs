namespace Gui_Presentacion
{
    partial class FrmBuscarProductos
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
            this.DgvConsultarProducto = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.CmbTipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsultarProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvConsultarProducto
            // 
            this.DgvConsultarProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvConsultarProducto.Location = new System.Drawing.Point(12, 12);
            this.DgvConsultarProducto.Name = "DgvConsultarProducto";
            this.DgvConsultarProducto.Size = new System.Drawing.Size(573, 236);
            this.DgvConsultarProducto.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Geometr212 BkCn BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(592, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 80;
            this.label2.Text = "Buscar Por:";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Goldenrod;
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrchid;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Geometr212 BkCn BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGuardar.Location = new System.Drawing.Point(595, 99);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(117, 27);
            this.BtnGuardar.TabIndex = 79;
            this.BtnGuardar.Text = "Buscar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            // 
            // CmbTipo
            // 
            this.CmbTipo.FormattingEnabled = true;
            this.CmbTipo.Items.AddRange(new object[] {
            "Proveedor",
            "Deudor"});
            this.CmbTipo.Location = new System.Drawing.Point(594, 31);
            this.CmbTipo.Name = "CmbTipo";
            this.CmbTipo.Size = new System.Drawing.Size(118, 21);
            this.CmbTipo.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Geometr212 BkCn BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(591, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 74;
            this.label3.Text = "Buscar";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(594, 73);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(118, 20);
            this.TxtNombre.TabIndex = 73;
            // 
            // FrmBuscarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(724, 260);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.CmbTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.DgvConsultarProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBuscarProductos";
            this.Text = "FrmBuscarProductos";
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsultarProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvConsultarProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.ComboBox CmbTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNombre;
    }
}