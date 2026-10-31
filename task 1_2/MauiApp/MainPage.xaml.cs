namespace MauiApp_1._2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

     

        private async void OnSubmitClicked(object sender, EventArgs e)
        {
            int n = int.Parse(NumberEntry.Text);
            await DisplayAlert("Message", "You have entered: " + n, "OK");
        }
    }
}
