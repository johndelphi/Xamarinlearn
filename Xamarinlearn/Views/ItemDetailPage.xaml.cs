using System.ComponentModel;
using Xamarin.Forms;
using Xamarinlearn.ViewModels;

namespace Xamarinlearn.Views
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