namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.знятиВсіПрапорціToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.встановитиВсіПрапорціToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.встановитиІнверсивноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.обчисленняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.протабулюватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вивідДанихЗМасивуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститиПолеВведенняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кінецьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кінецьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.побудуватиГрафікToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.кінецьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститиГрафікToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(269, 261);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "-10";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(269, 308);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "10";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(269, 351);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 22);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "0,2";
            // 
            // groupBox1
            // 
            this.groupBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(276, 87);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(145, 131);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Виведення";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.знятиВсіПрапорціToolStripMenuItem,
            this.встановитиВсіПрапорціToolStripMenuItem,
            this.встановитиІнверсивноToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(210, 70);
            // 
            // знятиВсіПрапорціToolStripMenuItem
            // 
            this.знятиВсіПрапорціToolStripMenuItem.Name = "знятиВсіПрапорціToolStripMenuItem";
            this.знятиВсіПрапорціToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.знятиВсіПрапорціToolStripMenuItem.Text = "Зняти всі прапорці";
            this.знятиВсіПрапорціToolStripMenuItem.Click += new System.EventHandler(this.знятиВсіПрапорціToolStripMenuItem_Click);
            // 
            // встановитиВсіПрапорціToolStripMenuItem
            // 
            this.встановитиВсіПрапорціToolStripMenuItem.Name = "встановитиВсіПрапорціToolStripMenuItem";
            this.встановитиВсіПрапорціToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.встановитиВсіПрапорціToolStripMenuItem.Text = "Встановити всі прапорці";
            this.встановитиВсіПрапорціToolStripMenuItem.Click += new System.EventHandler(this.встановитиВсіПрапорціToolStripMenuItem_Click);
            // 
            // встановитиІнверсивноToolStripMenuItem
            // 
            this.встановитиІнверсивноToolStripMenuItem.Name = "встановитиІнверсивноToolStripMenuItem";
            this.встановитиІнверсивноToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.встановитиІнверсивноToolStripMenuItem.Text = "Встановити інверсивно";
            this.встановитиІнверсивноToolStripMenuItem.Click += new System.EventHandler(this.встановитиІнверсивноToolStripMenuItem_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(9, 102);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(69, 19);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Похідна";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(9, 76);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(72, 19);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "У масив";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(9, 49);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(66, 19);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "У файл";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 23);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "На екран";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обчисленняToolStripMenuItem,
            this.кінецьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(426, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // обчисленняToolStripMenuItem
            // 
            this.обчисленняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.протабулюватиToolStripMenuItem,
            this.вивідДанихЗМасивуToolStripMenuItem,
            this.очиститиПолеВведенняToolStripMenuItem});
            this.обчисленняToolStripMenuItem.Name = "обчисленняToolStripMenuItem";
            this.обчисленняToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.обчисленняToolStripMenuItem.Text = "Обчислення";
            // 
            // протабулюватиToolStripMenuItem
            // 
            this.протабулюватиToolStripMenuItem.Name = "протабулюватиToolStripMenuItem";
            this.протабулюватиToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.протабулюватиToolStripMenuItem.Text = "Протабулювати";
            this.протабулюватиToolStripMenuItem.Click += new System.EventHandler(this.протабулюватиToolStripMenuItem_Click);
            // 
            // вивідДанихЗМасивуToolStripMenuItem
            // 
            this.вивідДанихЗМасивуToolStripMenuItem.Name = "вивідДанихЗМасивуToolStripMenuItem";
            this.вивідДанихЗМасивуToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.вивідДанихЗМасивуToolStripMenuItem.Text = "Вивід даних з масиву";
            this.вивідДанихЗМасивуToolStripMenuItem.Click += new System.EventHandler(this.вивідДанихЗМасивуToolStripMenuItem_Click);
            // 
            // очиститиПолеВведенняToolStripMenuItem
            // 
            this.очиститиПолеВведенняToolStripMenuItem.Name = "очиститиПолеВведенняToolStripMenuItem";
            this.очиститиПолеВведенняToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.очиститиПолеВведенняToolStripMenuItem.Text = "Очистити поле виведення";
            this.очиститиПолеВведенняToolStripMenuItem.Click += new System.EventHandler(this.очиститиПолеВведенняToolStripMenuItem_Click);
            // 
            // кінецьToolStripMenuItem
            // 
            this.кінецьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проПрограмуToolStripMenuItem,
            this.кінецьToolStripMenuItem1});
            this.кінецьToolStripMenuItem.Name = "кінецьToolStripMenuItem";
            this.кінецьToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.кінецьToolStripMenuItem.Text = "Кінець";
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
            this.проПрограмуToolStripMenuItem.Click += new System.EventHandler(this.проПрограмуToolStripMenuItem_Click);
            // 
            // кінецьToolStripMenuItem1
            // 
            this.кінецьToolStripMenuItem1.Name = "кінецьToolStripMenuItem1";
            this.кінецьToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.кінецьToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.кінецьToolStripMenuItem1.Text = "Кінець";
            this.кінецьToolStripMenuItem1.Click += new System.EventHandler(this.кінецьToolStripMenuItem1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(10, 87);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(249, 439);
            this.listBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ліва межа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Права межа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Крок";
            // 
            // chart1
            // 
            this.chart1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Bottom;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Y=sin(x)+1";
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Y`=cos(x)";
            this.chart1.Legends.Add(legend1);
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(5, 56);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Y=sin(x)+1";
            series1.Name = "sin(x)+1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Y=sin(x)+1";
            series2.Name = "cos(x)";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(328, 263);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(95, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "y=sin(x)+1";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.побудуватиГрафікToolStripMenuItem,
            this.очиститиГрафікToolStripMenuItem,
            this.toolStripMenuItem1,
            this.кінецьToolStripMenuItem2});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(181, 98);
            // 
            // побудуватиГрафікToolStripMenuItem
            // 
            this.побудуватиГрафікToolStripMenuItem.CheckOnClick = true;
            this.побудуватиГрафікToolStripMenuItem.Name = "побудуватиГрафікToolStripMenuItem";
            this.побудуватиГрафікToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.побудуватиГрафікToolStripMenuItem.Text = "Побудувати графік";
            this.побудуватиГрафікToolStripMenuItem.Click += new System.EventHandler(this.побудуватиГрафікToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // кінецьToolStripMenuItem2
            // 
            this.кінецьToolStripMenuItem2.Name = "кінецьToolStripMenuItem2";
            this.кінецьToolStripMenuItem2.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.кінецьToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.кінецьToolStripMenuItem2.Text = "Кінець";
            this.кінецьToolStripMenuItem2.Click += new System.EventHandler(this.кінецьToolStripMenuItem2_Click);
            // 
            // очиститиГрафікToolStripMenuItem
            // 
            this.очиститиГрафікToolStripMenuItem.Name = "очиститиГрафікToolStripMenuItem";
            this.очиститиГрафікToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.очиститиГрафікToolStripMenuItem.Text = "Очистити графік";
            this.очиститиГрафікToolStripMenuItem.Click += new System.EventHandler(this.очиститиГрафікToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chart1);
            this.groupBox2.Location = new System.Drawing.Point(427, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 333);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 535);
            this.ContextMenuStrip = this.contextMenuStrip2;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Табулювання функції";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem обчисленняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem протабулюватиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститиПолеВведенняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кінецьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кінецьToolStripMenuItem1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem знятиВсіПрапорціToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem встановитиВсіПрапорціToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem встановитиІнверсивноToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.ToolStripMenuItem побудуватиГрафікToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem кінецьToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem очиститиГрафікToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem вивідДанихЗМасивуToolStripMenuItem;
    }
}

