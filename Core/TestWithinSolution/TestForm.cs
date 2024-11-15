using Core;

namespace TestWithinSolution
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dataAccess = new MyDataAccess();
            dataAccess.Test();
        }
    }
}
