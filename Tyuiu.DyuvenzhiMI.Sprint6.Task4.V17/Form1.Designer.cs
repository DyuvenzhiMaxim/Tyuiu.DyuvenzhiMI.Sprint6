namespace Tyuiu.DyuvenzhiMI.Sprint6.Task4.V17
{
    partial class Form_DMI
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DMI));
            groupBox_DMI = new GroupBox();
            textBoxResult_DMI = new TextBox();
            label_DMI = new Label();
            labelEnd_DMI = new Label();
            labelNach_Dmi = new Label();
            textBoxEnd_DMI = new TextBox();
            textBoxNach_DMI = new TextBox();
            buttonResult_DMI = new Button();
            buttonSave_DMI = new Button();
            chart_DMI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            pictureBox_DMI = new PictureBox();
            panel2 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            buttonSpravka_DMI = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            groupBox1 = new GroupBox();
            panel7 = new Panel();
            button1 = new Button();
            groupBox_DMI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart_DMI).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_DMI).BeginInit();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_DMI
            // 
            groupBox_DMI.Controls.Add(textBoxResult_DMI);
            groupBox_DMI.Controls.Add(label_DMI);
            groupBox_DMI.Controls.Add(labelEnd_DMI);
            groupBox_DMI.Controls.Add(labelNach_Dmi);
            groupBox_DMI.Controls.Add(textBoxEnd_DMI);
            groupBox_DMI.Controls.Add(textBoxNach_DMI);
            groupBox_DMI.Controls.Add(buttonResult_DMI);
            groupBox_DMI.Controls.Add(buttonSave_DMI);
            groupBox_DMI.Controls.Add(chart_DMI);
            groupBox_DMI.Controls.Add(pictureBox_DMI);
            groupBox_DMI.Controls.Add(panel2);
            groupBox_DMI.Location = new Point(12, 12);
            groupBox_DMI.Name = "groupBox_DMI";
            groupBox_DMI.Size = new Size(986, 459);
            groupBox_DMI.TabIndex = 0;
            groupBox_DMI.TabStop = false;
            groupBox_DMI.Text = "Task 4";
            // 
            // textBoxResult_DMI
            // 
            textBoxResult_DMI.Location = new Point(6, 240);
            textBoxResult_DMI.Multiline = true;
            textBoxResult_DMI.Name = "textBoxResult_DMI";
            textBoxResult_DMI.ScrollBars = ScrollBars.Vertical;
            textBoxResult_DMI.Size = new Size(393, 195);
            textBoxResult_DMI.TabIndex = 10;
            // 
            // label_DMI
            // 
            label_DMI.AutoSize = true;
            label_DMI.Location = new Point(6, 216);
            label_DMI.Name = "label_DMI";
            label_DMI.Size = new Size(54, 20);
            label_DMI.TabIndex = 9;
            label_DMI.Text = "Вывод";
            // 
            // labelEnd_DMI
            // 
            labelEnd_DMI.AutoSize = true;
            labelEnd_DMI.Location = new Point(577, 23);
            labelEnd_DMI.Name = "labelEnd_DMI";
            labelEnd_DMI.Size = new Size(53, 20);
            labelEnd_DMI.TabIndex = 8;
            labelEnd_DMI.Text = "Конец";
            // 
            // labelNach_Dmi
            // 
            labelNach_Dmi.AutoSize = true;
            labelNach_Dmi.Location = new Point(424, 24);
            labelNach_Dmi.Name = "labelNach_Dmi";
            labelNach_Dmi.Size = new Size(61, 20);
            labelNach_Dmi.TabIndex = 7;
            labelNach_Dmi.Text = "Начало";
            // 
            // textBoxEnd_DMI
            // 
            textBoxEnd_DMI.Location = new Point(577, 47);
            textBoxEnd_DMI.Name = "textBoxEnd_DMI";
            textBoxEnd_DMI.Size = new Size(125, 27);
            textBoxEnd_DMI.TabIndex = 5;
            // 
            // textBoxNach_DMI
            // 
            textBoxNach_DMI.Location = new Point(424, 47);
            textBoxNach_DMI.Name = "textBoxNach_DMI";
            textBoxNach_DMI.Size = new Size(125, 27);
            textBoxNach_DMI.TabIndex = 4;
            // 
            // buttonResult_DMI
            // 
            buttonResult_DMI.BackColor = SystemColors.InactiveCaption;
            buttonResult_DMI.Location = new Point(708, 28);
            buttonResult_DMI.Name = "buttonResult_DMI";
            buttonResult_DMI.Size = new Size(82, 64);
            buttonResult_DMI.TabIndex = 3;
            buttonResult_DMI.Text = "Ответ";
            buttonResult_DMI.UseVisualStyleBackColor = false;
            buttonResult_DMI.Click += buttonAnswer_DMI_Click;
            // 
            // buttonSave_DMI
            // 
            buttonSave_DMI.BackColor = SystemColors.Info;
            buttonSave_DMI.Location = new Point(794, 28);
            buttonSave_DMI.Name = "buttonSave_DMI";
            buttonSave_DMI.Size = new Size(92, 64);
            buttonSave_DMI.TabIndex = 2;
            buttonSave_DMI.Text = "Сохранить";
            buttonSave_DMI.UseVisualStyleBackColor = false;
            buttonSave_DMI.Click += button1_Click;
            // 
            // chart_DMI
            // 
            chartArea3.Name = "ChartArea1";
            chart_DMI.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chart_DMI.Legends.Add(legend3);
            chart_DMI.Location = new Point(448, 114);
            chart_DMI.Name = "chart_DMI";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chart_DMI.Series.Add(series3);
            chart_DMI.Size = new Size(528, 334);
            chart_DMI.TabIndex = 1;
            chart_DMI.Text = "chart1";
            title3.Name = "График функции";
            title3.Text = "График функции";
            chart_DMI.Titles.Add(title3);
            // 
            // pictureBox_DMI
            // 
            pictureBox_DMI.Image = (Image)resources.GetObject("pictureBox_DMI.Image");
            pictureBox_DMI.Location = new Point(6, 26);
            pictureBox_DMI.Name = "pictureBox_DMI";
            pictureBox_DMI.Size = new Size(389, 187);
            pictureBox_DMI.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_DMI.TabIndex = 0;
            pictureBox_DMI.TabStop = false;
            pictureBox_DMI.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(buttonSpravka_DMI);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(980, 433);
            panel2.TabIndex = 11;
            // 
            // panel6
            // 
            panel6.Controls.Add(button1);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(980, 433);
            panel6.TabIndex = 4;
            panel6.Paint += panel6_Paint;
            // 
            // panel5
            // 
            panel5.Location = new Point(823, 411);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 125);
            panel5.TabIndex = 3;
            // 
            // buttonSpravka_DMI
            // 
            buttonSpravka_DMI.BackColor = SystemColors.ButtonFace;
            buttonSpravka_DMI.Location = new Point(889, 5);
            buttonSpravka_DMI.Name = "buttonSpravka_DMI";
            buttonSpravka_DMI.Size = new Size(88, 64);
            buttonSpravka_DMI.TabIndex = 6;
            buttonSpravka_DMI.Text = "Справка";
            buttonSpravka_DMI.UseVisualStyleBackColor = false;
            buttonSpravka_DMI.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(250, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(763, 125);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(groupBox1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 484);
            panel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(229, 484);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Вывод";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(255, 192, 192);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(250, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(763, 484);
            panel7.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(889, 5);
            button1.Name = "button1";
            button1.Size = new Size(84, 64);
            button1.TabIndex = 0;
            button1.Text = "Справка";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Form_DMI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 484);
            Controls.Add(groupBox_DMI);
            Controls.Add(panel1);
            Controls.Add(panel7);
            Controls.Add(panel3);
            MinimumSize = new Size(1031, 531);
            Name = "Form_DMI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 14 | Дювенжи М. И.";
            groupBox_DMI.ResumeLayout(false);
            groupBox_DMI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart_DMI).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_DMI).EndInit();
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_DMI;
        private PictureBox pictureBox_DMI;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_DMI;
        private Button buttonResult_DMI;
        private Button buttonSave_DMI;
        private Label labelEnd_DMI;
        private Label labelNach_Dmi;
        private Button buttonSpravka_DMI;
        private TextBox textBoxEnd_DMI;
        private TextBox textBoxNach_DMI;
        private TextBox textBoxResult_DMI;
        private Label label_DMI;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Panel panel6;
        private Panel panel5;
        private Panel panel7;
        private GroupBox groupBox1;
        private Button button1;
    }
}
