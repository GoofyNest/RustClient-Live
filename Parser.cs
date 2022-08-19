internal sealed class Parser // TypeDefIndex: 919
{	// Fields
	private SecurityDocument _doc; // 0x10
	private Tokenizer _t; // 0x18

	// Methods

	// RVA: 0x17AFCE0 Offset: 0x17AF0E0 VA: 0x1817AFCE0
	internal SecurityElement GetTopElement() { }

	// RVA: 0x17AF420 Offset: 0x17AE820 VA: 0x1817AF420
	private void GetRequiredSizes(TokenizerStream stream, ref int index) { }

	// RVA: 0x17AF250 Offset: 0x17AE650 VA: 0x1817AF250
	private int DetermineFormat(TokenizerStream stream) { }

	// RVA: 0x17AFD10 Offset: 0x17AF110 VA: 0x1817AFD10
	private void ParseContents() { }

	// RVA: 0x17B0180 Offset: 0x17AF580 VA: 0x1817B0180
	private void .ctor(Tokenizer t) { }

	// RVA: 0x17B0080 Offset: 0x17AF480 VA: 0x1817B0080
	internal void .ctor(string input) { }

}

internal sealed class Parser // TypeDefIndex: 2265
{	// Fields
	private SchemaType schemaType; // 0x10
	private XmlNameTable nameTable; // 0x18
	private SchemaNames schemaNames; // 0x20
	private ValidationEventHandler eventHandler; // 0x28
	private XmlNamespaceManager namespaceManager; // 0x30
	private XmlReader reader; // 0x38
	private PositionInfo positionInfo; // 0x40
	private bool isProcessNamespaces; // 0x48
	private int schemaXmlDepth; // 0x4C
	private int markupDepth; // 0x50
	private SchemaBuilder builder; // 0x58
	private XmlSchema schema; // 0x60
	private SchemaInfo xdrSchema; // 0x68
	private XmlResolver xmlResolver; // 0x70
	private XmlDocument dummyDocument; // 0x78
	private bool processMarkup; // 0x80
	private XmlNode parentNode; // 0x88
	private XmlNamespaceManager annotationNSManager; // 0x90
	private string xmlns; // 0x98
	private XmlCharType xmlCharType; // 0xA0

	// Properties
	public XmlSchema XmlSchema { get; }
	internal XmlResolver XmlResolver { set; }
	public SchemaInfo XdrSchema { get; }

	// Methods

