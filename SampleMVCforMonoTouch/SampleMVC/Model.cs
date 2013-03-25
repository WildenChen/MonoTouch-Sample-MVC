using System;
using System.Net;
using System.IO;
using System.Text;

namespace SampleMVCforMonoTouch.SampleMVC
{
	public delegate void onModelEventHandler (object sender, ModelEventArgs e);
	public class Model
	{
		public event onModelEventHandler OnModelChanged;
		private int mCurrentClickCount;//要存的資料,數字的總和

		public int CurrentClickCount {
			//寫get方法,才能夠讓view拿到這數字去顯示,不過沒用到的變數就不用寫get的,
			//不然到時候寫程式的時候,提示多一堆沒用的東西以外,還會不小心寫錯~
			get {
				return mCurrentClickCount;
			}
			set {
				//這就是重點了,當別人改變model裡面這數字的時候,就發送一個事件出去,
				mCurrentClickCount = value;
				if (OnModelChanged != null) {
					ModelEventArgs _modelEventArgs = new ModelEventArgs ();
					_modelEventArgs.ID = mCurrentClickCount;
					OnModelChanged (this, _modelEventArgs);
				}
			}
		}
		
		public Model ()
		{
			mCurrentClickCount = 0;
		}
	}

	public class ModelEventArgs:EventArgs
	{
		public int ID;
		private string mType;
		
		public string Type {
			get {
				return mType;
			}
		}
		
		public ModelEventArgs ()
		{
			mType = "model_event";
		}
	}
}

