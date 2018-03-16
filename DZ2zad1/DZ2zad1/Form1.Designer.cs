namespace DZ2zad1
{
    partial class Form1_date
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
            this.textBox1_Entering = new System.Windows.Forms.TextBox();
            this.textBox1_Show = new System.Windows.Forms.TextBox();
            this.button1_Clear = new System.Windows.Forms.Button();
            this.button1_ok = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1_Entering
            // 
            this.textBox1_Entering.Location = new System.Drawing.Point(197, 48);
            this.textBox1_Entering.Name = "textBox1_Entering";
            this.textBox1_Entering.Size = new System.Drawing.Size(213, 20);
            this.textBox1_Entering.TabIndex = 1;
            this.textBox1_Entering.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1_Entering.TextChanged += new System.EventHandler(this.textBox1_Entering_TextChanged);
            // 
            // textBox1_Show
            // 
            this.textBox1_Show.Enabled = false;
            this.textBox1_Show.Location = new System.Drawing.Point(197, 159);
            this.textBox1_Show.Name = "textBox1_Show";
            this.textBox1_Show.Size = new System.Drawing.Size(213, 20);
            this.textBox1_Show.TabIndex = 2;
            this.textBox1_Show.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1_Clear
            // 
            this.button1_Clear.Image = global::DZ2zad1.Properties.Resources.Clear_icon;
            this.button1_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1_Clear.Location = new System.Drawing.Point(245, 198);
            this.button1_Clear.Name = "button1_Clear";
            this.button1_Clear.Padding = new System.Windows.Forms.Padding(0, 0, 11, 0);
            this.button1_Clear.Size = new System.Drawing.Size(115, 32);
            this.button1_Clear.TabIndex = 4;
            this.button1_Clear.Text = "Очистить";
            this.button1_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1_Clear.UseVisualStyleBackColor = true;
            this.button1_Clear.Click += new System.EventHandler(this.button1_Clear_Click);
            // 
            // button1_ok
            // 
            this.button1_ok.Image = global::DZ2zad1.Properties.Resources.Accept_icon;
            this.button1_ok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1_ok.Location = new System.Drawing.Point(245, 96);
            this.button1_ok.Name = "button1_ok";
            this.button1_ok.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.button1_ok.Size = new System.Drawing.Size(115, 34);
            this.button1_ok.TabIndex = 3;
            this.button1_ok.Text = "Вычислить";
            this.button1_ok.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1_ok.UseVisualStyleBackColor = true;
            this.button1_ok.Click += new System.EventHandler(this.button1_ok_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DZ2zad1.Properties.Resources.calendar_icon;
            this.pictureBox1.Location = new System.Drawing.Point(24, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 131);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1_date
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 254);
            this.Controls.Add(this.button1_Clear);
            this.Controls.Add(this.button1_ok);
            this.Controls.Add(this.textBox1_Show);
            this.Controls.Add(this.textBox1_Entering);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1_date";
            this.RightToLeftLayout = true;
            this.Text = "Вывод дня!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1_Entering;
        private System.Windows.Forms.TextBox textBox1_Show;
        private System.Windows.Forms.Button button1_ok;
        private System.Windows.Forms.Button button1_Clear;
    }
}

