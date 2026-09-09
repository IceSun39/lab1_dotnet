namespace lab1
{
    partial class Form_tabulate
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            label_Xn = new Label();
            label_Xk = new Label();
            label_h = new Label();
            label_a = new Label();
            textBox_Xn = new TextBox();
            textBox_a = new TextBox();
            textBox_h = new TextBox();
            textBox_Xk = new TextBox();
            button_evaluate = new Button();
            dataGridView1 = new DataGridView();
            x = new DataGridViewTextBoxColumn();
            y = new DataGridViewTextBoxColumn();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            menuStrip1 = new MenuStrip();
            роботаЗМасивамиToolStripMenuItem = new ToolStripMenuItem();
            одновимірніМасивиToolStripMenuItem = new ToolStripMenuItem();
            двовимірніМасивиToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label_Xn
            // 
            label_Xn.AutoSize = true;
            label_Xn.Location = new Point(12, 32);
            label_Xn.Name = "label_Xn";
            label_Xn.Size = new Size(21, 15);
            label_Xn.TabIndex = 0;
            label_Xn.Text = "Xn";
            label_Xn.Click += label1_Click;
            // 
            // label_Xk
            // 
            label_Xk.AutoSize = true;
            label_Xk.Location = new Point(73, 32);
            label_Xk.Name = "label_Xk";
            label_Xk.Size = new Size(20, 15);
            label_Xk.TabIndex = 1;
            label_Xk.Text = "Xk";
            label_Xk.Click += label2_Click;
            // 
            // label_h
            // 
            label_h.AutoSize = true;
            label_h.Location = new Point(134, 32);
            label_h.Name = "label_h";
            label_h.Size = new Size(14, 15);
            label_h.TabIndex = 2;
            label_h.Text = "h";
            label_h.Click += label1_Click_1;
            // 
            // label_a
            // 
            label_a.AutoSize = true;
            label_a.Location = new Point(195, 32);
            label_a.Name = "label_a";
            label_a.Size = new Size(13, 15);
            label_a.TabIndex = 3;
            label_a.Text = "a";
            label_a.Click += label1_Click_2;
            // 
            // textBox_Xn
            // 
            textBox_Xn.Location = new Point(12, 50);
            textBox_Xn.Name = "textBox_Xn";
            textBox_Xn.Size = new Size(55, 23);
            textBox_Xn.TabIndex = 5;
            textBox_Xn.Text = "-5.55";
            // 
            // textBox_a
            // 
            textBox_a.Location = new Point(195, 50);
            textBox_a.Name = "textBox_a";
            textBox_a.Size = new Size(55, 23);
            textBox_a.TabIndex = 6;
            textBox_a.Text = "5";
            // 
            // textBox_h
            // 
            textBox_h.Location = new Point(134, 50);
            textBox_h.Name = "textBox_h";
            textBox_h.Size = new Size(55, 23);
            textBox_h.TabIndex = 7;
            textBox_h.Text = "0.1";
            // 
            // textBox_Xk
            // 
            textBox_Xk.Location = new Point(73, 50);
            textBox_Xk.Name = "textBox_Xk";
            textBox_Xk.Size = new Size(55, 23);
            textBox_Xk.TabIndex = 8;
            textBox_Xk.Text = "10.33";
            // 
            // button_evaluate
            // 
            button_evaluate.Location = new Point(319, 50);
            button_evaluate.Name = "button_evaluate";
            button_evaluate.Size = new Size(99, 24);
            button_evaluate.TabIndex = 9;
            button_evaluate.Text = "Розрахувати";
            button_evaluate.UseVisualStyleBackColor = true;
            button_evaluate.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { x, y });
            dataGridView1.Location = new Point(12, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(238, 368);
            dataGridView1.TabIndex = 10;
            // 
            // x
            // 
            x.HeaderText = "x";
            x.Name = "x";
            // 
            // y
            // 
            y.HeaderText = "y";
            y.Name = "y";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(319, 80);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(469, 367);
            chart1.TabIndex = 11;
            chart1.Text = "chart1";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { роботаЗМасивамиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // роботаЗМасивамиToolStripMenuItem
            // 
            роботаЗМасивамиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { одновимірніМасивиToolStripMenuItem, двовимірніМасивиToolStripMenuItem });
            роботаЗМасивамиToolStripMenuItem.Name = "роботаЗМасивамиToolStripMenuItem";
            роботаЗМасивамиToolStripMenuItem.Size = new Size(125, 20);
            роботаЗМасивамиToolStripMenuItem.Text = "Робота з масивами";
            // 
            // одновимірніМасивиToolStripMenuItem
            // 
            одновимірніМасивиToolStripMenuItem.Name = "одновимірніМасивиToolStripMenuItem";
            одновимірніМасивиToolStripMenuItem.Size = new Size(189, 22);
            одновимірніМасивиToolStripMenuItem.Text = "Одновимірні масиви";
            одновимірніМасивиToolStripMenuItem.Click += одновимірніМасивиToolStripMenuItem_Click;
            // 
            // двовимірніМасивиToolStripMenuItem
            // 
            двовимірніМасивиToolStripMenuItem.Name = "двовимірніМасивиToolStripMenuItem";
            двовимірніМасивиToolStripMenuItem.Size = new Size(189, 22);
            двовимірніМасивиToolStripMenuItem.Text = "Двовимірні масиви";
            двовимірніМасивиToolStripMenuItem.Click += двовимірніМасивиToolStripMenuItem_Click;
            // 
            // Form_tabulate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 477);
            Controls.Add(chart1);
            Controls.Add(dataGridView1);
            Controls.Add(button_evaluate);
            Controls.Add(textBox_Xk);
            Controls.Add(textBox_h);
            Controls.Add(textBox_a);
            Controls.Add(textBox_Xn);
            Controls.Add(label_a);
            Controls.Add(label_h);
            Controls.Add(label_Xk);
            Controls.Add(label_Xn);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form_tabulate";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Xn;
        private Label label_Xk;
        private Label label_h;
        private Label label_a;
        private TextBox textBox_Xn;
        private TextBox textBox_a;
        private TextBox textBox_h;
        private TextBox textBox_Xk;
        private Button button_evaluate;
        private DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private DataGridViewTextBoxColumn x;
        private DataGridViewTextBoxColumn y;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem роботаЗМасивамиToolStripMenuItem;
        private ToolStripMenuItem одновимірніМасивиToolStripMenuItem;
        private ToolStripMenuItem двовимірніМасивиToolStripMenuItem;
    }
}
