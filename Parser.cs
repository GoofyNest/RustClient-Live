internal sealed class Parser // TypeDefIndex: 919
{
	private SecurityDocument _doc; 
	private Tokenizer _t; 


internal SecurityElement GetTopElement() { }

private void GetRequiredSizes(TokenizerStream stream, ref int index) { }

private int DetermineFormat(TokenizerStream stream) { }

private void ParseContents() { }

private void .ctor(Tokenizer t) { }

internal void .ctor(string input) { }

}

internal sealed class Parser // TypeDefIndex: 2265
{
	private SchemaType schemaType; 
	private XmlNameTable nameTable; 
	private SchemaNames schemaNames; 
	private ValidationEventHandler eventHandler; 
	private XmlNamespaceManager namespaceManager; 
	private XmlReader reader; 
	private PositionInfo positionInfo; 
	private bool isProcessNamespaces; 
	private int schemaXmlDepth; 
	private int markupDepth; 
	private SchemaBuilder builder; 
	private XmlSchema schema; 
	private SchemaInfo xdrSchema; 
	private XmlResolver xmlResolver; 
	private XmlDocument dummyDocument; 
	private bool processMarkup; 
	private XmlNode parentNode; 
	private XmlNamespaceManager annotationNSManager; 
	private string xmlns; 
	private XmlCharType xmlCharType; 

public XmlSchema XmlSchema { get; }
internal XmlResolver XmlResolver { set; }
public SchemaInfo XdrSchema { get; }


public void .ctor(SchemaType schemaType, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

public SchemaType Parse(XmlReader reader, string targetNamespace) { }

public void StartParsing(XmlReader reader, string targetNamespace) { }

private bool CheckSchemaRoot(SchemaType rootType, out string code) { }

public SchemaType FinishParsing() { }

public XmlSchema get_XmlSchema() { }

internal void set_XmlResolver(XmlResolver value) { }

public SchemaInfo get_XdrSchema() { }

public bool ParseReaderNode() { }

private void ProcessAppInfoDocMarkup(bool root) { }

private XmlElement LoadElementNode(bool root) { }

private XmlAttribute CreateXmlNsAttribute(string prefix, string value) { }

private XmlAttribute LoadAttributeNode() { }

private XmlEntityReference LoadEntityReferenceInAttribute() { }

}

public static class Parser.Token // TypeDefIndex: 5790
{

public static class Parser.Token 

public static void Check(string s) { }

public static bool TryCheck(string s) { }

}

public static class Parser.DateTime // TypeDefIndex: 5791
{
	public static readonly Func<object, string> ToString; 


public static bool TryParse(string input, out DateTimeOffset result) { }

private static void .cctor() { }

}

private sealed class Parser.DateTime.<>c // TypeDefIndex: 5792
{
	public static readonly Parser.DateTime.<>c <>9; 


private static void .cctor() { }

public void .ctor() { }

internal string <.cctor>b__2_0(object l) { }

}

public static class Parser.EmailAddress // TypeDefIndex: 5793
{

public static bool TryParse(string input, out string result) { }

}

public static class Parser.Host // TypeDefIndex: 5794
{

public static bool TryParse(string input, out string result) { }

}

public static class Parser.Int // TypeDefIndex: 5795
{

public static bool TryParse(string input, out int result) { }

}

public static class Parser.Long // TypeDefIndex: 5796
{

public static bool TryParse(string input, out long result) { }

}

public static class Parser.MD5 // TypeDefIndex: 5797
{
	public static readonly Func<object, string> ToString; 


public static bool TryParse(string input, out byte[] result) { }

private static void .cctor() { }

}

private sealed class Parser.MD5.<>c // TypeDefIndex: 5798
{
	public static readonly Parser.MD5.<>c <>9; 


private static void .cctor() { }

public void .ctor() { }

internal string <.cctor>b__2_0(object l) { }

}

public static class Parser.TimeSpanSeconds // TypeDefIndex: 5799
{

public static bool TryParse(string input, out TimeSpan result) { }

}

public static class Parser.Uri // TypeDefIndex: 5800
{

public static bool TryParse(string input, out Uri result) { }

}

