#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Devices
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class VideoDeviceControllerGetDevicePropertyResult 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Media.Devices.VideoDeviceControllerGetDevicePropertyStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member VideoDeviceControllerGetDevicePropertyStatus VideoDeviceControllerGetDevicePropertyResult.Status is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=VideoDeviceControllerGetDevicePropertyStatus%20VideoDeviceControllerGetDevicePropertyResult.Status");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  object Value
		{
			get
			{
				throw new global::System.NotImplementedException("The member object VideoDeviceControllerGetDevicePropertyResult.Value is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=object%20VideoDeviceControllerGetDevicePropertyResult.Value");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.Devices.VideoDeviceControllerGetDevicePropertyResult.Status.get
		// Forced skipping of method Windows.Media.Devices.VideoDeviceControllerGetDevicePropertyResult.Value.get
	}
}
