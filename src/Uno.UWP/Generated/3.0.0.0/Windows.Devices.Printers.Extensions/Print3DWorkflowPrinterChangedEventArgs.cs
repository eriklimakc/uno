#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Printers.Extensions
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class Print3DWorkflowPrinterChangedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string NewDeviceId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string Print3DWorkflowPrinterChangedEventArgs.NewDeviceId is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20Print3DWorkflowPrinterChangedEventArgs.NewDeviceId");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.Printers.Extensions.Print3DWorkflowPrinterChangedEventArgs.NewDeviceId.get
	}
}
