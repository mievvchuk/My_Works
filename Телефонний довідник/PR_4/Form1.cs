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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace PR_4
{
    public partial class Form1 : Form
    {
        struct info
        {
            public string prizv, imja, adresa, tel;
        };
        info[] arr = new info[100];
        info r;
        int n;
        bool change;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 4; 
            dataGridView1.Columns[0].HeaderText = "Прізвище";
            dataGridView1.Columns[1].HeaderText = "Ім’я";
            dataGridView1.Columns[2].HeaderText = "Адреса";
            dataGridView1.Columns[3].HeaderText = "Телефон";
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 183;
            change = false;
        }
        private void кінецьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form2 = new Form2();
            Form2.ShowDialog();
        }
        private void прочиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName == null) return;
            try
            {
                int i = 0;
                n = 0;
                BinaryReader reader = new BinaryReader(File.Open(openFileDialog1.FileName, FileMode.Open));
                while (reader.PeekChar() > -1)
                {
                    dataGridView1.Rows.Add();
                    r.prizv = reader.ReadString();
                    r.imja = reader.ReadString();
                    r.adresa = reader.ReadString();
                    r.tel = reader.ReadString();
                    dataGridView1.Rows[i].Cells[0].Value = r.prizv;
                    dataGridView1.Rows[i].Cells[1].Value = r.imja;
                    dataGridView1.Rows[i].Cells[2].Value = r.adresa;
                    dataGridView1.Rows[i].Cells[3].Value = r.tel;
                    arr[n] = r;
                    i++;
                    n++;
                }
                reader.Close();
                change = false;
                newComboBox();
                comboBox1.SelectedIndex = 0;
                MessageBox.Show("З файлу прочитано " + n + " записів", "Результат зчитування",
    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception) { }
        }
        private void newComboBox()
        {
            int i, j;
            j = comboBox1.SelectedIndex;
            comboBox1.Items.Clear();
            if (n != 0)
            {
                for (i = 0; i < n; i++)
                    comboBox1.Items.Add(dataGridView1.Rows[i].Cells[0].Value);
                if (j < n) comboBox1.SelectedIndex = j;
                else if (j == n) comboBox1.SelectedIndex = 1;
            }
        }
        private void записатиУФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Бінарні файли (*.bin)|*.bin|Усі файли (*.*)|*.*";
            saveFileDialog1.DefaultExt = "bin";
            saveFileDialog1.AddExtension = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrWhiteSpace(saveFileDialog1.FileName)) return;
                try
                {
                    int i = 0;
                    BinaryWriter writer = new BinaryWriter(File.Open(saveFileDialog1.FileName, FileMode.Create));
                    while (dataGridView1.Rows[i].Cells[0].Value != null)
                    {
                        r.prizv = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        r.imja = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        r.adresa = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        r.tel = dataGridView1.Rows[i].Cells[3].Value.ToString();
                        writer.Write(r.prizv);
                        writer.Write(r.imja);
                        writer.Write(r.adresa);
                        writer.Write(r.tel);
                        i++;
                    }
                    writer.Close();
                    change = false;
                }
                catch (Exception) { }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (n != 0)
            {
                if (comboBox1.SelectedIndex == 0)
                    comboBox1.SelectedIndex = n - 1;
                else comboBox1.SelectedIndex = comboBox1.SelectedIndex - 1;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            bool result = false;
            for (int i = 0; i < n; i++)
            {
                if (arr[i].prizv == textBox5.Text)
                {
                    comboBox1.SelectedIndex = i;
                    result = true;
                    break;
                }
            }
            if (!result)
                MessageBox.Show($"Прізвище '{textBox5.Text}' не знайдено", "Результат пошуку", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (n != 0)
            {
                int i;
                i = comboBox1.SelectedIndex;
                for (; i < n; i++)
                    arr[i] = arr[i + 1];
                n--;
                dataGridView1.Rows.Clear();
                for (i = 0; i < n; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = arr[i].prizv;
                    dataGridView1.Rows[i].Cells[1].Value = arr[i].imja;
                    dataGridView1.Rows[i].Cells[2].Value = arr[i].adresa;
                    dataGridView1.Rows[i].Cells[3].Value = arr[i].tel;
                }
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                newComboBox();
                change = true;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (n != 0)
            {
                if (comboBox1.SelectedIndex == n - 1)
                    comboBox1.SelectedIndex = 0;
                else
                    comboBox1.SelectedIndex = comboBox1.SelectedIndex + 1;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = comboBox1.SelectedIndex;
            if (i >= 0 && i < n)
            {
                textBox1.Text = arr[i].prizv;
                textBox2.Text = arr[i].imja;
                textBox3.Text = arr[i].adresa;
                textBox4.Text = arr[i].tel;
            }
        }
        private bool sortAscending = true; 
        private void впорядкуватиЗаАлфавітомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (n <= 0)
            {
                MessageBox.Show("Немає даних для сортування", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sortAscending = !sortAscending;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    int cmp = string.Compare(arr[j].prizv, arr[j + 1].prizv, StringComparison.CurrentCulture);
                    bool needSwap = sortAscending ? (cmp > 0) : (cmp < 0);
                    if (needSwap)
                    {
                        info temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            dataGridView1.Rows.Clear();
            for (int i = 0; i < n; i++)
            {
                dataGridView1.Rows.Add(arr[i].prizv, arr[i].imja, arr[i].adresa, arr[i].tel);
            }
            newComboBox();
            change = true;
            string message;
            if (sortAscending)
                message = "Дані впорядковано за алфавітом (A→Я)";
            else
                message = "Дані впорядковано у зворотному порядку (Я→A)";

            MessageBox.Show(message, "Сортування",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void видалитиУсіЗаписиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (n == 0)
            {
                MessageBox.Show("Немає записів для видалення", "Інформація",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult result = MessageBox.Show("Ви точно хочете видалити всі записи?", "Підтвердження видалення",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                dataGridView1.Rows.Clear();
                comboBox1.Items.Clear();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                n = 0;
                change = true;

                MessageBox.Show("Усі записи було успішно видалено", "Операція завершена",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void видалитиОдинЗаписToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (n == 0 || dataGridView1.SelectedCells.Count == 0)
            {
                MessageBox.Show("Будь ласка, виберіть запис для видалення.", "Увага",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            DialogResult result = MessageBox.Show(
                $"Ви впевнені, що хочете видалити запис \"{arr[rowIndex].prizv}\"?",
                "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                for (int i = rowIndex; i < n - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                n--;
                dataGridView1.Rows.Clear();
                for (int i = 0; i < n; i++)
                {
                    dataGridView1.Rows.Add(arr[i].prizv, arr[i].imja, arr[i].adresa, arr[i].tel);
                }
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                newComboBox();
                if (n > 0) comboBox1.SelectedIndex = 0;
                change = true;
                MessageBox.Show("Запис успішно видалено.", "Успіх",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void видалитиВибірковоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (n == 0 || dataGridView1.SelectedCells.Count == 0)
            {
                MessageBox.Show("Немає вибраних клітинок для видалення!", "Увага",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int[] tempIndices = new int[dataGridView1.SelectedCells.Count];
            int found = 0;
            bool єПустаКолонка = false;
            for (int i = 0; i < dataGridView1.SelectedCells.Count; i++)
            {
                int rowIndex = dataGridView1.SelectedCells[i].RowIndex;
                bool alreadyExists = false;
                for (int j = 0; j < found; j++)
                {
                    if (tempIndices[j] == rowIndex)
                    {
                        alreadyExists = true;
                        break;
                    }
                }
                if (!alreadyExists)
                {
                    object cellValue = dataGridView1.Rows[rowIndex].Cells[0].Value;
                    if (cellValue == null || string.IsNullOrWhiteSpace(cellValue.ToString()))
                    {
                        єПустаКолонка = true;
                        break;
                    }
                    tempIndices[found] = rowIndex;
                    found++;
                }
            }
            if (єПустаКолонка)
            {
                MessageBox.Show("Серед вибраних рядків є пусті прізвища. Будь ласка, виберіть рядки з даними в колонці \"Прізвище\".", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string message = "Буде видалено записи з такими прізвищами:\n\n";
            for (int i = 0; i < found; i++)
            {
                int rowIndex = tempIndices[i];
                message += $"- {dataGridView1.Rows[rowIndex].Cells[0].Value.ToString()}\n";
            }
            message += "\nПродовжити видалення?";
            DialogResult res = MessageBox.Show(message, "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res != DialogResult.Yes)
                return;
            Array.Sort(tempIndices, 0, found);
            Array.Reverse(tempIndices, 0, found);

            for (int i = 0; i < found; i++)
            {
                int index = tempIndices[i];
                for (int j = index; j < n - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }
                n--;
            }
            dataGridView1.Rows.Clear();
            for (int i = 0; i < n; i++)
            {
                dataGridView1.Rows.Add(arr[i].prizv, arr[i].imja, arr[i].adresa, arr[i].tel);
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            newComboBox();
            if (n > 0) comboBox1.SelectedIndex = 0;
            change = true;
            MessageBox.Show("Видалено вибрані записи.", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = openFileDialog1.FileName;
            if (string.IsNullOrEmpty(filePath))
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveFileDialog1.FileName;
                    openFileDialog1.FileName = filePath; // Запам’ятати шлях до файлу
                }
                else
                {
                    return; // Користувач натиснув "Скасувати"
                }
            }
            try
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
                {
                    for (int i = 0; i < n; i++)
                    {
                        writer.Write(arr[i].prizv);
                        writer.Write(arr[i].imja);
                        writer.Write(arr[i].adresa);
                        writer.Write(arr[i].tel);
                    }
                }
                MessageBox.Show("Дані успішно збережено", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                change = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при збереженні файлу: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult closeResult = MessageBox.Show("Ви дійсно хочете завершити роботу?",
                "Завершення роботи",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (closeResult == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            if (change)
            {
                DialogResult saveResult = MessageBox.Show("Дані було змінено. Зберегти зміни?",
                    "Збереження даних",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (saveResult == DialogResult.Yes)
                {
                    записатиУФайлToolStripMenuItem_Click(sender, e);
                    if (change)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            change = true;
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentCell.RowIndex;
            if (dataGridView1.Rows[i].Cells[0].Value != null &&
                dataGridView1.Rows[i].Cells[1].Value != null &&
                dataGridView1.Rows[i].Cells[2].Value != null &&
                dataGridView1.Rows[i].Cells[3].Value != null)
            {
                arr[i].prizv = dataGridView1.Rows[i].Cells[0].Value.ToString();
                arr[i].imja = dataGridView1.Rows[i].Cells[1].Value.ToString();
                arr[i].adresa = dataGridView1.Rows[i].Cells[2].Value.ToString();
                arr[i].tel = dataGridView1.Rows[i].Cells[3].Value.ToString();
                if (i == n)
                    n++;
                newComboBox();
                comboBox1.SelectedIndex = i;
            }
        }
    }
}
