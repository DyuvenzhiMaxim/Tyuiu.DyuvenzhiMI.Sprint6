namespace Tyuiu.DyuvenzhiMI.Sprint6.Task3.V24
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
            groupBox1 = new GroupBox();
            buttonSPR_DMI = new Button();
            buttonResult_DMI = new Button();
            dataGridViewFunction_DMI = new DataGridView();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_DMI).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonSPR_DMI);
            groupBox1.Controls.Add(buttonResult_DMI);
            groupBox1.Controls.Add(dataGridViewFunction_DMI);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Таск 3";
            // 
            // buttonSPR_DMI
            // 
            buttonSPR_DMI.Location = new Point(151, 368);
            buttonSPR_DMI.Name = "buttonSPR_DMI";
            buttonSPR_DMI.Size = new Size(43, 42);
            buttonSPR_DMI.TabIndex = 3;
            buttonSPR_DMI.Text = "?";
            buttonSPR_DMI.UseVisualStyleBackColor = true;
            buttonSPR_DMI.Click += buttonSPR_DMI_Click;
            // 
            // buttonResult_DMI
            // 
            buttonResult_DMI.Location = new Point(200, 321);
            buttonResult_DMI.Name = "buttonResult_DMI";
            buttonResult_DMI.Size = new Size(149, 89);
            buttonResult_DMI.TabIndex = 1;
            buttonResult_DMI.Text = "Ответ";
            buttonResult_DMI.UseVisualStyleBackColor = true;
            buttonResult_DMI.Click += buttonResult_DMI_Click;
            // 
            // dataGridViewFunction_DMI
            // 
            dataGridViewFunction_DMI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_DMI.Location = new Point(382, 20);
            dataGridViewFunction_DMI.Name = "dataGridViewFunction_DMI";
            dataGridViewFunction_DMI.RowHeadersWidth = 51;
            dataGridViewFunction_DMI.Size = new Size(388, 400);
            dataGridViewFunction_DMI.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(356, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Спринт 6 | Таск 1 | Вариант 14 | Дювенжи М. И.";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_DMI).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private DataGridView dataGridViewFunction_DMI;
        private Button buttonSPR_DMI;
        private Button buttonResult_DMI;
    }
}
