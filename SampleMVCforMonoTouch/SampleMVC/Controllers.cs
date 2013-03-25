using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace SampleMVCforMonoTouch.SampleMVC
{
	public class Controllers
	{
		public Model Model;
		public Controllers (Model pModel)
		{
			this.Model = pModel;//把model丟進來
		}
		
		public void AddIncButton (UIButton pButton)
		{
			pButton.TouchUpInside += HandleTouchUpInside;
			//設定增加數值的按鈕,按鈕丟進來,就偵聽,只要按下按鈕就改變model
		}
		
		void HandleTouchUpInside (object sender, EventArgs e)
		{
			this.Model.CurrentClickCount++;
		}


		public void AddDecButton (UIButton pButton)
		{
			pButton.TouchUpInside += HandleDecTouchUpInside;
		}

		void HandleDecTouchUpInside (object sender, EventArgs e)
		{
			this.Model.CurrentClickCount--;
		}
	}
}

