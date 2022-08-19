internal static class NativeMethods // TypeDefIndex: 2562
{	// Methods

	// RVA: 0x1215690 Offset: 0x1214A90 VA: 0x181215690
	public static bool DuplicateHandle(HandleRef hSourceProcessHandle, SafeHandle hSourceHandle, HandleRef hTargetProcess, out SafeWaitHandle targetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions) { }

	// RVA: 0x1215890 Offset: 0x1214C90 VA: 0x181215890
	public static bool DuplicateHandle(HandleRef hSourceProcessHandle, HandleRef hSourceHandle, HandleRef hTargetProcess, out SafeProcessHandle targetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions) { }

	// RVA: 0x12159F0 Offset: 0x1214DF0 VA: 0x1812159F0
	public static IntPtr GetCurrentProcess() { }

	// RVA: 0x1215A00 Offset: 0x1214E00 VA: 0x181215A00
	public static bool GetExitCodeProcess(IntPtr processHandle, out int exitCode) { }

	// RVA: 0x1215A10 Offset: 0x1214E10 VA: 0x181215A10
	public static bool GetExitCodeProcess(SafeProcessHandle processHandle, out int exitCode) { }

	// RVA: 0x12159E0 Offset: 0x1214DE0 VA: 0x1812159E0
	public static int GetCurrentProcessId() { }

	// RVA: 0x1215680 Offset: 0x1214A80 VA: 0x181215680
	public static bool CloseProcess(IntPtr handle) { }

}

