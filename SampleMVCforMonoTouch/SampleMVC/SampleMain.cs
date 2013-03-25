using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace SampleMVCforMonoTouch.SampleMVC
{
	public class SampleMain
	{
		private Model mModel;
		private Controllers mController;
		private TextViews mTextView;
		
		
		private UILabel mLabel;
		private UIButton mIncButton;
		private UIButton mDecButton;
		private UIView mContainer;

		//最開始執行的程式
		public SampleMain (UIView pContainer)
		{
			mContainer = pContainer;
			
			mLabel = new UILabel ();
			mLabel.Frame = new RectangleF (10, 10, 300, 100);
			mIncButton = new UIButton (UIButtonType.RoundedRect);
			mIncButton.Frame = new RectangleF (10, 110, 100, 80);
			mDecButton = new UIButton (UIButtonType.RoundedRect);
			mDecButton.Frame = new RectangleF (120, 110, 100, 80);
			
			mContainer.AddSubview (mLabel);
			mContainer.AddSubview (mIncButton);
			mContainer.AddSubview (mDecButton);

			// Simple MVC Start!
			mModel = new Model ();//要實體化model後才能夠在裡面存東西
			mTextView = new TextViews (mLabel);//把會因為model改變的Label丟進LabelView裡面
			mTextView.Model = mModel;//當然還要告訴view說model是誰
			
			mController = new Controllers (mModel);//control當然也要知道model是誰,所以把model丟進去
			mController.AddIncButton (mIncButton);//把會在mvc中用到的控制項作設定
			mController.AddDecButton (mDecButton);
			Console.WriteLine ("MVC Start!");
			// Simple MVC End!
		}
	}
}

