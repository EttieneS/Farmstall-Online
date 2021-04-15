using System.ComponentModel;
using Xamarin.Forms;
using Farmstall_Online.ViewModels;

namespace Farmstall_Online.Views
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