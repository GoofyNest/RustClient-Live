internal static class Win32Native // TypeDefIndex: 111
{
	public static string GetMessage(int hr) { }

	public static int MakeHRFromErrorCode(int errorCode) { }

	internal static extern uint GetCurrentProcessId() { }

}

internal class Win32Native.WIN32_FIND_DATA // TypeDefIndex: 112
{	internal int dwFileAttributes; // 0x10
	internal string cFileName; // 0x18


	public void .ctor() { }

}

