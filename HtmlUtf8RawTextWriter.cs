internal class HtmlUtf8RawTextWriter : XmlUtf8RawTextWriter // TypeDefIndex: 1842
{	protected ByteStack elementScope; // 0x90
	protected ElementProperties currentElementProperties; // 0x98
	private AttributeProperties currentAttributeProperties; // 0x9C
	private bool endsWithAmpersand; // 0xA0
	private byte[] uriEscapingBuffer; // 0xA8
	private string mediaType; // 0xB0
	private bool doNotEscapeUriAttributes; // 0xB8
	protected static TernaryTreeReadOnly elementPropertySearch; // 0x0
	protected static TernaryTreeReadOnly attributePropertySearch; // 0x8


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

