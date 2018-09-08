namespace RoverCamController
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.Up1 = new System.Windows.Forms.Button();
            this.Right1 = new System.Windows.Forms.Button();
            this.Down1 = new System.Windows.Forms.Button();
            this.Left1 = new System.Windows.Forms.Button();
            this.Center = new System.Windows.Forms.Button();
            this.StatusBox = new System.Windows.Forms.TextBox();
            this.Conn_disconn = new System.Windows.Forms.Button();
            this.Up2 = new System.Windows.Forms.Button();
            this.Up3 = new System.Windows.Forms.Button();
            this.Down2 = new System.Windows.Forms.Button();
            this.Down3 = new System.Windows.Forms.Button();
            this.Left2 = new System.Windows.Forms.Button();
            this.Left3 = new System.Windows.Forms.Button();
            this.Right2 = new System.Windows.Forms.Button();
            this.Right3 = new System.Windows.Forms.Button();
            this.Save_position = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Up1
            // 
            this.Up1.Location = new System.Drawing.Point(160, 86);
            this.Up1.Name = "Up1";
            this.Up1.Size = new System.Drawing.Size(70, 35);
            this.Up1.TabIndex = 0;
            this.Up1.Text = "10";
            this.Up1.UseVisualStyleBackColor = true;
            this.Up1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Right1
            // 
            this.Right1.Location = new System.Drawing.Point(119, 127);
            this.Right1.Name = "Right1";
            this.Right1.Size = new System.Drawing.Size(35, 70);
            this.Right1.TabIndex = 1;
            this.Right1.Text = "10";
            this.Right1.UseVisualStyleBackColor = true;
            this.Right1.Click += new System.EventHandler(this.button2_Click);
            // 
            // Down1
            // 
            this.Down1.Location = new System.Drawing.Point(160, 203);
            this.Down1.Name = "Down1";
            this.Down1.Size = new System.Drawing.Size(70, 35);
            this.Down1.TabIndex = 2;
            this.Down1.Text = "10";
            this.Down1.UseVisualStyleBackColor = true;
            this.Down1.Click += new System.EventHandler(this.button3_Click);
            // 
            // Left1
            // 
            this.Left1.Location = new System.Drawing.Point(236, 127);
            this.Left1.Name = "Left1";
            this.Left1.Size = new System.Drawing.Size(35, 70);
            this.Left1.TabIndex = 3;
            this.Left1.Text = "10";
            this.Left1.UseVisualStyleBackColor = true;
            this.Left1.Click += new System.EventHandler(this.button4_Click);
            // 
            // Center
            // 
            this.Center.Location = new System.Drawing.Point(160, 127);
            this.Center.Name = "Center";
            this.Center.Size = new System.Drawing.Size(70, 70);
            this.Center.TabIndex = 4;
            this.Center.Text = "C";
            this.Center.UseVisualStyleBackColor = true;
            this.Center.Click += new System.EventHandler(this.button5_Click);
            // 
            // StatusBox
            // 
            this.StatusBox.Location = new System.Drawing.Point(12, 328);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.ReadOnly = true;
            this.StatusBox.Size = new System.Drawing.Size(238, 20);
            this.StatusBox.TabIndex = 5;
            // 
            // Conn_disconn
            // 
            this.Conn_disconn.Location = new System.Drawing.Point(256, 326);
            this.Conn_disconn.Name = "Conn_disconn";
            this.Conn_disconn.Size = new System.Drawing.Size(116, 23);
            this.Conn_disconn.TabIndex = 6;
            this.Conn_disconn.Text = "Connect/Disconnect";
            this.Conn_disconn.UseVisualStyleBackColor = true;
            this.Conn_disconn.Click += new System.EventHandler(this.button6_Click);
            // 
            // Up2
            // 
            this.Up2.Location = new System.Drawing.Point(160, 45);
            this.Up2.Name = "Up2";
            this.Up2.Size = new System.Drawing.Size(70, 35);
            this.Up2.TabIndex = 7;
            this.Up2.Text = "50";
            this.Up2.UseVisualStyleBackColor = true;
            this.Up2.Click += new System.EventHandler(this.Up2_Click);
            // 
            // Up3
            // 
            this.Up3.Location = new System.Drawing.Point(160, 4);
            this.Up3.Name = "Up3";
            this.Up3.Size = new System.Drawing.Size(70, 35);
            this.Up3.TabIndex = 8;
            this.Up3.Text = "100";
            this.Up3.UseVisualStyleBackColor = true;
            this.Up3.Click += new System.EventHandler(this.Up3_Click);
            // 
            // Down2
            // 
            this.Down2.Location = new System.Drawing.Point(160, 244);
            this.Down2.Name = "Down2";
            this.Down2.Size = new System.Drawing.Size(70, 35);
            this.Down2.TabIndex = 9;
            this.Down2.Text = "50";
            this.Down2.UseVisualStyleBackColor = true;
            this.Down2.Click += new System.EventHandler(this.Down2_Click);
            // 
            // Down3
            // 
            this.Down3.Location = new System.Drawing.Point(160, 285);
            this.Down3.Name = "Down3";
            this.Down3.Size = new System.Drawing.Size(70, 35);
            this.Down3.TabIndex = 10;
            this.Down3.Text = "100";
            this.Down3.UseVisualStyleBackColor = true;
            this.Down3.Click += new System.EventHandler(this.Down3_Click);
            // 
            // Left2
            // 
            this.Left2.Location = new System.Drawing.Point(277, 127);
            this.Left2.Name = "Left2";
            this.Left2.Size = new System.Drawing.Size(35, 70);
            this.Left2.TabIndex = 11;
            this.Left2.Text = "50";
            this.Left2.UseVisualStyleBackColor = true;
            this.Left2.Click += new System.EventHandler(this.Left2_Click);
            // 
            // Left3
            // 
            this.Left3.Location = new System.Drawing.Point(318, 127);
            this.Left3.Name = "Left3";
            this.Left3.Size = new System.Drawing.Size(35, 70);
            this.Left3.TabIndex = 12;
            this.Left3.Text = "100";
            this.Left3.UseVisualStyleBackColor = true;
            this.Left3.Click += new System.EventHandler(this.Left3_Click);
            // 
            // Right2
            // 
            this.Right2.Location = new System.Drawing.Point(78, 127);
            this.Right2.Name = "Right2";
            this.Right2.Size = new System.Drawing.Size(35, 70);
            this.Right2.TabIndex = 13;
            this.Right2.Text = "50";
            this.Right2.UseVisualStyleBackColor = true;
            this.Right2.Click += new System.EventHandler(this.Right2_Click);
            // 
            // Right3
            // 
            this.Right3.Location = new System.Drawing.Point(37, 127);
            this.Right3.Name = "Right3";
            this.Right3.Size = new System.Drawing.Size(35, 70);
            this.Right3.TabIndex = 14;
            this.Right3.Text = "100";
            this.Right3.UseVisualStyleBackColor = true;
            this.Right3.Click += new System.EventHandler(this.Right3_Click);
            // 
            // Save_position
            // 
            this.Save_position.Location = new System.Drawing.Point(256, 296);
            this.Save_position.Name = "Save_position";
            this.Save_position.Size = new System.Drawing.Size(116, 23);
            this.Save_position.TabIndex = 15;
            this.Save_position.Text = "Save position";
            this.Save_position.UseVisualStyleBackColor = true;
            this.Save_position.Click += new System.EventHandler(this.Save_position_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.Save_position);
            this.Controls.Add(this.Right3);
            this.Controls.Add(this.Right2);
            this.Controls.Add(this.Left3);
            this.Controls.Add(this.Left2);
            this.Controls.Add(this.Down3);
            this.Controls.Add(this.Down2);
            this.Controls.Add(this.Up3);
            this.Controls.Add(this.Up2);
            this.Controls.Add(this.Conn_disconn);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.Center);
            this.Controls.Add(this.Left1);
            this.Controls.Add(this.Down1);
            this.Controls.Add(this.Right1);
            this.Controls.Add(this.Up1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Rover Camera Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button Up1;
        private System.Windows.Forms.Button Right1;
        private System.Windows.Forms.Button Down1;
        private System.Windows.Forms.Button Left1;
        private System.Windows.Forms.Button Center;
        private System.Windows.Forms.TextBox StatusBox;
        private System.Windows.Forms.Button Conn_disconn;
        private System.Windows.Forms.Button Up2;
        private System.Windows.Forms.Button Up3;
        private System.Windows.Forms.Button Down2;
        private System.Windows.Forms.Button Down3;
        private System.Windows.Forms.Button Left2;
        private System.Windows.Forms.Button Left3;
        private System.Windows.Forms.Button Right2;
        private System.Windows.Forms.Button Right3;
        private System.Windows.Forms.Button Save_position;
    }
}

