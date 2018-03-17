using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ1
{
    public partial class Form1 : Form
    {
        static private List<String> vec;
        static private List<String> nam;
        static private double average;
        static private int col;
        public Form1()
        {
            InitializeComponent();
            vec = new List<String> { "Плетиненко", "Олег", "Алексеевич", "13 декабря 1983" };
            nam = new List<String> { "Фамилия", "Имя", "Отчество", "Год рождения" };
            average = 0;
            col = 0;
            this.Shown += Show_Message_Box;
        }
        private void Show_Message_Box(object sender, EventArgs e)
        {
            for (int i = 0; i < vec.Count; i++)
            {
                col += vec[i].Length;
                MessageBox.Show(vec[i], nam[i],
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            average = (double)col / vec.Count;
            MessageBox.Show(" ", $"Среднее: {average} Общее: {col} Количество MessageBox: {vec.Count}",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
