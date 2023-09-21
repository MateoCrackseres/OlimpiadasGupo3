namespace EmergencyButtonBC
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblemergencia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStart.BackgroundImage")));
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.btnStart.FlatAppearance.BorderSize = 6;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStart.Location = new System.Drawing.Point(162, 153);
            this.btnStart.Name = "btnStart";
            this.btnStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStart.Size = new System.Drawing.Size(361, 355);
            this.btnStart.TabIndex = 4;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            this.btnStart.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.btnStart.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // lblemergencia
            // 
            this.lblemergencia.AutoSize = true;
            this.lblemergencia.BackColor = System.Drawing.Color.Crimson;
            this.lblemergencia.Font = new System.Drawing.Font("Microsoft YaHei", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemergencia.ForeColor = System.Drawing.Color.Snow;
            this.lblemergencia.Location = new System.Drawing.Point(-8, 38);
            this.lblemergencia.Name = "lblemergencia";
            this.lblemergencia.Size = new System.Drawing.Size(708, 128);
            this.lblemergencia.TabIndex = 5;
            this.lblemergencia.Text = "EMERGENCIA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Crimson;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(-93, -177);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 10, 10, 100);
            this.label1.Size = new System.Drawing.Size(1063, 238);
            this.label1.TabIndex = 6;
            this.label1.Text = "_______________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Crimson;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(-191, 546);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 10, 10, 100);
            this.label2.Size = new System.Drawing.Size(1063, 238);
            this.label2.TabIndex = 7;
            this.label2.Text = "_______________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(619, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 516);
            this.label4.TabIndex = 9;
            this.label4.Text = "||\r\n||\r\n||\r\n||\r\n||\r\n||";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(-10, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 516);
            this.label5.TabIndex = 10;
            this.label5.Text = "||\r\n||\r\n||\r\n||\r\n||\r\n||";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStop.BackgroundImage")));
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Enabled = false;
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.btnStop.FlatAppearance.BorderSize = 6;
            this.btnStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStop.Location = new System.Drawing.Point(162, 153);
            this.btnStop.Name = "btnStop";
            this.btnStop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStop.Size = new System.Drawing.Size(361, 355);
            this.btnStop.TabIndex = 11;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            this.btnStop.MouseEnter += new System.EventHandler(this.btnStop_MouseEnter);
            this.btnStop.MouseLeave += new System.EventHandler(this.btnStop_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Crimson;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(-44, 491);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(200, 0, 200, 0);
            this.label6.Size = new System.Drawing.Size(797, 128);
            this.label6.TabIndex = 12;
            this.label6.Text = "SALA 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblemergencia);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnStop);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Sala 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblemergencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label6;
    }
}

