namespace MerhabaDünyaÖrneği
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

   
        private void button1_Click_1(object sender, EventArgs e)
        {
            label6.Text = Convert.ToString(Convert.ToInt16(textBox1.Text) + Convert.ToInt16(textBox2.Text));

        }
    }
}