internal class QueryOutputWriter : XmlRawWriter // TypeDefIndex: 1859
{	// Fields
	private XmlRawWriter wrapped; // 0x28
	private bool inCDataSection; // 0x30
	private Dictionary<XmlQualifiedName, int> lookupCDataElems; // 0x38
	private BitStack bitsCData; // 0x40
	private XmlQualifiedName qnameCData; // 0x48
	private bool outputDocType; // 0x50
	private bool checkWellFormedDoc; // 0x51
	private bool hasDocElem; // 0x52
	private bool inAttr; // 0x53
	private string systemId; // 0x58
	private string publicId; // 0x60
	private int depth; // 0x68

	// Properties
	internal override IXmlNamespaceResolver NamespaceResolver { set; }
	internal override bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0xF5B4F0 Offset: 0xF5A8F0 VA: 0x180F5B4F0
	public void .ctor(XmlRawWriter writer, XmlWriterSettings settings) { }

	// RVA: 0xF5B760 Offset: 0xF5AB60 VA: 0x180F5B760 Slot: 35
	internal override void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	// RVA: 0xF5B4C0 Offset: 0xF5A8C0 VA: 0x180F5B4C0 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0xF5B490 Offset: 0xF5A890 VA: 0x180F5B490 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0xF5ADF0 Offset: 0xF5A1F0 VA: 0x180F5ADF0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0xF5B150 Offset: 0xF5A550 VA: 0x180F5B150 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0xF5AE60 Offset: 0xF5A260 VA: 0x180F5AE60 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0xF5AEF0 Offset: 0xF5A2F0 VA: 0x180F5AEF0 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0xE52520 Offset: 0xE51920 VA: 0x180E52520 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0xF5B110 Offset: 0xF5A510 VA: 0x180F5B110 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0xF5AE30 Offset: 0xF5A230 VA: 0x180F5AE30 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0xF5AF50 Offset: 0xF5A350 VA: 0x180F5AF50 Slot: 42
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0xE530A0 Offset: 0xE524A0 VA: 0x180E530A0 Slot: 43
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0xF5B310 Offset: 0xF5A710 VA: 0x180F5B310 Slot: 44
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0xE528E0 Offset: 0xE51CE0 VA: 0x180E528E0 Slot: 45
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0xF5AC90 Offset: 0xF5A090 VA: 0x180F5AC90 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0xF5ADC0 Offset: 0xF5A1C0 VA: 0x180F5ADC0 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0xF5AF80 Offset: 0xF5A380 VA: 0x180F5AF80 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0xF5B400 Offset: 0xF5A800 VA: 0x180F5B400 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0xF5B340 Offset: 0xF5A740 VA: 0x180F5B340 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0xF5ACF0 Offset: 0xF5A0F0 VA: 0x180F5ACF0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0xF5AEC0 Offset: 0xF5A2C0 VA: 0x180F5AEC0 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0xF5ACC0 Offset: 0xF5A0C0 VA: 0x180F5ACC0 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0xF5B3D0 Offset: 0xF5A7D0 VA: 0x180F5B3D0 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0xF5B040 Offset: 0xF5A440 VA: 0x180F5B040 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0xF5AFB0 Offset: 0xF5A3B0 VA: 0x180F5AFB0 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0xF5AB60 Offset: 0xF59F60 VA: 0x180F5AB60 Slot: 28
	public override void Close() { }

	// RVA: 0xF5AC20 Offset: 0xF5A020 VA: 0x180F5AC20 Slot: 29
	public override void Flush() { }

	// RVA: 0xF5AC50 Offset: 0xF5A050 VA: 0x180F5AC50
	private bool StartCDataSection() { }

	// RVA: 0xF5AC10 Offset: 0xF5A010 VA: 0x180F5AC10
	private void EndCDataSection() { }

}

