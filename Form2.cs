using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen bluePen = new Pen(Color.Blue, 5);
            int x = 3;//граница пополам
            int y = 3;
            int width = 20;
            int height = 40;
            g.DrawRectangle(bluePen, x, y, width, height);

            g.FillEllipse(Brushes.Yellow, 50, 40, 100, 100); //большая и малая оси эллипса
            g.FillEllipse(Brushes.Black, 70, 60, 25, 15);
            g.FillEllipse(Brushes.Black, 115, 60, 15, 15);
            g.DrawArc(Pens.Red, 70, 60, 60, 60, 0, 180);
            //Pen smilePen = new Pen(Color.Red, 3);
            //g.DrawArc(smilePen, x, y, width, height, angle1, angle2);

        }

        private void Form2_SizeChanged(object sender, EventArgs e)
        {
            label1.Text = "Размер окна: " + ClientSize.Width.ToString() + " " + ClientSize.Height.ToString();
        }

        private void Button_exit_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Выйти из формы 2", "?", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                Close();
            }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox1.SelectedItem.ToString() == "молоко")
            {
                textBox1.Text = "70";
            }
            if (toolStripComboBox1.SelectedItem.ToString() == "яйца")
            {
                textBox1.Text = "150";
            }
            if (toolStripComboBox1.SelectedItem.ToString() == "хлеб")
            {
                textBox1.Text = "40";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (num1.Value == 1)
            {
                Form3 frm3 = new Form3();
                frm3.Show();
            }
        }
    }
}
