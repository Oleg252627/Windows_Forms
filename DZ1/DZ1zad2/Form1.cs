using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ1zad2
{
    public partial class Form1 : Form
    {
        private static Random ran;
        private static int col;
        public Form1()
        {
            InitializeComponent();
            ran = new Random();
            col = 0;
            this.Shown += Game;
        }

        private void Game( object sender, EventArgs e)
        {
            DialogResult Global_result;
            MessageBox.Show("Загодайте число и я отгодаю", "Игра", MessageBoxButtons.OK, MessageBoxIcon.Information);
            do
            {
                while (true)
                {
                    col++;
                    DialogResult result = MessageBox.Show($"Вы загадали {ran.Next(1, 2001)}", "Отгадываю число", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show($"Попыток: {col}", "Количество", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        col = 0;
                        break;
                    }
                }
                Global_result = MessageBox.Show("Хотите начать новую игру", "Вопрос", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question);
            } while (Global_result == DialogResult.Yes);
        }
    }
}
