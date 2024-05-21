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
            DateEnd = new DateTimePicker();
            dataGridView1 = new DataGridView();
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
            DateStart.Location = new Point(57, 39);
            DateStart.Name = "DateStart";
            DateStart.Size = new Size(227, 23);
            DateStart.TabIndex = 1;
            // 
            // DateEnd
            // 
            DateEnd.Location = new Point(339, 39);
            DateEnd.Name = "DateEnd";
            DateEnd.Size = new Size(227, 23);
            DateEnd.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(57, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(857, 421);
            dataGridView1.TabIndex = 3;
            // 
            // FormHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(dataGridView1);
            Controls.Add(DateEnd);
            Controls.Add(DateStart);
            Name = "FormHistory";
            Text = "Form1";
            Load += Form1_Load;
            FormClosed += Form1_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dataModelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource dataModelBindingSource;
        private DateTimePicker DateStart;
        private DateTimePicker DateEnd;
        private DataGridView dataGridView1;
    }
}