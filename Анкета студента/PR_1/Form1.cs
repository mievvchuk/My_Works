namespace PR_1
{
    public partial class Анкета : Form
    {
        public Анкета()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button2.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            if (button1.Text == "Портретна фотографія")
            {
                pictureBox1.Visible = true;
                label7.Text = "Портретна фотографія";
                button1.Text = "Художня фотографія";
            }
            else if (button1.Text == "Художня фотографія")
            {
                pictureBox2.Visible = true;
                label7.Text = "Художня фотографія";
                button1.Text = "Третя фотографія";
            }
            else 
            {
                pictureBox3.Visible = true;
                label7.Text = "Третя фотографія";
                button1.Text = "Портретна фотографія";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            label7.Text = "Немає фотографії";
            button2.Enabled = false;
            button2.Visible = false;
        }

    }
}
