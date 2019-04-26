﻿using System;
using System.Collections.Generic;
using System.Text;
using Uno.UI.Samples.UITests.Helpers;
using Windows.UI.Core;

namespace SamplesApp.Windows_UI_Xaml_Controls.Models
{
	public class ListViewWithFlipViewViewModel : ViewModelBase
	{
		public ListViewWithFlipViewViewModel(CoreDispatcher dispatcher) : base(dispatcher)
		{
			//Build(b => b
			//	.Properties(pb => pb
			//		.Attach("SampleItems", GetSampleItems)
			//	)
			//);
		}

		private class FlipViewItems
		{
			public string[] Items { get; set; }
		}

		private FlipViewItems[] GetSampleItems()
		{

			return new FlipViewItems[]
			{
				new FlipViewItems{ Items = new [] {"1","2","3","4" } },
				new FlipViewItems{ Items = new [] {"1","2","3","4" } },
				new FlipViewItems{ Items = new [] {"1","2","3","4" } },
				new FlipViewItems{ Items = new [] {"1","2","3","4" } }
			};
		}
	}
}
