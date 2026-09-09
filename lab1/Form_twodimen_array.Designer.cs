namespace lab1
{
    partial class Form_twodimen_array
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
            button_close = new Button();
            dataGridView1 = new DataGridView();
            label_rows = new Label();
            labe_rows = new Label();
            textBox_rows = new TextBox();
            textBox_cols = new TextBox();
            button_draw_matrix = new Button();
            button_find_duplicate = new Button();
            label1 = new Label();
            label_result = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button_close
            // 
            button_close.Location = new Point(387, 394);
            button_close.Name = "button_close";
            button_close.Size = new Size(75, 23);
            button_close.TabIndex = 0;
            button_close.Text = "Закрити";
            button_close.UseVisualStyleBackColor = true;
            button_close.Click += button_close_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(355, 373);
            dataGridView1.TabIndex = 1;
            // 
            // label_rows
            // 
            label_rows.AutoSize = true;
            label_rows.Location = new Point(387, 37);
            label_rows.Name = "label_rows";
            label_rows.Size = new Size(39, 15);
            label_rows.TabIndex = 2;
            label_rows.Text = "Рядки";
            // 
            // labe_rows
            // 
            labe_rows.AutoSize = true;
            labe_rows.Location = new Point(387, 82);
            labe_rows.Name = "labe_rows";
            labe_rows.Size = new Size(50, 15);
            labe_rows.TabIndex = 3;
            labe_rows.Text = "Стовпці";
            labe_rows.Click += label2_Click;
            // 
            // textBox_rows
            // 
            textBox_rows.Location = new Point(443, 37);
            textBox_rows.Name = "textBox_rows";
            textBox_rows.Size = new Size(100, 23);
            textBox_rows.TabIndex = 4;
            textBox_rows.Text = "3";
            // 
            // textBox_cols
            // 
            textBox_cols.Location = new Point(443, 79);
            textBox_cols.Name = "textBox_cols";
            textBox_cols.Size = new Size(100, 23);
            textBox_cols.TabIndex = 5;
            textBox_cols.Text = "5";
            // 
            // button_draw_matrix
            // 
            button_draw_matrix.Location = new Point(387, 125);
            button_draw_matrix.Name = "button_draw_matrix";
            button_draw_matrix.Size = new Size(75, 23);
            button_draw_matrix.TabIndex = 6;
            button_draw_matrix.Text = "Оновити масив";
            button_draw_matrix.UseVisualStyleBackColor = true;
            // 
            // button_find_duplicate
            // 
            button_find_duplicate.Location = new Point(480, 125);
            button_find_duplicate.Name = "button_find_duplicate";
            button_find_duplicate.Size = new Size(131, 23);
            button_find_duplicate.TabIndex = 7;
            button_find_duplicate.Text = "Найти дублікат";
            button_find_duplicate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(387, 172);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 8;
            label1.Text = "Результат:";
            // 
            // label_result
            // 
            label_result.AutoSize = true;
            label_result.Location = new Point(456, 172);
            label_result.Name = "label_result";
            label_result.Size = new Size(0, 15);
            label_result.TabIndex = 9;
            label_result.Click += label2_Click_1;
            // 
            // Form_twodimen_array
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_result);
            Controls.Add(label1);
            Controls.Add(button_find_duplicate);
            Controls.Add(button_draw_matrix);
            Controls.Add(textBox_cols);
            Controls.Add(textBox_rows);
            Controls.Add(labe_rows);
            Controls.Add(label_rows);
            Controls.Add(dataGridView1);
            Controls.Add(button_close);
            Name = "Form_twodimen_array";
            Text = "Form_twodimen_array";
            Load += Form_twodimen_array_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_close;
        private DataGridView dataGridView1;
        private Label label_rows;
        private Label labe_rows;
        private TextBox textBox_rows;
        private TextBox textBox_cols;
        private Button button_draw_matrix;
        private Button button_find_duplicate;
        private Label label1;
        private Label label_result;
    }
}