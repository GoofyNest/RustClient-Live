internal sealed class XdrValidator : BaseValidator // TypeDefIndex: 2302
{	private HWStack validationStack; // 0x80
	private Hashtable attPresence; // 0x88
	private XmlQualifiedName name; // 0x90
	private XmlNamespaceManager nsManager; // 0x98
	private bool isProcessContents; // 0xA0
	private Hashtable IDs; // 0xA8
	private IdRefNode idRefListHead; // 0xB0
	private Parser inlineSchemaParser; // 0xB8

	private bool IsInlineSchemaStarted { get; }
	private bool HasSchema { get; }
	public override bool PreserveWhitespace { get; }


	internal void .ctor(BaseValidator validator) { }

	internal void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	private void Init() { }

	public override void Validate() { }

	private void ValidateElement() { }

	private void ValidateChildElement() { }

	private bool get_IsInlineSchemaStarted() { }

	private void ProcessInlineSchema() { }

	private void ProcessElement() { }

	private void ValidateEndElement() { }

	private SchemaElementDecl ThoroughGetElementDecl() { }

	private void ValidateStartElement() { }

	private void ValidateEndStartElement() { }

	private void LoadSchemaFromLocation(string uri) { }

	private void LoadSchema(string uri) { }

	private bool get_HasSchema() { }

	public override bool get_PreserveWhitespace() { }

	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	public override void CompleteValidation() { }

	private void CheckValue(string value, SchemaAttDef attdef) { }

	public static void CheckDefaultValue(string value, SchemaAttDef attdef, SchemaInfo sinfo, XmlNamespaceManager nsManager, XmlNameTable NameTable, object sender, ValidationEventHandler eventhandler, string baseUri, int lineNo, int linePos) { }

	internal void AddID(string name, object node) { }

	public override object FindId(string name) { }

	private void Push(XmlQualifiedName elementName) { }

	private void Pop() { }

	private void CheckForwardRefs() { }

	private XmlQualifiedName QualifiedName(string name, string ns) { }

}

