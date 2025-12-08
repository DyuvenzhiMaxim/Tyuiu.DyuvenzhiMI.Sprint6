
using Tyuiu.DyuvenzhiMI.Sprint6.Task6.V13.Lib;
namespace Tyuiu.DyuvenzhiMI.Sprint6.Task6.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string openFilePath;
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonResult_DMI_MouseEnter(object sender, EventArgs e)
        {
            buttonResult_DMI.BackColor = Color.Gray;
        }

        private void buttonFile_DMI_MouseEnter(object sender, EventArgs e)
        {
            buttonFile_DMI.BackColor = Color.Gray;
        }

        private void buttonResult_DMI_MouseLeave(object sender, EventArgs e)
        {
            buttonResult_DMI.BackColor = Color.White;
        }

        private void buttonFile_DMI_MouseLeave(object sender, EventArgs e)
        {
            buttonFile_DMI.BackColor = Color.White;
        }

        private void buttonFile_DMI_Click(object sender, EventArgs e)
        {
            openFileDialog_DMI.ShowDialog();
            openFilePath = openFileDialog_DMI.FileName;
            textBox1_DMI.Text = File.ReadAllText(openFilePath);
            groupBoxOutPutData_DMI.Text = groupBoxOutPutData_DMI.Text + " " + openFileDialog_DMI.FileName;
            buttonResult_DMI.Enabled = true;
        }

        private void buttonResult_DMI_Click(object sender, EventArgs e)
        {
            textBox2_DMI.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
