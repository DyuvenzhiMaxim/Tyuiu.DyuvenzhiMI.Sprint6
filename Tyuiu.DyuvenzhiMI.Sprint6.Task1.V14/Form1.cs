
using Tyuiu.DyuvenzhiMI.Sprint6.Task1.V14.Lib;

namespace Tyuiu.DyuvenzhiMI.Sprint6.Task1.V14
{
    public partial class Name_DMI : Form
    {
        public Name_DMI()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int startStep = -5;
                int stopStep = 5;
                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_DMI.Text = "";
                textBoxResult_DMI.AppendText("+------+---------+" + Environment.NewLine);
                textBoxResult_DMI.AppendText("|   X  |  f(x)   |" + Environment.NewLine);
                textBoxResult_DMI.AppendText("+------+---------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d} |  {1, 5:f2}  |", startStep, valueArray[i]);
                    textBoxResult_DMI.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_DMI.AppendText("+------+---------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Что то не так", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxReslts_DMI_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSpravka_DMI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ПИНб-25-1 Дювенжи Максим Иванович");
        }
    }
}
