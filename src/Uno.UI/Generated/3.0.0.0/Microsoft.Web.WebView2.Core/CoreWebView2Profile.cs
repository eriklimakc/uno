#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.Web.WebView2.Core
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CoreWebView2Profile 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.Web.WebView2.Core.CoreWebView2PreferredColorScheme PreferredColorScheme
		{
			get
			{
				throw new global::System.NotImplementedException("The member CoreWebView2PreferredColorScheme CoreWebView2Profile.PreferredColorScheme is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=CoreWebView2PreferredColorScheme%20CoreWebView2Profile.PreferredColorScheme");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Web.WebView2.Core.CoreWebView2Profile", "CoreWebView2PreferredColorScheme CoreWebView2Profile.PreferredColorScheme");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string DefaultDownloadFolderPath
		{
			get
			{
				throw new global::System.NotImplementedException("The member string CoreWebView2Profile.DefaultDownloadFolderPath is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20CoreWebView2Profile.DefaultDownloadFolderPath");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Web.WebView2.Core.CoreWebView2Profile", "string CoreWebView2Profile.DefaultDownloadFolderPath");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsInPrivateModeEnabled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool CoreWebView2Profile.IsInPrivateModeEnabled is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20CoreWebView2Profile.IsInPrivateModeEnabled");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string ProfileName
		{
			get
			{
				throw new global::System.NotImplementedException("The member string CoreWebView2Profile.ProfileName is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20CoreWebView2Profile.ProfileName");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string ProfilePath
		{
			get
			{
				throw new global::System.NotImplementedException("The member string CoreWebView2Profile.ProfilePath is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20CoreWebView2Profile.ProfilePath");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction ClearBrowsingDataAsync( global::Microsoft.Web.WebView2.Core.CoreWebView2BrowsingDataKinds dataKinds,  global::System.DateTimeOffset startTime,  global::System.DateTimeOffset endTime)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction CoreWebView2Profile.ClearBrowsingDataAsync(CoreWebView2BrowsingDataKinds dataKinds, DateTimeOffset startTime, DateTimeOffset endTime) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20CoreWebView2Profile.ClearBrowsingDataAsync%28CoreWebView2BrowsingDataKinds%20dataKinds%2C%20DateTimeOffset%20startTime%2C%20DateTimeOffset%20endTime%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction ClearBrowsingDataAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncAction CoreWebView2Profile.ClearBrowsingDataAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20CoreWebView2Profile.ClearBrowsingDataAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction ClearBrowsingDataAsync( global::Microsoft.Web.WebView2.Core.CoreWebView2BrowsingDataKinds dataKinds)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction CoreWebView2Profile.ClearBrowsingDataAsync(CoreWebView2BrowsingDataKinds dataKinds) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20CoreWebView2Profile.ClearBrowsingDataAsync%28CoreWebView2BrowsingDataKinds%20dataKinds%29");
		}
		#endif
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2Profile.ProfileName.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2Profile.IsInPrivateModeEnabled.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2Profile.ProfilePath.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2Profile.DefaultDownloadFolderPath.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2Profile.DefaultDownloadFolderPath.set
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2Profile.PreferredColorScheme.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2Profile.PreferredColorScheme.set
	}
}
