namespace OlimpiadasVol2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAlarma = new System.Windows.Forms.Button();
            this.sliderButton1 = new OlimpiadasVol2.Controls.SliderButton();
            this.customComboBox2 = new OlimpiadasVol2.Controls.CustomComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-9, 96);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(350, 370);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(117, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Medical Emergency";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.txtTitulo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 100);
            this.panel1.TabIndex = 9;
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.SystemColors.Window;
            this.txtTitulo.Location = new System.Drawing.Point(123, 37);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(284, 29);
            this.txtTitulo.TabIndex = 0;
            this.txtTitulo.Text = "Medical No Emergency";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-9, -21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnAlarma
            // 
            this.btnAlarma.BackColor = System.Drawing.Color.Transparent;
            this.btnAlarma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlarma.BackgroundImage")));
            this.btnAlarma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlarma.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(66)))));
            this.btnAlarma.FlatAppearance.BorderSize = 0;
            this.btnAlarma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAlarma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAlarma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlarma.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlarma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlarma.Location = new System.Drawing.Point(570, 106);
            this.btnAlarma.Name = "btnAlarma";
            this.btnAlarma.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAlarma.Size = new System.Drawing.Size(339, 332);
            this.btnAlarma.TabIndex = 11;
            this.btnAlarma.UseVisualStyleBackColor = false;
            this.btnAlarma.Click += new System.EventHandler(this.button1_Click);
            // 
            // sliderButton1
            // 
            this.sliderButton1.Location = new System.Drawing.Point(299, 337);
            this.sliderButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.sliderButton1.Name = "sliderButton1";
            this.sliderButton1.OffBackColor = System.Drawing.Color.SteelBlue;
            this.sliderButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.sliderButton1.OnBackColor = System.Drawing.Color.Red;
            this.sliderButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.sliderButton1.Size = new System.Drawing.Size(265, 42);
            this.sliderButton1.TabIndex = 12;
            this.sliderButton1.UseVisualStyleBackColor = true;
            this.sliderButton1.CheckedChanged += new System.EventHandler(this.sliderButton1_CheckedChanged);
            // 
            // customComboBox2
            // 
            this.customComboBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.customComboBox2.BorderColor = System.Drawing.Color.Blue;
            this.customComboBox2.BorderSize = 1;
            this.customComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.customComboBox2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.customComboBox2.ForeColor = System.Drawing.Color.Black;
            this.customComboBox2.IconColor = System.Drawing.Color.Blue;
            this.customComboBox2.Items.AddRange(new object[] {
            "Guardia",
            "Sala 1",
            "Sala 2",
            "Sala 3"});
            this.customComboBox2.ListBackColor = System.Drawing.Color.White;
            this.customComboBox2.ListTextColor = System.Drawing.Color.Gray;
            this.customComboBox2.Location = new System.Drawing.Point(308, 212);
            this.customComboBox2.MinimumSize = new System.Drawing.Size(200, 30);
            this.customComboBox2.Name = "customComboBox2";
            this.customComboBox2.Padding = new System.Windows.Forms.Padding(1);
            this.customComboBox2.Size = new System.Drawing.Size(256, 49);
            this.customComboBox2.TabIndex = 15;
            this.customComboBox2.Texts = "Indica el Lugar :D";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(921, 455);
            this.Controls.Add(this.customComboBox2);
            this.Controls.Add(this.sliderButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnAlarma);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emergency Medical - Grupo 3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAlarma;
        private Controls.SliderButton sliderButton1;
        private Controls.CustomComboBox customComboBox2;
    }
}

