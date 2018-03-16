using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ2zad3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.panel5_Focus.Height = this.button2_Glav.Height;
            this.panel5_Focus.Top = this.button2_Glav.Top;
            this.firstCastomControl1.BringToFront();
        }

        private void button2_Glav_Click(object sender, EventArgs e)
        {
            this.panel5_Focus.Height = this.button2_Glav.Height;
            this.panel5_Focus.Top = this.button2_Glav.Top;
            this.firstCastomControl1.BringToFront();
        }

        private void button2_Fod_Click(object sender, EventArgs e)
        {
            this.panel5_Focus.Height = this.button2_Fod.Height;
            this.panel5_Focus.Top = this.button2_Fod.Top;
            this.firstCastomFud1.BringToFront();
            FirstCastomControl.I_fud = true;
        }

        private void button2_Toplivo_Click(object sender, EventArgs e)
        {
            this.panel5_Focus.Height = this.button2_Toplivo.Height;
            this.panel5_Focus.Top = this.button2_Toplivo.Top;
            this.firstCastomToplivo1.BringToFront();
            FirstCastomControl.I_toplivo = true;
        }

        private void button2_Summ_Click(object sender, EventArgs e)
        {
            this.panel5_Focus.Height = this.button2_Summ.Height;
            this.panel5_Focus.Top = this.button2_Summ.Top;
            this.firstCastomControl1.BringToFront();
        }

        private void button2_Svorach_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
