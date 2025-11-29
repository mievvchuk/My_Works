namespace PR_22
{
    partial class обмін
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button3 = new Button();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            groupBox1 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            button5 = new Button();
            button4 = new Button();
            groupBox2 = new GroupBox();
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            toolTip3 = new ToolTip(components);
            toolTip4 = new ToolTip(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            radioButton1.Location = new Point(64, 36);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(96, 29);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Купівля";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            radioButton2.Location = new Point(504, 36);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(100, 29);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "Продаж";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(300, 9);
            label1.Name = "label1";
            label1.Size = new Size(57, 55);
            label1.TabIndex = 2;
            label1.Text = "⇨";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(67, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            toolTip1.SetToolTip(textBox1, "Введіть курс купівлі");
            // 
            // textBox2
            // 
            textBox2.Location = new Point(67, 184);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            toolTip1.SetToolTip(textBox2, "Введіть суму в доларах");
            // 
            // textBox3
            // 
            textBox3.Location = new Point(498, 95);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 5;
            toolTip2.SetToolTip(textBox3, "Введіть курс продажі");
            // 
            // textBox4
            // 
            textBox4.Location = new Point(498, 184);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F);
            button1.Location = new Point(51, 245);
            button1.Name = "button1";
            button1.Size = new Size(127, 30);
            button1.TabIndex = 7;
            button1.Text = "Обчислити";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F);
            button2.Location = new Point(514, 245);
            button2.Name = "button2";
            button2.Size = new Size(94, 30);
            button2.TabIndex = 8;
            button2.Text = "Кінець";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(286, 95);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 9;
            label2.Text = "Курси валют";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(87, 135);
            label3.Name = "label3";
            label3.Size = new Size(48, 25);
            label3.TabIndex = 10;
            label3.Text = "USD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(514, 135);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 11;
            label4.Text = "Гривні";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14.25F);
            button3.Location = new Point(286, 245);
            button3.Name = "button3";
            button3.Size = new Size(117, 30);
            button3.TabIndex = 12;
            button3.Text = "Очищення";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            // 
            // toolTip2
            // 
            toolTip2.ToolTipIcon = ToolTipIcon.Info;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(642, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(381, 254);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Переведення довжин";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(155, 25);
            label7.Name = "label7";
            label7.Size = new Size(42, 42);
            label7.TabIndex = 14;
            label7.Text = "⇨";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(273, 78);
            label6.Name = "label6";
            label6.Size = new Size(45, 21);
            label6.TabIndex = 8;
            label6.Text = "Милі";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 78);
            label5.Name = "label5";
            label5.Size = new Size(84, 21);
            label5.TabIndex = 7;
            label5.Text = "Кілометри";
            // 
            // button5
            // 
            button5.Font = new Font("Times New Roman", 14.25F);
            button5.Location = new Point(254, 197);
            button5.Name = "button5";
            button5.Size = new Size(103, 27);
            button5.TabIndex = 6;
            button5.Text = "Очистити";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Times New Roman", 14.25F);
            button4.Location = new Point(8, 197);
            button4.Name = "button4";
            button4.Size = new Size(103, 27);
            button4.TabIndex = 5;
            button4.Text = "Перевести";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Location = new Point(91, 85);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(157, 86);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Тип милі";
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(15, 56);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(91, 25);
            radioButton6.TabIndex = 1;
            radioButton6.Text = "Морська";
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.CheckedChanged += radioButton6_CheckedChanged;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Checked = true;
            radioButton5.Location = new Point(15, 25);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(97, 25);
            radioButton5.TabIndex = 0;
            radioButton5.TabStop = true;
            radioButton5.Text = "Звичайна";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(254, 110);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(79, 29);
            textBox6.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(8, 106);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(77, 29);
            textBox5.TabIndex = 2;
            toolTip3.SetToolTip(textBox5, "Введіть кілометри");
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Checked = true;
            radioButton4.Location = new Point(239, 32);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(63, 25);
            radioButton4.TabIndex = 1;
            radioButton4.TabStop = true;
            radioButton4.Text = "Милі";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(6, 32);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(102, 25);
            radioButton3.TabIndex = 0;
            radioButton3.Text = "Кілометри";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // toolTip3
            // 
            toolTip3.ToolTipIcon = ToolTipIcon.Info;
            // 
            // toolTip4
            // 
            toolTip4.ToolTipIcon = ToolTipIcon.Info;
            // 
            // обмін
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 283);
            Controls.Add(groupBox1);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "обмін";
            Text = "Обмін валют";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button3;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private TextBox textBox6;
        private TextBox textBox5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button button5;
        private Button button4;
        private ToolTip toolTip4;
        private ToolTip toolTip3;
    }
}
