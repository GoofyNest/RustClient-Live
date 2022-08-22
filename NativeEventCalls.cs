internal static class NativeEventCalls // TypeDefIndex: 827
{
internal static class NativeEventCalls // TypeDefIndex: 827

	public static IntPtr CreateEvent_internal(bool manual, bool initial, string name, out int errorCode) { }

	public static bool SetEvent(SafeWaitHandle handle) { }

	private static bool SetEvent_internal(IntPtr handle) { }

	public static bool ResetEvent(SafeWaitHandle handle) { }

	private static bool ResetEvent_internal(IntPtr handle) { }

	public static void CloseEvent_internal(IntPtr handle) { }

}

