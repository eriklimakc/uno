#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Phone.PersonalInformation
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ContactQueryOptions 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Phone.PersonalInformation.ContactQueryResultOrdering OrderBy
		{
			get
			{
				throw new global::System.NotImplementedException("The member ContactQueryResultOrdering ContactQueryOptions.OrderBy is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=ContactQueryResultOrdering%20ContactQueryOptions.OrderBy");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Phone.PersonalInformation.ContactQueryOptions", "ContactQueryResultOrdering ContactQueryOptions.OrderBy");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IList<string> DesiredFields
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<string> ContactQueryOptions.DesiredFields is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IList%3Cstring%3E%20ContactQueryOptions.DesiredFields");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public ContactQueryOptions() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Phone.PersonalInformation.ContactQueryOptions", "ContactQueryOptions.ContactQueryOptions()");
		}
		#endif
		// Forced skipping of method Windows.Phone.PersonalInformation.ContactQueryOptions.ContactQueryOptions()
		// Forced skipping of method Windows.Phone.PersonalInformation.ContactQueryOptions.DesiredFields.get
		// Forced skipping of method Windows.Phone.PersonalInformation.ContactQueryOptions.OrderBy.get
		// Forced skipping of method Windows.Phone.PersonalInformation.ContactQueryOptions.OrderBy.set
	}
}
