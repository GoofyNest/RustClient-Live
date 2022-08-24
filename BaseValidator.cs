internal class BaseValidator // TypeDefIndex: 2140
{
	private XmlSchemaCollection schemaCollection; 
	private IValidationEventHandling eventHandling; 
	private XmlNameTable nameTable; 
	private SchemaNames schemaNames; 
	private PositionInfo positionInfo; 
	private XmlResolver xmlResolver; 
	private Uri baseUri; 
	protected SchemaInfo schemaInfo; 
	protected XmlValidatingReaderImpl reader; 
	protected XmlQualifiedName elementName; 
	protected ValidationState context; 
	protected StringBuilder textValue; 
	protected string textString; 
	protected bool hasSibling; 
	protected bool checkDatatype; 

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

