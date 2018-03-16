using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ2zad3
{
    public partial class FirstCastomToplivo : UserControl
    {
        private List<String> prise;
        public static bool flag_toplivo { get; set; }
        public FirstCastomToplivo()
        {
            InitializeComponent();
            comboBox1_Toplivo.SelectedIndex = 0;
            this.radioButton1_Col.CheckedChanged += RadioButton1_Col_CheckedChanged;
            this.radioButton1_Sum.CheckedChanged += RadioButton1_Sum_CheckedChanged;
            this.comboBox1_Toplivo.SelectedIndexChanged += ComboBox1_Toplivo_SelectedIndexChanged;
            this.MouseMove += FirstCastomToplivo_MouseMove;
        }

        private void FirstCastomToplivo_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag_toplivo)
            {
                Clear_Toplivo();
            }
        }

        private void ComboBox1_Toplivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox1_Toplivo.SelectedIndex == 0)
            {
                this.label5_Toplivo_prise.Text = prise[0];
                if (this.radioButton1_Col.Checked == true)
                {
                    this.textBox1_Col.Text = "";
                }
                else
                {
                    this.textBox1_Summ.Text = "";
                }
            }
            if (this.comboBox1_Toplivo.SelectedIndex == 1)
            {
                this.label5_Toplivo_prise.Text = prise[1];
                if (this.radioButton1_Col.Checked == true)
                {
                    this.textBox1_Col.Text = "";
                }
                else
                {
                    this.textBox1_Summ.Text = "";
                }
            }
            if (this.comboBox1_Toplivo.SelectedIndex == 2)
            {
                this.label5_Toplivo_prise.Text = prise[2];
                if (this.radioButton1_Col.Checked == true)
                {
                    this.textBox1_Col.Text = "";
                }
                else
                {
                    this.textBox1_Summ.Text = "";
                }
            }
            if (this.comboBox1_Toplivo.SelectedIndex == 3)
            {
                this.label5_Toplivo_prise.Text = prise[3];
                if (this.radioButton1_Col.Checked == true)
                {
                    this.textBox1_Col.Text = "";
                }
                else
                {
                    this.textBox1_Summ.Text = "";
                }
            }
            if (this.comboBox1_Toplivo.SelectedIndex == 4)
            {
                this.label5_Toplivo_prise.Text = prise[4];
                if (this.radioButton1_Col.Checked == true)
                {
                    this.textBox1_Col.Text = "";
                }
                else
                {
                    this.textBox1_Summ.Text = "";
                }
            }
        }

        private void RadioButton1_Sum_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton1_Sum.Checked == true)
            {
                this.textBox1_Summ.Enabled = true;
                this.textBox1_Col.Enabled = false;
                this.textBox1_Col.Text = "0";
                this.textBox1_Summ.Text = null;
                this.label9_Grn_L.Text = "л.";
            }
        }

        private void RadioButton1_Col_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton1_Col.Checked == true)
            {
                this.textBox1_Summ.Enabled = false;
                this.textBox1_Col.Enabled = true;
                this.textBox1_Summ.Text = "0";
                this.textBox1_Col.Text = null;
                this.label9_Grn_L.Text = "грн.";
            }
        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void FirstCastomToplivo_Load(object sender, EventArgs e)
        {
            prise = new List<String>() {"32,49", "31,49", "30,49", "22,89", "12,69"};
            this.label5_Toplivo_prise.Text = prise[0];
            this.radioButton1_Col.Checked = true;
            this.textBox1_Summ.Enabled = false;
            this.textBox1_Summ.Text = "0";
            this.textBox1_Col.Text = null;
            flag_toplivo = false;
        }

        private void textBox1_Col_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(this.textBox1_Col.Text))
            {
                try
                {
                    double col = Convert.ToDouble(this.textBox1_Col.Text);
                    this.label8_Sum_Toplivo.Text = (col * (System.Convert.ToDouble(this.label5_Toplivo_prise.Text))).ToString();
                    FirstCastomControl.Toplivo = col * (System.Convert.ToDouble(this.label5_Toplivo_prise.Text));
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Не коректный ввод!","Ошибка", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    this.textBox1_Col.Text = "";

                }
            }
            else
            {
                this.label8_Sum_Toplivo.Text = "0";
                FirstCastomControl.Toplivo = 0;
            }
        }

        private void textBox1_Summ_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(this.textBox1_Summ.Text))
            {
                try
                {
                    double col = Convert.ToDouble(this.textBox1_Summ.Text);
                    this.label8_Sum_Toplivo.Text = Math.Round(col / (System.Convert.ToDouble(this.label5_Toplivo_prise.Text)), 1).ToString();
                    FirstCastomControl.Toplivo = Math.Round(Convert.ToDouble(this.textBox1_Summ.Text), 2);
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Не коректный ввод!","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.textBox1_Summ.Text = "";

                }
            }
            else
            {
                this.label8_Sum_Toplivo.Text = "0";
                FirstCastomControl.Toplivo = 0;
            }
        }

        public void Clear_Toplivo()
        {
            comboBox1_Toplivo.SelectedIndex = 0;
            this.label5_Toplivo_prise.Text = prise[0];
            this.radioButton1_Col.Checked = true;
            this.textBox1_Summ.Enabled = false;
            this.textBox1_Summ.Text = "0";
            this.textBox1_Col.Text = null;
            flag_toplivo = false;
        }
    }
}
