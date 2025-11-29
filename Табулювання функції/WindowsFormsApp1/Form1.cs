using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp1
{   public partial class Form1 : Form
    {
        private int FormShyr; 
        private int chartShyr;        
        public Form1()
        {
            InitializeComponent();
            FormShyr = this.Width;
            chartShyr = chart1.Width;
            chart1.Visible = false;
        }
        private void кінецьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void протабулюватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double h = Convert.ToDouble(textBox3.Text);
            double y;
            if (checkBox1.Checked)
            {
                listBox1.Items.Clear();
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                double minY = double.MaxValue;
                double maxY = double.MinValue;
                if (checkBox4.Checked)
                    listBox1.Items.Add("X\tY\tY'");
                else
                    listBox1.Items.Add("X\tY");
                for (double i = a; i <= b; i += h)
                {
                    y = Math.Sin(i) + 1;
                    minY = Math.Min(minY, y);
                    maxY = Math.Max(maxY, y);
                    if (checkBox4.Checked)
                    {
                        double y_ = Math.Cos(i);
                        minY = Math.Min(minY, y_);
                        maxY = Math.Max(maxY, y_);
                        listBox1.Items.Add($"{i:F2}\t{y:F2}\t{y_:F2}");
                        chart1.Series[0].Points.AddXY(i, y);
                        chart1.Series[1].Points.AddXY(i, y_);
                    }
                    else
                    {
                        listBox1.Items.Add($"{i:F2}\t{y:F2}");
                        chart1.Series[0].Points.AddXY(i, y);
                    }
                }
                listBox1.Items.Add($"min y: {minY:F2}");
                listBox1.Items.Add($"max y: {maxY:F2}");
            }
            if (checkBox2.Checked) 
            {
                using (StreamWriter func = new StreamWriter("result.txt"))
                {
                    double minY = double.MaxValue;
                    double maxY = double.MinValue;
                    func.WriteLine("X\tY");
                    for (double i = a; i <= b; i += h)
                    {
                        y = Math.Sin(i) + 1;
                        minY = Math.Min(minY, y);
                        maxY = Math.Max(maxY, y);
                        if (y > 0.5 && y < 1)
                            func.WriteLine($"{i:0.00}  {y:0.00}");
                    }
                    func.WriteLine();
                    func.WriteLine($"min y: {minY:0.00}");
                    func.WriteLine($"max y: {maxY:0.00}");
                }
                MessageBox.Show("Дані записані у файл result.txt.");
            }
            if (checkBox3.Checked)
            {
                int size = (int)((b - a) / h) + 1;
                double[] arr = new double[size];
                double x = a;
                for (int i = 0; i < size; i++)
                {
                    arr[i] = Math.Sin(x) + 1;
                    x += h;
                }
                вивідДанихЗМасивуToolStripMenuItem.Tag = arr;
            }
        }
        private void очиститиПолеВведенняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Виконав найпрекрасніший студент групи ПІ-231 Євчук Мішка :)");
        }
        private void знятиВсіПрапорціToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }
        private void встановитиВсіПрапорціToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            checkBox3.Checked = true;
            checkBox4.Checked = true;
        }
        private void встановитиІнверсивноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = !checkBox1.Checked;
            checkBox2.Checked = !checkBox2.Checked;
            checkBox3.Checked = !checkBox3.Checked;
            checkBox4.Checked = !checkBox4.Checked;
        }
        private void кінецьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void побудуватиГрафікToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart1.Visible = !chart1.Visible;
            if (chart1.Visible)
                this.Width = FormShyr + chartShyr; 
            else
                this.Width = FormShyr;
        }
        private void очиститиГрафікToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
        }
        private void вивідДанихЗМасивуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[] масив = (double[])вивідДанихЗМасивуToolStripMenuItem.Tag;

            if (масив != null)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Y");
                int count = 0;
                for (int i = 0; i < масив.Length; i++)
                {
                    double y = масив[i];
                    listBox1.Items.Add(y.ToString("F2"));
                    if (y > 0.5 && y < 1) count++;
                }
                listBox1.Items.Add("К-сть елементів > 0.5 та < 1: " + count);
            }
            else
            {
                MessageBox.Show("Немає збережених даних. Спочатку виконай табулювання 'У масив'.");
            }
        }
    }
}