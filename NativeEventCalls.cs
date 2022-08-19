internal static class NativeEventCalls // TypeDefIndex: 827
{
// Namespace: System.Threading
internal static class NativeEventCalls // TypeDefIndex: 827
	// Methods

	// RVA: 0x1492090 Offset: 0x1491490 VA: 0x181492090
	public static IntPtr CreateEvent_internal(bool manual, bool initial, string name, out int errorCode) { }

	// RVA: 0x14921A0 Offset: 0x14915A0 VA: 0x1814921A0
	public static bool SetEvent(SafeWaitHandle handle) { }

	// RVA: 0x1492190 Offset: 0x1491590 VA: 0x181492190
	private static bool SetEvent_internal(IntPtr handle) { }

	// RVA: 0x14920B0 Offset: 0x14914B0 VA: 0x1814920B0
	public static bool ResetEvent(SafeWaitHandle handle) { }

	// RVA: 0x14920A0 Offset: 0x14914A0 VA: 0x1814920A0
	private static bool ResetEvent_internal(IntPtr handle) { }

	// RVA: 0x1492080 Offset: 0x1491480 VA: 0x181492080
	public static void CloseEvent_internal(IntPtr handle) { }

}

