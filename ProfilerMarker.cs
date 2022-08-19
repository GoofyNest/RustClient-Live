public struct ProfilerMarker // TypeDefIndex: 3296
{	// Fields
	[NativeDisableUnsafePtrRestrictionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal readonly IntPtr m_Ptr; // 0x0

	// Methods

	// RVA: 0x213820 Offset: 0x212C20 VA: 0x180213820
	public void .ctor(string name) { }

	// RVA: 0x2137E0 Offset: 0x212BE0 VA: 0x1802137E0
	public ProfilerMarker.AutoScope Auto() { }

	[NativeConditionalAttribute] // RVA: 0xE93E0 Offset: 0xE87E0 VA: 0x1800E93E0
	[ThreadSafeAttribute] // RVA: 0xE93E0 Offset: 0xE87E0 VA: 0x1800E93E0
	// RVA: 0x182D740 Offset: 0x182CB40 VA: 0x18182D740
	internal static IntPtr Internal_Create(string name, ushort flags) { }

	[ThreadSafeAttribute] // RVA: 0xE9640 Offset: 0xE8A40 VA: 0x1800E9640
	[NativeConditionalAttribute] // RVA: 0xE9640 Offset: 0xE8A40 VA: 0x1800E9640
	// RVA: 0x182D700 Offset: 0x182CB00 VA: 0x18182D700
	internal static void Internal_Begin(IntPtr markerPtr) { }

	[ThreadSafeAttribute] // RVA: 0xE9640 Offset: 0xE8A40 VA: 0x1800E9640
	[NativeConditionalAttribute] // RVA: 0xE9640 Offset: 0xE8A40 VA: 0x1800E9640
	// RVA: 0x182D790 Offset: 0x182CB90 VA: 0x18182D790
	internal static void Internal_End(IntPtr markerPtr) { }

}

public struct ProfilerMarker.AutoScope : IDisposable // TypeDefIndex: 3297
{	// Fields
	[NativeDisableUnsafePtrRestrictionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal readonly IntPtr m_Ptr; // 0x0

	// Methods

	// RVA: 0x211F60 Offset: 0x211360 VA: 0x180211F60
	internal void .ctor(IntPtr markerPtr) { }

	// RVA: 0x211F20 Offset: 0x211320 VA: 0x180211F20 Slot: 4
	public void Dispose() { }

}

