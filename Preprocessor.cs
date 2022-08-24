internal sealed class Preprocessor : BaseProcessor // TypeDefIndex: 2268
{
	private string Xmlns; 
	private string NsXsi; 
	private string targetNamespace; 
	private XmlSchema rootSchema; 
	private XmlSchema currentSchema; 
	private XmlSchemaForm elementFormDefault; 
	private XmlSchemaForm attributeFormDefault; 
	private XmlSchemaDerivationMethod blockDefault; 
	private XmlSchemaDerivationMethod finalDefault; 
	private Hashtable schemaLocations; 
	private Hashtable chameleonSchemas; 
	private Hashtable referenceNamespaces; 
	private Hashtable processedExternals; 
	private SortedList lockList; 
	private XmlReaderSettings readerSettings; 
	private XmlSchema rootSchemaForRedefine; 
	private ArrayList redefinedList; 
	private static XmlSchema builtInSchemaForXmlNS; 
	private XmlResolver xmlResolver; 

	internal XmlResolver XmlResolver { set; }
	internal XmlReaderSettings ReaderSettings { set; }
	internal Hashtable SchemaLocations { set; }
	internal Hashtable ChameleonSchemas { set; }
	internal XmlSchema RootSchema { get; }


	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	public bool Execute(XmlSchema schema, string targetNamespace, bool loadExternals) { }

	private void Cleanup(XmlSchema schema) { }

	private void CleanupRedefine(XmlSchemaExternal include) { }

	internal void set_XmlResolver(XmlResolver value) { }

	internal void set_ReaderSettings(XmlReaderSettings value) { }

	internal void set_SchemaLocations(Hashtable value) { }

	internal void set_ChameleonSchemas(Hashtable value) { }

	internal XmlSchema get_RootSchema() { }

	private void BuildSchemaList(XmlSchema schema) { }

	private void LoadExternals(XmlSchema schema) { }

	internal static XmlSchema GetBuildInSchema() { }

	private void BuildRefNamespaces(XmlSchema schema) { }

	private void ParseUri(string uri, string code, XmlSchemaObject sourceSchemaObject) { }

	private void Preprocess(XmlSchema schema, string targetNamespace, ArrayList imports) { }

	private void CopyIncludedComponents(XmlSchema includedSchema, XmlSchema schema) { }

	private void PreprocessRedefine(RedefineEntry redefineEntry) { }

	private void GetIncludedSet(XmlSchema schema, ArrayList includesList) { }

	internal static XmlSchema GetParentSchema(XmlSchemaObject currentSchemaObject) { }

	private void SetSchemaDefaults(XmlSchema schema) { }

	private int CountGroupSelfReference(XmlSchemaObjectCollection items, XmlQualifiedName name, XmlSchemaGroup redefined) { }

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

	private Uri ResolveSchemaLocationUri(XmlSchema enclosingSchema, string location) { }

	private object GetSchemaEntity(Uri ruri) { }

	private XmlSchema GetChameleonSchema(string targetNamespace, XmlSchema schema) { }

	private void SetParent(XmlSchemaObject child, XmlSchemaObject parent) { }

	private void PreprocessAnnotation(XmlSchemaObject schemaObject) { }

	private void PreprocessAnnotation(XmlSchemaAnnotation annotation) { }

}

