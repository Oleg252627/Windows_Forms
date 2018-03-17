using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ1zad5
{
    public partial class Form1 : Form
    {
        private Label m_label;
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.MouseMove += Form1_MouseMove;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.X > m_label.Location.X - 20 && e.X < m_label.Location.X + m_label.Width + 20) && (e.Y > m_label.Location.Y - 20 && e.Y < m_label.Location.Y + m_label.Height + 20))
            {
                if (e.X > m_label.Location.X - 20 && e.X < m_label.Location.X)//движение курсора с лева по оси Х
                {
                    m_label.Left += 10;
                }
                else if(e.X < m_label.Location.X + m_label.Width + 20 && e.X > m_label.Location.X + m_label.Width) //движение курсора с право по оси Х
                {
                    m_label.Left -= 10;
                }
                else if(e.Y>m_label.Location.Y-20 && e.Y<m_label.Location.Y) //движение с верху по оси Y
                {
                    m_label.Top += 10;
                }
                else if(e.Y < m_label.Location.Y + m_label.Height +20 && e.Y>m_label.Location.Y+m_label.Height) //движение с низу по оси Y
                {
                    m_label.Top -= 10;
                }
                if(m_label.Location.X < 0|| m_label.Location.X > this.ClientSize.Width - m_label.Width|| m_label.Location.Y<0|| m_label.Location.Y>this.ClientSize.Height-m_label.Height) //проверка на граници формы
                {
                    m_label.Location = new Point(260, 130);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Догони Олега!";
            m_label = new Label();
            this.Controls.Add(m_label);
            m_label.BorderStyle = BorderStyle.FixedSingle;
            m_label.Text = "Олег";
            m_label.Location = new Point(260,130);
            m_label.Size = new Size(100, 60);
            m_label.BackColor = Color.Blue;
            m_label.ForeColor = Color.White;
            m_label.TextAlign = ContentAlignment.MiddleCenter;
        }
    }
}
