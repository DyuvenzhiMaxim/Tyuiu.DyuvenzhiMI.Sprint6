
using Tyuiu.DyuvenzhiMI.Sprint6.Task3.V24.Lib;


namespace Tyuiu.DyuvenzhiMI.Sprint6.Task3.V24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mas1 = new int[5, 5] { { -17, -6, 10, 5, 3 },
                                    {  -10, -14, 10, -7, -3 },
                                    { -19, 9, 8, -17, -9 },
                                    { -19, -5, -9, -18, 14 },
                                    { 17, 12, 11, 12, 2 } };
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSPR_DMI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ПИНб-25-1 Дювенжи Максим Иванович");
        }

        private void buttonResult_DMI_Click(object sender, EventArgs e)
        {
            int[,] mas = ds.Calculate(mas1);
            /*try
            {

                int len = ds.Calculate(mas).Length;

                int[,] valueArray = new int[5, 5];
                valueArray = ds.Calculate(mas);
                int start = 0;
                for (int i = 0; i < len; i++)
                {
                    for (int j = 0; j < len; j++)
                    {
                        this.dataGridViewFunction_DMI.Rows.Add(Convert.ToString(start), Convert.ToString(valueArray[i, j]));
                        start++;
                    }

                }
            }
            catch
            {
                MessageBox.Show("Что то не так", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[,] mas = ds.Calculate(mas1);
            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.Length / rows;

            dataGridViewFunction_DMI.ColumnCount = columns;
            dataGridViewFunction_DMI.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewFunction_DMI.Columns[i].Width = 40;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewFunction_DMI.Rows[i].Cells[j].Value = Convert.ToString(mas[i, j]);
                }
            }
        }
    }
}

