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
    public partial class FirstCastomFud : UserControl
    {
        private double labelfoGlobal = 0;
        private double labelCola = 0;
        private double labelFri = 0;
        private double labelGamburger = 0;
        private double labelHotDog = 0;
        public static bool Flag_Fud { get; set; }
        public FirstCastomFud()
        {
            InitializeComponent();
            this.Load += FirstCastomFud_Load;
            this.checkBox1_Cola.CheckStateChanged += new System.EventHandler(this.checkBox1_Cola_CheckedChanged);
            this.checkBox1_Fri.CheckStateChanged+= new System.EventHandler(this.checkBox1_Cola_CheckedChanged);
            this.checkBox1_Gambur.CheckStateChanged+=new System.EventHandler(this.checkBox1_Cola_CheckedChanged);
            this.checkBox1_HotDog.CheckStateChanged+=new System.EventHandler(this.checkBox1_Cola_CheckedChanged);
            this.textBox1_Cola.TextChanged+= new System.EventHandler(this.textBox1_Cola_TextChanged);
            this.textBox1_Fri.TextChanged+= new System.EventHandler(this.textBox1_Cola_TextChanged);
            this.textBox1_Gambur.TextChanged += new System.EventHandler(this.textBox1_Cola_TextChanged);
            this.textBox1_HotDog.TextChanged += new System.EventHandler(this.textBox1_Cola_TextChanged);
            this.MouseMove += FirstCastomFud_MouseMove;
        }

        private void FirstCastomFud_MouseMove(object sender, MouseEventArgs e)
        {
            if (Flag_Fud)
            {
                Clear_Fud();
            }
        }

        private void textBox1_Cola_TextChanged(object sender, EventArgs e)
        {
            TextBox item = (sender as TextBox);
            if (item.Name == this.textBox1_Cola.Name)
            {
                if (!String.IsNullOrWhiteSpace(item.Text))
                {
                    try
                    {
                        int col = Convert.ToInt32(item.Text);
                        labelCola = ((double)col * Convert.ToDouble(this.label6_Cola.Text));
                        labelfoGlobal = labelCola + labelFri + labelGamburger + labelHotDog;
                        this.label8_SumFud.Text = labelfoGlobal.ToString();
                        FirstCastomControl.Fud = labelfoGlobal;
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Не коректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        item.Text = "";
                    }
                }
                else
                {
                    labelCola = 0;
                    labelfoGlobal = labelCola + labelFri + labelGamburger + labelHotDog;
                    this.label8_SumFud.Text = labelfoGlobal.ToString();
                    FirstCastomControl.Fud = labelfoGlobal;
                }
            }
            else if (item.Name == this.textBox1_Fri.Name)
            {
                if (!String.IsNullOrWhiteSpace(item.Text))
                {
                    try
                    {
                        int col = Convert.ToInt32(item.Text);
                        labelFri = ((double)col * Convert.ToDouble(this.label4_Fri.Text));
                        labelfoGlobal = labelCola + labelFri + labelGamburger + labelHotDog;
                        this.label8_SumFud.Text = labelfoGlobal.ToString();
                        FirstCastomControl.Fud = labelfoGlobal;
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Не коректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        item.Text = "";
                    }
                }
                else
                {
                    labelFri = 0;
                    labelfoGlobal = labelCola + labelFri + labelGamburger + labelHotDog;
                    this.label8_SumFud.Text = labelfoGlobal.ToString();
                    FirstCastomControl.Fud = labelfoGlobal;
                }
            }
            else if (item.Name == this.textBox1_Gambur.Name)
            {
                if (!String.IsNullOrWhiteSpace(item.Text))
                {
                    try
                    {
                        int col = Convert.ToInt32(item.Text);
                        labelGamburger = ((double)col * Convert.ToDouble(this.label5_Gambur.Text));
                        labelfoGlobal = labelCola + labelFri + labelGamburger + labelHotDog;
                        this.label8_SumFud.Text = labelfoGlobal.ToString();
                        FirstCastomControl.Fud = labelfoGlobal;
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Не коректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        item.Text = "";
                    }
                }
                else
                {
                    labelGamburger = 0;
                    labelfoGlobal = labelCola + labelFri + labelGamburger + labelHotDog;
                    this.label8_SumFud.Text = labelfoGlobal.ToString();
                    FirstCastomControl.Fud = labelfoGlobal;
                }
            }
            else if (item.Name == this.textBox1_HotDog.Name)
            {
                if (!String.IsNullOrWhiteSpace(item.Text))
                {
                    try
                    {
                        int col = Convert.ToInt32(item.Text);
                        labelHotDog = ((double)col * Convert.ToDouble(this.label2_HotDog.Text));
                        labelfoGlobal = labelCola + labelFri + labelGamburger + labelHotDog;
                        this.label8_SumFud.Text = labelfoGlobal.ToString();
                        FirstCastomControl.Fud = labelfoGlobal;
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Не коректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        item.Text = "";
                    }
                }
                else
                {
                    labelHotDog = 0;
                    labelfoGlobal = labelCola + labelFri + labelGamburger + labelHotDog;
                    this.label8_SumFud.Text = labelfoGlobal.ToString();
                    FirstCastomControl.Fud = labelfoGlobal;
                }
            }
        }
        private void checkBox1_Cola_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox fud = (sender as CheckBox);
            if (fud.Text == this.checkBox1_Cola.Text && fud.Checked == true)
            {
                this.textBox1_Cola.Enabled = true;
                this.textBox1_Cola.Text = null;
            }
            else if (fud.Text == this.checkBox1_Cola.Text && fud.Checked == false)
            {
                this.textBox1_Cola.Enabled = false;
                this.textBox1_Cola.Text = "0";
            }
            else if (fud.Text == this.checkBox1_Fri.Text && fud.Checked == true)
            {
                this.textBox1_Fri.Enabled = true;
                this.textBox1_Fri.Text = null;
            }
            else if (fud.Text == this.checkBox1_Fri.Text && fud.Checked == false)
            {
                this.textBox1_Fri.Enabled = false;
                this.textBox1_Fri.Text = "0";
            }
            else if (fud.Text == this.checkBox1_Gambur.Text && fud.Checked == true)
            {
                this.textBox1_Gambur.Enabled = true;
                this.textBox1_Gambur.Text = null;
            }
            else if (fud.Text == this.checkBox1_Gambur.Text && fud.Checked == false)
            {
                this.textBox1_Gambur.Enabled = false;
                this.textBox1_Gambur.Text = "0";
            }
            else if (fud.Text == this.checkBox1_HotDog.Text && fud.Checked == true)
            {
                this.textBox1_HotDog.Enabled = true;
                this.textBox1_HotDog.Text = null;
            }
            else if (fud.Text == this.checkBox1_HotDog.Text && fud.Checked == false)
            {
                this.textBox1_HotDog.Enabled = false;
                this.textBox1_HotDog.Text = "0";
            }
        }
        private void FirstCastomFud_Load(object sender, EventArgs e)
        {
            this.textBox1_HotDog.Enabled = false;
            this.textBox1_Cola.Enabled = false;
            this.textBox1_Fri.Enabled = false;
            this.textBox1_Gambur.Enabled = false;
            Flag_Fud = false;
        }

        public void Clear_Fud()
        {
            this.textBox1_HotDog.Enabled = false;
            this.textBox1_HotDog.Text = "0";
            this.textBox1_Cola.Enabled = false;
            this.textBox1_Cola.Text = "0";
            this.textBox1_Fri.Enabled = false;
            this.textBox1_Fri.Text = "0";
            this.textBox1_Gambur.Enabled = false;
            this.textBox1_Gambur.Text = "0";
            this.checkBox1_Cola.Checked = false;
            this.checkBox1_Fri.Checked = false;
            this.checkBox1_Gambur.Checked = false;
            this.checkBox1_HotDog.Checked = false;
            labelfoGlobal = 0;
            labelCola = 0;
            labelFri = 0;
            labelGamburger = 0;
            labelHotDog = 0;
            Flag_Fud = false;
        }
    }
}
