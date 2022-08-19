internal class NativeInputSystem // TypeDefIndex: 4523
{	// Fields
	public static NativeUpdateCallback onUpdate; // 0x0
	public static Action<NativeInputUpdateType> onBeforeUpdate; // 0x8
	public static Func<NativeInputUpdateType, bool> onShouldRunUpdate; // 0x10
	private static Action<int, string> s_OnDeviceDiscoveredCallback; // 0x18

	// Properties
	internal static bool hasDeviceDiscoveredCallback { set; }

	// Methods

	// RVA: 0x231CBD0 Offset: 0x231BFD0 VA: 0x18231CBD0
	private static void .cctor() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x231C9A0 Offset: 0x231BDA0 VA: 0x18231C9A0
	internal static void NotifyBeforeUpdate(NativeInputUpdateType updateType) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x231CAA0 Offset: 0x231BEA0 VA: 0x18231CAA0
	internal static void NotifyUpdate(NativeInputUpdateType updateType, IntPtr eventBuffer) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x231CA20 Offset: 0x231BE20 VA: 0x18231CA20
	internal static void NotifyDeviceDiscovered(int deviceId, string deviceDescriptor) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x231CB40 Offset: 0x231BF40 VA: 0x18231CB40
	internal static void ShouldRunUpdate(NativeInputUpdateType updateType, out bool retval) { }

	// RVA: 0x231CC00 Offset: 0x231C000 VA: 0x18231CC00
	internal static void set_hasDeviceDiscoveredCallback(bool value) { }

}

