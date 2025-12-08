
using Tyuiu.DyuvenzhiMI.Sprint6.Task4.V17.Lib;
using System.IO;
using System.Linq.Expressions;
namespace Tyuiu.DyuvenzhiMI.Sprint6.Task4.V17
{
    public partial class Form_DMI : Form
    {
        public Form_DMI()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxResult_DMI.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранён!\n открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("не сохранено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ПИНб-25-1 Дювенжи Максим Иванович");
        }

        private void buttonAnswer_DMI_Click(object sender, EventArgs e)
        {

            try
            {
                int start = Convert.ToInt32(textBoxNach_DMI.Text);
                int stop = Convert.ToInt32(textBoxEnd_DMI.Text);

                int len = ds.GetMassFunction(start, stop).Length;

                double[] Array = new double[len];
                Array = ds.GetMassFunction(start, stop);

                this.chart_DMI.ChartAreas[0].AxisX.Title = "Ось X";
                this.chart_DMI.ChartAreas[0].AxisY.Title = "Ось Y";
                textBoxResult_DMI.Text = "";

                chart_DMI.Series[0].Points.Clear();
                for (int i = 0; i < len; i++)
                {
                    this.chart_DMI.Series[0].Points.AddXY(start, Array[i]);
                    textBoxResult_DMI.AppendText(Array[i] + Environment.NewLine);
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("Что то не так", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ПИНб-25-1 Дювенжи Максим Иванович");
        }
    }
}
