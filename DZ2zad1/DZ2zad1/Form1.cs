using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ2zad1
{
    public partial class Form1_date : Form
    {
        public Form1_date()
        {
            InitializeComponent();
        }

        private void button1_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(textBox1_Entering.Text))
                {
                    DateTime date = Convert.ToDateTime(textBox1_Entering.Text);
                    textBox1_Show.Text = date.ToString("ddddd");
                }
                else
                {
                    textBox1_Entering.Text = null;
                }
            }
            catch (Exception exception)
            {

                textBox1_Entering.Text = "Не коректная дата"; 
            }
        }

        private void button1_Clear_Click(object sender, EventArgs e)
        {
            textBox1_Entering.Clear();
            textBox1_Show.Clear();
        }

        private void textBox1_Entering_TextChanged(object sender, EventArgs e)
        {
            textBox1_Entering.ForeColor = Color.Blue;
        }
    }
}
