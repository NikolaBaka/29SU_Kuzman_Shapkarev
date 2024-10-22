namespace ChangeDesk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double USD = 1.8;
            double EUR = 1.96;
            double RUB = 0.019;
            double YEN = 0.012;

            double result;
            double value;

            if (radioButtonUSD.Checked)
            {
                value = double.Parse(textBoxCurrency.Text);

                result = value * USD;

                labelCaculation.Text = result.ToString() + " BGN";
            }
            if (radioButtonEUR.Checked)
            {
                value = double.Parse(textBoxCurrency.Text);

                result = value * EUR;

                labelCaculation.Text = result.ToString() + " BGN";
            }
            if (radioButtonRUB.Checked)
            {
                value = double.Parse(textBoxCurrency.Text);

                result = value * RUB;
                result = Math.Round(result, 2);

                labelCaculation.Text = result.ToString() + " BGN";
            }
            if (radioButtonYEN.Checked)
            {
                value = double.Parse(textBoxCurrency.Text);

                result = value * YEN;

                labelCaculation.Text = result.ToString() + " BGN";
            }
        }
    }
}
