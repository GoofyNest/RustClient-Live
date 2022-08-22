internal static class NativeMethods // TypeDefIndex: 2562
{
	public static bool DuplicateHandle(HandleRef hSourceProcessHandle, SafeHandle hSourceHandle, HandleRef hTargetProcess, out SafeWaitHandle targetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions) { }

	public static bool DuplicateHandle(HandleRef hSourceProcessHandle, HandleRef hSourceHandle, HandleRef hTargetProcess, out SafeProcessHandle targetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions) { }

	public static IntPtr GetCurrentProcess() { }

	public static bool GetExitCodeProcess(IntPtr processHandle, out int exitCode) { }

	public static bool GetExitCodeProcess(SafeProcessHandle processHandle, out int exitCode) { }

	public static int GetCurrentProcessId() { }

	public static bool CloseProcess(IntPtr handle) { }

}

