internal class HtmlEncodedRawTextWriterIndent : HtmlEncodedRawTextWriter // TypeDefIndex: 1840
{	// Fields
	private int indentLevel; // 0xF0
	private int endBlockPos; // 0xF4
	private string indentChars; // 0xF8
	private bool newLineOnAttributes; // 0x100

	// Methods

	// RVA: 0x12EBD20 Offset: 0x12EB120 VA: 0x1812EBD20
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x12EBCB0 Offset: 0x12EB0B0 VA: 0x1812EBCB0
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x12EB870 Offset: 0x12EAC70 VA: 0x1812EB870 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x12EBA80 Offset: 0x12EAE80 VA: 0x1812EBA80 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x12EB7A0 Offset: 0x12EABA0 VA: 0x1812EB7A0 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x12EB8A0 Offset: 0x12EACA0 VA: 0x1812EB8A0 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x12EB9C0 Offset: 0x12EADC0 VA: 0x1812EB9C0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x12EB730 Offset: 0x12EAB30 VA: 0x1812EB730 Slot: 48
	protected override void FlushBuffer() { }

	// RVA: 0x12EB750 Offset: 0x12EAB50 VA: 0x1812EB750
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x12EB960 Offset: 0x12EAD60 VA: 0x1812EB960
	private void WriteIndent() { }

}

