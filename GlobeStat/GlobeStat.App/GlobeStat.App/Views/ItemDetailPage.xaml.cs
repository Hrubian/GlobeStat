using GlobeStat.App.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace GlobeStat.App.Views
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