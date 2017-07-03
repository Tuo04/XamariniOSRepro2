using System;

using UIKit;
using Microsoft.Azure.Mobile.Crashes;

namespace iOSXamarinBitbucket
{
    public partial class FirstViewController : UIViewController
    {
        protected FirstViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void UIButton5_TouchUpInside(UIButton sender)
        {
            Crashes.GenerateTestCrash();
        }
    }
}
