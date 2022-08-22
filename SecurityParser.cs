internal class SecurityParser : SmallXmlParser, SmallXmlParser.IContentHandler // TypeDefIndex: 23
{	private SecurityElement root; // 0x68
	private SecurityElement current; // 0x70
	private Stack stack; // 0x78


	public void .ctor() { }

	public void LoadXml(string xml) { }

	public SecurityElement ToXml() { }

	public void OnStartParsing(SmallXmlParser parser) { }

	public void OnProcessingInstruction(string name, string text) { }

	public void OnIgnorableWhitespace(string s) { }

	public void OnStartElement(string name, SmallXmlParser.IAttrList attrs) { }

	public void OnEndElement(string name) { }

	public void OnChars(string ch) { }

	public void OnEndParsing(SmallXmlParser parser) { }

}

