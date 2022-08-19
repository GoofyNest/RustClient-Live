internal sealed class XdrValidator : BaseValidator // TypeDefIndex: 2302
{	// Fields
	private HWStack validationStack; // 0x80
	private Hashtable attPresence; // 0x88
	private XmlQualifiedName name; // 0x90
	private XmlNamespaceManager nsManager; // 0x98
	private bool isProcessContents; // 0xA0
	private Hashtable IDs; // 0xA8
	private IdRefNode idRefListHead; // 0xB0
	private Parser inlineSchemaParser; // 0xB8

	// Properties
	private bool IsInlineSchemaStarted { get; }
	private bool HasSchema { get; }
	public override bool PreserveWhitespace { get; }

	// Methods

	// RVA: 0x1427D30 Offset: 0x1427130 VA: 0x181427D30
	internal void .ctor(BaseValidator validator) { }

	// RVA: 0x1427C70 Offset: 0x1427070 VA: 0x181427C70
	internal void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x1425610 Offset: 0x1424A10 VA: 0x181425610
	private void Init() { }

	// RVA: 0x1427BA0 Offset: 0x1426FA0 VA: 0x181427BA0 Slot: 5
	public override void Validate() { }

	// RVA: 0x1426D70 Offset: 0x1426170 VA: 0x181426D70
	private void ValidateElement() { }

	// RVA: 0x1426BC0 Offset: 0x1425FC0 VA: 0x181426BC0
	private void ValidateChildElement() { }

	// RVA: 0x1115F00 Offset: 0x1115300 VA: 0x181115F00
	private bool get_IsInlineSchemaStarted() { }

	// RVA: 0x1426180 Offset: 0x1425580 VA: 0x181426180
	private void ProcessInlineSchema() { }

	// RVA: 0x14260A0 Offset: 0x14254A0 VA: 0x1814260A0
	private void ProcessElement() { }

	// RVA: 0x1427180 Offset: 0x1426580 VA: 0x181427180
	private void ValidateEndElement() { }

	// RVA: 0x1426810 Offset: 0x1425C10 VA: 0x181426810
	private SchemaElementDecl ThoroughGetElementDecl() { }

	// RVA: 0x1427750 Offset: 0x1426B50 VA: 0x181427750
	private void ValidateStartElement() { }

	// RVA: 0x1427430 Offset: 0x1426830 VA: 0x181427430
	private void ValidateEndStartElement() { }

	// RVA: 0x14257F0 Offset: 0x1424BF0 VA: 0x1814257F0
	private void LoadSchemaFromLocation(string uri) { }

	// RVA: 0x1425E70 Offset: 0x1425270 VA: 0x181425E70
	private void LoadSchema(string uri) { }

	// RVA: 0x1115EE0 Offset: 0x11152E0 VA: 0x181115EE0
	private bool get_HasSchema() { }

	// RVA: 0x1115F10 Offset: 0x1115310 VA: 0x181115F10 Slot: 4
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x14263A0 Offset: 0x14257A0 VA: 0x1814263A0
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	// RVA: 0x1425440 Offset: 0x1424840 VA: 0x181425440 Slot: 6
	public override void CompleteValidation() { }

	// RVA: 0x1424F70 Offset: 0x1424370 VA: 0x181424F70
	private void CheckValue(string value, SchemaAttDef attdef) { }

	// RVA: 0x1424A30 Offset: 0x1423E30 VA: 0x181424A30
	public static void CheckDefaultValue(string value, SchemaAttDef attdef, SchemaInfo sinfo, XmlNamespaceManager nsManager, XmlNameTable NameTable, object sender, ValidationEventHandler eventhandler, string baseUri, int lineNo, int linePos) { }

	// RVA: 0x1424980 Offset: 0x1423D80 VA: 0x181424980
	internal void AddID(string name, object node) { }

	// RVA: 0x1112400 Offset: 0x1111800 VA: 0x181112400 Slot: 7
	public override object FindId(string name) { }

	// RVA: 0x1426620 Offset: 0x1425A20 VA: 0x181426620
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x1426000 Offset: 0x1425400 VA: 0x181426000
	private void Pop() { }

	// RVA: 0x1424E30 Offset: 0x1424230 VA: 0x181424E30
	private void CheckForwardRefs() { }

	// RVA: 0x1426770 Offset: 0x1425B70 VA: 0x181426770
	private XmlQualifiedName QualifiedName(string name, string ns) { }

}

