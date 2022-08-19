internal sealed class SchemaCollectionPreprocessor : BaseProcessor // TypeDefIndex: 2273
{	// Fields
	private XmlSchema schema; // 0x40
	private string targetNamespace; // 0x48
	private bool buildinIncluded; // 0x50
	private XmlSchemaForm elementFormDefault; // 0x54
	private XmlSchemaForm attributeFormDefault; // 0x58
	private XmlSchemaDerivationMethod blockDefault; // 0x5C
	private XmlSchemaDerivationMethod finalDefault; // 0x60
	private Hashtable schemaLocations; // 0x68
	private Hashtable referenceNamespaces; // 0x70
	private string Xmlns; // 0x78
	private XmlResolver xmlResolver; // 0x80

	// Properties
	internal XmlResolver XmlResolver { set; }

	// Methods

	// RVA: 0xEE0F20 Offset: 0xEE0320 VA: 0x180EE0F20
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	// RVA: 0xED6300 Offset: 0xED5700 VA: 0x180ED6300
	public bool Execute(XmlSchema schema, string targetNamespace, bool loadExternals, XmlSchemaCollection xsc) { }

	// RVA: 0xED5D20 Offset: 0xED5120 VA: 0x180ED5D20
	private void Cleanup(XmlSchema schema) { }

	// RVA: 0x58DCD0 Offset: 0x58D0D0 VA: 0x18058DCD0
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0xED6640 Offset: 0xED5A40 VA: 0x180ED6640
	private void LoadExternals(XmlSchema schema, XmlSchemaCollection xsc) { }

	// RVA: 0xED52D0 Offset: 0xED46D0 VA: 0x180ED52D0
	private void BuildRefNamespaces(XmlSchema schema) { }

	// RVA: 0xEDE480 Offset: 0xEDD880 VA: 0x180EDE480
	private void Preprocess(XmlSchema schema, string targetNamespace, SchemaCollectionPreprocessor.Compositor compositor) { }

	// RVA: 0xEDBA90 Offset: 0xEDAE90 VA: 0x180EDBA90
	private void PreprocessRedefine(XmlSchemaRedefine redefine) { }

	// RVA: 0xED5FD0 Offset: 0xED53D0 VA: 0x180ED5FD0
	private int CountGroupSelfReference(XmlSchemaObjectCollection items, XmlQualifiedName name) { }

	// RVA: 0xED5B10 Offset: 0xED4F10 VA: 0x180ED5B10
	private void CheckRefinedGroup(XmlSchemaGroup group) { }

	// RVA: 0xED54E0 Offset: 0xED48E0 VA: 0x180ED54E0
	private void CheckRefinedAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0xED5BA0 Offset: 0xED4FA0 VA: 0x180ED5BA0
	private void CheckRefinedSimpleType(XmlSchemaSimpleType stype) { }

	// RVA: 0xED5630 Offset: 0xED4A30 VA: 0x180ED5630
	private void CheckRefinedComplexType(XmlSchemaComplexType ctype) { }

	// RVA: 0xED7680 Offset: 0xED6A80 VA: 0x180ED7680
	private void PreprocessAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0xED9620 Offset: 0xED8A20 VA: 0x180ED9620
	private void PreprocessLocalAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0xED73A0 Offset: 0xED67A0 VA: 0x180ED73A0
	private void PreprocessAttributeContent(XmlSchemaAttribute attribute) { }

	// RVA: 0xED7570 Offset: 0xED6970 VA: 0x180ED7570
	private void PreprocessAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0xED8F10 Offset: 0xED8310 VA: 0x180ED8F10
	private void PreprocessElement(XmlSchemaElement element) { }

	// RVA: 0xED97A0 Offset: 0xED8BA0 VA: 0x180ED97A0
	private void PreprocessLocalElement(XmlSchemaElement element) { }

	// RVA: 0xED8B40 Offset: 0xED7F40 VA: 0x180ED8B40
	private void PreprocessElementContent(XmlSchemaElement element) { }

	// RVA: 0xED92C0 Offset: 0xED86C0 VA: 0x180ED92C0
	private void PreprocessIdentityConstraint(XmlSchemaIdentityConstraint constraint) { }

	// RVA: 0xEDDBA0 Offset: 0xEDCFA0 VA: 0x180EDDBA0
	private void PreprocessSimpleType(XmlSchemaSimpleType simpleType, bool local) { }

	// RVA: 0xED81A0 Offset: 0xED75A0 VA: 0x180ED81A0
	private void PreprocessComplexType(XmlSchemaComplexType complexType, bool local) { }

	// RVA: 0xED9120 Offset: 0xED8520 VA: 0x180ED9120
	private void PreprocessGroup(XmlSchemaGroup group) { }

	// RVA: 0xED9B00 Offset: 0xED8F00 VA: 0x180ED9B00
	private void PreprocessNotation(XmlSchemaNotation notation) { }

	// RVA: 0xED9CC0 Offset: 0xED90C0 VA: 0x180ED9CC0
	private void PreprocessParticle(XmlSchemaParticle particle) { }

	// RVA: 0xED77C0 Offset: 0xED6BC0 VA: 0x180ED77C0
	private void PreprocessAttributes(XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaObject parent) { }

	// RVA: 0xEE08E0 Offset: 0xEDFCE0 VA: 0x180EE08E0
	private void ValidateIdAttribute(XmlSchemaObject xso) { }

	// RVA: 0xEE0AE0 Offset: 0xEDFEE0 VA: 0x180EE0AE0
	private void ValidateNameAttribute(XmlSchemaObject xso) { }

	// RVA: 0xEE0E00 Offset: 0xEE0200 VA: 0x180EE0E00
	private void ValidateQNameAttribute(XmlSchemaObject xso, string attributeName, XmlQualifiedName value) { }

	// RVA: 0xB21DB0 Offset: 0xB211B0 VA: 0x180B21DB0
	private void SetParent(XmlSchemaObject child, XmlSchemaObject parent) { }

	// RVA: 0xED72A0 Offset: 0xED66A0 VA: 0x180ED72A0
	private void PreprocessAnnotation(XmlSchemaObject schemaObject) { }

	// RVA: 0xEE0840 Offset: 0xEDFC40 VA: 0x180EE0840
	private Uri ResolveSchemaLocationUri(XmlSchema enclosingSchema, string location) { }

	// RVA: 0xED6570 Offset: 0xED5970 VA: 0x180ED6570
	private Stream GetSchemaEntity(Uri ruri) { }

}

private enum SchemaCollectionPreprocessor.Compositor // TypeDefIndex: 2274
{	// Fields
	public int value__; // 0x0
	public const SchemaCollectionPreprocessor.Compositor Root = 0;
	public const SchemaCollectionPreprocessor.Compositor Include = 1;
	public const SchemaCollectionPreprocessor.Compositor Import = 2;

}

