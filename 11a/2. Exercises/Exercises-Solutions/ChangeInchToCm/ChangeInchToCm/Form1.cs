namespace ChangeInchToCm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void пресметни_Click(object sender, EventArgs e)
        {
            try
            {
                double Inch = double.Parse(textBoxCalculate.Text);
                double cmValue = 2.54;
                double result = Inch * cmValue;
                result = Math.Abs(result);

                labelCalculation.Text = result.ToString() + " cm";
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Enter a number");
            }

            
        }
    }
}
