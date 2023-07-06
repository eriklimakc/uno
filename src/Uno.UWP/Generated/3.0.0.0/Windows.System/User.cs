#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class User 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.System.UserAuthenticationStatus AuthenticationStatus
		{
			get
			{
				throw new global::System.NotImplementedException("The member UserAuthenticationStatus User.AuthenticationStatus is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=UserAuthenticationStatus%20User.AuthenticationStatus");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string NonRoamableId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string User.NonRoamableId is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20User.NonRoamableId");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.System.UserType Type
		{
			get
			{
				throw new global::System.NotImplementedException("The member UserType User.Type is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=UserType%20User.Type");
			}
		}
		#endif
		// Forced skipping of method Windows.System.User.NonRoamableId.get
		// Forced skipping of method Windows.System.User.AuthenticationStatus.get
		// Forced skipping of method Windows.System.User.Type.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<object> GetPropertyAsync( string value)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<object> User.GetPropertyAsync(string value) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3Cobject%3E%20User.GetPropertyAsync%28string%20value%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Foundation.Collections.IPropertySet> GetPropertiesAsync( global::System.Collections.Generic.IReadOnlyList<string> values)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IPropertySet> User.GetPropertiesAsync(IReadOnlyList<string> values) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CIPropertySet%3E%20User.GetPropertiesAsync%28IReadOnlyList%3Cstring%3E%20values%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Storage.Streams.IRandomAccessStreamReference> GetPictureAsync( global::Windows.System.UserPictureSize desiredSize)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IRandomAccessStreamReference> User.GetPictureAsync(UserPictureSize desiredSize) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CIRandomAccessStreamReference%3E%20User.GetPictureAsync%28UserPictureSize%20desiredSize%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.System.UserAgeConsentResult> CheckUserAgeConsentGroupAsync( global::Windows.System.UserAgeConsentGroup consentGroup)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<UserAgeConsentResult> User.CheckUserAgeConsentGroupAsync(UserAgeConsentGroup consentGroup) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CUserAgeConsentResult%3E%20User.CheckUserAgeConsentGroupAsync%28UserAgeConsentGroup%20consentGroup%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.System.User GetDefault()
		{
			throw new global::System.NotImplementedException("The member User User.GetDefault() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=User%20User.GetDefault%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.System.UserWatcher CreateWatcher()
		{
			throw new global::System.NotImplementedException("The member UserWatcher User.CreateWatcher() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=UserWatcher%20User.CreateWatcher%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.System.User>> FindAllAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<User>> User.FindAllAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CIReadOnlyList%3CUser%3E%3E%20User.FindAllAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.System.User>> FindAllAsync( global::Windows.System.UserType type)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<User>> User.FindAllAsync(UserType type) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CIReadOnlyList%3CUser%3E%3E%20User.FindAllAsync%28UserType%20type%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.System.User>> FindAllAsync( global::Windows.System.UserType type,  global::Windows.System.UserAuthenticationStatus status)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<User>> User.FindAllAsync(UserType type, UserAuthenticationStatus status) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CIReadOnlyList%3CUser%3E%3E%20User.FindAllAsync%28UserType%20type%2C%20UserAuthenticationStatus%20status%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.System.User GetFromId( string nonRoamableId)
		{
			throw new global::System.NotImplementedException("The member User User.GetFromId(string nonRoamableId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=User%20User.GetFromId%28string%20nonRoamableId%29");
		}
		#endif
	}
}
