namespace CurrencyConverter
{
    public partial class MainForm : Form
    {
        CurrencyConverter currencyConverter;
        public MainForm()
        {
            InitializeComponent();
            currencyConverter = new CurrencyConverter();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Store symbols from GetCurrencySymbols into Dictionary datatype variable currencySymbolData
            Dictionary<string, string> currencySymbolData = currencyConverter.GetCurrencySymbols();
            cmbFromCurrency.Items.Clear();
            cmbToCurrency.Items.Clear();

            cmbFromCurrency.DataSource = new BindingSource(currencySymbolData, null);
            cmbFromCurrency.DisplayMember = "Value";
            cmbFromCurrency.ValueMember = "Key";

            cmbToCurrency.DataSource = new BindingSource(currencySymbolData, null);
            cmbToCurrency.DisplayMember = "Value";
            cmbToCurrency.ValueMember = "Key";
        }

        private void btnConvertCurrency_Click(object sender, EventArgs e)
        {
            string fromCurrency = ((KeyValuePair<string, string>) cmbFromCurrency.SelectedItem).Key;
            string toCurrency = ((KeyValuePair<string, string>)cmbToCurrency.SelectedItem).Key;
            double currencyAmount = double.Parse(txtFromCurrency.Text);
            double finalConversionAmount = currencyConverter.Convert(fromCurrency, toCurrency, currencyAmount);
            txtToCurrency.Text = finalConversionAmount.ToString();
        }

    }
}