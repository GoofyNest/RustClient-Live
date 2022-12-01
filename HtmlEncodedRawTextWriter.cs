internal class HtmlEncodedRawTextWriter : XmlEncodedRawTextWriter // TypeDefIndex: 1839
{
	protected ByteStack elementScope;
	protected ElementProperties currentElementProperties;
	private AttributeProperties currentAttributeProperties;
	private bool endsWithAmpersand;
	private byte[] uriEscapingBuffer;
	private string mediaType;
	private bool doNotEscapeUriAttributes;
	protected static TernaryTreeReadOnly elementPropertySearch;
	protected static TernaryTreeReadOnly attributePropertySearch;


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

