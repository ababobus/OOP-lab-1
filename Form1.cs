namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_ok_Click(object sender, EventArgs e)
        {
            Label_button_ok.Text = "OK";
            Label_button_ok.Visible = true;
        }

        private void Button_clear_MouseDown(object sender, MouseEventArgs e)
        {
            Label_button_ok.Text = "";
        }

        private void TextBox_TextChanged(object sender, EventArgs e) //ссылка на объект и сам объект
        {
            TextBox t_box = (TextBox) sender; 
            if (t_box == TextBox1)
            {
                TextBox2.BackColor = Color.Red;
            }
            else if (t_box == TextBox2)
            {
                TextBox1.BackColor = Color.Green;
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int myIndex = ComboBox1.SelectedIndex;
            string myValue = ComboBox1.Text;
            MessageBox.Show("Выбранное значение: " + myValue);
        }

        private void ComboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                string inputText = ComboBox1.Text;
                if (ComboBox1.Items.Contains(inputText))
                {
                    MessageBox.Show("Выбранное значение: " + inputText);
                }
                else
                {
                    MessageBox.Show("Нет такого значения! :(");
                }
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                CheckBox2.Enabled = true;
            }
            else
            {
                CheckBox2.Checked = false;
                CheckBox2.Enabled = false;
            }

        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton1.Checked)
            {
                TextBox3.Text = "Time 10:00 chosen";
            }
            else if (RadioButton2.Checked)
            {
                TextBox3.Text = "Time 12:00 chosen";
            }
            else if (RadioButton3.Checked)
            {
                TextBox3.Text = "Time 14:00 chosen";
            }
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
}