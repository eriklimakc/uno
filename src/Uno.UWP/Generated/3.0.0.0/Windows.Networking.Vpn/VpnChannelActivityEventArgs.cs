#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.Vpn
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class VpnChannelActivityEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Networking.Vpn.VpnChannelActivityEventType Type
		{
			get
			{
				throw new global::System.NotImplementedException("The member VpnChannelActivityEventType VpnChannelActivityEventArgs.Type is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=VpnChannelActivityEventType%20VpnChannelActivityEventArgs.Type");
			}
		}
		#endif
		// Forced skipping of method Windows.Networking.Vpn.VpnChannelActivityEventArgs.Type.get
	}
}
