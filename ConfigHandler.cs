internal class ConfigHandler : SmallXmlParser.IContentHandler // TypeDefIndex: 1138
{	private ArrayList typeEntries; // 0x10
	private ArrayList channelInstances; // 0x18
	private ChannelData currentChannel; // 0x20
	private Stack currentProviderData; // 0x28
	private string currentClientUrl; // 0x30
	private string appName; // 0x38
	private string currentXmlPath; // 0x40
	private bool onlyDelayedChannels; // 0x48


	public void .ctor(bool onlyDelayedChannels) { }

	private void ValidatePath(string element, string[] paths) { }

	private bool CheckPath(string path) { }

	public void OnStartParsing(SmallXmlParser parser) { }

	public void OnProcessingInstruction(string name, string text) { }

	public void OnIgnorableWhitespace(string s) { }

	public void OnStartElement(string name, SmallXmlParser.IAttrList attrs) { }

	public void ParseElement(string name, SmallXmlParser.IAttrList attrs) { }

	public void OnEndElement(string name) { }

	private void ReadCustomProviderData(string name, SmallXmlParser.IAttrList attrs) { }

	private void ReadLifetine(SmallXmlParser.IAttrList attrs) { }

	private TimeSpan ParseTime(string s) { }

	private void ReadChannel(SmallXmlParser.IAttrList attrs, bool isTemplate) { }

	private ProviderData ReadProvider(string name, SmallXmlParser.IAttrList attrs, bool isTemplate) { }

	private void ReadClientActivated(SmallXmlParser.IAttrList attrs) { }

	private void ReadServiceActivated(SmallXmlParser.IAttrList attrs) { }

	private void ReadClientWellKnown(SmallXmlParser.IAttrList attrs) { }

	private void ReadServiceWellKnown(SmallXmlParser.IAttrList attrs) { }

	private void ReadInteropXml(SmallXmlParser.IAttrList attrs, bool isElement) { }

	private void ReadPreload(SmallXmlParser.IAttrList attrs) { }

	private string GetNotNull(SmallXmlParser.IAttrList attrs, string name) { }

	private string ExtractAssembly(ref string type) { }

	public void OnChars(string ch) { }

	public void OnEndParsing(SmallXmlParser parser) { }

}

