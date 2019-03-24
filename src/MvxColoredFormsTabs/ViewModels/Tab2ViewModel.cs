using System;
using System.Diagnostics;
using System.Threading.Tasks;
using MvvmCross.ViewModels;
namespace MvxColoredFormsTabs.ViewModels
{
    public class Tab2ViewModel: MvxViewModel
    {
        public Tab2ViewModel()
        {
        }

        public override Task Initialize()
        {
            Debug.WriteLine("Tab2 View Initialize");

            return base.Initialize();
        }

        public override void Prepare()
        {
            base.Prepare();

            Debug.WriteLine("Tab2 View Prepare");
        }

        public override void ViewAppeared()
        {
            base.ViewAppeared();

            Debug.WriteLine("Tab2 View Appeared");
        }

        public override void ViewDisappeared()
        {
            base.ViewDisappeared();

            Debug.WriteLine("Tab2 View Disappeared");
        }

    }
}
