using QR_Code_Scanner.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace QR_Code_Scanner.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}