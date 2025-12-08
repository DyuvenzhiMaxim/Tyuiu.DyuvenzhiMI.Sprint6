namespace Tyuiu.DyuvenzhiMI.Sprint6.Task6.V13
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panel1 = new Panel();
            button1 = new Button();
            buttonResult_DMI = new Button();
            buttonFile_DMI = new Button();
            panel2 = new Panel();
            groupBox3 = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel3 = new Panel();
            groupBox1 = new GroupBox();
            textBox1_DMI = new TextBox();
            panel4 = new Panel();
            splitter1 = new Splitter();
            groupBoxOutPutData_DMI = new GroupBox();
            textBox2_DMI = new TextBox();
            openFileDialog_DMI = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            panel4.SuspendLayout();
            groupBoxOutPutData_DMI.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(buttonResult_DMI);
            panel1.Controls.Add(buttonFile_DMI);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1144, 79);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(1065, 8);
            button1.Name = "button1";
            button1.Size = new Size(67, 61);
            button1.TabIndex = 2;
            toolTip1.SetToolTip(button1, "справка");
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonResult_DMI
            // 
            buttonResult_DMI.Image = (Image)resources.GetObject("buttonResult_DMI.Image");
            buttonResult_DMI.Location = new Point(102, 3);
            buttonResult_DMI.Name = "buttonResult_DMI";
            buttonResult_DMI.Size = new Size(84, 70);
            buttonResult_DMI.TabIndex = 1;
            toolTip1.SetToolTip(buttonResult_DMI, "получит ответ");
            buttonResult_DMI.UseVisualStyleBackColor = true;
            buttonResult_DMI.Click += buttonResult_DMI_Click;
            buttonResult_DMI.MouseEnter += buttonResult_DMI_MouseEnter;
            buttonResult_DMI.MouseLeave += buttonResult_DMI_MouseLeave;
            // 
            // buttonFile_DMI
            // 
            buttonFile_DMI.Image = (Image)resources.GetObject("buttonFile_DMI.Image");
            buttonFile_DMI.Location = new Point(12, 3);
            buttonFile_DMI.Name = "buttonFile_DMI";
            buttonFile_DMI.Size = new Size(84, 70);
            buttonFile_DMI.TabIndex = 0;
            toolTip1.SetToolTip(buttonFile_DMI, "Файл для загрузки:");
            buttonFile_DMI.UseVisualStyleBackColor = true;
            buttonFile_DMI.Click += buttonFile_DMI_Click;
            buttonFile_DMI.MouseEnter += buttonFile_DMI_MouseEnter;
            buttonFile_DMI.MouseLeave += buttonFile_DMI_MouseLeave;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(1144, 125);
            panel2.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1144, 125);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Условие";
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Top;
            textBox2.Location = new Point(3, 23);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(1138, 93);
            textBox2.TabIndex = 1;
            textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // textBox1
            // 
            textBox1.Location = new Point(-23, 218);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 204);
            panel3.Name = "panel3";
            panel3.Size = new Size(565, 362);
            panel3.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1_DMI);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(565, 362);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод";
            // 
            // textBox1_DMI
            // 
            textBox1_DMI.Dock = DockStyle.Left;
            textBox1_DMI.Location = new Point(3, 23);
            textBox1_DMI.Multiline = true;
            textBox1_DMI.Name = "textBox1_DMI";
            textBox1_DMI.ScrollBars = ScrollBars.Vertical;
            textBox1_DMI.Size = new Size(556, 336);
            textBox1_DMI.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(splitter1);
            panel4.Controls.Add(groupBoxOutPutData_DMI);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(571, 204);
            panel4.Name = "panel4";
            panel4.Size = new Size(573, 362);
            panel4.TabIndex = 1;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 362);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // groupBoxOutPutData_DMI
            // 
            groupBoxOutPutData_DMI.Controls.Add(textBox2_DMI);
            groupBoxOutPutData_DMI.Dock = DockStyle.Right;
            groupBoxOutPutData_DMI.Location = new Point(0, 0);
            groupBoxOutPutData_DMI.Name = "groupBoxOutPutData_DMI";
            groupBoxOutPutData_DMI.Size = new Size(573, 362);
            groupBoxOutPutData_DMI.TabIndex = 1;
            groupBoxOutPutData_DMI.TabStop = false;
            groupBoxOutPutData_DMI.Text = "Вывод";
            // 
            // textBox2_DMI
            // 
            textBox2_DMI.Dock = DockStyle.Right;
            textBox2_DMI.Location = new Point(10, 23);
            textBox2_DMI.Multiline = true;
            textBox2_DMI.Name = "textBox2_DMI";
            textBox2_DMI.ScrollBars = ScrollBars.Vertical;
            textBox2_DMI.Size = new Size(560, 336);
            textBox2_DMI.TabIndex = 0;
            // 
            // openFileDialog_DMI
            // 
            openFileDialog_DMI.FileName = "openFileDialog1";
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 566);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 14 | Дювенжи М. И.";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel4.ResumeLayout(false);
            groupBoxOutPutData_DMI.ResumeLayout(false);
            groupBoxOutPutData_DMI.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonFile_DMI;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Splitter splitter1;
        private Button buttonResult_DMI;
        private GroupBox groupBox1;
        private GroupBox groupBoxOutPutData_DMI;
        private GroupBox groupBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private ToolTip toolTip1;
        private OpenFileDialog openFileDialog_DMI;
        private TextBox textBox1_DMI;
        private TextBox textBox2_DMI;
    }
}
