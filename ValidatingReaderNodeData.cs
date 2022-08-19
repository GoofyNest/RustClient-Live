internal class ValidatingReaderNodeData // TypeDefIndex: 1870
{	// Fields
	private string localName; // 0x10
	private string namespaceUri; // 0x18
	private string prefix; // 0x20
	private string nameWPrefix; // 0x28
	private string rawValue; // 0x30
	private string originalStringValue; // 0x38
	private int depth; // 0x40
	private AttributePSVIInfo attributePSVIInfo; // 0x48
	private XmlNodeType nodeType; // 0x50
	private int lineNo; // 0x54
	private int linePos; // 0x58

	// Properties
	public string LocalName { get; set; }
	public string Namespace { get; set; }
	public string Prefix { get; set; }
	public int Depth { get; set; }
	public string RawValue { get; set; }
	public string OriginalStringValue { get; }
	public XmlNodeType NodeType { get; set; }
	public AttributePSVIInfo AttInfo { get; set; }
	public int LineNumber { get; }
	public int LinePosition { get; }

	// Methods

	// RVA: 0xE4B080 Offset: 0xE4A480 VA: 0x180E4B080
	public void .ctor() { }

	// RVA: 0xE4B050 Offset: 0xE4A450 VA: 0x180E4B050
	public void .ctor(XmlNodeType nodeType) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_LocalName() { }

	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	public void set_LocalName(string value) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public string get_Namespace() { }

	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_Namespace(string value) { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public string get_Prefix() { }

	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	public void set_Prefix(string value) { }

	// RVA: 0xE4AE00 Offset: 0xE4A200 VA: 0x180E4AE00
	public string GetAtomizedNameWPrefix(XmlNameTable nameTable) { }

	// RVA: 0x5F7C80 Offset: 0x5F7080 VA: 0x1805F7C80
	public int get_Depth() { }

	// RVA: 0x6B9860 Offset: 0x6B8C60 VA: 0x1806B9860
	public void set_Depth(int value) { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public string get_RawValue() { }

	// RVA: 0x4A2F10 Offset: 0x4A2310 VA: 0x1804A2F10
	public void set_RawValue(string value) { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public string get_OriginalStringValue() { }

	// RVA: 0x8C8B80 Offset: 0x8C7F80 VA: 0x1808C8B80
	public XmlNodeType get_NodeType() { }

	// RVA: 0x8C8BC0 Offset: 0x8C7FC0 VA: 0x1808C8BC0
	public void set_NodeType(XmlNodeType value) { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0
	public AttributePSVIInfo get_AttInfo() { }

	// RVA: 0x5F7050 Offset: 0x5F6450 VA: 0x1805F7050
	public void set_AttInfo(AttributePSVIInfo value) { }

	// RVA: 0x5F8160 Offset: 0x5F7560 VA: 0x1805F8160
	public int get_LineNumber() { }

	// RVA: 0xAE4F70 Offset: 0xAE4370 VA: 0x180AE4F70
	public int get_LinePosition() { }

	// RVA: 0xE4AD30 Offset: 0xE4A130 VA: 0x180E4AD30
	internal void Clear(XmlNodeType nodeType) { }

	// RVA: 0xE4AFD0 Offset: 0xE4A3D0 VA: 0x180E4AFD0
	internal void SetLineInfo(int lineNo, int linePos) { }

	// RVA: 0xE4AFE0 Offset: 0xE4A3E0 VA: 0x180E4AFE0
	internal void SetLineInfo(IXmlLineInfo lineInfo) { }

	// RVA: 0xE4AF30 Offset: 0xE4A330 VA: 0x180E4AF30
	internal void SetItemData(string localName, string prefix, string ns, int depth) { }

	// RVA: 0xE4AEB0 Offset: 0xE4A2B0 VA: 0x180E4AEB0
	internal void SetItemData(string value) { }

	// RVA: 0xE4AEF0 Offset: 0xE4A2F0 VA: 0x180E4AEF0
	internal void SetItemData(string value, string originalStringValue) { }

}

