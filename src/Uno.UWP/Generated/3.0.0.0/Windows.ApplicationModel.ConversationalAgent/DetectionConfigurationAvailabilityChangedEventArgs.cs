#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.ConversationalAgent
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class DetectionConfigurationAvailabilityChangedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.ConversationalAgent.DetectionConfigurationAvailabilityChangeKind Kind
		{
			get
			{
				throw new global::System.NotImplementedException("The member DetectionConfigurationAvailabilityChangeKind DetectionConfigurationAvailabilityChangedEventArgs.Kind is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=DetectionConfigurationAvailabilityChangeKind%20DetectionConfigurationAvailabilityChangedEventArgs.Kind");
			}
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.ConversationalAgent.DetectionConfigurationAvailabilityChangedEventArgs.Kind.get
	}
}
