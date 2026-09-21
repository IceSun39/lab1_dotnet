using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class lab2_task1 : Form
    {
        public lab2_task1()
        {
            InitializeComponent();
        }

        private void завдання1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lab2_task1 f = new lab2_task1();
            f.Show();
            this.Hide();
        }

        private void завдання2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lab2_task2 f = new lab2_task2();
            f.Show();
            this.Hide();
        }

        private void завдання3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lab2_task3 f = new lab2_task3();
            f.Show();
            this.Hide();
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            int num1, num2, num3;

            if (!int.TryParse(textBox_firstNum.Text, out num1) || 
                !int.TryParse(textBox_secondNum.Text, out num2) || 
                !int.TryParse(textBox_thirdNum.Text, out num3))
            {
                MessageBox.Show("Будь ласка, введіть дійсні цілі числа.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new ArgumentException("Invalid input: Please enter valid integers.");
            }

            lab2_task1_controller controller = new lab2_task1_controller(num1, num2, num3);
            controller.checkDivisionBy27();
            countLabel.Text = controller.count.ToString();
        }
    }
}
