#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.DataTransfer
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public static partial class HtmlFormatHelper 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static string GetStaticFragment( string htmlFormat)
		{
			throw new global::System.NotImplementedException("The member string HtmlFormatHelper.GetStaticFragment(string htmlFormat) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20HtmlFormatHelper.GetStaticFragment%28string%20htmlFormat%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static string CreateHtmlFormat( string htmlFragment)
		{
			throw new global::System.NotImplementedException("The member string HtmlFormatHelper.CreateHtmlFormat(string htmlFragment) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20HtmlFormatHelper.CreateHtmlFormat%28string%20htmlFragment%29");
		}
		#endif
	}
}
