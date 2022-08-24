internal sealed class SearchResult // TypeDefIndex: 631
{
	private string fullPath; 
	private string userPath; 
	private Win32Native.WIN32_FIND_DATA findData; 

	internal string UserPath { get; }
	internal Win32Native.WIN32_FIND_DATA FindData { get; }


	internal void .ctor(string fullPath, string userPath, Win32Native.WIN32_FIND_DATA findData) { }

	internal string get_UserPath() { }

	internal Win32Native.WIN32_FIND_DATA get_FindData() { }

}

