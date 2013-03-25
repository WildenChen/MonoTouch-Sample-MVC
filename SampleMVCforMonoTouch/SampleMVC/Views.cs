using System;

namespace SampleMVCforMonoTouch.SampleMVC
{
	public class Views
	{
		public Views ()
		{
		}

		protected Model mModel;
		
		public Model Model {
			get {
				return mModel;
			}
			set {
				// 當model的變數被設定的時候,同時對model偵聽的事件,
				mModel = value;
				mModel.OnModelChanged += HandleOnModelChanged;
			}
		}

		protected virtual void HandleOnModelChanged (object sender, ModelEventArgs e)
		{
			
		}

	}
}

