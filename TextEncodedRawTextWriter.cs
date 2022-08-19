internal class TextEncodedRawTextWriter : XmlEncodedRawTextWriter // TypeDefIndex: 1868
{	// Properties
	internal override bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0xE47F00 Offset: 0xE47300 VA: 0x180E47F00
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0xE47EF0 Offset: 0xE472F0 VA: 0x180E47EF0
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

	// RVA: 0xE47E90 Offset: 0xE47290 VA: 0x180E47E90 Slot: 14
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

	// RVA: 0xE47ED0 Offset: 0xE472D0 VA: 0x180E47ED0 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0xE47ED0 Offset: 0xE472D0 VA: 0x180E47ED0 Slot: 20
	public override void WriteString(string textBlock) { }

	// RVA: 0xE47EA0 Offset: 0xE472A0 VA: 0x180E47EA0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0xE47EA0 Offset: 0xE472A0 VA: 0x180E47EA0 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0xE47ED0 Offset: 0xE472D0 VA: 0x180E47ED0 Slot: 24
	public override void WriteRaw(string data) { }

}

