using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ1zad3
{
    public partial class Form1 : Form
    {
        bool flag = false;
        public Form1()
        {
            InitializeComponent();
            this.MouseMove += Form1_MouseMove;
            this.MouseClick += Form1_MouseClick;
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }

        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                flag = true;
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (flag) { this.Close(); }
                if (e.X < 20 || e.X > this.ClientSize.Width - 20 || e.Y < 20 || e.Y > this.ClientSize.Height - 20)
                {
                    MessageBox.Show("С наружи прямоугольника", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (((e.X > 30 && e.X < this.ClientSize.Width - 30)) && ((e.Y > 30) && (e.Y < this.ClientSize.Height - 30)))
                {
                    MessageBox.Show("Внутри прямоугольника", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("На границе прямоугольника", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                this.Text = $"Высота: {this.ClientSize.Height} Ширина: {this.ClientSize.Width}";
                System.Threading.Thread.Sleep(2000);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"X = {e.X}, Y = {e.Y}";
        }
    }
}
