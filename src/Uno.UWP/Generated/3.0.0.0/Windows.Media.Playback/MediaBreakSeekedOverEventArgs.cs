#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Playback
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MediaBreakSeekedOverEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.TimeSpan NewPosition
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan MediaBreakSeekedOverEventArgs.NewPosition is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=TimeSpan%20MediaBreakSeekedOverEventArgs.NewPosition");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.TimeSpan OldPosition
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan MediaBreakSeekedOverEventArgs.OldPosition is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=TimeSpan%20MediaBreakSeekedOverEventArgs.OldPosition");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.Media.Playback.MediaBreak> SeekedOverBreaks
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<MediaBreak> MediaBreakSeekedOverEventArgs.SeekedOverBreaks is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IReadOnlyList%3CMediaBreak%3E%20MediaBreakSeekedOverEventArgs.SeekedOverBreaks");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.Playback.MediaBreakSeekedOverEventArgs.SeekedOverBreaks.get
		// Forced skipping of method Windows.Media.Playback.MediaBreakSeekedOverEventArgs.OldPosition.get
		// Forced skipping of method Windows.Media.Playback.MediaBreakSeekedOverEventArgs.NewPosition.get
	}
}
