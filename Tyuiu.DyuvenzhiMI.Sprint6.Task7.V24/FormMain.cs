using System.Drawing;
using System.IO;
using Tyuiu.DyuvenzhiMI.Sprint6.Task7.V24.Lib;

namespace Tyuiu.DyuvenzhiMI.Sprint6.Task7.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask.Filter = "Значения, разделённые запятыми(*.csv)|*csv|Все файлы(*.*|*.*)";
            saveFileDialogMatrix.Filter = "Значения, разделённые запятыми(*.csv)|*csv|Все файлы(*.*|*.*)";
        }

        static int rows;
        static int colums;
        static string openFilePath = "";
        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
                string fileData = File.ReadAllText(filePath);

                //Разделение на строки
                fileData = fileData.Replace('\n', '\r');
                string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

                // Определяем кол во строк и слобцов
                rows = lines.Length;
                colums = lines[0].Split(';').Length;

                // Выделите массив данных
                int[,] arrayValues = new int[rows, colums]; 


                // Заполняем массив данных
                for (int r = 0; r < rows; r++)
                {
                    string[] line_r = lines[r].Split(';');
                    for (int c = 0; c < colums; c++)
                    {
                        arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                    }

                }

                return arrayValues;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonOpenFile_DMI_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;

            // Выделите массив данных
            int[,] arrayValues = new int[rows, colums];
            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInMatrix_DMI.ColumnCount = colums;
            dataGridViewInMatrix_DMI.RowCount = rows;
            dataGridViewOutMatrix_DMI.ColumnCount = colums;
            dataGridViewOutMatrix_DMI.RowCount = rows;

            // задаём ширину столбцов dataGridViewInMatrix_DMI
            for (int i = 0; i < colums; i++)
            {
                dataGridViewInMatrix_DMI.Columns[i].Width = 25;
                dataGridViewOutMatrix_DMI.Columns[i].Width = 25;
            }

            //Добавьте данные в dataGridViewInMatrix_DMI
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewInMatrix_DMI.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix((openFilePath));
            buttonDone_DMI.Enabled = true;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_DMI_Click(object sender, EventArgs e)
        {
            // Выделите массив данных
            int[,] arrayValues = new int[rows, colums];
            arrayValues = ds.GetMatrix((openFilePath));

            // Добавляем в dataGridViewInMatrix_DMI
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewOutMatrix_DMI.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSaveFile_DMI.Enabled = true;
        }

        private void buttonSaveFile_DMI_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix.ShowDialog();

            string path = saveFileDialogMatrix.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewInMatrix_DMI.RowCount;
            int columns = dataGridViewInMatrix_DMI.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutMatrix_DMI.Rows[i].Cells[j].Value + ';';
                    }
                    else
                    {
                        str = str + dataGridViewOutMatrix_DMI.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpenFile_DMI_MouseEnter(object sender, EventArgs e)
        {
            //toolTipButton.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_DMI_MouseEnter(object sender, EventArgs e)
        {
            //toolTipButton.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_DMI_MouseEnter(object sender, EventArgs e)
        {
            //toolTipButton.ToolTipTitle = "Сохранить в файл";
        }
    }
}
