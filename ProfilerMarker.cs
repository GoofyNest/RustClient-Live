public struct ProfilerMarker // TypeDefIndex: 3296
{
	[NativeDisableUnsafePtrRestrictionAttribute] 
	internal readonly IntPtr m_Ptr; 


	public void .ctor(string name) { }

	public ProfilerMarker.AutoScope Auto() { }

	[ThreadSafeAttribute] 
	[NativeConditionalAttribute] 
	internal static IntPtr Internal_Create(string name, ushort flags) { }

	[ThreadSafeAttribute] 
	[NativeConditionalAttribute] 
	internal static void Internal_Begin(IntPtr markerPtr) { }

	[NativeConditionalAttribute] 
	[ThreadSafeAttribute] 
	internal static void Internal_End(IntPtr markerPtr) { }

}

public struct ProfilerMarker.AutoScope : IDisposable // TypeDefIndex: 3297
{
	[NativeDisableUnsafePtrRestrictionAttribute] 
	internal readonly IntPtr m_Ptr; 


	internal void .ctor(IntPtr markerPtr) { }

	public void Dispose() { }

}

