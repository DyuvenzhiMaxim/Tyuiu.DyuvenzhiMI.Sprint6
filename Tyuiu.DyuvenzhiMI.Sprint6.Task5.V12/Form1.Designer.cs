namespace Tyuiu.DyuvenzhiMI.Sprint6.Task5.V12
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            panel1_DMI = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox2_DMI = new GroupBox();
            textBox1 = new TextBox();
            panel2_DMI = new Panel();
            groupBox1_DMI = new GroupBox();
            dataGridView_DMI = new DataGridView();
            panel3_DMI = new Panel();
            chart_DMI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitter1 = new Splitter();
            panel1_DMI.SuspendLayout();
            groupBox2_DMI.SuspendLayout();
            panel2_DMI.SuspendLayout();
            groupBox1_DMI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_DMI).BeginInit();
            panel3_DMI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart_DMI).BeginInit();
            SuspendLayout();
            // 
            // panel1_DMI
            // 
            panel1_DMI.BackColor = SystemColors.ActiveCaption;
            panel1_DMI.Controls.Add(button3);
            panel1_DMI.Controls.Add(button2);
            panel1_DMI.Controls.Add(button1);
            panel1_DMI.Controls.Add(groupBox2_DMI);
            panel1_DMI.Dock = DockStyle.Top;
            panel1_DMI.Location = new Point(0, 0);
            panel1_DMI.Name = "panel1_DMI";
            panel1_DMI.Size = new Size(1067, 125);
            panel1_DMI.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(986, 40);
            button3.Name = "button3";
            button3.Size = new Size(78, 74);
            button3.TabIndex = 3;
            button3.Text = "Справка";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(882, 40);
            button2.Name = "button2";
            button2.Size = new Size(98, 71);
            button2.TabIndex = 2;
            button2.Text = "Открыть файл";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(784, 40);
            button1.Name = "button1";
            button1.Size = new Size(97, 74);
            button1.TabIndex = 1;
            button1.Text = "Выполнить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2_DMI
            // 
            groupBox2_DMI.Controls.Add(textBox1);
            groupBox2_DMI.Location = new Point(12, 3);
            groupBox2_DMI.Name = "groupBox2_DMI";
            groupBox2_DMI.Size = new Size(766, 119);
            groupBox2_DMI.TabIndex = 0;
            groupBox2_DMI.TabStop = false;
            groupBox2_DMI.Text = "Задание";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(18, 26);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(683, 87);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panel2_DMI
            // 
            panel2_DMI.BackColor = SystemColors.Info;
            panel2_DMI.Controls.Add(groupBox1_DMI);
            panel2_DMI.Dock = DockStyle.Left;
            panel2_DMI.Location = new Point(0, 125);
            panel2_DMI.Name = "panel2_DMI";
            panel2_DMI.Size = new Size(250, 424);
            panel2_DMI.TabIndex = 0;
            // 
            // groupBox1_DMI
            // 
            groupBox1_DMI.Controls.Add(dataGridView_DMI);
            groupBox1_DMI.Dock = DockStyle.Left;
            groupBox1_DMI.Location = new Point(0, 0);
            groupBox1_DMI.Name = "groupBox1_DMI";
            groupBox1_DMI.Size = new Size(244, 424);
            groupBox1_DMI.TabIndex = 0;
            groupBox1_DMI.TabStop = false;
            groupBox1_DMI.Text = "Вывод";
            // 
            // dataGridView_DMI
            // 
            dataGridView_DMI.BackgroundColor = SystemColors.InactiveBorder;
            dataGridView_DMI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_DMI.Dock = DockStyle.Left;
            dataGridView_DMI.Location = new Point(3, 23);
            dataGridView_DMI.Name = "dataGridView_DMI";
            dataGridView_DMI.RowHeadersWidth = 51;
            dataGridView_DMI.Size = new Size(232, 398);
            dataGridView_DMI.TabIndex = 1;
            // 
            // panel3_DMI
            // 
            panel3_DMI.BackColor = Color.FromArgb(255, 192, 192);
            panel3_DMI.Controls.Add(chart_DMI);
            panel3_DMI.Dock = DockStyle.Fill;
            panel3_DMI.Location = new Point(250, 125);
            panel3_DMI.Name = "panel3_DMI";
            panel3_DMI.Size = new Size(817, 424);
            panel3_DMI.TabIndex = 0;
            // 
            // chart_DMI
            // 
            chartArea1.Name = "ChartArea1";
            chart_DMI.ChartAreas.Add(chartArea1);
            chart_DMI.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chart_DMI.Legends.Add(legend1);
            chart_DMI.Location = new Point(0, 0);
            chart_DMI.Name = "chart_DMI";
            chart_DMI.Padding = new Padding(10);
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart_DMI.Series.Add(series1);
            chart_DMI.Size = new Size(817, 424);
            chart_DMI.TabIndex = 0;
            chart_DMI.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "График";
            chart_DMI.Titles.Add(title1);
            chart_DMI.Click += chart1_Click;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(250, 125);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 424);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 549);
            Controls.Add(splitter1);
            Controls.Add(panel3_DMI);
            Controls.Add(panel2_DMI);
            Controls.Add(panel1_DMI);
            Name = "Form1";
            Text = "Спринт 6 | Таск 1 | Вариант 14 | Дювенжи М. И.";
            panel1_DMI.ResumeLayout(false);
            groupBox2_DMI.ResumeLayout(false);
            groupBox2_DMI.PerformLayout();
            panel2_DMI.ResumeLayout(false);
            groupBox1_DMI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_DMI).EndInit();
            panel3_DMI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart_DMI).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1_DMI;
        private Panel panel2_DMI;
        private GroupBox groupBox1_DMI;
        private Panel panel3_DMI;
        private Splitter splitter1;
        private GroupBox groupBox2_DMI;
        private TextBox textBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_DMI;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView_DMI;
    }
}
