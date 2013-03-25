using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using SampleMVCforMonoTouch.SampleMVC;

namespace SampleMVCforMonoTouch
{
	public partial class SampleMVCforMonoTouchViewController : UIViewController
	{
		private SampleMain mMVCMain;
		public SampleMVCforMonoTouchViewController () : base ("SampleMVCforMonoTouchViewController", null)
		{
		}
		
		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();

			// Release any cached data, images, etc that aren't in use.
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			mMVCMain = new SampleMain (this.View);
			// Perform any additional setup after loading the view, typically from a nib.
		}
		
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return (toInterfaceOrientation == UIInterfaceOrientation.PortraitUpsideDown);
		}
	}
}

