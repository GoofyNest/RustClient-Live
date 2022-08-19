internal class CodePageDataItem // TypeDefIndex: 735
{	// Fields
	internal int m_dataIndex; // 0x10
	internal int m_uiFamilyCodePage; // 0x14
	internal string m_webName; // 0x18
	internal string m_headerName; // 0x20
	internal string m_bodyName; // 0x28
	internal uint m_flags; // 0x30
	private static readonly char[] sep; // 0x0

	// Properties
	public string WebName { get; }
	public virtual int UIFamilyCodePage { get; }
	public string HeaderName { get; }
	public string BodyName { get; }
	public uint Flags { get; }

	// Methods

	// RVA: 0x10CE980 Offset: 0x10CDD80 VA: 0x1810CE980
	internal void .ctor(int dataIndex) { }

	// RVA: 0x10CE830 Offset: 0x10CDC30 VA: 0x1810CE830
	internal static string CreateString(string pStrings, uint index) { }

	// RVA: 0x10CEC40 Offset: 0x10CE040 VA: 0x1810CEC40
	public string get_WebName() { }

	// RVA: 0x596230 Offset: 0x595630 VA: 0x180596230 Slot: 4
	public virtual int get_UIFamilyCodePage() { }

	// RVA: 0x10CEB50 Offset: 0x10CDF50 VA: 0x1810CEB50
	public string get_HeaderName() { }

	// RVA: 0x10CEA60 Offset: 0x10CDE60 VA: 0x1810CEA60
	public string get_BodyName() { }

	// RVA: 0xA178C0 Offset: 0xA16CC0 VA: 0x180A178C0
	public uint get_Flags() { }

	// RVA: 0x10CE900 Offset: 0x10CDD00 VA: 0x1810CE900
	private static void .cctor() { }

}

