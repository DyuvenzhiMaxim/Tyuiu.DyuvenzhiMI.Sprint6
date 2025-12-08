using Tyuiu.DyuvenzhiMI.Sprint6.Task5.V12.Lib;
namespace Tyuiu.DyuvenzhiMI.Sprint6.Task5.V12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"D:\programming\repos\Tyuiu.DyuvenzhiMI.Sprint6\Tyuiu.DyuvenzhiMI.Sprint6.Task5.V12\bin\Debug\net8.0-windows\InPutDataFileTask5V12.txt";

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView_DMI.ColumnCount = 2;
            dataGridView_DMI.Columns[0].Width = 20;
            dataGridView_DMI.Columns[1].Width = 50;

            this.chart_DMI.ChartAreas[0].AxisX.Title = "X";
            this.chart_DMI.ChartAreas[0].AxisY.Title = "Y";

            chart_DMI.Series[0].Points.Clear();
            double[] mas = new double[ds.len];

            mas = ds.LoadFromDataFile(path); //Самая важная часть

            for (int i = 0; i < mas.Length; i++)
            {
                dataGridView_DMI.Rows.Add(Convert.ToString(i), Convert.ToString(mas[i]));
                chart_DMI.Series[0].Points.AddXY(i, mas[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ПИНб-25-1 Дювенжи Максим Иванович");
        }
    }
}
