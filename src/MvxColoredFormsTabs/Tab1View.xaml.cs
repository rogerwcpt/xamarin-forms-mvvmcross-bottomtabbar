using MvvmCross.Forms.Views;
using MvxColoredFormsTabs.ViewModels;
using MvvmCross.Forms.Presenters.Attributes;

namespace MvxColoredFormsTabs
{
    [MvxTabbedPagePresentation(WrapInNavigationPage = false)]
    public partial class Tab1View : MvxContentPage<Tab1ViewModel>
    {
        public Tab1View()
        {
            InitializeComponent();
        }
    }
}
