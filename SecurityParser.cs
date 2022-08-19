internal class SecurityParser : SmallXmlParser, SmallXmlParser.IContentHandler // TypeDefIndex: 23
{	// Fields
	private SecurityElement root; // 0x68
	private SecurityElement current; // 0x70
	private Stack stack; // 0x78

	// Methods

	// RVA: 0x1591A60 Offset: 0x1590E60 VA: 0x181591A60
	public void .ctor() { }

	// RVA: 0x15916F0 Offset: 0x1590AF0 VA: 0x1815916F0
	public void LoadXml(string xml) { }

	// RVA: 0x5334F0 Offset: 0x5328F0 VA: 0x1805334F0
	public SecurityElement ToXml() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 4
	public void OnStartParsing(SmallXmlParser parser) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 8
	public void OnProcessingInstruction(string name, string text) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 10
	public void OnIgnorableWhitespace(string s) { }

	// RVA: 0x1591890 Offset: 0x1590C90 VA: 0x181591890 Slot: 6
	public void OnStartElement(string name, SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x1591810 Offset: 0x1590C10 VA: 0x181591810 Slot: 7
	public void OnEndElement(string name) { }

	// RVA: 0x1591790 Offset: 0x1590B90 VA: 0x181591790 Slot: 9
	public void OnChars(string ch) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	public void OnEndParsing(SmallXmlParser parser) { }

}

