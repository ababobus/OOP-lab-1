using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int seconds = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            seconds = 10;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = seconds--.ToString();
            if (seconds < 0)
            {
                timer1.Stop();
                textBox1.Text = "n! = (n+1)!/(n+1)";
            }
            else
            {
                textBox1.Text = "loading...";
            }
        }

        private void Form3_Click(object sender, EventArgs e)
        {
            Button btn= new Button();
            btn.Text = "hello";
            btn.Location = PointToClient(Cursor.Position);
            btn.Click += my_btn_Click;
            Controls.Add(btn);

        }

        private void my_btn_Click(object sender, EventArgs e)
        {
            //Button btn2 = new Button();
            Controls.Remove(sender as Button);
        }
    }
}
