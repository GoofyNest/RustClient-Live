internal sealed class SchemaCollectionPreprocessor : BaseProcessor // TypeDefIndex: 2273
{	private XmlSchema schema; // 0x40
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

	internal XmlResolver XmlResolver { set; }


	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	public bool Execute(XmlSchema schema, string targetNamespace, bool loadExternals, XmlSchemaCollection xsc) { }

	private void Cleanup(XmlSchema schema) { }

	internal void set_XmlResolver(XmlResolver value) { }

	private void LoadExternals(XmlSchema schema, XmlSchemaCollection xsc) { }

	private void BuildRefNamespaces(XmlSchema schema) { }

	private void Preprocess(XmlSchema schema, string targetNamespace, SchemaCollectionPreprocessor.Compositor compositor) { }

	private void PreprocessRedefine(XmlSchemaRedefine redefine) { }

	private int CountGroupSelfReference(XmlSchemaObjectCollection items, XmlQualifiedName name) { }

	private void CheckRefinedGroup(XmlSchemaGroup group) { }

	private void CheckRefinedAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	private void CheckRefinedSimpleType(XmlSchemaSimpleType stype) { }

	private void CheckRefinedComplexType(XmlSchemaComplexType ctype) { }

	private void PreprocessAttribute(XmlSchemaAttribute attribute) { }

	private void PreprocessLocalAttribute(XmlSchemaAttribute attribute) { }

	private void PreprocessAttributeContent(XmlSchemaAttribute attribute) { }

	private void PreprocessAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	private void PreprocessElement(XmlSchemaElement element) { }

	private void PreprocessLocalElement(XmlSchemaElement element) { }

	private void PreprocessElementContent(XmlSchemaElement element) { }

	private void PreprocessIdentityConstraint(XmlSchemaIdentityConstraint constraint) { }

	private void PreprocessSimpleType(XmlSchemaSimpleType simpleType, bool local) { }

	private void PreprocessComplexType(XmlSchemaComplexType complexType, bool local) { }

	private void PreprocessGroup(XmlSchemaGroup group) { }

	private void PreprocessNotation(XmlSchemaNotation notation) { }

	private void PreprocessParticle(XmlSchemaParticle particle) { }

	private void PreprocessAttributes(XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaObject parent) { }

	private void ValidateIdAttribute(XmlSchemaObject xso) { }

	private void ValidateNameAttribute(XmlSchemaObject xso) { }

	private void ValidateQNameAttribute(XmlSchemaObject xso, string attributeName, XmlQualifiedName value) { }

	private void SetParent(XmlSchemaObject child, XmlSchemaObject parent) { }

	private void PreprocessAnnotation(XmlSchemaObject schemaObject) { }

	private Uri ResolveSchemaLocationUri(XmlSchema enclosingSchema, string location) { }

	private Stream GetSchemaEntity(Uri ruri) { }

}

private enum SchemaCollectionPreprocessor.Compositor // TypeDefIndex: 2274
{	public int value__; // 0x0
	public const SchemaCollectionPreprocessor.Compositor Root = 0;
	public const SchemaCollectionPreprocessor.Compositor Include = 1;
	public const SchemaCollectionPreprocessor.Compositor Import = 2;

}

