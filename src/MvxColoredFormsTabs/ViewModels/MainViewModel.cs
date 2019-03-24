using System;
using MvvmCross.ViewModels;
using System.Threading.Tasks;
using System.Collections.Generic;
using MvvmCross.Navigation;
using MvvmCross.Commands;

namespace MvxColoredFormsTabs.ViewModels
{
    public class MainViewModel: MvxViewModel
    {
        private readonly IMvxNavigationService navigationService;

        public MainViewModel(IMvxNavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        public Task ShowTabs()
        {
            var tasks = new List<Task>();
            tasks.Add(navigationService.Navigate<Tab1ViewModel>());
            tasks.Add(navigationService.Navigate<Tab2ViewModel>());
            return Task.WhenAll(tasks);

        }
    }
}
