namespace Gui_Presentacion
{
    partial class FrmAlmacen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlmacen));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnMostrarProductos = new System.Windows.Forms.Button();
            this.BtnAgregarProductos = new System.Windows.Forms.Button();
            this.BtnCalcularVentas = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Geometr212 BkCn BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(364, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Almacén";
            // 
            // BtnMostrarProductos
            // 
            this.BtnMostrarProductos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnMostrarProductos.BackColor = System.Drawing.Color.Goldenrod;
            this.BtnMostrarProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMostrarProductos.FlatAppearance.BorderSize = 0;
            this.BtnMostrarProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnMostrarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMostrarProductos.Font = new System.Drawing.Font("Geometr212 BkCn BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrarProductos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnMostrarProductos.Location = new System.Drawing.Point(216, 109);
            this.BtnMostrarProductos.Name = "BtnMostrarProductos";
            this.BtnMostrarProductos.Size = new System.Drawing.Size(137, 23);
            this.BtnMostrarProductos.TabIndex = 2;
            this.BtnMostrarProductos.Text = "Mostrar Productos";
            this.BtnMostrarProductos.UseVisualStyleBackColor = false;
            this.BtnMostrarProductos.Click += new System.EventHandler(this.BtnMostrarProductos_Click);
            // 
            // BtnAgregarProductos
            // 
            this.BtnAgregarProductos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnAgregarProductos.BackColor = System.Drawing.Color.Goldenrod;
            this.BtnAgregarProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregarProductos.FlatAppearance.BorderSize = 0;
            this.BtnAgregarProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnAgregarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarProductos.Font = new System.Drawing.Font("Geometr212 BkCn BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarProductos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAgregarProductos.Location = new System.Drawing.Point(353, 109);
            this.BtnAgregarProductos.Name = "BtnAgregarProductos";
            this.BtnAgregarProductos.Size = new System.Drawing.Size(115, 23);
            this.BtnAgregarProductos.TabIndex = 3;
            this.BtnAgregarProductos.Text = "Agregar Productos";
            this.BtnAgregarProductos.UseVisualStyleBackColor = false;
            this.BtnAgregarProductos.Click += new System.EventHandler(this.BtnAgregarProductos_Click);
            // 
            // BtnCalcularVentas
            // 
            this.BtnCalcularVentas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnCalcularVentas.BackColor = System.Drawing.Color.Goldenrod;
            this.BtnCalcularVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCalcularVentas.FlatAppearance.BorderSize = 0;
            this.BtnCalcularVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnCalcularVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalcularVentas.Font = new System.Drawing.Font("Geometr212 BkCn BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcularVentas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCalcularVentas.Location = new System.Drawing.Point(468, 109);
            this.BtnCalcularVentas.Name = "BtnCalcularVentas";
            this.BtnCalcularVentas.Size = new System.Drawing.Size(115, 23);
            this.BtnCalcularVentas.TabIndex = 4;
            this.BtnCalcularVentas.Text = "Calcular Ventas";
            this.BtnCalcularVentas.UseVisualStyleBackColor = false;
            this.BtnCalcularVentas.Click += new System.EventHandler(this.BtnCalcularVentas_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChildForm.BackColor = System.Drawing.Color.Gray;
            this.panelChildForm.Location = new System.Drawing.Point(39, 165);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(724, 260);
            this.panelChildForm.TabIndex = 5;
            // 
            // FrmAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.BtnCalcularVentas);
            this.Controls.Add(this.BtnAgregarProductos);
            this.Controls.Add(this.BtnMostrarProductos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(724, 260);
            this.Name = "FrmAlmacen";
            this.Text = "FrmAlmacen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnMostrarProductos;
        private System.Windows.Forms.Button BtnAgregarProductos;
        private System.Windows.Forms.Button BtnCalcularVentas;
        private System.Windows.Forms.Panel panelChildForm;
    }
}