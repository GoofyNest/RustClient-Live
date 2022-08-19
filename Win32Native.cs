internal static class Win32Native // TypeDefIndex: 111
{	// Methods

	// RVA: 0x164D200 Offset: 0x164C600 VA: 0x18164D200
	public static string GetMessage(int hr) { }

	// RVA: 0x164D250 Offset: 0x164C650 VA: 0x18164D250
	public static int MakeHRFromErrorCode(int errorCode) { }

	// RVA: 0x164D180 Offset: 0x164C580 VA: 0x18164D180
	internal static extern uint GetCurrentProcessId() { }

}

internal class Win32Native.WIN32_FIND_DATA // TypeDefIndex: 112
{	// Fields
	internal int dwFileAttributes; // 0x10
	internal string cFileName; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

