namespace ChageBuro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            double BGN = double.Parse(textBoxCurrency.Text);
            double EURO = 1.95585;

            double result = Math.Round(BGN / EURO, 2);

            lableShow.Text = result.ToString();

            if (BGN < 0)
            {
                lableShow.Text = "Error";
            }
            else if (BGN == 0)
            {
                lableShow.Text = "0 euro";
            }
            else
            {
                lableShow.Text = result.ToString() + " euro";
            }
        }
    }
}
