internal sealed class DtdValidator : BaseValidator // TypeDefIndex: 2243
{	private static DtdValidator.NamespaceManager namespaceManager; // 0x0
	private HWStack validationStack; // 0x80
	private Hashtable attPresence; // 0x88
	private XmlQualifiedName name; // 0x90
	private Hashtable IDs; // 0x98
	private IdRefNode idRefListHead; // 0xA0
	private bool processIdentityConstraints; // 0xA8

	public override bool PreserveWhitespace { get; }


	internal void .ctor(XmlValidatingReaderImpl reader, IValidationEventHandling eventHandling, bool processIdentityConstraints) { }

	private void Init() { }

	public override void Validate() { }

	private bool MeetsStandAloneConstraint() { }

	private void ValidatePIComment() { }

	private void ValidateElement() { }

	private void ValidateChildElement() { }

	private void ValidateStartElement() { }

	private void ValidateEndStartElement() { }

	private void ProcessElement() { }

	public override void CompleteValidation() { }

	private void ValidateEndElement() { }

	public override bool get_PreserveWhitespace() { }

	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	private void CheckValue(string value, SchemaAttDef attdef) { }

	internal void AddID(string name, object node) { }

	public override object FindId(string name) { }

	private bool GenEntity(XmlQualifiedName qname) { }

	private SchemaEntity GetEntity(XmlQualifiedName qname, bool fParameterEntity) { }

	private void CheckForwardRefs() { }

	private void Push(XmlQualifiedName elementName) { }

	private bool Pop() { }

	public static void SetDefaultTypedValue(SchemaAttDef attdef, IDtdParserAdapter readerAdapter) { }

	public static void CheckDefaultValue(SchemaAttDef attdef, SchemaInfo sinfo, IValidationEventHandling eventHandling, string baseUriStr) { }

	private static void .cctor() { }

}

private class DtdValidator.NamespaceManager : XmlNamespaceManager // TypeDefIndex: 2244
{
	public override string LookupNamespace(string prefix) { }

	public void .ctor() { }

}

