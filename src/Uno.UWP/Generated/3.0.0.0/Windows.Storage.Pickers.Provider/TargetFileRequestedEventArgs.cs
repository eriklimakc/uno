#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Storage.Pickers.Provider
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class TargetFileRequestedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.Pickers.Provider.TargetFileRequest Request
		{
			get
			{
				throw new global::System.NotImplementedException("The member TargetFileRequest TargetFileRequestedEventArgs.Request is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=TargetFileRequest%20TargetFileRequestedEventArgs.Request");
			}
		}
		#endif
		// Forced skipping of method Windows.Storage.Pickers.Provider.TargetFileRequestedEventArgs.Request.get
	}
}
