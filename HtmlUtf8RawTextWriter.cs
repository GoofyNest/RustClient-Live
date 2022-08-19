internal class HtmlUtf8RawTextWriter : XmlUtf8RawTextWriter // TypeDefIndex: 1842
{	// Fields
	protected ByteStack elementScope; // 0x90
	protected ElementProperties currentElementProperties; // 0x98
	private AttributeProperties currentAttributeProperties; // 0x9C
	private bool endsWithAmpersand; // 0xA0
	private byte[] uriEscapingBuffer; // 0xA8
	private string mediaType; // 0xB0
	private bool doNotEscapeUriAttributes; // 0xB8
	protected static TernaryTreeReadOnly elementPropertySearch; // 0x0
	protected static TernaryTreeReadOnly attributePropertySearch; // 0x8

	// Methods

	// RVA: 0x12EEDA0 Offset: 0x12EE1A0 VA: 0x1812EEDA0
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x12EDB50 Offset: 0x12ECF50 VA: 0x1812EDB50 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x12EE7E0 Offset: 0x12EDBE0 VA: 0x1812EE7E0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x12ED950 Offset: 0x12ECD50 VA: 0x1812ED950 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x12EDE20 Offset: 0x12ED220 VA: 0x1812EDE20 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x12EDFE0 Offset: 0x12ED3E0 VA: 0x1812EDFE0 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x12EE650 Offset: 0x12EDA50 VA: 0x1812EE650 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x12EDDA0 Offset: 0x12ED1A0 VA: 0x1812EDDA0 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x12EE520 Offset: 0x12ED920 VA: 0x1812EE520 Slot: 16
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x12EE900 Offset: 0x12EDD00 VA: 0x1812EE900 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x12EDF70 Offset: 0x12ED370 VA: 0x1812EDF70 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x12EDA80 Offset: 0x12ECE80 VA: 0x1812EDA80 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x12EE9D0 Offset: 0x12EDDD0 VA: 0x1812EE9D0 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x12EDAF0 Offset: 0x12ECEF0 VA: 0x1812EDAF0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x12ED6A0 Offset: 0x12ECAA0 VA: 0x1812ED6A0
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x12EE440 Offset: 0x12ED840 VA: 0x1812EE440
	protected void WriteMetaElement() { }

	// RVA: 0x12EE420 Offset: 0x12ED820 VA: 0x1812EE420
	protected void WriteHtmlElementTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x12EE130 Offset: 0x12ED530 VA: 0x1812EE130
	protected void WriteHtmlAttributeTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x12EE170 Offset: 0x12ED570 VA: 0x1812EE170
	private void WriteHtmlAttributeText(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x12EEA40 Offset: 0x12EDE40 VA: 0x1812EEA40
	private void WriteUriAttributeText(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x12ED880 Offset: 0x12ECC80 VA: 0x1812ED880
	private void OutputRestAmps() { }

}

