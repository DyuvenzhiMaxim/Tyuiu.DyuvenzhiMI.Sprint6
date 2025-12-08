
using Tyuiu.DyuvenzhiMI.Sprint6.Task0.V6.Lib;

namespace Tyuiu.DyuvenzhiMI.Sprint6.Task0.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonResult_DMI_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            int x = 3;
            textBoxResult_DMI.Text = Convert.ToString(ds.Calculate(x));
            try
            {
                textBoxResult_DMI.Text = Convert.ToString(ds.Calculate(x));
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
