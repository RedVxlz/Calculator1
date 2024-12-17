namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputNum1 = textBox1.Text;
            string inputNum2 = textBox2.Text;

            int iNum1 = Int32.Parse(inputNum1);
            int iNum2 = Int32.Parse(inputNum2);

            int AddResult = iNum1 + iNum2;
            ResultBox.Text = AddResult.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ResultBox.Clear();
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            string inputNum1 = textBox1.Text;
            string inputNum2 = textBox2.Text;

            int iNum1 = Int32.Parse(inputNum1);
            int iNum2 = Int32.Parse(inputNum2);

            int AddResult = iNum1 - iNum2;
            ResultBox.Text = AddResult.ToString();
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            string inputNum1 = textBox1.Text;
            string inputNum2 = textBox2.Text;

            int iNum1 = Int32.Parse(inputNum1);
            int iNum2 = Int32.Parse(inputNum2);

            int AddResult = iNum1 * iNum2;
            ResultBox.Text = AddResult.ToString();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            string inputNum1 = textBox1.Text;
            string inputNum2 = textBox2.Text;

            int iNum1 = Int32.Parse(inputNum1);
            int iNum2 = Int32.Parse(inputNum2);

            int AddResult = iNum1 / iNum2;
            ResultBox.Text = AddResult.ToString();
        }
    }
}
