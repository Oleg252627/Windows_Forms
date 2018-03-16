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
    public partial class FirstCastomControl : UserControl
    {
       public static bool I_fud { get; set; }
        public static bool I_toplivo { get; set; }
        public static double Fud { get; set; }
        public static double Toplivo { get; set; }
        private double GlobalSum;
        public FirstCastomControl()
        {
            InitializeComponent();
            Fud = 0;
            Toplivo = 0;
            GlobalSum = 0;
            I_fud = false;
            I_toplivo = false;
        }

        private void button1_S_Click(object sender, EventArgs e)
        {
            if(I_fud)
            {
                this.label2_Sum.Text =(Convert.ToDouble(this.label2_Sum.Text)+ Fud).ToString();
                GlobalSum += Fud;
                this.label3_GlobalSumm.Text = GlobalSum.ToString();
                I_fud = false;
            }

            if (I_toplivo)
            {
                this.label2_Sum.Text = (Convert.ToDouble(this.label2_Sum.Text) + Toplivo).ToString();
                GlobalSum += Toplivo;
                this.label3_GlobalSumm.Text = GlobalSum.ToString();
                I_toplivo = false;
            }
            var otvet = MessageBox.Show("Перейти к следующему клиенту", "Оповещение", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);
            if(otvet==DialogResult.Yes)
            {
                this.label2_Sum.Text = "0";
                FirstCastomFud.Flag_Fud = true;
                FirstCastomToplivo.flag_toplivo = true;
            }
            else
            {
                System.Threading.Thread.Sleep(3000);
                this.label2_Sum.Text = "0";
                FirstCastomFud.Flag_Fud = true;
                FirstCastomToplivo.flag_toplivo = true;
            }

            
        }
    }
}
