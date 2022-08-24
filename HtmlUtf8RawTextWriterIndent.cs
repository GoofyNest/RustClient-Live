internal class HtmlUtf8RawTextWriterIndent : HtmlUtf8RawTextWriter // TypeDefIndex: 1843
{
	private int indentLevel; 
	private int endBlockPos; 
	private string indentChars; 
	private bool newLineOnAttributes; 


	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	public override void WriteStartElement(string prefix, string localName, string ns) { }

	internal override void StartElementContent() { }

	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	protected override void FlushBuffer() { }

	private void Init(XmlWriterSettings settings) { }

	private void WriteIndent() { }

}

