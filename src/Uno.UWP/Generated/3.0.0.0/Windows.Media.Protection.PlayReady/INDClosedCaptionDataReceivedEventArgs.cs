#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Protection.PlayReady
{
	// This type is deprecated. Consider not implementing it.
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface INDClosedCaptionDataReceivedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		byte[] ClosedCaptionData
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		global::Windows.Media.Protection.PlayReady.NDClosedCaptionFormat ClosedCaptionDataFormat
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		long PresentationTimestamp
		{
			get;
		}
		#endif
		// Forced skipping of method Windows.Media.Protection.PlayReady.INDClosedCaptionDataReceivedEventArgs.ClosedCaptionDataFormat.get
		// Forced skipping of method Windows.Media.Protection.PlayReady.INDClosedCaptionDataReceivedEventArgs.PresentationTimestamp.get
		// Forced skipping of method Windows.Media.Protection.PlayReady.INDClosedCaptionDataReceivedEventArgs.ClosedCaptionData.get
	}
}
