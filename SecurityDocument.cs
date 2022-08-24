internal sealed class SecurityDocument // TypeDefIndex: 897
{
	internal byte[] m_data; 


public void .ctor(int numData) { }

public void GuaranteeSize(int size) { }

public void AddString(string str, ref int position) { }

public void AppendString(string str, ref int position) { }

public static int EncodedStringSize(string str) { }

public string GetString(ref int position, bool bCreate) { }

public void AddToken(byte b, ref int position) { }

public SecurityElement GetRootElement() { }

public SecurityElement GetElement(int position, bool bCreate) { }

internal SecurityElement InternalGetElement(ref int position, bool bCreate) { }

}

