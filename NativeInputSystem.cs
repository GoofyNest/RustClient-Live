internal class NativeInputSystem // TypeDefIndex: 4523
{
	public static NativeUpdateCallback onUpdate; 
	public static Action<NativeInputUpdateType> onBeforeUpdate; 
	public static Func<NativeInputUpdateType, bool> onShouldRunUpdate; 
	private static Action<int, string> s_OnDeviceDiscoveredCallback; 

	internal static bool hasDeviceDiscoveredCallback { set; }


	private static void .cctor() { }

	[RequiredByNativeCodeAttribute] 
	internal static void NotifyBeforeUpdate(NativeInputUpdateType updateType) { }

	[RequiredByNativeCodeAttribute] 
	internal static void NotifyUpdate(NativeInputUpdateType updateType, IntPtr eventBuffer) { }

	[RequiredByNativeCodeAttribute] 
	internal static void NotifyDeviceDiscovered(int deviceId, string deviceDescriptor) { }

	[RequiredByNativeCodeAttribute] 
	internal static void ShouldRunUpdate(NativeInputUpdateType updateType, out bool retval) { }

	internal static void set_hasDeviceDiscoveredCallback(bool value) { }

}

