using System;
using MvvmCross.ViewModels;
using MvxColoredFormsTabs.ViewModels;

namespace MvxColoredFormsTabs
{
    public class CoreApp: MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();

            RegisterAppStart<MainViewModel>();
        }
    }
}
