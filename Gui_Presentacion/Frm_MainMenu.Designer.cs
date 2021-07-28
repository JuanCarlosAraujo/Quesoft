namespace Gui_Presentacion
{
    partial class Frm_MainMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MainMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAlmacen = new System.Windows.Forms.Label();
            this.pictureAlmacen = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelGestion = new System.Windows.Forms.Label();
            this.pictureBoxProductos = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelAgentes = new System.Windows.Forms.Label();
            this.pictureBoxAgentes = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelFinanzas = new System.Windows.Forms.Label();
            this.pictureBoxFinanzas = new System.Windows.Forms.PictureBox();
            this.labelWelcome2 = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.welcome = new System.Windows.Forms.Label();
            this.BtnMainMenu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAlmacen)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductos)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAgentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFinanzas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.labelAlmacen);
            this.panel1.Controls.Add(this.pictureAlmacen);
            this.panel1.Location = new System.Drawing.Point(1, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 291);
            this.panel1.TabIndex = 2;
            // 
            // labelAlmacen
            // 
            this.labelAlmacen.AutoSize = true;
            this.labelAlmacen.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlmacen.ForeColor = System.Drawing.Color.White;
            this.labelAlmacen.Location = new System.Drawing.Point(63, 20);
            this.labelAlmacen.Name = "labelAlmacen";
            this.labelAlmacen.Size = new System.Drawing.Size(71, 16);
            this.labelAlmacen.TabIndex = 1;
            this.labelAlmacen.Text = "Inventario";
            // 
            // pictureAlmacen
            // 
            this.pictureAlmacen.BackgroundImage = global::Gui_Presentacion.Properties.Resources.degradado_en_negro_borde_inferior_1;
            this.pictureAlmacen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureAlmacen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureAlmacen.Image = global::Gui_Presentacion.Properties.Resources.Almacenad;
            this.pictureAlmacen.Location = new System.Drawing.Point(0, 1);
            this.pictureAlmacen.Name = "pictureAlmacen";
            this.pictureAlmacen.Size = new System.Drawing.Size(209, 291);
            this.pictureAlmacen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureAlmacen.TabIndex = 0;
            this.pictureAlmacen.TabStop = false;
            this.pictureAlmacen.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OliveDrab;
            this.panel2.Controls.Add(this.labelGestion);
            this.panel2.Controls.Add(this.pictureBoxProductos);
            this.panel2.Location = new System.Drawing.Point(201, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 291);
            this.panel2.TabIndex = 3;
            // 
            // labelGestion
            // 
            this.labelGestion.AutoSize = true;
            this.labelGestion.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGestion.ForeColor = System.Drawing.Color.White;
            this.labelGestion.Location = new System.Drawing.Point(44, 20);
            this.labelGestion.Name = "labelGestion";
            this.labelGestion.Size = new System.Drawing.Size(124, 16);
            this.labelGestion.TabIndex = 2;
            this.labelGestion.Text = "Registrar Compras";
            // 
            // pictureBoxProductos
            // 
            this.pictureBoxProductos.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxProductos.BackgroundImage = global::Gui_Presentacion.Properties.Resources.degradado_en_negro_borde_inferior_1;
            this.pictureBoxProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxProductos.Image = global::Gui_Presentacion.Properties.Resources._52b6db816135381e779c23e360de15de1;
            this.pictureBoxProductos.Location = new System.Drawing.Point(-1, -18);
            this.pictureBoxProductos.Name = "pictureBoxProductos";
            this.pictureBoxProductos.Size = new System.Drawing.Size(215, 312);
            this.pictureBoxProductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxProductos.TabIndex = 2;
            this.pictureBoxProductos.TabStop = false;
            this.pictureBoxProductos.Click += new System.EventHandler(this.pictureBoxProductos_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Indigo;
            this.panel3.Controls.Add(this.labelAgentes);
            this.panel3.Controls.Add(this.pictureBoxAgentes);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(401, 158);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 291);
            this.panel3.TabIndex = 3;
            // 
            // labelAgentes
            // 
            this.labelAgentes.AutoSize = true;
            this.labelAgentes.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgentes.ForeColor = System.Drawing.Color.White;
            this.labelAgentes.Location = new System.Drawing.Point(26, 21);
            this.labelAgentes.Name = "labelAgentes";
            this.labelAgentes.Size = new System.Drawing.Size(146, 16);
            this.labelAgentes.TabIndex = 3;
            this.labelAgentes.Text = "Proveedores y Deudas";
            this.labelAgentes.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBoxAgentes
            // 
            this.pictureBoxAgentes.BackgroundImage = global::Gui_Presentacion.Properties.Resources.degradado_en_negro_borde_inferior_1;
            this.pictureBoxAgentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAgentes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAgentes.Image = global::Gui_Presentacion.Properties.Resources.unnamed__w_;
            this.pictureBoxAgentes.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAgentes.Name = "pictureBoxAgentes";
            this.pictureBoxAgentes.Size = new System.Drawing.Size(200, 291);
            this.pictureBoxAgentes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxAgentes.TabIndex = 1;
            this.pictureBoxAgentes.TabStop = false;
            this.pictureBoxAgentes.Click += new System.EventHandler(this.pictureBoxAgentes_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 290);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel4.Controls.Add(this.labelFinanzas);
            this.panel4.Controls.Add(this.pictureBoxFinanzas);
            this.panel4.Location = new System.Drawing.Point(601, 158);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 291);
            this.panel4.TabIndex = 4;
            // 
            // labelFinanzas
            // 
            this.labelFinanzas.AutoSize = true;
            this.labelFinanzas.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinanzas.ForeColor = System.Drawing.Color.White;
            this.labelFinanzas.Location = new System.Drawing.Point(67, 20);
            this.labelFinanzas.Name = "labelFinanzas";
            this.labelFinanzas.Size = new System.Drawing.Size(63, 16);
            this.labelFinanzas.TabIndex = 4;
            this.labelFinanzas.Text = "Finanzas";
            // 
            // pictureBoxFinanzas
            // 
            this.pictureBoxFinanzas.BackgroundImage = global::Gui_Presentacion.Properties.Resources.degradado_en_negro_borde_inferior_1;
            this.pictureBoxFinanzas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxFinanzas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxFinanzas.Image = global::Gui_Presentacion.Properties.Resources._1667808;
            this.pictureBoxFinanzas.Location = new System.Drawing.Point(0, -21);
            this.pictureBoxFinanzas.Name = "pictureBoxFinanzas";
            this.pictureBoxFinanzas.Size = new System.Drawing.Size(200, 312);
            this.pictureBoxFinanzas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxFinanzas.TabIndex = 0;
            this.pictureBoxFinanzas.TabStop = false;
            this.pictureBoxFinanzas.Click += new System.EventHandler(this.pictureBoxFinanzas_Click);
            // 
            // labelWelcome2
            // 
            this.labelWelcome2.AutoSize = true;
            this.labelWelcome2.Font = new System.Drawing.Font("Geometr212 BkCn BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelWelcome2.Location = new System.Drawing.Point(30, 96);
            this.labelWelcome2.Name = "labelWelcome2";
            this.labelWelcome2.Size = new System.Drawing.Size(352, 16);
            this.labelWelcome2.TabIndex = 1;
            this.labelWelcome2.Text = "Gestiona de una manera facil e interactiva tu empresa.";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = global::Gui_Presentacion.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(601, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(189, 195);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLogo.TabIndex = 5;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(-1, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(802, 450);
            this.panelMain.TabIndex = 6;
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Geometr415 Blk BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.welcome.Location = new System.Drawing.Point(27, 40);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(191, 35);
            this.welcome.TabIndex = 7;
            this.welcome.Text = "BIENVENIDO";
            // 
            // BtnMainMenu
            // 
            this.BtnMainMenu.BackColor = System.Drawing.Color.DimGray;
            this.BtnMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMainMenu.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.BtnMainMenu.FlatAppearance.BorderSize = 0;
            this.BtnMainMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.BtnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMainMenu.Font = new System.Drawing.Font("Geometr415 Blk BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMainMenu.ForeColor = System.Drawing.Color.Maroon;
            this.BtnMainMenu.Location = new System.Drawing.Point(-1, -3);
            this.BtnMainMenu.Name = "BtnMainMenu";
            this.BtnMainMenu.Size = new System.Drawing.Size(89, 68);
            this.BtnMainMenu.TabIndex = 8;
            this.BtnMainMenu.Text = "(←)";
            this.BtnMainMenu.UseVisualStyleBackColor = false;
            this.BtnMainMenu.Click += new System.EventHandler(this.BtnMainMenu_Click);
            // 
            // Frm_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.BtnMainMenu);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelWelcome2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.panelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 440);
            this.Name = "Frm_MainMenu";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAlmacen)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAgentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFinanzas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBoxProductos;
        private System.Windows.Forms.PictureBox pictureAlmacen;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBoxAgentes;
        private System.Windows.Forms.PictureBox pictureBoxFinanzas;
        private System.Windows.Forms.Label labelAlmacen;
        private System.Windows.Forms.Label labelGestion;
        private System.Windows.Forms.Label labelAgentes;
        private System.Windows.Forms.Label labelFinanzas;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelWelcome2;
        public System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Button BtnMainMenu;
    }
}

