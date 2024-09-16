namespace OZzadanie
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void RadioButtonCheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton && radioButton.IsChecked)
            {
         
                    Random r = new Random();
                    int diceRoll = r.Next(1, 7);

                    RollValueLabel.Text = "Wylosowany rzut: " + diceRoll.ToString();

                    SemanticScreenReader.Announce(CounterBtn.Text);
                }
            
        }

    }
}
