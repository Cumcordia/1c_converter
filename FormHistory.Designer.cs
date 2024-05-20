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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);

            components = new System.ComponentModel.Container();
            DataGridView = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            convertDateAndTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fileOriginalNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fileConvertedNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataModelBindingSource = new BindingSource(components);
            DateStart = new DateTimePicker();
            DateEnd = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // DataGridView
            // 
            DataGridView.AutoGenerateColumns = false;
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, convertDateAndTimeDataGridViewTextBoxColumn, fileOriginalNameDataGridViewTextBoxColumn, fileConvertedNameDataGridViewTextBoxColumn });
            DataGridView.DataSource = dataModelBindingSource;
            DataGridView.Location = new Point(57, 94);
            DataGridView.Name = "DataGridView";
            DataGridView.Size = new Size(871, 416);
            DataGridView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // convertDateAndTimeDataGridViewTextBoxColumn
            // 
            convertDateAndTimeDataGridViewTextBoxColumn.DataPropertyName = "ConvertDateAndTime";
            convertDateAndTimeDataGridViewTextBoxColumn.HeaderText = "ConvertDateAndTime";
            convertDateAndTimeDataGridViewTextBoxColumn.Name = "convertDateAndTimeDataGridViewTextBoxColumn";
            // 
            // fileOriginalNameDataGridViewTextBoxColumn
            // 
            fileOriginalNameDataGridViewTextBoxColumn.DataPropertyName = "FileOriginalName";
            fileOriginalNameDataGridViewTextBoxColumn.HeaderText = "FileOriginalName";
            fileOriginalNameDataGridViewTextBoxColumn.Name = "fileOriginalNameDataGridViewTextBoxColumn";
            // 
            // fileConvertedNameDataGridViewTextBoxColumn
            // 
            fileConvertedNameDataGridViewTextBoxColumn.DataPropertyName = "FileConvertedName";
            fileConvertedNameDataGridViewTextBoxColumn.HeaderText = "FileConvertedName";
            fileConvertedNameDataGridViewTextBoxColumn.Name = "fileConvertedNameDataGridViewTextBoxColumn";
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
            // FormHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(DateEnd);
            Controls.Add(DateStart);
            Controls.Add(DataGridView);
            Name = "FormHistory";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataModelBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataGridView;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn convertDateAndTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fileOriginalNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fileConvertedNameDataGridViewTextBoxColumn;
        private BindingSource dataModelBindingSource;
        private DateTimePicker DateStart;
        private DateTimePicker DateEnd;
    }
}