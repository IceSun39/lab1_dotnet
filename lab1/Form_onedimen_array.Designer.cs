namespace lab1
{
    partial class Form_onedimen_array
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
            Number = new DataGridViewTextBoxColumn();
            s = new DataGridViewTextBoxColumn();
            label1 = new Label();
            textBox_time = new TextBox();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button_close
            // 
            button_close.Location = new Point(341, 387);
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Number, s });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(256, 398);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Number
            // 
            Number.HeaderText = "№";
            Number.Name = "Number";
            // 
            // s
            // 
            s.HeaderText = "Відстань";
            s.Name = "s";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(297, 26);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 2;
            label1.Text = "Час:";
            // 
            // textBox_time
            // 
            textBox_time.Location = new Point(333, 23);
            textBox_time.Name = "textBox_time";
            textBox_time.Size = new Size(100, 23);
            textBox_time.TabIndex = 3;
            textBox_time.Text = "10";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(439, 26);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 4;
            label2.Text = "секунд";
            // 
            // button1
            // 
            button1.Location = new Point(297, 76);
            button1.Name = "button1";
            button1.Size = new Size(86, 23);
            button1.TabIndex = 5;
            button1.Text = "Обрахувати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form_onedimen_array
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox_time);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button_close);
            Name = "Form_onedimen_array";
            Text = "Form_onedimen_array";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_close;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox_time;
        private Label label2;
        private Button button1;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn s;
    }
}