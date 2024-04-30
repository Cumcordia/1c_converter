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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 95);
            button1.Name = "button1";
            button1.Size = new Size(159, 38);
            button1.TabIndex = 2;
            button1.Text = "Конвертировать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 23);
            textBox1.TabIndex = 4;
            textBox1.Text = "C:\\";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 48);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(239, 23);
            textBox2.TabIndex = 5;
            textBox2.Text = "C:\\";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 153);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(159, 285);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(178, 153);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(306, 285);
            richTextBox2.TabIndex = 7;
            richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(490, 153);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(298, 285);
            richTextBox3.TabIndex = 8;
            richTextBox3.Text = "";
            // 
            // button3
            // 
            button3.Location = new Point(257, 19);
            button3.Name = "button3";
            button3.Size = new Size(25, 23);
            button3.TabIndex = 9;
            button3.Text = "Конвертировать";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(257, 48);
            button4.Name = "button4";
            button4.Size = new Size(25, 23);
            button4.TabIndex = 10;
            button4.Text = "Конвертировать";
            button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(288, 23);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 11;
            label1.Text = "Входная папка";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(288, 51);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 12;
            label2.Text = "Выходная папка";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
    }
}
