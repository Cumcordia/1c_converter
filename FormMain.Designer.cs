namespace WinFormsApp1
{
    public partial class FormMain
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
            inputText = new TextBox();
            outputText = new TextBox();
            textBoxFolder = new RichTextBox();
            textBoxOriginal = new RichTextBox();
            textBoxResult = new RichTextBox();
            inputButton = new Button();
            outputButton = new Button();
            label1 = new Label();
            label2 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog2 = new FolderBrowserDialog();
            folderBrowserDialog3 = new FolderBrowserDialog();
            folderBrowserDialog4 = new FolderBrowserDialog();
            convertButton = new Button();
            menuStrip1 = new MenuStrip();
            MenuToolStripMenuItem = new ToolStripMenuItem();
            AboutToolStripMenuItem = new ToolStripMenuItem();
            ExitToolStripMenuItem = new ToolStripMenuItem();
            HistoryToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // inputText
            // 
            inputText.Location = new Point(12, 27);
            inputText.Name = "inputText";
            inputText.Size = new Size(426, 23);
            inputText.TabIndex = 4;
            inputText.Text = "C:\\Users\\praktikant_dikt\\Desktop\\in";
            // 
            // outputText
            // 
            outputText.Location = new Point(12, 56);
            outputText.Name = "outputText";
            outputText.Size = new Size(426, 23);
            outputText.TabIndex = 5;
            outputText.Text = "C:\\Users\\praktikant_dikt\\Desktop\\out";
            // 
            // textBoxFolder
            // 
            textBoxFolder.Location = new Point(12, 153);
            textBoxFolder.Name = "textBoxFolder";
            textBoxFolder.Size = new Size(159, 388);
            textBoxFolder.TabIndex = 6;
            textBoxFolder.Text = "";
            // 
            // textBoxOriginal
            // 
            textBoxOriginal.Location = new Point(177, 153);
            textBoxOriginal.Name = "textBoxOriginal";
            textBoxOriginal.Size = new Size(385, 388);
            textBoxOriginal.TabIndex = 7;
            textBoxOriginal.Text = "";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(568, 153);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(396, 388);
            textBoxResult.TabIndex = 8;
            textBoxResult.Text = "";
            // 
            // inputButton
            // 
            inputButton.Location = new Point(444, 26);
            inputButton.Name = "inputButton";
            inputButton.Size = new Size(25, 23);
            inputButton.TabIndex = 9;
            inputButton.UseVisualStyleBackColor = true;
            inputButton.Click += inputButton_Click;
            // 
            // outputButton
            // 
            outputButton.Location = new Point(444, 55);
            outputButton.Name = "outputButton";
            outputButton.Size = new Size(25, 23);
            outputButton.TabIndex = 10;
            outputButton.UseVisualStyleBackColor = true;
            outputButton.Click += outputButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(475, 30);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 11;
            label1.Text = "Входная папка";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(475, 58);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 12;
            label2.Text = "Выходная папка";
            // 
            // convertButton
            // 
            convertButton.Location = new Point(12, 91);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(159, 38);
            convertButton.TabIndex = 13;
            convertButton.Text = "Конвертировать";
            convertButton.UseVisualStyleBackColor = true;
            convertButton.Click += convertButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuToolStripMenuItem, HistoryToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(984, 24);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // MenuToolStripMenuItem
            // 
            MenuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AboutToolStripMenuItem, ExitToolStripMenuItem });
            MenuToolStripMenuItem.Name = "MenuToolStripMenuItem";
            MenuToolStripMenuItem.Size = new Size(53, 20);
            MenuToolStripMenuItem.Text = "Меню";
            // 
            // AboutToolStripMenuItem
            // 
            AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            AboutToolStripMenuItem.Size = new Size(149, 22);
            AboutToolStripMenuItem.Text = "О программе";
            AboutToolStripMenuItem.Click += AboutToolStripMenuItem_Click;
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.Size = new Size(149, 22);
            ExitToolStripMenuItem.Text = "Выход";
            ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // HistoryToolStripMenuItem
            // 
            HistoryToolStripMenuItem.Name = "HistoryToolStripMenuItem";
            HistoryToolStripMenuItem.Size = new Size(66, 20);
            HistoryToolStripMenuItem.Text = "История";
            HistoryToolStripMenuItem.Click += HistoryToolStripMenuItem_Click_1;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(convertButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(outputButton);
            Controls.Add(inputButton);
            Controls.Add(textBoxResult);
            Controls.Add(textBoxOriginal);
            Controls.Add(textBoxFolder);
            Controls.Add(outputText);
            Controls.Add(inputText);
            Controls.Add(menuStrip1);
            Name = "FormMain";
            Text = "1c-mt-100";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox inputText;
        private TextBox outputText;
        private Button inputButton;
        private Button outputButton;
        private Label label1;
        private Label label2;
        private FolderBrowserDialog folderBrowserDialog1;
        private FolderBrowserDialog folderBrowserDialog2;
        private FolderBrowserDialog folderBrowserDialog3;
        private FolderBrowserDialog folderBrowserDialog4;
        private Button convertButton;
        public RichTextBox textBoxFolder;
        public RichTextBox textBoxOriginal;
        public RichTextBox textBoxResult;
        public RichTextBox test1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuToolStripMenuItem;
        private ToolStripMenuItem AboutToolStripMenuItem;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private ToolStripMenuItem HistoryToolStripMenuItem;
    }
}
