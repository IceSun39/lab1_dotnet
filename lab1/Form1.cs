namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tabul tabul = new Tabul();
            double Xn, Xk, h, a;

            Xn = Convert.ToDouble(this.textBox_Xn.Text.Replace('.', ','));
            Xk = Convert.ToDouble(this.textBox_Xk.Text.Replace('.', ','));
            h = Convert.ToDouble(this.textBox_h.Text.Replace('.', ','));
            a = Convert.ToDouble(this.textBox_a.Text.Replace('.', ','));

            if (h <= 0)
            {
                MessageBox.Show("Крок повинен бути більше нуля!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridView1.Rows.Clear();
            chart1.Series[0].Points.Clear();
            tabul.Tabulate(Xn, Xk, h, a);

            for (int i = 0; i < tabul.n; i++)
            {
                dataGridView1.Rows.Add(
                    Math.Round(tabul.xy[i, 0], 2).ToString(),
                    Math.Round(tabul.xy[i, 1], 3).ToString()
                );
                chart1.Series[0].Points.AddXY(tabul.xy[i, 0], tabul.xy[i, 1]);
            }   
        }
    }
}
