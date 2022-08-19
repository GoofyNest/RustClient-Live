internal sealed class DtdValidator : BaseValidator // TypeDefIndex: 2243
{	// Fields
	private static DtdValidator.NamespaceManager namespaceManager; // 0x0
	private HWStack validationStack; // 0x80
	private Hashtable attPresence; // 0x88
	private XmlQualifiedName name; // 0x90
	private Hashtable IDs; // 0x98
	private IdRefNode idRefListHead; // 0xA0
	private bool processIdentityConstraints; // 0xA8

	// Properties
	public override bool PreserveWhitespace { get; }

	// Methods

	// RVA: 0x1532020 Offset: 0x1531420 VA: 0x181532020
	internal void .ctor(XmlValidatingReaderImpl reader, IValidationEventHandling eventHandling, bool processIdentityConstraints) { }

	// RVA: 0x15302F0 Offset: 0x152F6F0 VA: 0x1815302F0
	private void Init() { }

	// RVA: 0x1531B30 Offset: 0x1530F30 VA: 0x181531B30 Slot: 5
	public override void Validate() { }

	// RVA: 0x1530440 Offset: 0x152F840 VA: 0x181530440
	private bool MeetsStandAloneConstraint() { }

	// RVA: 0x1531670 Offset: 0x1530A70 VA: 0x181531670
	private void ValidatePIComment() { }

	// RVA: 0x1530ED0 Offset: 0x15302D0 VA: 0x181530ED0
	private void ValidateElement() { }

	// RVA: 0x1530D20 Offset: 0x1530120 VA: 0x181530D20
	private void ValidateChildElement() { }

	// RVA: 0x1531720 Offset: 0x1530B20 VA: 0x181531720
	private void ValidateStartElement() { }

	// RVA: 0x15314A0 Offset: 0x15308A0 VA: 0x1815314A0
	private void ValidateEndStartElement() { }

	// RVA: 0x1530570 Offset: 0x152F970 VA: 0x181530570
	private void ProcessElement() { }

	// RVA: 0x152FED0 Offset: 0x152F2D0 VA: 0x18152FED0 Slot: 6
	public override void CompleteValidation() { }

	// RVA: 0x15312B0 Offset: 0x15306B0 VA: 0x1815312B0
	private void ValidateEndElement() { }

	// RVA: 0x1532210 Offset: 0x1531610 VA: 0x181532210 Slot: 4
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x15306C0 Offset: 0x152FAC0 VA: 0x1815306C0
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	// RVA: 0x152FA40 Offset: 0x152EE40 VA: 0x18152FA40
	private void CheckValue(string value, SchemaAttDef attdef) { }

	// RVA: 0x152F580 Offset: 0x152E980 VA: 0x18152F580
	internal void AddID(string name, object node) { }

	// RVA: 0x1530040 Offset: 0x152F440 VA: 0x181530040 Slot: 7
	public override object FindId(string name) { }

	// RVA: 0x1530060 Offset: 0x152F460 VA: 0x181530060
	private bool GenEntity(XmlQualifiedName qname) { }

	// RVA: 0x1530220 Offset: 0x152F620 VA: 0x181530220
	private SchemaEntity GetEntity(XmlQualifiedName qname, bool fParameterEntity) { }

	// RVA: 0x152F900 Offset: 0x152ED00 VA: 0x18152F900
	private void CheckForwardRefs() { }

	// RVA: 0x1530960 Offset: 0x152FD60 VA: 0x181530960
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x15304D0 Offset: 0x152F8D0 VA: 0x1815304D0
	private bool Pop() { }

	// RVA: 0x1530AB0 Offset: 0x152FEB0 VA: 0x181530AB0
	public static void SetDefaultTypedValue(SchemaAttDef attdef, IDtdParserAdapter readerAdapter) { }

	// RVA: 0x152F630 Offset: 0x152EA30 VA: 0x18152F630
	public static void CheckDefaultValue(SchemaAttDef attdef, SchemaInfo sinfo, IValidationEventHandling eventHandling, string baseUriStr) { }

	// RVA: 0x1531FC0 Offset: 0x15313C0 VA: 0x181531FC0
	private static void .cctor() { }

}

private class DtdValidator.NamespaceManager : XmlNamespaceManager // TypeDefIndex: 2244
{	// Methods

	// RVA: 0x7B2BE0 Offset: 0x7B1FE0 VA: 0x1807B2BE0 Slot: 16
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

}

