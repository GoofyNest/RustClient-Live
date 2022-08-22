public struct ProfilerMarker // TypeDefIndex: 3296
{	[NativeDisableUnsafePtrRestrictionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal readonly IntPtr m_Ptr; // 0x0


	public void .ctor(string name) { }

	public ProfilerMarker.AutoScope Auto() { }

	[NativeConditionalAttribute] // RVA: 0xE93E0 Offset: 0xE87E0 VA: 0x1800E93E0
	[ThreadSafeAttribute] // RVA: 0xE93E0 Offset: 0xE87E0 VA: 0x1800E93E0
	internal static IntPtr Internal_Create(string name, ushort flags) { }

	[ThreadSafeAttribute] // RVA: 0xE9640 Offset: 0xE8A40 VA: 0x1800E9640
	[NativeConditionalAttribute] // RVA: 0xE9640 Offset: 0xE8A40 VA: 0x1800E9640
	internal static void Internal_Begin(IntPtr markerPtr) { }

	[ThreadSafeAttribute] // RVA: 0xE9640 Offset: 0xE8A40 VA: 0x1800E9640
	[NativeConditionalAttribute] // RVA: 0xE9640 Offset: 0xE8A40 VA: 0x1800E9640
	internal static void Internal_End(IntPtr markerPtr) { }

}

public struct ProfilerMarker.AutoScope : IDisposable // TypeDefIndex: 3297
{	[NativeDisableUnsafePtrRestrictionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal readonly IntPtr m_Ptr; // 0x0


	internal void .ctor(IntPtr markerPtr) { }

	public void Dispose() { }

}

