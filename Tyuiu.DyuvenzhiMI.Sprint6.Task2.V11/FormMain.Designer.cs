namespace Tyuiu.DyuvenzhiMI.Sprint6.Task2.V11
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            pictureBox1 = new PictureBox();
            ChartFunction_DMI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            button_DMI = new Button();
            button2 = new Button();
            dataGridViewFunction_DMI = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            colo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChartFunction_DMI).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_DMI).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(502, 297);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ChartFunction_DMI
            // 
            chartArea1.Name = "ChartArea1";
            ChartFunction_DMI.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            ChartFunction_DMI.Legends.Add(legend1);
            ChartFunction_DMI.Location = new Point(668, 12);
            ChartFunction_DMI.Name = "ChartFunction_DMI";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            ChartFunction_DMI.Series.Add(series1);
            ChartFunction_DMI.Size = new Size(437, 426);
            ChartFunction_DMI.TabIndex = 2;
            ChartFunction_DMI.Text = "chart1";
            // 
            // button_DMI
            // 
            button_DMI.BackColor = SystemColors.ActiveCaption;
            button_DMI.ForeColor = SystemColors.ControlText;
            button_DMI.Location = new Point(342, 323);
            button_DMI.Name = "button_DMI";
            button_DMI.Size = new Size(159, 74);
            button_DMI.TabIndex = 3;
            button_DMI.Text = "Вычеслить";
            button_DMI.UseVisualStyleBackColor = false;
            button_DMI.Click += button1_Click;
            button_DMI.MouseClick += button_DMI_MouseClick;
            button_DMI.MouseEnter += button1_MouseEnter;
            button_DMI.MouseLeave += ActiveCaption;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Info;
            button2.Location = new Point(225, 333);
            button2.Name = "button2";
            button2.Size = new Size(111, 64);
            button2.TabIndex = 4;
            button2.Text = "справка";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridViewFunction_DMI
            // 
            dataGridViewFunction_DMI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_DMI.Columns.AddRange(new DataGridViewColumn[] { X, colo });
            dataGridViewFunction_DMI.Location = new Point(520, 12);
            dataGridViewFunction_DMI.Name = "dataGridViewFunction_DMI";
            dataGridViewFunction_DMI.RowHeadersVisible = false;
            dataGridViewFunction_DMI.RowHeadersWidth = 51;
            dataGridViewFunction_DMI.Size = new Size(142, 309);
            dataGridViewFunction_DMI.TabIndex = 5;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.Width = 50;
            // 
            // colo
            // 
            colo.HeaderText = "F(x)";
            colo.MinimumWidth = 6;
            colo.Name = "colo";
            colo.Width = 50;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 450);
            Controls.Add(dataGridViewFunction_DMI);
            Controls.Add(button2);
            Controls.Add(button_DMI);
            Controls.Add(ChartFunction_DMI);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Спринт 6 | Таск 1 | Вариант 14 | Дювенжи М. И.";
            Load += Form1_Load;
            MouseEnter += Form1_MouseEnter;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChartFunction_DMI).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_DMI).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartFunction_DMI;
        private Button button_DMI;
        private Button button2;
        private DataGridView dataGridViewFunction_DMI;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn colo;
    }
}
