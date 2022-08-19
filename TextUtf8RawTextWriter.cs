internal class TextUtf8RawTextWriter : XmlUtf8RawTextWriter // TypeDefIndex: 1869
{	// Properties
	internal override bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0xE47F50 Offset: 0xE47350 VA: 0x180E47F50
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0xE47EE0 Offset: 0xE472E0 VA: 0x180E47EE0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0xE47EC0 Offset: 0xE472C0 VA: 0x180E47EC0 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 42
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 43
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0xE47F10 Offset: 0xE47310 VA: 0x180E47F10 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0xE47F40 Offset: 0xE47340 VA: 0x180E47F40 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0xE47F40 Offset: 0xE47340 VA: 0x180E47F40 Slot: 20
	public override void WriteString(string textBlock) { }

	// RVA: 0xE47F20 Offset: 0xE47320 VA: 0x180E47F20 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0xE47F20 Offset: 0xE47320 VA: 0x180E47F20 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0xE47F40 Offset: 0xE47340 VA: 0x180E47F40 Slot: 24
	public override void WriteRaw(string data) { }

}

