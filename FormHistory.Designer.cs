namespace WinFormsApp1
{
    partial class FormHistory
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
            components = new System.ComponentModel.Container();
            dataModelBindingSource = new BindingSource(components);
            DateStart = new DateTimePicker();
            dataGridView1 = new DataGridView();
            ExportButton = new Button();
            BackButton = new Button();
            label2History = new Label();
            outputTextHistory = new TextBox();
            folderBrowserDialogHistory = new FolderBrowserDialog();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataModelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataModelBindingSource
            // 
            dataModelBindingSource.DataSource = typeof(DataModel);
            // 
            // DateStart
            // 
            DateStart.Location = new Point(12, 68);
            DateStart.Name = "DateStart";
            DateStart.Size = new Size(227, 23);
            DateStart.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 199);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(960, 350);
            dataGridView1.TabIndex = 3;
            // 
            // ExportButton
            // 
            ExportButton.Location = new Point(12, 144);
            ExportButton.Name = "ExportButton";
            ExportButton.Size = new Size(129, 38);
            ExportButton.TabIndex = 4;
            ExportButton.Text = "Загрузить";
            ExportButton.UseVisualStyleBackColor = true;
            ExportButton.Click += button1_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(12, 12);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 5;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // label2History
            // 
            label2History.AutoSize = true;
            label2History.Location = new Point(12, 94);
            label2History.Name = "label2History";
            label2History.Size = new Size(217, 15);
            label2History.TabIndex = 15;
            label2History.Text = "Выберите папку для выгрузки файлов";
            // 
            // outputTextHistory
            // 
            outputTextHistory.Location = new Point(12, 115);
            outputTextHistory.Name = "outputTextHistory";
            outputTextHistory.Size = new Size(426, 23);
            outputTextHistory.TabIndex = 13;
            outputTextHistory.Text = "C:\\Users\\praktikant_dikt\\Desktop\\out";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 46);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 16;
            label1.Text = "Выберите дату";
            // 
            // FormHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(label1);
            Controls.Add(label2History);
            Controls.Add(outputTextHistory);
            Controls.Add(BackButton);
            Controls.Add(ExportButton);
            Controls.Add(dataGridView1);
            Controls.Add(DateStart);
            Name = "FormHistory";
            Text = "История";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataModelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource dataModelBindingSource;
        private DateTimePicker DateStart;
        private DataGridView dataGridView1;
        private Button ExportButton;
        private Button BackButton;
        private Label label2History;
        private TextBox outputTextHistory;
        private FolderBrowserDialog folderBrowserDialogHistory;
        private Label label1;
    }
}