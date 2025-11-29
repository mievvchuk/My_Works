using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PR_5
{
    public partial class Form1 : Form
    {
        bool Drow;
        private Bitmap bmp_for_draw;
        private Point start_point;
        private bool Draw;
        private Pen pen_for_draw = new Pen(Color.Black, 4);
        private string full_name_of_image;
        private Color selectedFillColor = Color.LimeGreen;
        public Form1()
        {
            InitializeComponent();
            ToolTip toolTip1 = new ToolTip();
            pen_for_draw.StartCap = pen_for_draw.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            toolTip1.AutoPopDelay = 5000; 
            toolTip1.InitialDelay = 500;  
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;   
            toolTip1.SetToolTip(textBox1, "Введи X координату початку");
            toolTip1.SetToolTip(textBox2, "Введи Y координату початку");
            toolTip1.SetToolTip(textBox3, "Введи X координату кінця");
            toolTip1.SetToolTip(textBox4, "Введи Y координату кінця");
            toolTip1.SetToolTip(textBox5, "Для трикутника: введи X третьої вершини");
            toolTip1.SetToolTip(textBox6, "Для трикутника: введи Y третьої вершини");
            textBox1.TextChanged += TextBoxes_TextChanged;
            textBox2.TextChanged += TextBoxes_TextChanged;
            textBox3.TextChanged += TextBoxes_TextChanged;
            textBox4.TextChanged += TextBoxes_TextChanged;
            textBox5.TextChanged += TextBoxes_TextChanged;
            textBox6.TextChanged += TextBoxes_TextChanged;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Графічний редактор";
            button1.Text = "Фарбувати";
            button2.Text = "Очистити";
            button3.Text = "Колір";
            button4.Text = "Колір тектсу";
            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = 20;
            numericUpDown1.Value = 4;
            bmp_for_draw = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp_for_draw;
            comboBox1.SelectedIndex = -1;
            HideAllTextBoxesAndCheckbox();
            button1.Enabled = false;
        }
        private void HideAllTextBoxesAndCheckbox()
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            checkBox1.Visible = false;
            groupBox1.Visible = false;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                HideAllTextBoxesAndCheckbox();
                groupBox1.Visible = false;
                button1.Enabled = false;
                return;
            }
            bool isTriangle = comboBox1.SelectedIndex == 1;
            bool isEllipse = comboBox1.SelectedIndex == 2;
            bool isRect = comboBox1.SelectedIndex == 3;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = isTriangle;
            textBox6.Visible = isTriangle;
            checkBox1.Visible = isEllipse || isTriangle || isRect;
            groupBox1.Visible = true; 
            button1.Enabled = CheckIfCanDraw();
        }
        private bool CheckIfCanDraw()
        {
            if (!textBox1.Visible) return false;

            TextBox[] boxes;

            if (textBox5.Visible && textBox6.Visible)
            {
                boxes = new TextBox[] { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6 };
            }
            else
            {
                boxes = new TextBox[] { textBox1, textBox2, textBox3, textBox4 };
            }

            for (int i = 0; i < boxes.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(boxes[i].Text)) return false;
                int temp;
                if (!int.TryParse(boxes[i].Text, out temp)) return false;
            }

            return true;
        }
        private void TextBoxes_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = CheckIfCanDraw();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            if (checkBox1.Checked)
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    selectedFillColor = colorDialog1.Color;
                }
                else
                {
                    return;
                }
            }
            if (comboBox1.SelectedIndex == 0)
            {
                g.DrawLine(Pens.Black,
                    Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text),
                    Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                Point p1 = new Point(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                Point p2 = new Point(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
                Point p3 = new Point(Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
                Point[] points = new Point[] { p1, p2, p3 };
                if (checkBox1.Checked)
                {
                    using (Brush brush = new SolidBrush(selectedFillColor))
                    {
                        g.FillPolygon(brush, points);
                    }
                }
                else
                {
                    g.DrawPolygon(Pens.Black, points);
                }
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                Rectangle rect = new Rectangle(
                    Convert.ToInt32(textBox1.Text),
                    Convert.ToInt32(textBox2.Text),
                    Convert.ToInt32(textBox3.Text),
                    Convert.ToInt32(textBox4.Text));
                if (checkBox1.Checked)
                {
                    using (Brush b = new SolidBrush(selectedFillColor))
                    {
                        g.FillEllipse(b, rect);
                    }
                }
                else
                {
                    g.DrawEllipse(Pens.Black, rect);
                }
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                Rectangle rect = new Rectangle(
                    Convert.ToInt32(textBox1.Text),
                    Convert.ToInt32(textBox2.Text),
                    Convert.ToInt32(textBox3.Text),
                    Convert.ToInt32(textBox4.Text));
                if (checkBox1.Checked)
                {
                    using (Brush b = new SolidBrush(selectedFillColor))
                    {
                        g.FillRectangle(b, rect);
                    }
                }
                else
                {
                    g.DrawRectangle(Pens.Black, rect);
                }
            }
            pictureBox1.Invalidate();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            bmp_for_draw = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp_for_draw;
            pictureBox1.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pen_for_draw.Color = colorDialog1.Color;
                selectedFillColor = colorDialog1.Color;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string text = textBox7.Text;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color textColor = colorDialog1.Color;
                using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                {
                    using (Brush brush = new SolidBrush(textColor))
                    {
                        g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                        g.DrawString(text, Font, brush, 150, 50);
                    }
                }
                pictureBox1.Invalidate();
            }
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Drow = true;
            if (e.Button == MouseButtons.Left)
            {
                Draw = true;
                start_point = e.Location;
            }
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Drow && e.Button == MouseButtons.Left && pictureBox1.Image != null)
            {
                using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                {
                    g.DrawLine(pen_for_draw, start_point, e.Location);
                    start_point = e.Location;
                }
                pictureBox1.Invalidate();
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Drow = false;
            Draw = false;
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            pen_for_draw.Width = (float)numericUpDown1.Value;
        }
        private void зберегтиЯкToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
                saveFileDialog.Title = "Зберегти зображення як...";
                saveFileDialog.DefaultExt = "png";
                saveFileDialog.AddExtension = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    System.Drawing.Imaging.ImageFormat format = System.Drawing.Imaging.ImageFormat.Png;
                    switch (System.IO.Path.GetExtension(saveFileDialog.FileName).ToLower())
                    {
                        case ".jpg":
                        case ".jpeg":
                            format = System.Drawing.Imaging.ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = System.Drawing.Imaging.ImageFormat.Bmp;
                            break;
                        case ".png":
                        default:
                            format = System.Drawing.Imaging.ImageFormat.Png;
                            break;
                    }
                    pictureBox1.Image.Save(saveFileDialog.FileName, format);
                }
            }
        }
        private void відкритиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp|All Files|*.*";
                openFileDialog.Title = "Відкрити зображення";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                }
            }
        }
        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fr = new Form2();
            fr.ShowDialog();
        }
    }
}