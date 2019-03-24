using MvvmCross.Forms.Views;
using MvxColoredFormsTabs.ViewModels;
using MvvmCross.Forms.Presenters.Attributes;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace MvxColoredFormsTabs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxTabbedPagePresentation(TabbedPosition.Root, NoHistory = true)]
    public partial class MainView : MvxTabbedPage<MainViewModel>
    {
        private bool _tabsLoaded;

        public MainView()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            On<Android>()
                .SetToolbarPlacement(ToolbarPlacement.Bottom)
                .SetBarItemColor(Xamarin.Forms.Color.Blue)
                .SetBarSelectedItemColor(Xamarin.Forms.Color.Red);

            Xamarin.Forms.PlatformConfiguration.AndroidSpecific.TabbedPage.SetIsSwipePagingEnabled(this, false);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (_tabsLoaded == false)
            {
                ViewModel.ShowTabs();
                _tabsLoaded = true;
            }
        }
    }
}
