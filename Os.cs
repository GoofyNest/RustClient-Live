public static class Os // TypeDefIndex: 5614
{

	public static void OpenFolder(string folder) { }

	public static bool StartProcess(string executable, string arguments) { }

	private static extern bool CreateProcess(string lpApplicationName, string lpCommandLine, ref Os.SECURITY_ATTRIBUTES lpProcessAttributes, ref Os.SECURITY_ATTRIBUTES lpThreadAttributes, bool bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, in Os.STARTUPINFO lpStartupInfo, out Os.PROCESS_INFORMATION lpProcessInformation) { }

}

internal struct Os.PROCESS_INFORMATION // TypeDefIndex: 5615
{
	public IntPtr hProcess; 
	public IntPtr hThread; 
	public int dwProcessId; 
	public int dwThreadId; 

}

private struct Os.STARTUPINFO // TypeDefIndex: 5616
{
	public int cb; 
	public IntPtr lpReserved; 
	public IntPtr lpDesktop; 
	public IntPtr lpTitle; 
	public int dwX; 
	public int dwY; 
	public int dwXSize; 
	public int dwYSize; 
	public int dwXCountChars; 
	public int dwYCountChars; 
	public int dwFillAttribute; 
	public int dwFlags; 
	public short wShowWindow; 
	public short cbReserved2; 
	public IntPtr lpReserved2; 
	public IntPtr hStdInput; 
	public IntPtr hStdOutput; 
	public IntPtr hStdError; 

}

public struct Os.SECURITY_ATTRIBUTES // TypeDefIndex: 5617
{
	public int nLength; 
	public IntPtr lpSecurityDescriptor; 
	public int bInheritHandle; 

}

