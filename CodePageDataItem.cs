internal class CodePageDataItem // TypeDefIndex: 735
{	internal int m_dataIndex; // 0x10
	internal int m_uiFamilyCodePage; // 0x14
	internal string m_webName; // 0x18
	internal string m_headerName; // 0x20
	internal string m_bodyName; // 0x28
	internal uint m_flags; // 0x30
	private static readonly char[] sep; // 0x0

	public string WebName { get; }
	public virtual int UIFamilyCodePage { get; }
	public string HeaderName { get; }
	public string BodyName { get; }
	public uint Flags { get; }


	internal void .ctor(int dataIndex) { }

	internal static string CreateString(string pStrings, uint index) { }

	public string get_WebName() { }

	public virtual int get_UIFamilyCodePage() { }

	public string get_HeaderName() { }

	public string get_BodyName() { }

	public uint get_Flags() { }

	private static void .cctor() { }

}

