#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Calls
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class PhoneCallHistoryEntryQueryOptions 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Calls.PhoneCallHistoryEntryQueryDesiredMedia DesiredMedia
		{
			get
			{
				throw new global::System.NotImplementedException("The member PhoneCallHistoryEntryQueryDesiredMedia PhoneCallHistoryEntryQueryOptions.DesiredMedia is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=PhoneCallHistoryEntryQueryDesiredMedia%20PhoneCallHistoryEntryQueryOptions.DesiredMedia");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Calls.PhoneCallHistoryEntryQueryOptions", "PhoneCallHistoryEntryQueryDesiredMedia PhoneCallHistoryEntryQueryOptions.DesiredMedia");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IList<string> SourceIds
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<string> PhoneCallHistoryEntryQueryOptions.SourceIds is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IList%3Cstring%3E%20PhoneCallHistoryEntryQueryOptions.SourceIds");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public PhoneCallHistoryEntryQueryOptions() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Calls.PhoneCallHistoryEntryQueryOptions", "PhoneCallHistoryEntryQueryOptions.PhoneCallHistoryEntryQueryOptions()");
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Calls.PhoneCallHistoryEntryQueryOptions.PhoneCallHistoryEntryQueryOptions()
		// Forced skipping of method Windows.ApplicationModel.Calls.PhoneCallHistoryEntryQueryOptions.DesiredMedia.get
		// Forced skipping of method Windows.ApplicationModel.Calls.PhoneCallHistoryEntryQueryOptions.DesiredMedia.set
		// Forced skipping of method Windows.ApplicationModel.Calls.PhoneCallHistoryEntryQueryOptions.SourceIds.get
	}
}
