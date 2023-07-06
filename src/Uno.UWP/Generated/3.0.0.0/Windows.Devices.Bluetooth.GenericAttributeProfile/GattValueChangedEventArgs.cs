#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class GattValueChangedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.Streams.IBuffer CharacteristicValue
		{
			get
			{
				throw new global::System.NotImplementedException("The member IBuffer GattValueChangedEventArgs.CharacteristicValue is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IBuffer%20GattValueChangedEventArgs.CharacteristicValue");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.DateTimeOffset Timestamp
		{
			get
			{
				throw new global::System.NotImplementedException("The member DateTimeOffset GattValueChangedEventArgs.Timestamp is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=DateTimeOffset%20GattValueChangedEventArgs.Timestamp");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.Bluetooth.GenericAttributeProfile.GattValueChangedEventArgs.CharacteristicValue.get
		// Forced skipping of method Windows.Devices.Bluetooth.GenericAttributeProfile.GattValueChangedEventArgs.Timestamp.get
	}
}
