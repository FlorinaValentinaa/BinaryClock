namespace BinaryClock {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing&&(components!=null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.lightsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.seconds1 = new System.Windows.Forms.Button();
            this.seconds16 = new System.Windows.Forms.Button();
            this.minutes1 = new System.Windows.Forms.Button();
            this.minutes16 = new System.Windows.Forms.Button();
            this.hours1 = new System.Windows.Forms.Button();
            this.hours16 = new System.Windows.Forms.Button();
            this.seconds2 = new System.Windows.Forms.Button();
            this.seconds32 = new System.Windows.Forms.Button();
            this.minutes2 = new System.Windows.Forms.Button();
            this.minutes32 = new System.Windows.Forms.Button();
            this.hours2 = new System.Windows.Forms.Button();
            this.seconds4 = new System.Windows.Forms.Button();
            this.minutes4 = new System.Windows.Forms.Button();
            this.hours4 = new System.Windows.Forms.Button();
            this.seconds8 = new System.Windows.Forms.Button();
            this.minutes8 = new System.Windows.Forms.Button();
            this.hours8 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lightsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lightsPanel
            // 
            this.lightsPanel.ColumnCount = 6;
            this.lightsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.lightsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.lightsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.lightsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.28972F));
            this.lightsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.88785F));
            this.lightsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.lightsPanel.Controls.Add(this.seconds1, 5, 3);
            this.lightsPanel.Controls.Add(this.seconds16, 4, 3);
            this.lightsPanel.Controls.Add(this.minutes1, 3, 3);
            this.lightsPanel.Controls.Add(this.minutes16, 2, 3);
            this.lightsPanel.Controls.Add(this.hours1, 1, 3);
            this.lightsPanel.Controls.Add(this.hours16, 0, 3);
            this.lightsPanel.Controls.Add(this.seconds2, 5, 2);
            this.lightsPanel.Controls.Add(this.seconds32, 4, 2);
            this.lightsPanel.Controls.Add(this.minutes2, 3, 2);
            this.lightsPanel.Controls.Add(this.minutes32, 2, 2);
            this.lightsPanel.Controls.Add(this.hours2, 1, 2);
            this.lightsPanel.Controls.Add(this.seconds4, 5, 1);
            this.lightsPanel.Controls.Add(this.minutes4, 3, 1);
            this.lightsPanel.Controls.Add(this.hours4, 1, 1);
            this.lightsPanel.Controls.Add(this.seconds8, 5, 0);
            this.lightsPanel.Controls.Add(this.minutes8, 3, 0);
            this.lightsPanel.Controls.Add(this.hours8, 1, 0);
            this.lightsPanel.Location = new System.Drawing.Point(272, 53);
            this.lightsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.lightsPanel.Name = "lightsPanel";
            this.lightsPanel.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.lightsPanel.RowCount = 4;
            this.lightsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.lightsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.lightsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.lightsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.lightsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.lightsPanel.Size = new System.Drawing.Size(480, 309);
            this.lightsPanel.TabIndex = 6;
            // 
            // seconds1
            // 
            this.seconds1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seconds1.Location = new System.Drawing.Point(392, 229);
            this.seconds1.Margin = new System.Windows.Forms.Padding(4);
            this.seconds1.Name = "seconds1";
            this.seconds1.Size = new System.Drawing.Size(71, 64);
            this.seconds1.TabIndex = 23;
            this.seconds1.UseVisualStyleBackColor = true;
            // 
            // seconds16
            // 
            this.seconds16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seconds16.Location = new System.Drawing.Point(320, 229);
            this.seconds16.Margin = new System.Windows.Forms.Padding(4);
            this.seconds16.Name = "seconds16";
            this.seconds16.Size = new System.Drawing.Size(64, 64);
            this.seconds16.TabIndex = 22;
            this.seconds16.UseVisualStyleBackColor = true;
            // 
            // minutes1
            // 
            this.minutes1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minutes1.Location = new System.Drawing.Point(242, 229);
            this.minutes1.Margin = new System.Windows.Forms.Padding(4);
            this.minutes1.Name = "minutes1";
            this.minutes1.Size = new System.Drawing.Size(70, 64);
            this.minutes1.TabIndex = 21;
            this.minutes1.UseVisualStyleBackColor = true;
            // 
            // minutes16
            // 
            this.minutes16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minutes16.Location = new System.Drawing.Point(167, 229);
            this.minutes16.Margin = new System.Windows.Forms.Padding(4);
            this.minutes16.Name = "minutes16";
            this.minutes16.Size = new System.Drawing.Size(67, 64);
            this.minutes16.TabIndex = 20;
            this.minutes16.UseVisualStyleBackColor = true;
            // 
            // hours1
            // 
            this.hours1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hours1.Location = new System.Drawing.Point(92, 229);
            this.hours1.Margin = new System.Windows.Forms.Padding(4);
            this.hours1.Name = "hours1";
            this.hours1.Size = new System.Drawing.Size(67, 64);
            this.hours1.TabIndex = 19;
            this.hours1.UseVisualStyleBackColor = true;
            // 
            // hours16
            // 
            this.hours16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hours16.Location = new System.Drawing.Point(17, 229);
            this.hours16.Margin = new System.Windows.Forms.Padding(4);
            this.hours16.Name = "hours16";
            this.hours16.Size = new System.Drawing.Size(67, 64);
            this.hours16.TabIndex = 18;
            this.hours16.UseVisualStyleBackColor = true;
            // 
            // seconds2
            // 
            this.seconds2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seconds2.Location = new System.Drawing.Point(392, 158);
            this.seconds2.Margin = new System.Windows.Forms.Padding(4);
            this.seconds2.Name = "seconds2";
            this.seconds2.Size = new System.Drawing.Size(71, 63);
            this.seconds2.TabIndex = 17;
            this.seconds2.UseVisualStyleBackColor = true;
            // 
            // seconds32
            // 
            this.seconds32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seconds32.Location = new System.Drawing.Point(320, 158);
            this.seconds32.Margin = new System.Windows.Forms.Padding(4);
            this.seconds32.Name = "seconds32";
            this.seconds32.Size = new System.Drawing.Size(64, 63);
            this.seconds32.TabIndex = 16;
            this.seconds32.UseVisualStyleBackColor = true;
            // 
            // minutes2
            // 
            this.minutes2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minutes2.Location = new System.Drawing.Point(242, 158);
            this.minutes2.Margin = new System.Windows.Forms.Padding(4);
            this.minutes2.Name = "minutes2";
            this.minutes2.Size = new System.Drawing.Size(70, 63);
            this.minutes2.TabIndex = 15;
            this.minutes2.UseVisualStyleBackColor = true;
            // 
            // minutes32
            // 
            this.minutes32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minutes32.Location = new System.Drawing.Point(167, 158);
            this.minutes32.Margin = new System.Windows.Forms.Padding(4);
            this.minutes32.Name = "minutes32";
            this.minutes32.Size = new System.Drawing.Size(67, 63);
            this.minutes32.TabIndex = 14;
            this.minutes32.UseVisualStyleBackColor = true;
            // 
            // hours2
            // 
            this.hours2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hours2.Location = new System.Drawing.Point(92, 158);
            this.hours2.Margin = new System.Windows.Forms.Padding(4);
            this.hours2.Name = "hours2";
            this.hours2.Size = new System.Drawing.Size(67, 63);
            this.hours2.TabIndex = 13;
            this.hours2.UseVisualStyleBackColor = true;
            // 
            // seconds4
            // 
            this.seconds4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seconds4.Location = new System.Drawing.Point(392, 87);
            this.seconds4.Margin = new System.Windows.Forms.Padding(4);
            this.seconds4.Name = "seconds4";
            this.seconds4.Size = new System.Drawing.Size(71, 63);
            this.seconds4.TabIndex = 11;
            this.seconds4.UseVisualStyleBackColor = true;
            // 
            // minutes4
            // 
            this.minutes4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minutes4.Location = new System.Drawing.Point(242, 87);
            this.minutes4.Margin = new System.Windows.Forms.Padding(4);
            this.minutes4.Name = "minutes4";
            this.minutes4.Size = new System.Drawing.Size(70, 63);
            this.minutes4.TabIndex = 9;
            this.minutes4.UseVisualStyleBackColor = true;
            // 
            // hours4
            // 
            this.hours4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hours4.Location = new System.Drawing.Point(92, 87);
            this.hours4.Margin = new System.Windows.Forms.Padding(4);
            this.hours4.Name = "hours4";
            this.hours4.Size = new System.Drawing.Size(67, 63);
            this.hours4.TabIndex = 7;
            this.hours4.UseVisualStyleBackColor = true;
            // 
            // seconds8
            // 
            this.seconds8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seconds8.Location = new System.Drawing.Point(392, 16);
            this.seconds8.Margin = new System.Windows.Forms.Padding(4);
            this.seconds8.Name = "seconds8";
            this.seconds8.Size = new System.Drawing.Size(71, 63);
            this.seconds8.TabIndex = 5;
            this.seconds8.UseVisualStyleBackColor = true;
            // 
            // minutes8
            // 
            this.minutes8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minutes8.Location = new System.Drawing.Point(242, 16);
            this.minutes8.Margin = new System.Windows.Forms.Padding(4);
            this.minutes8.Name = "minutes8";
            this.minutes8.Size = new System.Drawing.Size(70, 63);
            this.minutes8.TabIndex = 3;
            this.minutes8.UseVisualStyleBackColor = true;
            // 
            // hours8
            // 
            this.hours8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hours8.Location = new System.Drawing.Point(92, 16);
            this.hours8.Margin = new System.Windows.Forms.Padding(4);
            this.hours8.Name = "hours8";
            this.hours8.Size = new System.Drawing.Size(67, 63);
            this.hours8.TabIndex = 1;
            this.hours8.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Binary Clock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(740, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(740, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(740, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(740, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "8";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(609, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "16";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(459, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "16";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(310, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "16";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(459, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "32";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(609, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "32";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(46, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 24);
            this.label11.TabIndex = 17;
            this.label11.Text = "Time";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 441);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lightsPanel);
            this.Controls.Add(this.label10);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Binary Clock";
            this.lightsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel lightsPanel;
        private System.Windows.Forms.Button seconds1;
        private System.Windows.Forms.Button seconds16;
        private System.Windows.Forms.Button minutes1;
        private System.Windows.Forms.Button minutes16;
        private System.Windows.Forms.Button hours1;
        private System.Windows.Forms.Button hours16;
        private System.Windows.Forms.Button seconds2;
        private System.Windows.Forms.Button seconds32;
        private System.Windows.Forms.Button minutes2;
        private System.Windows.Forms.Button minutes32;
        private System.Windows.Forms.Button hours2;
        private System.Windows.Forms.Button seconds4;
        private System.Windows.Forms.Button minutes4;
        private System.Windows.Forms.Button hours4;
        private System.Windows.Forms.Button seconds8;
        private System.Windows.Forms.Button minutes8;
        private System.Windows.Forms.Button hours8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer timer2;
    }
}

