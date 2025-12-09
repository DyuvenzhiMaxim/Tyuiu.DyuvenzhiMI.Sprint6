namespace Tyuiu.DyuvenzhiMI.Sprint6.Task7.V24
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
            textBox1 = new TextBox();
            panel1 = new Panel();
            buttonHelp = new Button();
            buttonSaveFile_DMI = new Button();
            buttonDone_DMI = new Button();
            buttonOpenFile_DMI = new Button();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            dataGridViewInMatrix_DMI = new DataGridView();
            groupBox3 = new GroupBox();
            dataGridViewOutMatrix_DMI = new DataGridView();
            toolTipButton = new ToolTip(components);
            saveFileDialogMatrix = new SaveFileDialog();
            openFileDialogTask = new OpenFileDialog();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix_DMI).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix_DMI).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Top;
            textBox1.Location = new Point(3, 23);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(889, 82);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonHelp);
            panel1.Controls.Add(buttonSaveFile_DMI);
            panel1.Controls.Add(buttonDone_DMI);
            panel1.Controls.Add(buttonOpenFile_DMI);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(895, 68);
            panel1.TabIndex = 1;
            // 
            // buttonHelp
            // 
            buttonHelp.Image = (Image)resources.GetObject("buttonHelp.Image");
            buttonHelp.Location = new Point(816, 4);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(67, 61);
            buttonHelp.TabIndex = 3;
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonSaveFile_DMI
            // 
            buttonSaveFile_DMI.Enabled = false;
            buttonSaveFile_DMI.Image = (Image)resources.GetObject("buttonSaveFile_DMI.Image");
            buttonSaveFile_DMI.Location = new Point(166, 3);
            buttonSaveFile_DMI.Name = "buttonSaveFile_DMI";
            buttonSaveFile_DMI.Size = new Size(72, 59);
            buttonSaveFile_DMI.TabIndex = 2;
            buttonSaveFile_DMI.UseVisualStyleBackColor = true;
            buttonSaveFile_DMI.Click += buttonSaveFile_DMI_Click;
            buttonSaveFile_DMI.MouseEnter += buttonSaveFile_DMI_MouseEnter;
            // 
            // buttonDone_DMI
            // 
            buttonDone_DMI.Enabled = false;
            buttonDone_DMI.Image = (Image)resources.GetObject("buttonDone_DMI.Image");
            buttonDone_DMI.Location = new Point(89, 3);
            buttonDone_DMI.Name = "buttonDone_DMI";
            buttonDone_DMI.Size = new Size(71, 59);
            buttonDone_DMI.TabIndex = 1;
            buttonDone_DMI.UseVisualStyleBackColor = true;
            buttonDone_DMI.Click += buttonDone_DMI_Click;
            buttonDone_DMI.MouseEnter += buttonDone_DMI_MouseEnter;
            // 
            // buttonOpenFile_DMI
            // 
            buttonOpenFile_DMI.Image = (Image)resources.GetObject("buttonOpenFile_DMI.Image");
            buttonOpenFile_DMI.Location = new Point(12, 3);
            buttonOpenFile_DMI.Name = "buttonOpenFile_DMI";
            buttonOpenFile_DMI.Size = new Size(71, 59);
            buttonOpenFile_DMI.TabIndex = 0;
            buttonOpenFile_DMI.UseVisualStyleBackColor = true;
            buttonOpenFile_DMI.Click += buttonOpenFile_DMI_Click;
            buttonOpenFile_DMI.MouseEnter += buttonOpenFile_DMI_MouseEnter;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(895, 93);
            panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(895, 107);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewInMatrix_DMI);
            groupBox2.Dock = DockStyle.Left;
            groupBox2.Location = new Point(0, 161);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(413, 368);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод";
            // 
            // dataGridViewInMatrix_DMI
            // 
            dataGridViewInMatrix_DMI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInMatrix_DMI.Dock = DockStyle.Left;
            dataGridViewInMatrix_DMI.Location = new Point(3, 23);
            dataGridViewInMatrix_DMI.Name = "dataGridViewInMatrix_DMI";
            dataGridViewInMatrix_DMI.RowHeadersWidth = 51;
            dataGridViewInMatrix_DMI.Size = new Size(404, 342);
            dataGridViewInMatrix_DMI.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridViewOutMatrix_DMI);
            groupBox3.Dock = DockStyle.Right;
            groupBox3.Location = new Point(419, 161);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(476, 368);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод";
            // 
            // dataGridViewOutMatrix_DMI
            // 
            dataGridViewOutMatrix_DMI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutMatrix_DMI.Dock = DockStyle.Right;
            dataGridViewOutMatrix_DMI.Location = new Point(6, 23);
            dataGridViewOutMatrix_DMI.Name = "dataGridViewOutMatrix_DMI";
            dataGridViewOutMatrix_DMI.RowHeadersWidth = 51;
            dataGridViewOutMatrix_DMI.Size = new Size(467, 342);
            dataGridViewOutMatrix_DMI.TabIndex = 0;
            // 
            // toolTipButton
            // 
            toolTipButton.ToolTipTitle = "Подсказка";
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 529);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 14 | Дювенжи М. И.";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix_DMI).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix_DMI).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private Panel panel1;
        private Button buttonSaveFile_DMI;
        private Button buttonDone_DMI;
        private Button buttonOpenFile_DMI;
        private Panel panel2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button buttonHelp;
        private DataGridView dataGridViewInMatrix_DMI;
        private DataGridView dataGridViewOutMatrix_DMI;
        //private OpenFileDialog openFilePath;
        private ToolTip toolTipButton;
        private SaveFileDialog saveFileDialogMatrix;
        private OpenFileDialog openFileDialogTask;
    }
}
