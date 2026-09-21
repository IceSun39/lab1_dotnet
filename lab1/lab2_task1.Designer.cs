namespace lab1
{
    partial class lab2_task1
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
            textBox_thirdNum = new TextBox();
            textBox_secondNum = new TextBox();
            textBox_firstNum = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            лабораторнаРобToolStripMenuItem = new ToolStripMenuItem();
            завдання1ToolStripMenuItem = new ToolStripMenuItem();
            завдання2ToolStripMenuItem = new ToolStripMenuItem();
            завдання3ToolStripMenuItem = new ToolStripMenuItem();
            label4 = new Label();
            countLabel = new Label();
            countButton = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox_thirdNum
            // 
            textBox_thirdNum.Location = new Point(128, 116);
            textBox_thirdNum.Name = "textBox_thirdNum";
            textBox_thirdNum.Size = new Size(100, 23);
            textBox_thirdNum.TabIndex = 11;
            // 
            // textBox_secondNum
            // 
            textBox_secondNum.Location = new Point(128, 77);
            textBox_secondNum.Name = "textBox_secondNum";
            textBox_secondNum.Size = new Size(100, 23);
            textBox_secondNum.TabIndex = 10;
            // 
            // textBox_firstNum
            // 
            textBox_firstNum.Location = new Point(128, 34);
            textBox_firstNum.Name = "textBox_firstNum";
            textBox_firstNum.Size = new Size(100, 23);
            textBox_firstNum.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 116);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 8;
            label3.Text = "Третє число";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 77);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 7;
            label2.Text = "Друге число";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 37);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 6;
            label1.Text = "Перше число";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { лабораторнаРобToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // лабораторнаРобToolStripMenuItem
            // 
            лабораторнаРобToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { завдання1ToolStripMenuItem, завдання2ToolStripMenuItem, завдання3ToolStripMenuItem });
            лабораторнаРобToolStripMenuItem.Name = "лабораторнаРобToolStripMenuItem";
            лабораторнаРобToolStripMenuItem.Size = new Size(156, 20);
            лабораторнаРобToolStripMenuItem.Text = "Лабораторна робота №2";
            // 
            // завдання1ToolStripMenuItem
            // 
            завдання1ToolStripMenuItem.Name = "завдання1ToolStripMenuItem";
            завдання1ToolStripMenuItem.Size = new Size(134, 22);
            завдання1ToolStripMenuItem.Text = "Завдання 1";
            завдання1ToolStripMenuItem.Click += завдання1ToolStripMenuItem_Click;
            // 
            // завдання2ToolStripMenuItem
            // 
            завдання2ToolStripMenuItem.Name = "завдання2ToolStripMenuItem";
            завдання2ToolStripMenuItem.Size = new Size(134, 22);
            завдання2ToolStripMenuItem.Text = "Завдання 2";
            завдання2ToolStripMenuItem.Click += завдання2ToolStripMenuItem_Click;
            // 
            // завдання3ToolStripMenuItem
            // 
            завдання3ToolStripMenuItem.Name = "завдання3ToolStripMenuItem";
            завдання3ToolStripMenuItem.Size = new Size(134, 22);
            завдання3ToolStripMenuItem.Text = "Завдання 3";
            завдання3ToolStripMenuItem.Click += завдання3ToolStripMenuItem_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 155);
            label4.Name = "label4";
            label4.Size = new Size(120, 15);
            label4.TabIndex = 13;
            label4.Text = "Кількість кратних 27:";
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Location = new Point(165, 155);
            countLabel.Name = "countLabel";
            countLabel.Size = new Size(22, 15);
            countLabel.TabIndex = 14;
            countLabel.Text = "---";
            // 
            // countButton
            // 
            countButton.Location = new Point(39, 184);
            countButton.Name = "countButton";
            countButton.Size = new Size(83, 23);
            countButton.TabIndex = 15;
            countButton.Text = "Обрахувати";
            countButton.UseVisualStyleBackColor = true;
            countButton.Click += countButton_Click;
            // 
            // lab2_task1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(countButton);
            Controls.Add(countLabel);
            Controls.Add(label4);
            Controls.Add(textBox_thirdNum);
            Controls.Add(textBox_secondNum);
            Controls.Add(textBox_firstNum);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "lab2_task1";
            Text = "lab2_task1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_thirdNum;
        private TextBox textBox_secondNum;
        private TextBox textBox_firstNum;
        private Label label3;
        private Label label2;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem лабораторнаРобToolStripMenuItem;
        private ToolStripMenuItem завдання1ToolStripMenuItem;
        private ToolStripMenuItem завдання2ToolStripMenuItem;
        private ToolStripMenuItem завдання3ToolStripMenuItem;
        private Label label4;
        private Label countLabel;
        private Button countButton;
    }
}