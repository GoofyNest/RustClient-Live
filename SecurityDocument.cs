internal sealed class SecurityDocument // TypeDefIndex: 897
{	// Fields
	internal byte[] m_data; // 0x10

	// Methods

	// RVA: 0x17BE530 Offset: 0x17BD930 VA: 0x1817BE530
	public void .ctor(int numData) { }

	// RVA: 0x17BE1F0 Offset: 0x17BD5F0 VA: 0x1817BE1F0
	public void GuaranteeSize(int size) { }

	// RVA: 0x17BD9D0 Offset: 0x17BCDD0 VA: 0x1817BD9D0
	public void AddString(string str, ref int position) { }

	// RVA: 0x17BDCB0 Offset: 0x17BD0B0 VA: 0x1817BDCB0
	public void AppendString(string str, ref int position) { }

	// RVA: 0x17BDDA0 Offset: 0x17BD1A0 VA: 0x1817BDDA0
	public static int EncodedStringSize(string str) { }

	// RVA: 0x17BDE10 Offset: 0x17BD210 VA: 0x1817BDE10
	public string GetString(ref int position, bool bCreate) { }

	// RVA: 0x17BDBC0 Offset: 0x17BCFC0 VA: 0x1817BDBC0
	public void AddToken(byte b, ref int position) { }

	// RVA: 0x17BDDE0 Offset: 0x17BD1E0 VA: 0x1817BDDE0
	public SecurityElement GetRootElement() { }

	// RVA: 0x17BDDC0 Offset: 0x17BD1C0 VA: 0x1817BDDC0
	public SecurityElement GetElement(int position, bool bCreate) { }

	// RVA: 0x17BE290 Offset: 0x17BD690 VA: 0x1817BE290
	internal SecurityElement InternalGetElement(ref int position, bool bCreate) { }

}

