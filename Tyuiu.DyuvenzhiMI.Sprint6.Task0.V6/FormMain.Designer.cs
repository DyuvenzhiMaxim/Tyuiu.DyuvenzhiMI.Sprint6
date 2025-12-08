namespace Tyuiu.DyuvenzhiMI.Sprint6.Task0.V6
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
            buttonResult_DMI = new Button();
            textBoxResult_DMI = new TextBox();
            textBoxTask0_DMI = new TextBox();
            pictureBoxTask0_DMI = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask0_DMI).BeginInit();
            SuspendLayout();
            // 
            // buttonResult_DMI
            // 
            buttonResult_DMI.Location = new Point(568, 308);
            buttonResult_DMI.Name = "buttonResult_DMI";
            buttonResult_DMI.Size = new Size(141, 55);
            buttonResult_DMI.TabIndex = 0;
            buttonResult_DMI.Text = "Вывести ответ";
            buttonResult_DMI.UseVisualStyleBackColor = true;
            buttonResult_DMI.Click += buttonResult_DMI_Click;
            // 
            // textBoxResult_DMI
            // 
            textBoxResult_DMI.Location = new Point(536, 275);
            textBoxResult_DMI.Name = "textBoxResult_DMI";
            textBoxResult_DMI.ReadOnly = true;
            textBoxResult_DMI.Size = new Size(173, 27);
            textBoxResult_DMI.TabIndex = 2;
            textBoxResult_DMI.Text = "0,866";
            // 
            // textBoxTask0_DMI
            // 
            textBoxTask0_DMI.Font = new Font("Segoe UI", 12F);
            textBoxTask0_DMI.Location = new Point(29, 12);
            textBoxTask0_DMI.Multiline = true;
            textBoxTask0_DMI.Name = "textBoxTask0_DMI";
            textBoxTask0_DMI.Size = new Size(467, 247);
            textBoxTask0_DMI.TabIndex = 3;
            textBoxTask0_DMI.Text = "Дано выражение вычислить его значение при x = 3. Округлить до трёх знаков после запятой. ";
            // 
            // pictureBoxTask0_DMI
            // 
            pictureBoxTask0_DMI.ErrorImage = (Image)resources.GetObject("pictureBoxTask0_DMI.ErrorImage");
            pictureBoxTask0_DMI.Image = (Image)resources.GetObject("pictureBoxTask0_DMI.Image");
            pictureBoxTask0_DMI.InitialImage = (Image)resources.GetObject("pictureBoxTask0_DMI.InitialImage");
            pictureBoxTask0_DMI.Location = new Point(521, 29);
            pictureBoxTask0_DMI.Name = "pictureBoxTask0_DMI";
            pictureBoxTask0_DMI.Size = new Size(188, 89);
            pictureBoxTask0_DMI.TabIndex = 4;
            pictureBoxTask0_DMI.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(536, 253);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 5;
            label1.Text = "Результат";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 375);
            Controls.Add(label1);
            Controls.Add(pictureBoxTask0_DMI);
            Controls.Add(textBoxTask0_DMI);
            Controls.Add(textBoxResult_DMI);
            Controls.Add(buttonResult_DMI);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 6 | Дювенжи М. И.";
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask0_DMI).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonResult_DMI;
        private TextBox textBoxResult_DMI;
        private TextBox textBoxTask0_DMI;
        private PictureBox pictureBoxTask0_DMI;
        private Label label1;
    }
}
