using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using MvxColoredFormsTabs.ViewModels;
using Xamarin.Forms.Xaml;

namespace MvxColoredFormsTabs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxContentPagePresentation(WrapInNavigationPage = true)]
    public partial class SecondView : MvxContentPage<SecondViewModel>
    {
        public SecondView()
        {
            InitializeComponent();
        }
    }
}
