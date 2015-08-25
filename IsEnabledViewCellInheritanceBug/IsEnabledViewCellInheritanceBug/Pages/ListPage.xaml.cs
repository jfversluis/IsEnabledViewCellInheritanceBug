using IsEnabledViewCellInheritanceBug.PageModels;
using Xamarin.Forms;

namespace IsEnabledViewCellInheritanceBug.Pages
{
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();

            BindingContext = new ListPageModel();
        }
    }
}