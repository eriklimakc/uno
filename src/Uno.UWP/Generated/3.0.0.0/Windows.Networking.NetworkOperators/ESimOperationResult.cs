#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.NetworkOperators
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ESimOperationResult 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Networking.NetworkOperators.ESimOperationStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member ESimOperationStatus ESimOperationResult.Status is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=ESimOperationStatus%20ESimOperationResult.Status");
			}
		}
		#endif
		// Forced skipping of method Windows.Networking.NetworkOperators.ESimOperationResult.Status.get
	}
}
