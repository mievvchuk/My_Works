namespace PR_22
{
    public partial class обмін : Form
    {
        public обмін()
        {
            InitializeComponent();
            toolTip3.SetToolTip(textBox5, "Введіть значення у кілометрах");
            toolTip3.SetToolTip(textBox6, "Результат у милях");
        }
        private void label1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton2.Checked = true;
                label1.ForeColor = Color.Red;
            }
            else
            {
                radioButton1.Checked = true;
                label1.ForeColor = Color.Purple;
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label1.Text = "⇦";
            }
            if (radioButton2.Checked)
            {
                label1.Text = "⇨";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);
            double d = 0;
            if (radioButton1.Checked)
            {
                d = a * b;
            }
            else if (radioButton2.Checked)
            {
                d = b * c;
            }
            textBox4.Text = d.ToString("F2");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox4.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "⇦";
            label6.Text = "Кілометри";
            label5.Text = "Милі";
            toolTip3.SetToolTip(textBox5, "Введіть значення у милях");
            toolTip3.SetToolTip(textBox6, "Результат у кілометрах");
        }
        private void label7_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                radioButton4.Checked = true;
                label7.ForeColor = Color.Red;
            }
            else
            {
                radioButton3.Checked = true;
                label7.ForeColor = Color.Purple;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            double g = Convert.ToDouble(textBox5.Text);
            double rez = 0;
            if (!radioButton5.Checked && !radioButton6.Checked)
            {
                return;
            }
            if (radioButton4.Checked)
            {

                if (radioButton5.Checked)
                {
                    rez = g * 0.621;
                }
                else
                {
                    rez = g * 0.539956;
                }
                textBox6.Text = rez.ToString("F2");
            }
            else if (radioButton3.Checked)
            {
                label7.Text = "⇦";
                if (radioButton5.Checked)
                {
                    rez = g * 1.609344;
                }
                else
                {
                    rez = g * 1.852;
                }
                textBox6.Text = rez.ToString("F2");
            }

        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            textBox6.Clear();
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "⇨";
            label6.Text = "Милі";
            label5.Text = "Кілометри";

            toolTip3.SetToolTip(textBox5, "Введіть значення у кілометрах");
            toolTip3.SetToolTip(textBox6, "Результат у милях");

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.Clear();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.Clear();
        }
    }
}
