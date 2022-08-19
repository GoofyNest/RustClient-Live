internal sealed class Preprocessor : BaseProcessor // TypeDefIndex: 2268
{	// Fields
	private string Xmlns; // 0x40
	private string NsXsi; // 0x48
	private string targetNamespace; // 0x50
	private XmlSchema rootSchema; // 0x58
	private XmlSchema currentSchema; // 0x60
	private XmlSchemaForm elementFormDefault; // 0x68
	private XmlSchemaForm attributeFormDefault; // 0x6C
	private XmlSchemaDerivationMethod blockDefault; // 0x70
	private XmlSchemaDerivationMethod finalDefault; // 0x74
	private Hashtable schemaLocations; // 0x78
	private Hashtable chameleonSchemas; // 0x80
	private Hashtable referenceNamespaces; // 0x88
	private Hashtable processedExternals; // 0x90
	private SortedList lockList; // 0x98
	private XmlReaderSettings readerSettings; // 0xA0
	private XmlSchema rootSchemaForRedefine; // 0xA8
	private ArrayList redefinedList; // 0xB0
	private static XmlSchema builtInSchemaForXmlNS; // 0x0
	private XmlResolver xmlResolver; // 0xB8

	// Properties
	internal XmlResolver XmlResolver { set; }
	internal XmlReaderSettings ReaderSettings { set; }
	internal Hashtable SchemaLocations { set; }
	internal Hashtable ChameleonSchemas { set; }
	internal XmlSchema RootSchema { get; }

	// Methods

	// RVA: 0xB22780 Offset: 0xB21B80 VA: 0x180B22780
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0xB16940 Offset: 0xB15D40 VA: 0x180B16940
	public bool Execute(XmlSchema schema, string targetNamespace, bool loadExternals) { }

	// RVA: 0xB15600 Offset: 0xB14A00 VA: 0x180B15600
	private void Cleanup(XmlSchema schema) { }

	// RVA: 0xB15550 Offset: 0xB14950 VA: 0x180B15550
	private void CleanupRedefine(XmlSchemaExternal include) { }

	// RVA: 0xA2BE10 Offset: 0xA2B210 VA: 0x180A2BE10
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x58DC50 Offset: 0x58D050 VA: 0x18058DC50
	internal void set_ReaderSettings(XmlReaderSettings value) { }

	// RVA: 0x4E51E0 Offset: 0x4E45E0 VA: 0x1804E51E0
	internal void set_SchemaLocations(Hashtable value) { }

	// RVA: 0x58DCD0 Offset: 0x58D0D0 VA: 0x18058DCD0
	internal void set_ChameleonSchemas(Hashtable value) { }

	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340
	internal XmlSchema get_RootSchema() { }

	// RVA: 0xB14B50 Offset: 0xB13F50 VA: 0x180B14B50
	private void BuildSchemaList(XmlSchema schema) { }

	// RVA: 0xB17860 Offset: 0xB16C60 VA: 0x180B17860
	private void LoadExternals(XmlSchema schema) { }

	// RVA: 0xB16F50 Offset: 0xB16350 VA: 0x180B16F50
	internal static XmlSchema GetBuildInSchema() { }

	// RVA: 0xB148A0 Offset: 0xB13CA0 VA: 0x180B148A0
	private void BuildRefNamespaces(XmlSchema schema) { }

	// RVA: 0xB184C0 Offset: 0xB178C0 VA: 0x180B184C0
	private void ParseUri(string uri, string code, XmlSchemaObject sourceSchemaObject) { }

	// RVA: 0xB1FF20 Offset: 0xB1F320 VA: 0x180B1FF20
	private void Preprocess(XmlSchema schema, string targetNamespace, ArrayList imports) { }

	// RVA: 0xB15700 Offset: 0xB14B00 VA: 0x180B15700
	private void CopyIncludedComponents(XmlSchema includedSchema, XmlSchema schema) { }

	// RVA: 0xB1D8D0 Offset: 0xB1CCD0 VA: 0x180B1D8D0
	private void PreprocessRedefine(RedefineEntry redefineEntry) { }

	// RVA: 0xB17630 Offset: 0xB16A30 VA: 0x180B17630
	private void GetIncludedSet(XmlSchema schema, ArrayList includesList) { }

	// RVA: 0xB177A0 Offset: 0xB16BA0 VA: 0x180B177A0
	internal static XmlSchema GetParentSchema(XmlSchemaObject currentSchemaObject) { }

	// RVA: 0xB21DE0 Offset: 0xB211E0 VA: 0x180B21DE0
	private void SetSchemaDefaults(XmlSchema schema) { }

	// RVA: 0xB165E0 Offset: 0xB159E0 VA: 0x180B165E0
	private int CountGroupSelfReference(XmlSchemaObjectCollection items, XmlQualifiedName name, XmlSchemaGroup redefined) { }

	// RVA: 0xB15330 Offset: 0xB14730 VA: 0x180B15330
	private void CheckRefinedGroup(XmlSchemaGroup group) { }

	// RVA: 0xB14D00 Offset: 0xB14100 VA: 0x180B14D00
	private void CheckRefinedAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0xB153D0 Offset: 0xB147D0 VA: 0x180B153D0
	private void CheckRefinedSimpleType(XmlSchemaSimpleType stype) { }

	// RVA: 0xB14E50 Offset: 0xB14250 VA: 0x180B14E50
	private void CheckRefinedComplexType(XmlSchemaComplexType ctype) { }

	// RVA: 0xB18AC0 Offset: 0xB17EC0 VA: 0x180B18AC0
	private void PreprocessAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0xB1B290 Offset: 0xB1A690 VA: 0x180B1B290
	private void PreprocessLocalAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0xB187E0 Offset: 0xB17BE0 VA: 0x180B187E0
	private void PreprocessAttributeContent(XmlSchemaAttribute attribute) { }

	// RVA: 0xB189B0 Offset: 0xB17DB0 VA: 0x180B189B0
	private void PreprocessAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0xB1AB80 Offset: 0xB19F80 VA: 0x180B1AB80
	private void PreprocessElement(XmlSchemaElement element) { }

	// RVA: 0xB1B410 Offset: 0xB1A810 VA: 0x180B1B410
	private void PreprocessLocalElement(XmlSchemaElement element) { }

	// RVA: 0xB1A0B0 Offset: 0xB194B0 VA: 0x180B1A0B0
	private void PreprocessElementContent(XmlSchemaElement element) { }

	// RVA: 0xB1AF30 Offset: 0xB1A330 VA: 0x180B1AF30
	private void PreprocessIdentityConstraint(XmlSchemaIdentityConstraint constraint) { }

	// RVA: 0xB1F590 Offset: 0xB1E990 VA: 0x180B1F590
	private void PreprocessSimpleType(XmlSchemaSimpleType simpleType, bool local) { }

	// RVA: 0xB19710 Offset: 0xB18B10 VA: 0x180B19710
	private void PreprocessComplexType(XmlSchemaComplexType complexType, bool local) { }

	// RVA: 0xB1AD90 Offset: 0xB1A190 VA: 0x180B1AD90
	private void PreprocessGroup(XmlSchemaGroup group) { }

	// RVA: 0xB1B770 Offset: 0xB1AB70 VA: 0x180B1B770
	private void PreprocessNotation(XmlSchemaNotation notation) { }

	// RVA: 0xB1B990 Offset: 0xB1AD90 VA: 0x180B1B990
	private void PreprocessParticle(XmlSchemaParticle particle) { }

	// RVA: 0xB18C00 Offset: 0xB18000 VA: 0x180B18C00
	private void PreprocessAttributes(XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaObject parent) { }

	// RVA: 0xB21ED0 Offset: 0xB212D0 VA: 0x180B21ED0
	private void ValidateIdAttribute(XmlSchemaObject xso) { }

	// RVA: 0xB22140 Offset: 0xB21540 VA: 0x180B22140
	private void ValidateNameAttribute(XmlSchemaObject xso) { }

	// RVA: 0xB22460 Offset: 0xB21860 VA: 0x180B22460
	private void ValidateQNameAttribute(XmlSchemaObject xso, string attributeName, XmlQualifiedName value) { }

	// RVA: 0xB21D60 Offset: 0xB21160 VA: 0x180B21D60
	private Uri ResolveSchemaLocationUri(XmlSchema enclosingSchema, string location) { }

	// RVA: 0xB17820 Offset: 0xB16C20 VA: 0x180B17820
	private object GetSchemaEntity(Uri ruri) { }

	// RVA: 0xB174D0 Offset: 0xB168D0 VA: 0x180B174D0
	private XmlSchema GetChameleonSchema(string targetNamespace, XmlSchema schema) { }

	// RVA: 0xB21DB0 Offset: 0xB211B0 VA: 0x180B21DB0
	private void SetParent(XmlSchemaObject child, XmlSchemaObject parent) { }

	// RVA: 0xB185E0 Offset: 0xB179E0 VA: 0x180B185E0
	private void PreprocessAnnotation(XmlSchemaObject schemaObject) { }

	// RVA: 0xB18750 Offset: 0xB17B50 VA: 0x180B18750
	private void PreprocessAnnotation(XmlSchemaAnnotation annotation) { }

}

