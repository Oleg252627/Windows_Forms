namespace DZ2zad_2_
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1_Year = new System.Windows.Forms.RadioButton();
            this.radioButton1_Month = new System.Windows.Forms.RadioButton();
            this.radioButton1_day = new System.Windows.Forms.RadioButton();
            this.radioButton1_Minets = new System.Windows.Forms.RadioButton();
            this.radioButton1_Sec = new System.Windows.Forms.RadioButton();
            this.panel6_Focus = new System.Windows.Forms.Panel();
            this.textBox1_Set = new System.Windows.Forms.TextBox();
            this.textBox1_Get = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1_vkl = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1_Clear = new System.Windows.Forms.Button();
            this.button1_Calculate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.button1_Clear);
            this.panel1.Controls.Add(this.button1_Calculate);
            this.panel1.Controls.Add(this.panel6_Focus);
            this.panel1.Controls.Add(this.radioButton1_Sec);
            this.panel1.Controls.Add(this.radioButton1_Minets);
            this.panel1.Controls.Add(this.radioButton1_day);
            this.panel1.Controls.Add(this.radioButton1_Month);
            this.panel1.Controls.Add(this.radioButton1_Year);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 422);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Chocolate;
            this.panel2.Location = new System.Drawing.Point(281, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 10);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Chocolate;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(188, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(94, 107);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Chocolate;
            this.panel4.Location = new System.Drawing.Point(146, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(44, 10);
            this.panel4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Вычислить";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Время";
            // 
            // radioButton1_Year
            // 
            this.radioButton1_Year.Checked = true;
            this.radioButton1_Year.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1_Year.ForeColor = System.Drawing.Color.White;
            this.radioButton1_Year.Location = new System.Drawing.Point(34, 95);
            this.radioButton1_Year.Name = "radioButton1_Year";
            this.radioButton1_Year.Size = new System.Drawing.Size(111, 30);
            this.radioButton1_Year.TabIndex = 6;
            this.radioButton1_Year.TabStop = true;
            this.radioButton1_Year.Text = "В годах";
            this.radioButton1_Year.UseVisualStyleBackColor = true;
            this.radioButton1_Year.CheckedChanged += new System.EventHandler(this.radioButton1_Year_CheckedChanged);
            // 
            // radioButton1_Month
            // 
            this.radioButton1_Month.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1_Month.ForeColor = System.Drawing.Color.White;
            this.radioButton1_Month.Location = new System.Drawing.Point(34, 131);
            this.radioButton1_Month.Name = "radioButton1_Month";
            this.radioButton1_Month.Size = new System.Drawing.Size(111, 30);
            this.radioButton1_Month.TabIndex = 7;
            this.radioButton1_Month.TabStop = true;
            this.radioButton1_Month.Text = "В месяцах";
            this.radioButton1_Month.UseVisualStyleBackColor = true;
            this.radioButton1_Month.CheckedChanged += new System.EventHandler(this.radioButton1_Month_CheckedChanged);
            // 
            // radioButton1_day
            // 
            this.radioButton1_day.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1_day.ForeColor = System.Drawing.Color.White;
            this.radioButton1_day.Location = new System.Drawing.Point(34, 167);
            this.radioButton1_day.Name = "radioButton1_day";
            this.radioButton1_day.Size = new System.Drawing.Size(111, 30);
            this.radioButton1_day.TabIndex = 8;
            this.radioButton1_day.TabStop = true;
            this.radioButton1_day.Text = "В днях";
            this.radioButton1_day.UseVisualStyleBackColor = true;
            this.radioButton1_day.CheckedChanged += new System.EventHandler(this.radioButton1_day_CheckedChanged);
            // 
            // radioButton1_Minets
            // 
            this.radioButton1_Minets.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1_Minets.ForeColor = System.Drawing.Color.White;
            this.radioButton1_Minets.Location = new System.Drawing.Point(34, 203);
            this.radioButton1_Minets.Name = "radioButton1_Minets";
            this.radioButton1_Minets.Size = new System.Drawing.Size(111, 30);
            this.radioButton1_Minets.TabIndex = 9;
            this.radioButton1_Minets.TabStop = true;
            this.radioButton1_Minets.Text = "В минутах";
            this.radioButton1_Minets.UseVisualStyleBackColor = true;
            this.radioButton1_Minets.CheckedChanged += new System.EventHandler(this.radioButton1_Minets_CheckedChanged);
            // 
            // radioButton1_Sec
            // 
            this.radioButton1_Sec.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1_Sec.ForeColor = System.Drawing.Color.White;
            this.radioButton1_Sec.Location = new System.Drawing.Point(34, 239);
            this.radioButton1_Sec.Name = "radioButton1_Sec";
            this.radioButton1_Sec.Size = new System.Drawing.Size(111, 30);
            this.radioButton1_Sec.TabIndex = 10;
            this.radioButton1_Sec.TabStop = true;
            this.radioButton1_Sec.Text = "В секундах";
            this.radioButton1_Sec.UseVisualStyleBackColor = true;
            this.radioButton1_Sec.CheckedChanged += new System.EventHandler(this.radioButton1_Sec_CheckedChanged);
            // 
            // panel6_Focus
            // 
            this.panel6_Focus.BackColor = System.Drawing.Color.Chocolate;
            this.panel6_Focus.Location = new System.Drawing.Point(0, 95);
            this.panel6_Focus.Name = "panel6_Focus";
            this.panel6_Focus.Size = new System.Drawing.Size(10, 30);
            this.panel6_Focus.TabIndex = 6;
            // 
            // textBox1_Set
            // 
            this.textBox1_Set.Location = new System.Drawing.Point(169, 141);
            this.textBox1_Set.Name = "textBox1_Set";
            this.textBox1_Set.Size = new System.Drawing.Size(190, 20);
            this.textBox1_Set.TabIndex = 6;
            this.textBox1_Set.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1_Get
            // 
            this.textBox1_Get.Enabled = false;
            this.textBox1_Get.Location = new System.Drawing.Point(169, 226);
            this.textBox1_Get.Name = "textBox1_Get";
            this.textBox1_Get.Size = new System.Drawing.Size(190, 20);
            this.textBox1_Get.TabIndex = 7;
            this.textBox1_Get.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DZ2zad_2_.Properties.Resources.images__1_;
            this.pictureBox2.Location = new System.Drawing.Point(378, 255);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 134);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // button1_vkl
            // 
            this.button1_vkl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1_vkl.FlatAppearance.BorderSize = 0;
            this.button1_vkl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1_vkl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1_vkl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_vkl.Image = global::DZ2zad_2_.Properties.Resources.Windows_Turn_Off_icon;
            this.button1_vkl.Location = new System.Drawing.Point(484, 16);
            this.button1_vkl.Name = "button1_vkl";
            this.button1_vkl.Size = new System.Drawing.Size(40, 38);
            this.button1_vkl.TabIndex = 4;
            this.button1_vkl.UseVisualStyleBackColor = true;
            this.button1_vkl.Click += new System.EventHandler(this.button1_vkl_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DZ2zad_2_.Properties.Resources.calendar_icon;
            this.pictureBox1.Location = new System.Drawing.Point(23, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1_Clear
            // 
            this.button1_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1_Clear.FlatAppearance.BorderSize = 0;
            this.button1_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_Clear.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_Clear.ForeColor = System.Drawing.Color.White;
            this.button1_Clear.Image = global::DZ2zad_2_.Properties.Resources.Actions_view_refresh_icon;
            this.button1_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1_Clear.Location = new System.Drawing.Point(0, 354);
            this.button1_Clear.Name = "button1_Clear";
            this.button1_Clear.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.button1_Clear.Size = new System.Drawing.Size(148, 35);
            this.button1_Clear.TabIndex = 7;
            this.button1_Clear.Text = "Очистить";
            this.button1_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1_Clear.UseVisualStyleBackColor = true;
            this.button1_Clear.Click += new System.EventHandler(this.button1_Clear_Click);
            // 
            // button1_Calculate
            // 
            this.button1_Calculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1_Calculate.FlatAppearance.BorderSize = 0;
            this.button1_Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_Calculate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_Calculate.ForeColor = System.Drawing.Color.White;
            this.button1_Calculate.Image = global::DZ2zad_2_.Properties.Resources.computer_accept_icon;
            this.button1_Calculate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1_Calculate.Location = new System.Drawing.Point(0, 313);
            this.button1_Calculate.Name = "button1_Calculate";
            this.button1_Calculate.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.button1_Calculate.Size = new System.Drawing.Size(148, 35);
            this.button1_Calculate.TabIndex = 6;
            this.button1_Calculate.Text = "Вычислить";
            this.button1_Calculate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1_Calculate.UseVisualStyleBackColor = true;
            this.button1_Calculate.Click += new System.EventHandler(this.button1_Calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(536, 422);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox1_Get);
            this.Controls.Add(this.textBox1_Set);
            this.Controls.Add(this.button1_vkl);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1_vkl;
        private System.Windows.Forms.RadioButton radioButton1_Year;
        private System.Windows.Forms.RadioButton radioButton1_Month;
        private System.Windows.Forms.RadioButton radioButton1_day;
        private System.Windows.Forms.RadioButton radioButton1_Minets;
        private System.Windows.Forms.RadioButton radioButton1_Sec;
        private System.Windows.Forms.Panel panel6_Focus;
        private System.Windows.Forms.Button button1_Calculate;
        private System.Windows.Forms.Button button1_Clear;
        private System.Windows.Forms.TextBox textBox1_Set;
        private System.Windows.Forms.TextBox textBox1_Get;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

