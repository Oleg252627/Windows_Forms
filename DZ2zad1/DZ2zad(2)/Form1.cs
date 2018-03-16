using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ2zad_2_
{
    public partial class Form1 : Form
    {
        private DateTime tec;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tec = DateTime.Now;
            radioButton1_Year.Checked = true;
            panel6_Focus.Top = radioButton1_Year.Top;
            panel6_Focus.Height = radioButton1_Year.Height;
        }
        private void button1_vkl_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void radioButton1_Year_CheckedChanged(object sender, EventArgs e)
        {
            panel6_Focus.Top = radioButton1_Year.Top;
            panel6_Focus.Height = radioButton1_Year.Height;
        }
        private void radioButton1_Month_CheckedChanged(object sender, EventArgs e)
        {
            panel6_Focus.Top = radioButton1_Month.Top;
            panel6_Focus.Height = radioButton1_Month.Height;
        }
        private void radioButton1_day_CheckedChanged(object sender, EventArgs e)
        {
            panel6_Focus.Top = radioButton1_day.Top;
            panel6_Focus.Height = radioButton1_day.Height;
        }

        private void radioButton1_Minets_CheckedChanged(object sender, EventArgs e)
        {
            panel6_Focus.Top = radioButton1_Minets.Top;
            panel6_Focus.Height = radioButton1_Minets.Height;
        }

        private void radioButton1_Sec_CheckedChanged(object sender, EventArgs e)
        {
            panel6_Focus.Top = radioButton1_Sec.Top;
            panel6_Focus.Height = radioButton1_Sec.Height;
        }

        private void button1_Calculate_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBox1_Set.Text))
            {
                try
                {
                    DateTime set = Convert.ToDateTime(textBox1_Set.Text);
                    if (tec < set)
                    {
                        TimeSpan raz = set - tec;
                        if (radioButton1_Year.Checked == true)
                        {
                            textBox1_Get.Text = $"{(((double) raz.TotalDays) / 365.25).ToString()}";
                        }
                        else if (radioButton1_Month.Checked == true)
                        {
                            if ((((double)raz.TotalDays) / 365.25) == 0 && (set.Month-tec.Month)!=0)
                            {
                                if ((set.Month - tec.Month) < 0)
                                {
                                    textBox1_Get.Text = ((12 - tec.Month) + set.Month).ToString();
                                }
                                else
                                {
                                    textBox1_Get.Text = (set.Month - tec.Month).ToString();
                                }
                            }
                            else 
                            {
                                textBox1_Get.Text = (((((double)raz.TotalDays) / 365.25) )*12)
                                    .ToString();
                            }
                        }
                        else if (radioButton1_day.Checked == true)
                        {
                            textBox1_Get.Text = ((int)raz.TotalDays).ToString();
                        }
                        else if (radioButton1_Minets.Checked == true)
                        {
                            textBox1_Get.Text = ((int)raz.TotalMinutes).ToString();
                        }
                        else if (radioButton1_Sec.Checked == true)
                        {
                            textBox1_Get.Text = ((int)raz.TotalSeconds).ToString();
                        }
                    }
                    else
                    {
                        textBox1_Set.Text = "Введенная дата меньше текущей!";
                    }
                }
                catch (Exception exception)
                {
                    textBox1_Set.Text = "Не коректная дата!";
                }
            }
            else
            {
                textBox1_Set.Text = null;
            }
        }

        private void button1_Clear_Click(object sender, EventArgs e)
        {
            textBox1_Set.Clear();
            textBox1_Get.Clear();
        }
    }
}
