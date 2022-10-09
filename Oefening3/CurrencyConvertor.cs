namespace Oefening3
{
    public partial class CurrencyConvertor : Form
    {
        public CurrencyConvertor()
        {
            InitializeComponent();
            //€1 = 0.98 USD (Euro)
            //1£ = 1.14 USD, (Britse Pond)
            //1CHF = 1.01 USD (Sweedse Frank)
            //1INR = 0.012 USD (Roepie)
            //1JPY = 0.0069 USD (Yen)
            //UNFINISHED
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            decimal euroInput = decimal.Parse(TextEuro.Text());
        }
    }
}