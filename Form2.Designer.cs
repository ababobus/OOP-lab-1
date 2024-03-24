using System.Diagnostics.SymbolStore;
using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            dragon_pic = new PictureBox();
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            закрытьToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripSeparator2 = new ToolStripSeparator();
            Button_exit = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripComboBox1 = new ToolStripComboBox();
            toolStripSeparator3 = new ToolStripSeparator();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            timer_label = new Label();
            num1 = new NumericUpDown();
            button1 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dragon_pic).BeginInit();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num1).BeginInit();
            SuspendLayout();
            // 
            // dragon_pic
            // 
            dragon_pic.BackColor = Color.Transparent;
            dragon_pic.Image = Properties.Resources._1001637_847271;
            dragon_pic.Location = new Point(12, 141);
            dragon_pic.Name = "dragon_pic";
            dragon_pic.Size = new Size(166, 111);
            dragon_pic.SizeMode = PictureBoxSizeMode.StretchImage;
            dragon_pic.TabIndex = 0;
            dragon_pic.TabStop = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(12, 258);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 168);
            panel1.TabIndex = 1;
            panel1.Paint += Panel1_Paint;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(960, 33);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { закрытьToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(69, 29);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // закрытьToolStripMenuItem
            // 
            закрытьToolStripMenuItem.Image = (Image)resources.GetObject("закрытьToolStripMenuItem.Image");
            закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            закрытьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            закрытьToolStripMenuItem.Size = new Size(244, 34);
            закрытьToolStripMenuItem.Text = "Закрыть";
            закрытьToolStripMenuItem.Click += Button_exit_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSeparator2, Button_exit, toolStripSeparator1, toolStripComboBox1, toolStripSeparator3 });
            toolStrip1.Location = new Point(0, 33);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(960, 105);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 105);
            // 
            // Button_exit
            // 
            Button_exit.AutoSize = false;
            Button_exit.Font = new Font("Segoe UI", 16F, FontStyle.Italic, GraphicsUnit.Point);
            Button_exit.Image = (Image)resources.GetObject("Button_exit.Image");
            Button_exit.ImageTransparentColor = Color.Magenta;
            Button_exit.Name = "Button_exit";
            Button_exit.RightToLeft = RightToLeft.Yes;
            Button_exit.RightToLeftAutoMirrorImage = true;
            Button_exit.Size = new Size(100, 100);
            Button_exit.Text = "Выход";
            Button_exit.TextImageRelation = TextImageRelation.ImageAboveText;
            Button_exit.Click += Button_exit_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 105);
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            toolStripComboBox1.Items.AddRange(new object[] { "молоко", "яйца", "хлеб" });
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(200, 105);
            toolStripComboBox1.SelectedIndexChanged += toolStripComboBox1_SelectedIndexChanged;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.ForeColor = SystemColors.ControlText;
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 105);
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(740, 156);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 31);
            textBox1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(654, 211);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(276, 215);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // timer_label
            // 
            timer_label.AutoSize = true;
            timer_label.Location = new Point(272, 258);
            timer_label.Name = "timer_label";
            timer_label.Size = new Size(216, 25);
            timer_label.TabIndex = 8;
            timer_label.Text = "Чему равен факториал 0";
            // 
            // num1
            // 
            num1.Location = new Point(278, 297);
            num1.Name = "num1";
            num1.Size = new Size(180, 31);
            num1.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(493, 294);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 10;
            button1.Text = "проверить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Location = new Point(253, 182);
            label1.Name = "label1";
            label1.Size = new Size(352, 70);
            label1.TabIndex = 11;
            label1.Text = "Размер окна: 960 450";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 450);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(num1);
            Controls.Add(timer_label);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(toolStrip1);
            Controls.Add(panel1);
            Controls.Add(dragon_pic);
            Controls.Add(menuStrip1);
            Name = "Form2";
            Text = "Form2";
            SizeChanged += Form2_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)dragon_pic).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)num1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox dragon_pic;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem закрытьToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton Button_exit;
        private ToolStripComboBox toolStripComboBox1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator3;
        private Label timer_label;
        private NumericUpDown num1;
        private Button button1;
        private Label label1;
    }
}