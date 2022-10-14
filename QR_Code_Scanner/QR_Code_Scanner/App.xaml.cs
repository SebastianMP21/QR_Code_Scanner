using QR_Code_Scanner.Services;
using QR_Code_Scanner.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QR_Code_Scanner
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
