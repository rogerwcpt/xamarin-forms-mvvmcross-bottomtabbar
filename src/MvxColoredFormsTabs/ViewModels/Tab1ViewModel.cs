using System;
using System.Diagnostics;
using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
namespace MvxColoredFormsTabs.ViewModels
{
    public class Tab1ViewModel: MvxViewModel
    {
        private readonly IMvxNavigationService navigationService;

        public Tab1ViewModel(IMvxNavigationService navigationService)
        {
            Button1Command = new MvxAsyncCommand(DoButton1Command);
            this.navigationService = navigationService;
        }

        public MvxAsyncCommand Button1Command { get; }
        private Task DoButton1Command()
        {
            return navigationService.Navigate<SecondViewModel>();
        }

        public override Task Initialize()
        {
            Debug.WriteLine("Tab1 View Initialize");

            return base.Initialize();
        }

        public override void Prepare()
        {
            base.Prepare();

            Debug.WriteLine("Tab1 View Prepare");
        }

        public override void ViewDisappeared()
        {
            base.ViewDisappeared();

            Debug.WriteLine("Tab1 View Disappeared");
        }

        public override void ViewAppeared()
        {
            base.ViewAppeared();

            Debug.WriteLine("Tab1 View Appeared");
        }
    }
}
