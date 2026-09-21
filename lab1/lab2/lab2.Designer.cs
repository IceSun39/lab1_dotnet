namespace lab1
{
    partial class lab2_view
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            countButton = new Button();
            countLabel = new Label();
            label6 = new Label();
            textBox_thirdNum = new TextBox();
            textBox_secondNum = new TextBox();
            textBox_firstNum = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            label1 = new Label();
            label2 = new Label();
            textBox_leftBoundary = new TextBox();
            textBox_rigthBoundary = new TextBox();
            returnToFirstLab = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(1, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(431, 301);
            tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(returnToFirstLab);
            tabPage1.Controls.Add(countButton);
            tabPage1.Controls.Add(countLabel);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(textBox_thirdNum);
            tabPage1.Controls.Add(textBox_secondNum);
            tabPage1.Controls.Add(textBox_firstNum);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label9);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(423, 273);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Завдання 1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // countButton
            // 
            countButton.Location = new Point(46, 161);
            countButton.Name = "countButton";
            countButton.Size = new Size(83, 23);
            countButton.TabIndex = 24;
            countButton.Text = "Обрахувати";
            countButton.UseVisualStyleBackColor = true;
            countButton.Click += button1_Click;
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Location = new Point(172, 132);
            countLabel.Name = "countLabel";
            countLabel.Size = new Size(22, 15);
            countLabel.TabIndex = 23;
            countLabel.Text = "---";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 132);
            label6.Name = "label6";
            label6.Size = new Size(120, 15);
            label6.TabIndex = 22;
            label6.Text = "Кількість кратних 27:";
            // 
            // textBox_thirdNum
            // 
            textBox_thirdNum.Location = new Point(135, 93);
            textBox_thirdNum.Name = "textBox_thirdNum";
            textBox_thirdNum.Size = new Size(100, 23);
            textBox_thirdNum.TabIndex = 21;
            // 
            // textBox_secondNum
            // 
            textBox_secondNum.Location = new Point(135, 54);
            textBox_secondNum.Name = "textBox_secondNum";
            textBox_secondNum.Size = new Size(100, 23);
            textBox_secondNum.TabIndex = 20;
            // 
            // textBox_firstNum
            // 
            textBox_firstNum.Location = new Point(135, 11);
            textBox_firstNum.Name = "textBox_firstNum";
            textBox_firstNum.Size = new Size(100, 23);
            textBox_firstNum.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 93);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 18;
            label7.Text = "Третє число";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(46, 54);
            label8.Name = "label8";
            label8.Size = new Size(76, 15);
            label8.TabIndex = 17;
            label8.Text = "Друге число";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(46, 14);
            label9.Name = "label9";
            label9.Size = new Size(83, 15);
            label9.TabIndex = 16;
            label9.Text = "Перше число";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(textBox_rigthBoundary);
            tabPage2.Controls.Add(textBox_leftBoundary);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(423, 273);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Завдання 2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(423, 273);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Завдання 3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 19);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "Перше число";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 48);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 1;
            label2.Text = "Друге число";
            // 
            // textBox_leftBoundary
            // 
            textBox_leftBoundary.Location = new Point(96, 16);
            textBox_leftBoundary.Name = "textBox_leftBoundary";
            textBox_leftBoundary.Size = new Size(100, 23);
            textBox_leftBoundary.TabIndex = 2;
            // 
            // textBox_rigthBoundary
            // 
            textBox_rigthBoundary.Location = new Point(96, 45);
            textBox_rigthBoundary.Name = "textBox_rigthBoundary";
            textBox_rigthBoundary.Size = new Size(100, 23);
            textBox_rigthBoundary.TabIndex = 3;
            // 
            // returnToFirstLab
            // 
            returnToFirstLab.Location = new Point(175, 222);
            returnToFirstLab.Name = "returnToFirstLab";
            returnToFirstLab.Size = new Size(75, 23);
            returnToFirstLab.TabIndex = 25;
            returnToFirstLab.Text = "Закрити";
            returnToFirstLab.UseVisualStyleBackColor = true;
            returnToFirstLab.Click += button1_Click_1;
            // 
            // lab2_view
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 304);
            Controls.Add(tabControl1);
            Name = "lab2_view";
            Text = "lab2_task1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button countButton;
        private Label countLabel;
        private Label label6;
        private TextBox textBox_thirdNum;
        private TextBox textBox_secondNum;
        private TextBox textBox_firstNum;
        private Label label7;
        private Label label8;
        private Label label9;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TextBox textBox_rigthBoundary;
        private TextBox textBox_leftBoundary;
        private Label label2;
        private Label label1;
        private Button returnToFirstLab;
    }
}