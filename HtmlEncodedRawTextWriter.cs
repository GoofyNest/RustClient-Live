internal class HtmlEncodedRawTextWriter : XmlEncodedRawTextWriter // TypeDefIndex: 1839
{	// Fields
	protected ByteStack elementScope; // 0xC0
	protected ElementProperties currentElementProperties; // 0xC8
	private AttributeProperties currentAttributeProperties; // 0xCC
	private bool endsWithAmpersand; // 0xD0
	private byte[] uriEscapingBuffer; // 0xD8
	private string mediaType; // 0xE0
	private bool doNotEscapeUriAttributes; // 0xE8
	protected static TernaryTreeReadOnly elementPropertySearch; // 0x0
	protected static TernaryTreeReadOnly attributePropertySearch; // 0x8

	// Methods

	// RVA: 0x12ED590 Offset: 0x12EC990 VA: 0x1812ED590
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x12ED5C0 Offset: 0x12EC9C0 VA: 0x1812ED5C0
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x12EC150 Offset: 0x12EB550 VA: 0x1812EC150 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x12ECF60 Offset: 0x12EC360 VA: 0x1812ECF60 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x12EC070 Offset: 0x12EB470 VA: 0x1812EC070 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x12EC4A0 Offset: 0x12EB8A0 VA: 0x1812EC4A0 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x12EC690 Offset: 0x12EBA90 VA: 0x1812EC690 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x12ECDA0 Offset: 0x12EC1A0 VA: 0x1812ECDA0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x12EC3F0 Offset: 0x12EB7F0 VA: 0x1812EC3F0 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x12ECC20 Offset: 0x12EC020 VA: 0x1812ECC20 Slot: 16
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x12ED0A0 Offset: 0x12EC4A0 VA: 0x1812ED0A0 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x12EC620 Offset: 0x12EBA20 VA: 0x1812EC620 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x12EC0E0 Offset: 0x12EB4E0 VA: 0x1812EC0E0 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x12ED190 Offset: 0x12EC590 VA: 0x1812ED190 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x11BB080 Offset: 0x11BA480 VA: 0x1811BB080 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x12EBD90 Offset: 0x12EB190 VA: 0x1812EBD90
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x12ECB40 Offset: 0x12EBF40 VA: 0x1812ECB40
	protected void WriteMetaElement() { }

	// RVA: 0x12ECB20 Offset: 0x12EBF20 VA: 0x1812ECB20
	protected void WriteHtmlElementTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x12EC810 Offset: 0x12EBC10 VA: 0x1812EC810
	protected void WriteHtmlAttributeTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x12EC850 Offset: 0x12EBC50 VA: 0x1812EC850
	private void WriteHtmlAttributeText(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x12ED200 Offset: 0x12EC600 VA: 0x1812ED200
	private void WriteUriAttributeText(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x12EBF70 Offset: 0x12EB370 VA: 0x1812EBF70
	private void OutputRestAmps() { }

}

