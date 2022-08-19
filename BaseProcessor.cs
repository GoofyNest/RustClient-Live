internal class BaseProcessor // TypeDefIndex: 2139
{	// Fields
	private XmlNameTable nameTable; // 0x10
	private SchemaNames schemaNames; // 0x18
	private ValidationEventHandler eventHandler; // 0x20
	private XmlSchemaCompilationSettings compilationSettings; // 0x28
	private int errorCount; // 0x30
	private string NsXml; // 0x38

	// Properties
	protected XmlNameTable NameTable { get; }
	protected SchemaNames SchemaNames { get; }
	protected ValidationEventHandler EventHandler { get; }
	protected XmlSchemaCompilationSettings CompilationSettings { get; }
	protected bool HasErrors { get; }

	// Methods

	// RVA: 0xF3FC60 Offset: 0xF3F060 VA: 0x180F3FC60
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	// RVA: 0xF3FD00 Offset: 0xF3F100 VA: 0x180F3FD00
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	protected XmlNameTable get_NameTable() { }

	// RVA: 0xF3FDE0 Offset: 0xF3F1E0 VA: 0x180F3FDE0
	protected SchemaNames get_SchemaNames() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	protected ValidationEventHandler get_EventHandler() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	protected XmlSchemaCompilationSettings get_CompilationSettings() { }

	// RVA: 0xF3FDD0 Offset: 0xF3F1D0 VA: 0x180F3FDD0
	protected bool get_HasErrors() { }

	// RVA: 0xF3E9B0 Offset: 0xF3DDB0 VA: 0x180F3E9B0
	protected void AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item) { }

	// RVA: 0xF3EF30 Offset: 0xF3E330 VA: 0x180F3EF30
	private bool IsValidAttributeGroupRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	// RVA: 0xF3F050 Offset: 0xF3E450 VA: 0x180F3F050
	private bool IsValidGroupRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	// RVA: 0xF3F170 Offset: 0xF3E570 VA: 0x180F3F170
	private bool IsValidTypeRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	// RVA: 0xF3F6D0 Offset: 0xF3EAD0 VA: 0x180F3F6D0
	protected void SendValidationEvent(string code, XmlSchemaObject source) { }

	// RVA: 0xF3FA30 Offset: 0xF3EE30 VA: 0x180F3FA30
	protected void SendValidationEvent(string code, string msg, XmlSchemaObject source) { }

	// RVA: 0xF3F320 Offset: 0xF3E720 VA: 0x180F3F320
	protected void SendValidationEvent(string code, string msg1, string msg2, XmlSchemaObject source) { }

	// RVA: 0xF3F8E0 Offset: 0xF3ECE0 VA: 0x180F3F8E0
	protected void SendValidationEvent(string code, string[] args, Exception innerException, XmlSchemaObject source) { }

	// RVA: 0xF3F4F0 Offset: 0xF3E8F0 VA: 0x180F3F4F0
	protected void SendValidationEvent(string code, string msg1, string msg2, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0xF3FB20 Offset: 0xF3EF20 VA: 0x180F3FB20
	protected void SendValidationEvent(string code, XmlSchemaObject source, XmlSeverityType severity) { }

	// RVA: 0xF3F7B0 Offset: 0xF3EBB0 VA: 0x180F3F7B0
	protected void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0xF3F840 Offset: 0xF3EC40 VA: 0x180F3F840
	protected void SendValidationEvent(string code, string msg, XmlSchemaObject source, XmlSeverityType severity) { }

	// RVA: 0xF3FBB0 Offset: 0xF3EFB0 VA: 0x180F3FBB0
	protected void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0xF3F290 Offset: 0xF3E690 VA: 0x180F3F290
	protected void SendValidationEventNoThrow(XmlSchemaException e, XmlSeverityType severity) { }

}

