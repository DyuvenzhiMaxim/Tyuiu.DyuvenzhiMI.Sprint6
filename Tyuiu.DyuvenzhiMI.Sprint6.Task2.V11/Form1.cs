using Tyuiu.DyuvenzhiMI.Sprint6.Task2.V11.Lib;
namespace Tyuiu.DyuvenzhiMI.Sprint6.Task2.V11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ПИНб-25-1 Дювенжи Максим Иванович");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int start = -5;
                int stop = 5;
                int len = ds.GetMassFunction(start, stop).Length;

                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(start, stop);

                this.ChartFunction_DMI.ChartAreas[0].AxisX.Title = "Ось X";
                this.ChartFunction_DMI.ChartAreas[0].AxisX.Title = "Ось Y";

                for (int i = 0; i < len; i++)
                {
                    this.dataGridViewFunction_DMI.Rows.Add(Convert.ToString(start), Convert.ToString(valueArray[i]));
                    this.ChartFunction_DMI.Series[0].Points.AddXY(start, valueArray[i]);
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("Что то не так", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button_DMI.BackColor = Color.Red;
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void ActiveCaption(object sender, EventArgs e)
        {
            button_DMI.BackColor = Color.Blue;
        }

        private void button_DMI_MouseClick(object sender, MouseEventArgs e)
        {
            button_DMI.BackColor = Color.Yellow;
        }
    }
}
