internal class ConfigHandler : SmallXmlParser.IContentHandler // TypeDefIndex: 1138
{	// Fields
	private ArrayList typeEntries; // 0x10
	private ArrayList channelInstances; // 0x18
	private ChannelData currentChannel; // 0x20
	private Stack currentProviderData; // 0x28
	private string currentClientUrl; // 0x30
	private string appName; // 0x38
	private string currentXmlPath; // 0x40
	private bool onlyDelayedChannels; // 0x48

	// Methods

	// RVA: 0xFDF400 Offset: 0xFDE800 VA: 0x180FDF400
	public void .ctor(bool onlyDelayedChannels) { }

	// RVA: 0xFDF310 Offset: 0xFDE710 VA: 0x180FDF310
	private void ValidatePath(string element, string[] paths) { }

	// RVA: 0xFDB980 Offset: 0xFDAD80 VA: 0x180FDB980
	private bool CheckPath(string path) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 4
	public void OnStartParsing(SmallXmlParser parser) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 8
	public void OnProcessingInstruction(string name, string text) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 10
	public void OnIgnorableWhitespace(string s) { }

	// RVA: 0xFDBE10 Offset: 0xFDB210 VA: 0x180FDBE10 Slot: 6
	public void OnStartElement(string name, SmallXmlParser.IAttrList attrs) { }

	// RVA: 0xFDBF40 Offset: 0xFDB340 VA: 0x180FDBF40
	public void ParseElement(string name, SmallXmlParser.IAttrList attrs) { }

	// RVA: 0xFDBC20 Offset: 0xFDB020 VA: 0x180FDBC20 Slot: 7
	public void OnEndElement(string name) { }

	// RVA: 0xFDE0E0 Offset: 0xFDD4E0 VA: 0x180FDE0E0
	private void ReadCustomProviderData(string name, SmallXmlParser.IAttrList attrs) { }

	// RVA: 0xFDE6F0 Offset: 0xFDDAF0 VA: 0x180FDE6F0
	private void ReadLifetine(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0xFDD5C0 Offset: 0xFDC9C0 VA: 0x180FDD5C0
	private TimeSpan ParseTime(string s) { }

	// RVA: 0xFDD950 Offset: 0xFDCD50 VA: 0x180FDD950
	private void ReadChannel(SmallXmlParser.IAttrList attrs, bool isTemplate) { }

	// RVA: 0xFDEBB0 Offset: 0xFDDFB0 VA: 0x180FDEBB0
	private ProviderData ReadProvider(string name, SmallXmlParser.IAttrList attrs, bool isTemplate) { }

	// RVA: 0xFDDDE0 Offset: 0xFDD1E0 VA: 0x180FDDDE0
	private void ReadClientActivated(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0xFDEFD0 Offset: 0xFDE3D0 VA: 0x180FDEFD0
	private void ReadServiceActivated(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0xFDE000 Offset: 0xFDD400 VA: 0x180FDE000
	private void ReadClientWellKnown(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0xFDF180 Offset: 0xFDE580 VA: 0x180FDF180
	private void ReadServiceWellKnown(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0xFDE4E0 Offset: 0xFDD8E0 VA: 0x180FDE4E0
	private void ReadInteropXml(SmallXmlParser.IAttrList attrs, bool isElement) { }

	// RVA: 0xFDEA00 Offset: 0xFDDE00 VA: 0x180FDEA00
	private void ReadPreload(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0xFDBB60 Offset: 0xFDAF60 VA: 0x180FDBB60
	private string GetNotNull(SmallXmlParser.IAttrList attrs, string name) { }

	// RVA: 0xFDBA80 Offset: 0xFDAE80 VA: 0x180FDBA80
	private string ExtractAssembly(ref string type) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 9
	public void OnChars(string ch) { }

	// RVA: 0xFDBCD0 Offset: 0xFDB0D0 VA: 0x180FDBCD0 Slot: 5
	public void OnEndParsing(SmallXmlParser parser) { }

}

