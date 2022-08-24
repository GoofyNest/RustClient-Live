internal class CodePageDataItem // TypeDefIndex: 735
{
	internal int m_dataIndex; 
	internal int m_uiFamilyCodePage; 
	internal string m_webName; 
	internal string m_headerName; 
	internal string m_bodyName; 
	internal uint m_flags; 
	private static readonly char[] sep; 

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

