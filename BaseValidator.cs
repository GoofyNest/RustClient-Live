internal class BaseValidator // TypeDefIndex: 2140
{	// Fields
	private XmlSchemaCollection schemaCollection; // 0x10
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

	// Properties
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

	// Methods

	// RVA: 0xF40EE0 Offset: 0xF402E0 VA: 0x180F40EE0
	public void .ctor(BaseValidator other) { }

	// RVA: 0xF40FA0 Offset: 0xF403A0 VA: 0x180F40FA0
	public void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	public XmlValidatingReaderImpl get_Reader() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public XmlSchemaCollection get_SchemaCollection() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public XmlNameTable get_NameTable() { }

	// RVA: 0xF41180 Offset: 0xF40580 VA: 0x180F41180
	public SchemaNames get_SchemaNames() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public PositionInfo get_PositionInfo() { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public XmlResolver get_XmlResolver() { }

	// RVA: 0x5089D0 Offset: 0x507DD0 VA: 0x1805089D0
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	public Uri get_BaseUri() { }

	// RVA: 0x4B94A0 Offset: 0x4B88A0 VA: 0x1804B94A0
	public void set_BaseUri(Uri value) { }

	// RVA: 0xF41110 Offset: 0xF40510 VA: 0x180F41110
	public ValidationEventHandler get_EventHandler() { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0
	public SchemaInfo get_SchemaInfo() { }

	// RVA: 0xF41220 Offset: 0xF40620 VA: 0x180F41220
	public void set_DtdInfo(IDtdInfo value) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 4
	public virtual bool get_PreserveWhitespace() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	public virtual void Validate() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 6
	public virtual void CompleteValidation() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 7
	public virtual object FindId(string name) { }

	// RVA: 0xF409B0 Offset: 0xF3FDB0 VA: 0x180F409B0
	public void ValidateText() { }

	// RVA: 0xF40DB0 Offset: 0xF401B0 VA: 0x180F40DB0
	public void ValidateWhitespace() { }

	// RVA: 0xF40300 Offset: 0xF3F700 VA: 0x180F40300
	private void SaveTextValue(string value) { }

	// RVA: 0xF40740 Offset: 0xF3FB40 VA: 0x180F40740
	protected void SendValidationEvent(string code) { }

	// RVA: 0xF404A0 Offset: 0xF3F8A0 VA: 0x180F404A0
	protected void SendValidationEvent(string code, string[] args) { }

	// RVA: 0xF405F0 Offset: 0xF3F9F0 VA: 0x180F405F0
	protected void SendValidationEvent(string code, string arg) { }

	// RVA: 0xF40820 Offset: 0xF3FC20 VA: 0x180F40820
	protected void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0xF40890 Offset: 0xF3FC90 VA: 0x180F40890
	protected void SendValidationEvent(string code, string msg, XmlSeverityType severity) { }

	// RVA: 0xF40380 Offset: 0xF3F780 VA: 0x180F40380
	protected void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	// RVA: 0xF407A0 Offset: 0xF3FBA0 VA: 0x180F407A0
	protected void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0xF40010 Offset: 0xF3F410 VA: 0x180F40010
	protected static void ProcessEntity(SchemaInfo sinfo, string name, object sender, ValidationEventHandler eventhandler, string baseUri, int lineNumber, int linePosition) { }

	// RVA: 0xF401A0 Offset: 0xF3F5A0 VA: 0x180F401A0
	protected static void ProcessEntity(SchemaInfo sinfo, string name, IValidationEventHandling eventHandling, string baseUriStr, int lineNumber, int linePosition) { }

	// RVA: 0xF3FE60 Offset: 0xF3F260 VA: 0x180F3FE60
	public static BaseValidator CreateInstance(ValidationType valType, XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling, bool processIdentityConstraints) { }

}

