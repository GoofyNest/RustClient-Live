internal class BaseValidator // TypeDefIndex: 2140
{	private XmlSchemaCollection schemaCollection; // 0x10
	private IValidationEventHandling eventHandling; // 0x18
	private XmlNameTable nameTable; // 0x20
	private SchemaNames schemaNames; // 0x28
	private PositionInfo positionInfo; // 0x30
	private XmlResolver xmlResolver; // 0x38
	private Uri baseUri; // 0x40
	protected SchemaInfo schemaInfo; // 0x48
	protected XmlValidatingReaderImpl reader; // 0x50
	protected XmlQualifiedName elementName; // 0x58
	protected ValidationState context; // 0x60
	protected StringBuilder textValue; // 0x68
	protected string textString; // 0x70
	protected bool hasSibling; // 0x78
	protected bool checkDatatype; // 0x79

	public XmlValidatingReaderImpl Reader { get; }
	public XmlSchemaCollection SchemaCollection { get; }
	public XmlNameTable NameTable { get; }
	public SchemaNames SchemaNames { get; }
	public PositionInfo PositionInfo { get; }
	public XmlResolver XmlResolver { get; set; }
	public Uri BaseUri { get; set; }
	public ValidationEventHandler EventHandler { get; }
	public SchemaInfo SchemaInfo { get; }
	public IDtdInfo DtdInfo { set; }
	public virtual bool PreserveWhitespace { get; }


	public void .ctor(BaseValidator other) { }

	public void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	public XmlValidatingReaderImpl get_Reader() { }

	public XmlSchemaCollection get_SchemaCollection() { }

	public XmlNameTable get_NameTable() { }

	public SchemaNames get_SchemaNames() { }

	public PositionInfo get_PositionInfo() { }

	public XmlResolver get_XmlResolver() { }

	public void set_XmlResolver(XmlResolver value) { }

	public Uri get_BaseUri() { }

	public void set_BaseUri(Uri value) { }

	public ValidationEventHandler get_EventHandler() { }

	public SchemaInfo get_SchemaInfo() { }

	public void set_DtdInfo(IDtdInfo value) { }

	public virtual bool get_PreserveWhitespace() { }

	public virtual void Validate() { }

	public virtual void CompleteValidation() { }

	public virtual object FindId(string name) { }

	public void ValidateText() { }

	public void ValidateWhitespace() { }

	private void SaveTextValue(string value) { }

	protected void SendValidationEvent(string code) { }

	protected void SendValidationEvent(string code, string[] args) { }

	protected void SendValidationEvent(string code, string arg) { }

	protected void SendValidationEvent(XmlSchemaException e) { }

	protected void SendValidationEvent(string code, string msg, XmlSeverityType severity) { }

	protected void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	protected void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	protected static void ProcessEntity(SchemaInfo sinfo, string name, object sender, ValidationEventHandler eventhandler, string baseUri, int lineNumber, int linePosition) { }

	protected static void ProcessEntity(SchemaInfo sinfo, string name, IValidationEventHandling eventHandling, string baseUriStr, int lineNumber, int linePosition) { }

	public static BaseValidator CreateInstance(ValidationType valType, XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling, bool processIdentityConstraints) { }

}

