using lab1.lab2;
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
    public partial class lab2_view : Form
    {
        public lab2_view()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form f = Application.OpenForms[0];
            f.Show();
            this.Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Form f = Application.OpenForms[0];
            f.Show();
            this.Close();
        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            int num1, num2;

            if(!int.TryParse(textBox_leftBoundary.Text, out num1) ||
                !int.TryParse(textBox_rigthBoundary.Text, out num2))
            {
                MessageBox.Show("Будь ласка, введіть дійсні цілі числа.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new ArgumentException("Invalid input: Please enter valid integers.");
            }

            lab2_task2_controller controller = new lab2_task2_controller(num1, num2);
            sumLabel.Text = controller.calculate().ToString();
        }
    }
}
