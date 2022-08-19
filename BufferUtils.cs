internal static class BufferUtils // TypeDefIndex: 5958
{
// Namespace: Newtonsoft.Json.Utilities
[PreserveAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
internal static class BufferUtils // TypeDefIndex: 5958
	// Methods

	// RVA: 0x17F90F0 Offset: 0x17F84F0 VA: 0x1817F90F0
	public static char[] RentBuffer(IArrayPool<char> bufferPool, int minSize) { }

	// RVA: 0x17F9160 Offset: 0x17F8560 VA: 0x1817F9160
	public static void ReturnBuffer(IArrayPool<char> bufferPool, char[] buffer) { }

	// RVA: 0x17F9050 Offset: 0x17F8450 VA: 0x1817F9050
	public static char[] EnsureBufferSize(IArrayPool<char> bufferPool, int size, char[] buffer) { }

}

