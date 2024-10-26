using Roman.Custom;
using Microsoft.Maui.Controls;


namespace Roman
{
    public partial class MainPage : ContentPage
    {
        private Converter _converter;

        public MainPage()
        {
            InitializeComponent();
            _converter = new Converter();
        }

        private void OnConvertClicked(object sender, EventArgs e)
        {
            // Correctly reference NumberEntry and ResultLabel from XAML
            if (int.TryParse(NumberEntry.Text, out int number) && number > 0)
            {
                string romanNumeral = _converter.NumberToRoman(number);
                ResultLabel.Text = $"Roman: {romanNumeral}";
            }
            else
            {
                ResultLabel.Text = "Please enter a valid positive number.";
            }
        }
    }
}