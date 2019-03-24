using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using MvxColoredFormsTabs.ViewModels;

namespace MvxColoredFormsTabs
{
    [MvxTabbedPagePresentation(WrapInNavigationPage = false)]
    public partial class Tab2View : MvxContentPage<Tab2ViewModel>
    {
        public Tab2View()
        {
            InitializeComponent();
        }
    }
}
