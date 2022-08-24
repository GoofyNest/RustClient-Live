internal class TextUtf8RawTextWriter : XmlUtf8RawTextWriter // TypeDefIndex: 1869
{
	internal override bool SupportsNamespaceDeclarationInChunks { get; }


	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	internal override void WriteXmlDeclaration(string xmldecl) { }

	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	public override void WriteStartElement(string prefix, string localName, string ns) { }

	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	internal override void StartElementContent() { }

	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	public override void WriteEndAttribute() { }

	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	public override void WriteCData(string text) { }

	public override void WriteComment(string text) { }

	public override void WriteProcessingInstruction(string name, string text) { }

	public override void WriteEntityRef(string name) { }

	public override void WriteCharEntity(char ch) { }

	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	public override void WriteWhitespace(string ws) { }

	public override void WriteString(string textBlock) { }

	public override void WriteChars(char[] buffer, int index, int count) { }

	public override void WriteRaw(char[] buffer, int index, int count) { }

	public override void WriteRaw(string data) { }

}

