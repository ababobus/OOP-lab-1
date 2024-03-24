namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button_ok = new Button();
            Label_button_ok = new Label();
            Label2_button_ok = new Label();
            Button_clear = new Button();
            TextBox1 = new TextBox();
            TextBox2 = new TextBox();
            ComboBox1 = new ComboBox();
            CheckBox1 = new CheckBox();
            CheckBox2 = new CheckBox();
            RadioButton1 = new RadioButton();
            RadioButton2 = new RadioButton();
            RadioButton3 = new RadioButton();
            TextBox3 = new TextBox();
            Btn_add = new Button();
            SuspendLayout();
            // 
            // Button_ok
            // 
            Button_ok.Location = new Point(35, 32);
            Button_ok.Name = "Button_ok";
            Button_ok.Size = new Size(112, 34);
            Button_ok.TabIndex = 1;
            Button_ok.Text = "OK";
            Button_ok.UseVisualStyleBackColor = true;
            Button_ok.Click += Button_ok_Click;
            // 
            // Label_button_ok
            // 
            Label_button_ok.AutoSize = true;
            Label_button_ok.Location = new Point(176, 32);
            Label_button_ok.Name = "Label_button_ok";
            Label_button_ok.Size = new Size(310, 25);
            Label_button_ok.TabIndex = 2;
            Label_button_ok.Text = "тут будет OK при событии button_ok\r\n";
            Label_button_ok.Visible = false;
            // 
            // Label2_button_ok
            // 
            Label2_button_ok.AutoSize = true;
            Label2_button_ok.Location = new Point(176, 85);
            Label2_button_ok.Name = "Label2_button_ok";
            Label2_button_ok.Size = new Size(51, 25);
            Label2_button_ok.TabIndex = 3;
            Label2_button_ok.Text = "OK 2";
            Label2_button_ok.Click += Button_ok_Click;
            // 
            // Button_clear
            // 
            Button_clear.Location = new Point(35, 80);
            Button_clear.Name = "Button_clear";
            Button_clear.Size = new Size(112, 34);
            Button_clear.TabIndex = 4;
            Button_clear.Text = "CLEAR";
            Button_clear.UseVisualStyleBackColor = true;
            Button_clear.MouseDown += Button_clear_MouseDown;
            // 
            // TextBox1
            // 
            TextBox1.Location = new Point(134, 141);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(150, 31);
            TextBox1.TabIndex = 5;
            TextBox1.TextChanged += TextBox_TextChanged;
            // 
            // TextBox2
            // 
            TextBox2.Location = new Point(350, 141);
            TextBox2.Name = "TextBox2";
            TextBox2.Size = new Size(150, 31);
            TextBox2.TabIndex = 6;
            TextBox2.TextChanged += TextBox_TextChanged;
            // 
            // ComboBox1
            // 
            ComboBox1.FormattingEnabled = true;
            ComboBox1.Items.AddRange(new object[] { "LOL", "KEK", "cCHEBYREK" });
            ComboBox1.Location = new Point(45, 216);
            ComboBox1.Name = "ComboBox1";
            ComboBox1.Size = new Size(182, 33);
            ComboBox1.TabIndex = 7;
            ComboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            ComboBox1.KeyDown += ComboBox1_KeyDown;
            // 
            // CheckBox1
            // 
            CheckBox1.AutoSize = true;
            CheckBox1.Location = new Point(45, 286);
            CheckBox1.Name = "CheckBox1";
            CheckBox1.Size = new Size(121, 29);
            CheckBox1.TabIndex = 8;
            CheckBox1.Text = "checkBox1";
            CheckBox1.UseVisualStyleBackColor = true;
            CheckBox1.CheckedChanged += CheckBox1_CheckedChanged;
            // 
            // CheckBox2
            // 
            CheckBox2.AutoSize = true;
            CheckBox2.Enabled = false;
            CheckBox2.Location = new Point(45, 325);
            CheckBox2.Name = "CheckBox2";
            CheckBox2.Size = new Size(121, 29);
            CheckBox2.TabIndex = 9;
            CheckBox2.Text = "checkBox2";
            CheckBox2.UseVisualStyleBackColor = true;
            // 
            // RadioButton1
            // 
            RadioButton1.AutoSize = true;
            RadioButton1.Location = new Point(214, 285);
            RadioButton1.Name = "RadioButton1";
            RadioButton1.Size = new Size(81, 29);
            RadioButton1.TabIndex = 10;
            RadioButton1.TabStop = true;
            RadioButton1.Text = "10:00";
            RadioButton1.UseVisualStyleBackColor = true;
            RadioButton1.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // RadioButton2
            // 
            RadioButton2.AutoSize = true;
            RadioButton2.Location = new Point(213, 320);
            RadioButton2.Name = "RadioButton2";
            RadioButton2.Size = new Size(81, 29);
            RadioButton2.TabIndex = 11;
            RadioButton2.TabStop = true;
            RadioButton2.Text = "12:00";
            RadioButton2.UseVisualStyleBackColor = true;
            RadioButton2.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // RadioButton3
            // 
            RadioButton3.AutoSize = true;
            RadioButton3.Location = new Point(213, 355);
            RadioButton3.Name = "RadioButton3";
            RadioButton3.Size = new Size(81, 29);
            RadioButton3.TabIndex = 12;
            RadioButton3.TabStop = true;
            RadioButton3.Text = "14:00";
            RadioButton3.UseVisualStyleBackColor = true;
            RadioButton3.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // TextBox3
            // 
            TextBox3.Enabled = false;
            TextBox3.Location = new Point(350, 318);
            TextBox3.Name = "TextBox3";
            TextBox3.Size = new Size(197, 31);
            TextBox3.TabIndex = 13;
            // 
            // Btn_add
            // 
            Btn_add.BackColor = Color.Green;
            Btn_add.Location = new Point(422, 198);
            Btn_add.Name = "Btn_add";
            Btn_add.Size = new Size(125, 85);
            Btn_add.TabIndex = 14;
            Btn_add.Text = "START";
            Btn_add.UseVisualStyleBackColor = false;
            Btn_add.Click += Btn_add_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(623, 434);
            Controls.Add(Btn_add);
            Controls.Add(TextBox3);
            Controls.Add(RadioButton3);
            Controls.Add(RadioButton2);
            Controls.Add(RadioButton1);
            Controls.Add(CheckBox2);
            Controls.Add(CheckBox1);
            Controls.Add(ComboBox1);
            Controls.Add(TextBox2);
            Controls.Add(TextBox1);
            Controls.Add(Button_clear);
            Controls.Add(Label2_button_ok);
            Controls.Add(Label_button_ok);
            Controls.Add(Button_ok);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Button_ok;
        private Label Label_button_ok;
        private Label Label2_button_ok;
        private Button Button_clear;
        private TextBox TextBox1;
        private TextBox TextBox2;
        private ComboBox ComboBox1;
        private CheckBox CheckBox1;
        private CheckBox CheckBox2;
        private RadioButton RadioButton1;
        private RadioButton RadioButton2;
        private RadioButton RadioButton3;
        private TextBox TextBox3;
        private Button Btn_add;
    }
}