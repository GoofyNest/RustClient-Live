internal class BaseProcessor // TypeDefIndex: 2139
{
	private XmlNameTable nameTable; 
	private SchemaNames schemaNames; 
	private ValidationEventHandler eventHandler; 
	private XmlSchemaCompilationSettings compilationSettings; 
	private int errorCount; 
	private string NsXml; 

protected XmlNameTable NameTable { get; }
protected SchemaNames SchemaNames { get; }
protected ValidationEventHandler EventHandler { get; }
protected XmlSchemaCompilationSettings CompilationSettings { get; }
protected bool HasErrors { get; }


public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

protected XmlNameTable get_NameTable() { }

protected SchemaNames get_SchemaNames() { }

protected ValidationEventHandler get_EventHandler() { }

protected XmlSchemaCompilationSettings get_CompilationSettings() { }

protected bool get_HasErrors() { }

protected void AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item) { }

private bool IsValidAttributeGroupRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

private bool IsValidGroupRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

private bool IsValidTypeRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

protected void SendValidationEvent(string code, XmlSchemaObject source) { }

protected void SendValidationEvent(string code, string msg, XmlSchemaObject source) { }

protected void SendValidationEvent(string code, string msg1, string msg2, XmlSchemaObject source) { }

protected void SendValidationEvent(string code, string[] args, Exception innerException, XmlSchemaObject source) { }

protected void SendValidationEvent(string code, string msg1, string msg2, string sourceUri, int lineNumber, int linePosition) { }

protected void SendValidationEvent(string code, XmlSchemaObject source, XmlSeverityType severity) { }

protected void SendValidationEvent(XmlSchemaException e) { }

protected void SendValidationEvent(string code, string msg, XmlSchemaObject source, XmlSeverityType severity) { }

protected void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

protected void SendValidationEventNoThrow(XmlSchemaException e, XmlSeverityType severity) { }

}

