#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Core
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class HighDynamicRangeControl 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool Enabled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool HighDynamicRangeControl.Enabled is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20HighDynamicRangeControl.Enabled");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Core.HighDynamicRangeControl", "bool HighDynamicRangeControl.Enabled");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.Core.HighDynamicRangeControl.Enabled.set
		// Forced skipping of method Windows.Media.Core.HighDynamicRangeControl.Enabled.get
	}
}
