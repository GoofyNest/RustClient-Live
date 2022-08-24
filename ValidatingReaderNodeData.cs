internal class ValidatingReaderNodeData // TypeDefIndex: 1870
{
	private string localName; 
	private string namespaceUri; 
	private string prefix; 
	private string nameWPrefix; 
	private string rawValue; 
	private string originalStringValue; 
	private int depth; 
	private AttributePSVIInfo attributePSVIInfo; 
	private XmlNodeType nodeType; 
	private int lineNo; 
	private int linePos; 

	public string LocalName { get; set; }
	public string Namespace { get; set; }
	public string Prefix { get; set; }
	public int Depth { get; set; }
	public string RawValue { get; set; }
	public string OriginalStringValue { get; }
	public XmlNodeType NodeType { get; set; }
	public AttributePSVIInfo AttInfo { get; set; }
	public int LineNumber { get; }
	public int LinePosition { get; }


	public void .ctor() { }

	public void .ctor(XmlNodeType nodeType) { }

	public string get_LocalName() { }

	public void set_LocalName(string value) { }

	public string get_Namespace() { }

	public void set_Namespace(string value) { }

	public string get_Prefix() { }

	public void set_Prefix(string value) { }

	public string GetAtomizedNameWPrefix(XmlNameTable nameTable) { }

	public int get_Depth() { }

	public void set_Depth(int value) { }

	public string get_RawValue() { }

	public void set_RawValue(string value) { }

	public string get_OriginalStringValue() { }

	public XmlNodeType get_NodeType() { }

	public void set_NodeType(XmlNodeType value) { }

	public AttributePSVIInfo get_AttInfo() { }

	public void set_AttInfo(AttributePSVIInfo value) { }

	public int get_LineNumber() { }

	public int get_LinePosition() { }

	internal void Clear(XmlNodeType nodeType) { }

	internal void SetLineInfo(int lineNo, int linePos) { }

	internal void SetLineInfo(IXmlLineInfo lineInfo) { }

	internal void SetItemData(string localName, string prefix, string ns, int depth) { }

	internal void SetItemData(string value) { }

	internal void SetItemData(string value, string originalStringValue) { }

}

