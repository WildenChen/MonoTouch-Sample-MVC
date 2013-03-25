using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace SampleMVCforMonoTouch.SampleMVC
{
	public class TextViews:Views
	{
		private UILabel mContainer;

		//把Label丟進來.
		public TextViews (UILabel pContainer)
		{
			mContainer = pContainer;
		}

		//當model改變的時候,就...改變顯示Label
		protected override void HandleOnModelChanged (object sender, ModelEventArgs e)
		{
			base.HandleOnModelChanged (sender, e);
			mContainer.Text = "" + this.Model.CurrentClickCount;//要顯示的內容是model裡面的totals變數數值
		}

	}
}

