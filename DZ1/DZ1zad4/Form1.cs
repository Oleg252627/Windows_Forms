using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ1zad4
{
    public partial class Form1 : Form
    {
        private int count = 0;
        Point startPoint;
        Point endPoint;
        public Form1()
        {
            InitializeComponent();
            this.MouseDown += Form1_MouseDown;
            this.MouseUp += Form1_MouseUp;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                endPoint = e.Location;
                int x = 0;
                int y = 0;

                if (startPoint.X < endPoint.X)
                {
                    x = startPoint.X;
                }
                else
                {
                    x = endPoint.X;
                }

                if (startPoint.Y < endPoint.Y)
                {
                    y = startPoint.Y;
                }
                else
                {
                    y = endPoint.Y;
                }
                if (Math.Abs(endPoint.X - startPoint.X) < 10 && Math.Abs(endPoint.Y - startPoint.Y) < 10)
                {
                    MessageBox.Show("Создать статик не возможно размер меньше 10!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    count++;
                    Label m_label = new Label();
                    m_label.Location = new Point(x, y);
                    m_label.Size = new Size(Math.Abs(endPoint.X - startPoint.X), Math.Abs(endPoint.Y - startPoint.Y));
                    m_label.BackColor = Color.Gold;
                    m_label.TextAlign = ContentAlignment.TopCenter;
                    m_label.Text = count.ToString();
                    this.Controls.Add(m_label);
                    m_label.MouseClick += M_label_MouseClick;
                    m_label.MouseDoubleClick += M_label_MouseDoubleClick;
                }

            }
            else
            {
                MessageBox.Show("Создать статик можно только левой кнопкой!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void M_label_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int namber = count;
            if (e.Button == MouseButtons.Left)
            {
                foreach (Label item in Controls)
                {
                    Point locetion = item.PointToScreen(Point.Empty);
                    if (MousePosition.X > locetion.X && MousePosition.X < locetion.X + item.Width && MousePosition.Y > locetion.Y && MousePosition.Y < locetion.Y + item.Height)
                    {
                        if (namber > Convert.ToInt32(item.Text))
                        {
                            namber = Convert.ToInt32(item.Text);
                        }
                    }
                }
                foreach (Label item in Controls)
                {
                    if (namber.ToString().Equals(item.Text))
                    {
                        Text = $"«Статик» с номер №{item.Text} удалён!";
                        Controls.Remove(item);
                        item.MouseClick -= M_label_MouseClick;
                        item.MouseDoubleClick -= M_label_MouseDoubleClick;
                    }
                }
            }
        }

        private void M_label_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                foreach (Label item in Controls)
                {
                    Point locetion = item.PointToScreen(Point.Empty);
                    if (MousePosition.X > locetion.X && MousePosition.X < locetion.X + item.Width && MousePosition.Y > locetion.Y && MousePosition.Y < locetion.Y + item.Height)
                    {
                        this.Text = $"Номер № {item.Text} Площадь: {item.Width * item.Height} X = {item.Location.X} Y = {item.Location.Y}";
                    }
                }
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startPoint = e.Location;
            }
            else
            {
                MessageBox.Show("Создать статик можно только левой кнопкой!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
