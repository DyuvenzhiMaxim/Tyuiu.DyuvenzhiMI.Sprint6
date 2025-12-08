namespace Tyuiu.DyuvenzhiMI.Sprint6.Task1.V14
{
    partial class Name_DMI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Name_DMI));
            textBoxResult_DMI = new TextBox();
            buttonResult_Dmi = new Button();
            buttonSpravka_DMI = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxResult_DMI
            // 
            textBoxResult_DMI.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_DMI.Location = new Point(497, 12);
            textBoxResult_DMI.Multiline = true;
            textBoxResult_DMI.Name = "textBoxResult_DMI";
            textBoxResult_DMI.Size = new Size(291, 395);
            textBoxResult_DMI.TabIndex = 0;
            textBoxResult_DMI.TextChanged += textBoxReslts_DMI_TextChanged;
            // 
            // buttonResult_Dmi
            // 
            buttonResult_Dmi.Font = new Font("Segoe UI", 15F);
            buttonResult_Dmi.Location = new Point(298, 285);
            buttonResult_Dmi.Name = "buttonResult_Dmi";
            buttonResult_Dmi.Size = new Size(193, 79);
            buttonResult_Dmi.TabIndex = 2;
            buttonResult_Dmi.Text = "Вычислить";
            buttonResult_Dmi.UseVisualStyleBackColor = true;
            buttonResult_Dmi.Click += button1_Click;
            // 
            // buttonSpravka_DMI
            // 
            buttonSpravka_DMI.Font = new Font("Segoe UI", 10F);
            buttonSpravka_DMI.Location = new Point(205, 297);
            buttonSpravka_DMI.Name = "buttonSpravka_DMI";
            buttonSpravka_DMI.Size = new Size(87, 67);
            buttonSpravka_DMI.TabIndex = 3;
            buttonSpravka_DMI.Text = "Справка";
            buttonSpravka_DMI.UseVisualStyleBackColor = true;
            buttonSpravka_DMI.Click += buttonSpravka_DMI_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(489, 267);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Name_DMI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(buttonSpravka_DMI);
            Controls.Add(buttonResult_Dmi);
            Controls.Add(textBoxResult_DMI);
            Name = "Name_DMI";
            Text = "Спринт 6 | Таск 1 | Вариант 14 | Дювенжи М. И.";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxResult_DMI;
        private TextBox textBoxTask1_DMI;
        private Button buttonResult_Dmi;
        private Button buttonSpravka_DMI;
        private PictureBox pictureBox1;
    }
}
