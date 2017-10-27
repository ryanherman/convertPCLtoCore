namespace DotStanConverter.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new DotStanConverter.App());
        }
    }
}