	// RVA: 0xB11ED0 Offset: 0xB112D0 VA: 0x180B11ED0
	public void .ctor(SchemaType schemaType, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	// RVA: 0xB11640 Offset: 0xB10A40 VA: 0x180B11640
	public SchemaType Parse(XmlReader reader, string targetNamespace) { }

	// RVA: 0xB119D0 Offset: 0xB10DD0 VA: 0x180B119D0
	public void StartParsing(XmlReader reader, string targetNamespace) { }

	// RVA: 0xB10360 Offset: 0xB0F760 VA: 0x180B10360
	private bool CheckSchemaRoot(SchemaType rootType, out string code) { }

	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	public SchemaType FinishParsing() { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	public XmlSchema get_XmlSchema() { }

	// RVA: 0x58DCC0 Offset: 0x58D0C0 VA: 0x18058DCC0
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x5334F0 Offset: 0x5328F0 VA: 0x1805334F0
	public SchemaInfo get_XdrSchema() { }

	// RVA: 0xB10E40 Offset: 0xB10240 VA: 0x180B10E40
	public bool ParseReaderNode() { }

	// RVA: 0xB116A0 Offset: 0xB10AA0 VA: 0x180B116A0
	private void ProcessAppInfoDocMarkup(bool root) { }

	// RVA: 0xB10730 Offset: 0xB0FB30 VA: 0x180B10730
	private XmlElement LoadElementNode(bool root) { }

	// RVA: 0xB10460 Offset: 0xB0F860 VA: 0x180B10460
	private XmlAttribute CreateXmlNsAttribute(string prefix, string value) { }

	// RVA: 0xB10580 Offset: 0xB0F980 VA: 0x180B10580
	private XmlAttribute LoadAttributeNode() { }

	// RVA: 0xB10BD0 Offset: 0xB0FFD0 VA: 0x180B10BD0
	private XmlEntityReference LoadEntityReferenceInAttribute() { }

}

public static class Parser.Token // TypeDefIndex: 5790
{
// Namespace: 
public static class Parser.Token // TypeDefIndex: 5790
	// Methods

	// RVA: 0x1092360 Offset: 0x1091760 VA: 0x181092360
	public static void Check(string s) { }

	// RVA: 0x10924D0 Offset: 0x10918D0 VA: 0x1810924D0
	public static bool TryCheck(string s) { }

}

public static class Parser.DateTime // TypeDefIndex: 5791
{	// Fields
	public static readonly Func<object, string> ToString; // 0x2B0AC48

	// Methods

	// RVA: 0x1082A40 Offset: 0x1081E40 VA: 0x181082A40
	public static bool TryParse(string input, out DateTimeOffset result) { }

	// RVA: 0x1082AB0 Offset: 0x1081EB0 VA: 0x181082AB0
	private static void .cctor() { }

}

private sealed class Parser.DateTime.<>c // TypeDefIndex: 5792
{	// Fields
	public static readonly Parser.DateTime.<>c <>9; // 0x2710

	// Methods

	// RVA: 0x1095DF0 Offset: 0x10951F0 VA: 0x181095DF0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1095A30 Offset: 0x1094E30 VA: 0x181095A30
	internal string <.cctor>b__2_0(object l) { }

}

public static class Parser.EmailAddress // TypeDefIndex: 5793
{	// Methods

	// RVA: 0x1082B60 Offset: 0x1081F60 VA: 0x181082B60
	public static bool TryParse(string input, out string result) { }

}

public static class Parser.Host // TypeDefIndex: 5794
{	// Methods

	// RVA: 0x10835D0 Offset: 0x10829D0 VA: 0x1810835D0
	public static bool TryParse(string input, out string result) { }

}

public static class Parser.Int // TypeDefIndex: 5795
{	// Methods

	// RVA: 0x108B860 Offset: 0x108AC60 VA: 0x18108B860
	public static bool TryParse(string input, out int result) { }

}

public static class Parser.Long // TypeDefIndex: 5796
{	// Methods

	// RVA: 0x108C8B0 Offset: 0x108BCB0 VA: 0x18108C8B0
	public static bool TryParse(string input, out long result) { }

}

public static class Parser.MD5 // TypeDefIndex: 5797
{	// Fields
	public static readonly Func<object, string> ToString; // 0x2757

	// Methods

	// RVA: 0x108C930 Offset: 0x108BD30 VA: 0x18108C930
	public static bool TryParse(string input, out byte[] result) { }

	// RVA: 0x108C9D0 Offset: 0x108BDD0 VA: 0x18108C9D0
	private static void .cctor() { }

}

private sealed class Parser.MD5.<>c // TypeDefIndex: 5798
{	// Fields
	public static readonly Parser.MD5.<>c <>9; // 0x2B0AACC

	// Methods

	// RVA: 0x1095E50 Offset: 0x1095250 VA: 0x181095E50
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1095AD0 Offset: 0x1094ED0 VA: 0x181095AD0
	internal string <.cctor>b__2_0(object l) { }

}

public static class Parser.TimeSpanSeconds // TypeDefIndex: 5799
{	// Methods

	// RVA: 0x1092240 Offset: 0x1091640 VA: 0x181092240
	public static bool TryParse(string input, out TimeSpan result) { }

}

public static class Parser.Uri // TypeDefIndex: 5800
{	// Methods

	// RVA: 0x1095EB0 Offset: 0x10952B0 VA: 0x181095EB0
	public static bool TryParse(string input, out Uri result) { }

}

