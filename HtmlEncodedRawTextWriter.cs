internal class HtmlEncodedRawTextWriter : XmlEncodedRawTextWriter // TypeDefIndex: 1839
{	protected ByteStack elementScope; // 0xC0
	protected ElementProperties currentElementProperties; // 0xC8
	private AttributeProperties currentAttributeProperties; // 0xCC
	private bool endsWithAmpersand; // 0xD0
	private byte[] uriEscapingBuffer; // 0xD8
	private string mediaType; // 0xE0
	private bool doNotEscapeUriAttributes; // 0xE8
	protected static TernaryTreeReadOnly elementPropertySearch; // 0x0
	protected static TernaryTreeReadOnly attributePropertySearch; // 0x8


	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	internal override void WriteXmlDeclaration(string xmldecl) { }

	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	public override void WriteStartElement(string prefix, string localName, string ns) { }

	internal override void StartElementContent() { }

	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	public override void WriteEndAttribute() { }

	public override void WriteProcessingInstruction(string target, string text) { }

	public override void WriteString(string text) { }

	public override void WriteEntityRef(string name) { }

	public override void WriteCharEntity(char ch) { }

	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	public override void WriteChars(char[] buffer, int index, int count) { }

	private void Init(XmlWriterSettings settings) { }

	protected void WriteMetaElement() { }

	protected void WriteHtmlElementTextBlock(char* pSrc, char* pSrcEnd) { }

	protected void WriteHtmlAttributeTextBlock(char* pSrc, char* pSrcEnd) { }

	private void WriteHtmlAttributeText(char* pSrc, char* pSrcEnd) { }

	private void WriteUriAttributeText(char* pSrc, char* pSrcEnd) { }

	private void OutputRestAmps() { }

}

