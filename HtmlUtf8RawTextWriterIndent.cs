internal class HtmlUtf8RawTextWriterIndent : HtmlUtf8RawTextWriter // TypeDefIndex: 1843
{	// Fields
	private int indentLevel; // 0xC0
	private int endBlockPos; // 0xC4
	private string indentChars; // 0xC8
	private bool newLineOnAttributes; // 0xD0

	// Methods

	// RVA: 0xF5A080 Offset: 0xF59480 VA: 0x180F5A080
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0xF59C50 Offset: 0xF59050 VA: 0x180F59C50 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0xF59E50 Offset: 0xF59250 VA: 0x180F59E50 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0xF59B90 Offset: 0xF58F90 VA: 0x180F59B90 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0xF59C80 Offset: 0xF59080 VA: 0x180F59C80 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0xF59D90 Offset: 0xF59190 VA: 0x180F59D90 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0xF59B20 Offset: 0xF58F20 VA: 0x180F59B20 Slot: 48
	protected override void FlushBuffer() { }

	// RVA: 0xF59B40 Offset: 0xF58F40 VA: 0x180F59B40
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0xF59D40 Offset: 0xF59140 VA: 0x180F59D40
	private void WriteIndent() { }

}

