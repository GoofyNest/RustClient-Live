internal sealed class SchemaElementDecl : SchemaDeclBase, IDtdAttributeListInfo // TypeDefIndex: 2277
{	// Fields
	private Dictionary<XmlQualifiedName, SchemaAttDef> attdefs; // 0x60
	private List<IDtdDefaultAttributeInfo> defaultAttdefs; // 0x68
	private bool isIdDeclared; // 0x70
	private bool hasNonCDataAttribute; // 0x71
	private bool isAbstract; // 0x72
	private bool isNillable; // 0x73
	private bool hasRequiredAttribute; // 0x74
	private bool isNotationDeclared; // 0x75
	private Dictionary<XmlQualifiedName, XmlQualifiedName> prohibitedAttributes; // 0x78
	private ContentValidator contentValidator; // 0x80
	private XmlSchemaAnyAttribute anyAttribute; // 0x88
	private XmlSchemaDerivationMethod block; // 0x90
	private CompiledIdentityConstraint[] constraints; // 0x98
	private XmlSchemaElement schemaElement; // 0xA0
	internal static readonly SchemaElementDecl Empty; // 0x0

	// Properties
	private bool System.Xml.IDtdAttributeListInfo.HasNonCDataAttributes { get; }
	internal bool IsIdDeclared { get; set; }
	internal bool HasNonCDataAttribute { get; set; }
	internal bool IsAbstract { get; set; }
	internal bool IsNillable { get; set; }
	internal XmlSchemaDerivationMethod Block { get; set; }
	internal bool IsNotationDeclared { get; set; }
	internal bool HasDefaultAttribute { get; }
	internal bool HasRequiredAttribute { get; }
	internal ContentValidator ContentValidator { get; set; }
	internal XmlSchemaAnyAttribute AnyAttribute { get; set; }
	internal CompiledIdentityConstraint[] Constraints { get; set; }
	internal XmlSchemaElement SchemaElement { get; set; }
	internal IList<IDtdDefaultAttributeInfo> DefaultAttDefs { get; }
	internal Dictionary<XmlQualifiedName, SchemaAttDef> AttDefs { get; }
	internal Dictionary<XmlQualifiedName, XmlQualifiedName> ProhibitedAttributes { get; }

	// Methods

	// RVA: 0xEE1B20 Offset: 0xEE0F20 VA: 0x180EE1B20
	internal void .ctor() { }

	// RVA: 0xEE18E0 Offset: 0xEE0CE0 VA: 0x180EE18E0
	internal void .ctor(XmlSchemaDatatype dtype) { }

	// RVA: 0xEE19E0 Offset: 0xEE0DE0 VA: 0x180EE19E0
	internal void .ctor(XmlQualifiedName name, string prefix) { }

	// RVA: 0xEE1670 Offset: 0xEE0A70 VA: 0x180EE1670
	internal static SchemaElementDecl CreateAnyTypeElementDecl() { }

	// RVA: 0xE891D0 Offset: 0xE885D0 VA: 0x180E891D0 Slot: 4
	private bool System.Xml.IDtdAttributeListInfo.get_HasNonCDataAttributes() { }

	// RVA: 0xEE17D0 Offset: 0xEE0BD0 VA: 0x180EE17D0 Slot: 5
	private IDtdAttributeInfo System.Xml.IDtdAttributeListInfo.LookupAttribute(string prefix, string localName) { }

	// RVA: 0x5334F0 Offset: 0x5328F0 VA: 0x1805334F0 Slot: 6
	private IEnumerable<IDtdDefaultAttributeInfo> System.Xml.IDtdAttributeListInfo.LookupDefaultAttributes() { }

	// RVA: 0xC2CA80 Offset: 0xC2BE80 VA: 0x180C2CA80
	internal bool get_IsIdDeclared() { }

	// RVA: 0xC2DBA0 Offset: 0xC2CFA0 VA: 0x180C2DBA0
	internal void set_IsIdDeclared(bool value) { }

	// RVA: 0xE891D0 Offset: 0xE885D0 VA: 0x180E891D0
	internal bool get_HasNonCDataAttribute() { }

	// RVA: 0xE89200 Offset: 0xE88600 VA: 0x180E89200
	internal void set_HasNonCDataAttribute(bool value) { }

	// RVA: 0xEE1610 Offset: 0xEE0A10 VA: 0x180EE1610
	internal SchemaElementDecl Clone() { }

	// RVA: 0xE891B0 Offset: 0xE885B0 VA: 0x180E891B0
	internal bool get_IsAbstract() { }

	// RVA: 0xE891E0 Offset: 0xE885E0 VA: 0x180E891E0
	internal void set_IsAbstract(bool value) { }

	// RVA: 0xE891C0 Offset: 0xE885C0 VA: 0x180E891C0
	internal bool get_IsNillable() { }

	// RVA: 0xE891F0 Offset: 0xE885F0 VA: 0x180E891F0
	internal void set_IsNillable(bool value) { }

	// RVA: 0xD22840 Offset: 0xD21C40 VA: 0x180D22840
	internal XmlSchemaDerivationMethod get_Block() { }

	// RVA: 0xD227B0 Offset: 0xD21BB0 VA: 0x180D227B0
	internal void set_Block(XmlSchemaDerivationMethod value) { }

	// RVA: 0xEE1BD0 Offset: 0xEE0FD0 VA: 0x180EE1BD0
	internal bool get_IsNotationDeclared() { }

	// RVA: 0xEE1BE0 Offset: 0xEE0FE0 VA: 0x180EE1BE0
	internal void set_IsNotationDeclared(bool value) { }

	// RVA: 0xEE1BC0 Offset: 0xEE0FC0 VA: 0x180EE1BC0
	internal bool get_HasDefaultAttribute() { }

	// RVA: 0xC86150 Offset: 0xC85550 VA: 0x180C86150
	internal bool get_HasRequiredAttribute() { }

	// RVA: 0x58DC40 Offset: 0x58D040 VA: 0x18058DC40
	internal ContentValidator get_ContentValidator() { }

	// RVA: 0x58DCD0 Offset: 0x58D0D0 VA: 0x18058DCD0
	internal void set_ContentValidator(ContentValidator value) { }

	// RVA: 0x58DBD0 Offset: 0x58CFD0 VA: 0x18058DBD0
	internal XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x58DC60 Offset: 0x58D060 VA: 0x18058DC60
	internal void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x58DBE0 Offset: 0x58CFE0 VA: 0x18058DBE0
	internal CompiledIdentityConstraint[] get_Constraints() { }

	// RVA: 0x58DC70 Offset: 0x58D070 VA: 0x18058DC70
	internal void set_Constraints(CompiledIdentityConstraint[] value) { }

	// RVA: 0x58DBC0 Offset: 0x58CFC0 VA: 0x18058DBC0
	internal XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x58DC50 Offset: 0x58D050 VA: 0x18058DC50
	internal void set_SchemaElement(XmlSchemaElement value) { }

	// RVA: 0xEE12F0 Offset: 0xEE06F0 VA: 0x180EE12F0
	internal void AddAttDef(SchemaAttDef attdef) { }

	// RVA: 0xEE1750 Offset: 0xEE0B50 VA: 0x180EE1750
	internal SchemaAttDef GetAttDef(XmlQualifiedName qname) { }

	// RVA: 0x5334F0 Offset: 0x5328F0 VA: 0x1805334F0
	internal IList<IDtdDefaultAttributeInfo> get_DefaultAttDefs() { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	internal Dictionary<XmlQualifiedName, SchemaAttDef> get_AttDefs() { }

	// RVA: 0x4E4EC0 Offset: 0x4E42C0 VA: 0x1804E4EC0
	internal Dictionary<XmlQualifiedName, XmlQualifiedName> get_ProhibitedAttributes() { }

	// RVA: 0xEE13D0 Offset: 0xEE07D0 VA: 0x180EE13D0
	internal void CheckAttributes(Hashtable presence, bool standalone) { }

	// RVA: 0xEE1880 Offset: 0xEE0C80 VA: 0x180EE1880
	private static void .cctor() { }

}

