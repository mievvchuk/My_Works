using System;
using System.Drawing;
using System.Windows.Forms;
namespace PR_66
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        char WHO = 'O';  // Символ гравця
        short movement = 0;

        public Form1()
        {
            InitializeComponent();
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;

            button1.Click += buuton_click;
            button2.Click += buuton_click;
            button3.Click += buuton_click;
            button4.Click += buuton_click;
            button5.Click += buuton_click;
            button6.Click += buuton_click;
            button7.Click += buuton_click;
            button8.Click += buuton_click;
            button9.Click += buuton_click;

            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // При завантаженні просто починаємо нову гру
            новаГраToolStripMenuItem_Click(null, null);
        }

        private void новаГраToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Запитуємо, за кого грати
            DialogResult result = MessageBox.Show(
                "За кого хочете грати?\nНатисніть 'Так' для X, 'Ні' для O",
                "Вибір гравця",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                WHO = 'X';
            else
                WHO = 'O';

            movement = 0;
            tableLayoutPanel1.Enabled = true;

            Button[] buttons = { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            foreach (var btn in buttons)
            {
                btn.Visible = true;
                btn.Enabled = true;
                btn.Text = "";
                btn.BackColor = DefaultBackColor;
            }

            // Якщо гравець обрав O — ходить комп'ютер (X) першим
            if (WHO == 'O')
            {
                // Комп'ютер ходить X
                ComputerMove();
                movement++;
            }
        }

        private void buuton_click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            if (bt == null || !bt.Enabled) return;

            PlayerMove(bt);

            if (CheckWin())
            {
                MessageBox.Show($"Переможець - {WHO} !");
                tableLayoutPanel1.Enabled = false;
                return;
            }

            movement++;
            if (movement > 8)
            {
                MessageBox.Show("Нічия!");
                tableLayoutPanel1.Enabled = false;
                return;
            }

            // Хід комп'ютера робить символ протилежний гравцю
            ComputerMove();

            if (CheckWin())
            {
                // Комп'ютер ходить символом, протилежним WHO
                char compChar = WHO == 'X' ? 'O' : 'X';
                MessageBox.Show($"Переможець - {compChar} !");
                tableLayoutPanel1.Enabled = false;
                return;
            }

            movement++;
            if (movement > 8)
            {
                MessageBox.Show("Нічия!");
                tableLayoutPanel1.Enabled = false;
                return;
            }
        }

        private void PlayerMove(Button bt)
        {
            bt.Enabled = false;
            bt.BackColor = Color.Yellow;
            bt.Text = WHO.ToString();  // Хід гравця — символ WHO
        }

        private void ComputerMove()
        {
            int countFree = 0;
            Button[] buttons = { button1, button2, button3, button4, button5, button6, button7, button8, button9 };

            foreach (var btn in buttons)
                if (btn.Enabled) countFree++;

            if (countFree == 0) return;

            int r = rnd.Next(1, countFree + 1);
            int current = 0;

            foreach (var btn in buttons)
            {
                if (btn.Enabled)
                {
                    current++;
                    if (current == r)
                    {
                        MakeMove(btn);
                        return;
                    }
                }
            }
        }

        private void MakeMove(Button btn)
        {
            btn.Enabled = false;
            btn.BackColor = Color.LightGreen;
            // Комп'ютер ходить символом, протилежним гравцю
            btn.Text = (WHO == 'X') ? "O" : "X";
        }

        private Button GetButtonByNumber(int num)
        {
            if (num == 1) return button1;
            if (num == 2) return button2;
            if (num == 3) return button3;
            if (num == 4) return button4;
            if (num == 5) return button5;
            if (num == 6) return button6;
            if (num == 7) return button7;
            if (num == 8) return button8;
            return button9;
        }

        private bool CheckWin()
        {
            if (button1.Text != "" && button1.Text == button2.Text && button2.Text == button3.Text) return true;
            if (button4.Text != "" && button4.Text == button5.Text && button5.Text == button6.Text) return true;
            if (button7.Text != "" && button7.Text == button8.Text && button8.Text == button9.Text) return true;
            if (button1.Text != "" && button1.Text == button4.Text && button4.Text == button7.Text) return true;
            if (button2.Text != "" && button2.Text == button5.Text && button5.Text == button8.Text) return true;
            if (button3.Text != "" && button3.Text == button6.Text && button6.Text == button9.Text) return true;
            if (button1.Text != "" && button1.Text == button5.Text && button5.Text == button9.Text) return true;
            if (button3.Text != "" && button3.Text == button5.Text && button5.Text == button7.Text) return true;
            return false;
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fr = new Form2();
            fr.ShowDialog();
        }
    }
}
