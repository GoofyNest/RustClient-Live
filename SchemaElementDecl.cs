internal sealed class SchemaElementDecl : SchemaDeclBase, IDtdAttributeListInfo // TypeDefIndex: 2277
{	private Dictionary<XmlQualifiedName, SchemaAttDef> attdefs; // 0x60
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


	internal void .ctor() { }

	internal void .ctor(XmlSchemaDatatype dtype) { }

	internal void .ctor(XmlQualifiedName name, string prefix) { }

	internal static SchemaElementDecl CreateAnyTypeElementDecl() { }

	private bool System.Xml.IDtdAttributeListInfo.get_HasNonCDataAttributes() { }

	private IDtdAttributeInfo System.Xml.IDtdAttributeListInfo.LookupAttribute(string prefix, string localName) { }

	private IEnumerable<IDtdDefaultAttributeInfo> System.Xml.IDtdAttributeListInfo.LookupDefaultAttributes() { }

	internal bool get_IsIdDeclared() { }

	internal void set_IsIdDeclared(bool value) { }

	internal bool get_HasNonCDataAttribute() { }

	internal void set_HasNonCDataAttribute(bool value) { }

	internal SchemaElementDecl Clone() { }

	internal bool get_IsAbstract() { }

	internal void set_IsAbstract(bool value) { }

	internal bool get_IsNillable() { }

	internal void set_IsNillable(bool value) { }

	internal XmlSchemaDerivationMethod get_Block() { }

	internal void set_Block(XmlSchemaDerivationMethod value) { }

	internal bool get_IsNotationDeclared() { }

	internal void set_IsNotationDeclared(bool value) { }

	internal bool get_HasDefaultAttribute() { }

	internal bool get_HasRequiredAttribute() { }

	internal ContentValidator get_ContentValidator() { }

	internal void set_ContentValidator(ContentValidator value) { }

	internal XmlSchemaAnyAttribute get_AnyAttribute() { }

	internal void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	internal CompiledIdentityConstraint[] get_Constraints() { }

	internal void set_Constraints(CompiledIdentityConstraint[] value) { }

	internal XmlSchemaElement get_SchemaElement() { }

	internal void set_SchemaElement(XmlSchemaElement value) { }

	internal void AddAttDef(SchemaAttDef attdef) { }

	internal SchemaAttDef GetAttDef(XmlQualifiedName qname) { }

	internal IList<IDtdDefaultAttributeInfo> get_DefaultAttDefs() { }

	internal Dictionary<XmlQualifiedName, SchemaAttDef> get_AttDefs() { }

	internal Dictionary<XmlQualifiedName, XmlQualifiedName> get_ProhibitedAttributes() { }

	internal void CheckAttributes(Hashtable presence, bool standalone) { }

	private static void .cctor() { }

}

