namespace DZ2zad3
{
    partial class FirstCastomControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2_Sum = new System.Windows.Forms.Label();
            this.button1_S = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3_GlobalSumm = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DZ2zad3.Properties.Resources.Без_названия2;
            this.pictureBox2.Location = new System.Drawing.Point(448, 153);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 133);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::DZ2zad3.Properties.Resources.Без_названия1;
            this.pictureBox1.Location = new System.Drawing.Point(310, 243);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(174, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Разсчет всей суммы";
            // 
            // label2_Sum
            // 
            this.label2_Sum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2_Sum.Font = new System.Drawing.Font("Goudy Stout", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_Sum.ForeColor = System.Drawing.Color.Blue;
            this.label2_Sum.Location = new System.Drawing.Point(34, 196);
            this.label2_Sum.Name = "label2_Sum";
            this.label2_Sum.Size = new System.Drawing.Size(243, 56);
            this.label2_Sum.TabIndex = 3;
            this.label2_Sum.Text = "0";
            this.label2_Sum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1_S
            // 
            this.button1_S.BackColor = System.Drawing.Color.Blue;
            this.button1_S.FlatAppearance.BorderSize = 0;
            this.button1_S.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_S.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_S.ForeColor = System.Drawing.Color.White;
            this.button1_S.Location = new System.Drawing.Point(49, 316);
            this.button1_S.Name = "button1_S";
            this.button1_S.Size = new System.Drawing.Size(205, 34);
            this.button1_S.TabIndex = 4;
            this.button1_S.Text = "Суммировать";
            this.button1_S.UseVisualStyleBackColor = false;
            this.button1_S.Click += new System.EventHandler(this.button1_S_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(307, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выручка за день";
            // 
            // label3_GlobalSumm
            // 
            this.label3_GlobalSumm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3_GlobalSumm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3_GlobalSumm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label3_GlobalSumm.Location = new System.Drawing.Point(449, 72);
            this.label3_GlobalSumm.Name = "label3_GlobalSumm";
            this.label3_GlobalSumm.Size = new System.Drawing.Size(109, 18);
            this.label3_GlobalSumm.TabIndex = 6;
            this.label3_GlobalSumm.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 4000;
            // 
            // FirstCastomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label3_GlobalSumm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1_S);
            this.Controls.Add(this.label2_Sum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FirstCastomControl";
            this.Size = new System.Drawing.Size(571, 421);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2_Sum;
        private System.Windows.Forms.Button button1_S;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3_GlobalSumm;
        private System.Windows.Forms.Timer timer1;
    }
}
