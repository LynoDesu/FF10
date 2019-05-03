using System;

using AppKit;
using Foundation;
using FF10.Core.ViewModels;

namespace FF10.Mac
{
    public partial class ViewController : NSViewController
    {
        MainWindowViewModel _viewModel;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            _viewModel = new MainWindowViewModel();

            base.ViewDidLoad();
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }
    }
}
