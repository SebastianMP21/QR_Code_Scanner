using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;



using Xamarin.Forms.Xaml;

namespace QR_Code_Scanner
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnScannerQR_Clicked(object sender, EventArgs e)
        {
            try
            {
                var scanner = new ZXing.Mobile.MobileBarcodeScanner();
                scanner.TopText = "Hola soy Sebastian Marquez \ny esto es un QR";
                scanner.BottomText = "Semana 8";
                var result = await scanner.Scan();
                if (result != null)
                {
                    txtResultado.Text = result.Text;
                }
            }
            catch (Exception ex)
            {

                await DisplayAlert("Error", ex.Message.ToString(), "OK");
            }
        }
    }
}