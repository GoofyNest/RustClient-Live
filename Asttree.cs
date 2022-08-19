internal class Asttree // TypeDefIndex: 2137
{	// Fields
	private ArrayList fAxisArray; // 0x10
	private string xpathexpr; // 0x18
	private bool isField; // 0x20
	private XmlNamespaceManager nsmgr; // 0x28

	// Properties
	internal ArrayList SubtreeArray { get; }

	// Methods

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	internal ArrayList get_SubtreeArray() { }

	// RVA: 0xF3D780 Offset: 0xF3CB80 VA: 0x180F3D780
	public void .ctor(string xPath, bool isField, XmlNamespaceManager nsmgr) { }

	// RVA: 0xF3D610 Offset: 0xF3CA10 VA: 0x180F3D610
	private static bool IsNameTest(Axis ast) { }

	// RVA: 0xF3D5B0 Offset: 0xF3C9B0 VA: 0x180F3D5B0
	internal static bool IsAttribute(Axis ast) { }

	// RVA: 0xF3D5E0 Offset: 0xF3C9E0 VA: 0x180F3D5E0
	private static bool IsDescendantOrSelf(Axis ast) { }

	// RVA: 0xF3D640 Offset: 0xF3CA40 VA: 0x180F3D640
	internal static bool IsSelf(Axis ast) { }

	// RVA: 0xF3CD10 Offset: 0xF3C110 VA: 0x180F3CD10
	public void CompileXPath(string xPath, bool isField, XmlNamespaceManager nsmgr) { }

	// RVA: 0xF3D670 Offset: 0xF3CA70 VA: 0x180F3D670
	private void SetURN(Axis axis, XmlNamespaceManager nsmgr) { }

}

