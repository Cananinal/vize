namespace lıste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pazartesi pzt = new pazartesi();
            pzt.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            salı sal = new salı();
            sal.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            çarşamba cars = new çarşamba();
            cars.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            perşembe pers = new perşembe();
            pers.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            cuma cum = new cuma();
            cum.ShowDialog();
        }
    }
}