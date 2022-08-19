internal sealed class SearchResult // TypeDefIndex: 631
{	// Fields
	private string fullPath; // 0x10
	private string userPath; // 0x18
	private Win32Native.WIN32_FIND_DATA findData; // 0x20

	// Properties
	internal string UserPath { get; }
	internal Win32Native.WIN32_FIND_DATA FindData { get; }

	// Methods

	// RVA: 0x146E710 Offset: 0x146DB10 VA: 0x18146E710
	internal void .ctor(string fullPath, string userPath, Win32Native.WIN32_FIND_DATA findData) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	internal string get_UserPath() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	internal Win32Native.WIN32_FIND_DATA get_FindData() { }

}

