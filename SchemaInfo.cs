internal class SchemaInfo : IDtdInfo // TypeDefIndex: 2280
{	private Dictionary<XmlQualifiedName, SchemaElementDecl> elementDecls; // 0x10
	private Dictionary<XmlQualifiedName, SchemaElementDecl> undeclaredElementDecls; // 0x18
	private Dictionary<XmlQualifiedName, SchemaEntity> generalEntities; // 0x20
	private Dictionary<XmlQualifiedName, SchemaEntity> parameterEntities; // 0x28
	private XmlQualifiedName docTypeName; // 0x30
	private string internalDtdSubset; // 0x38
	private bool hasNonCDataAttributes; // 0x40
	private bool hasDefaultAttributes; // 0x41
	private Dictionary<string, bool> targetNamespaces; // 0x48
	private Dictionary<XmlQualifiedName, SchemaAttDef> attributeDecls; // 0x50
	private int errorCount; // 0x58
	private SchemaType schemaType; // 0x5C
	private Dictionary<XmlQualifiedName, SchemaElementDecl> elementDeclsByType; // 0x60
	private Dictionary<string, SchemaNotation> notations; // 0x68

	public XmlQualifiedName DocTypeName { get; set; }
	internal string InternalDtdSubset { set; }
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> ElementDecls { get; }
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> UndeclaredElementDecls { get; }
	internal Dictionary<XmlQualifiedName, SchemaEntity> GeneralEntities { get; }
	internal Dictionary<XmlQualifiedName, SchemaEntity> ParameterEntities { get; }
	internal SchemaType SchemaType { get; set; }
	internal Dictionary<string, bool> TargetNamespaces { get; }
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> ElementDeclsByType { get; }
	internal Dictionary<XmlQualifiedName, SchemaAttDef> AttributeDecls { get; }
	internal Dictionary<string, SchemaNotation> Notations { get; }
	internal int ErrorCount { get; set; }
	private bool System.Xml.IDtdInfo.HasDefaultAttributes { get; }
	private bool System.Xml.IDtdInfo.HasNonCDataAttributes { get; }
	private XmlQualifiedName System.Xml.IDtdInfo.Name { get; }
	private string System.Xml.IDtdInfo.InternalDtdSubset { get; }


	internal void .ctor() { }

	public XmlQualifiedName get_DocTypeName() { }

	public void set_DocTypeName(XmlQualifiedName value) { }

	internal void set_InternalDtdSubset(string value) { }

	internal Dictionary<XmlQualifiedName, SchemaElementDecl> get_ElementDecls() { }

	internal Dictionary<XmlQualifiedName, SchemaElementDecl> get_UndeclaredElementDecls() { }

	internal Dictionary<XmlQualifiedName, SchemaEntity> get_GeneralEntities() { }

	internal Dictionary<XmlQualifiedName, SchemaEntity> get_ParameterEntities() { }

	internal SchemaType get_SchemaType() { }

	internal void set_SchemaType(SchemaType value) { }

	internal Dictionary<string, bool> get_TargetNamespaces() { }

	internal Dictionary<XmlQualifiedName, SchemaElementDecl> get_ElementDeclsByType() { }

	internal Dictionary<XmlQualifiedName, SchemaAttDef> get_AttributeDecls() { }

	internal Dictionary<string, SchemaNotation> get_Notations() { }

	internal int get_ErrorCount() { }

	internal void set_ErrorCount(int value) { }

	internal SchemaElementDecl GetElementDecl(XmlQualifiedName qname) { }

	internal SchemaElementDecl GetTypeDecl(XmlQualifiedName qname) { }

	internal XmlSchemaElement GetElement(XmlQualifiedName qname) { }

	internal bool HasSchema(string ns) { }

	internal bool Contains(string ns) { }

	internal SchemaAttDef GetAttributeXdr(SchemaElementDecl ed, XmlQualifiedName qname) { }

	internal SchemaAttDef GetAttributeXsd(SchemaElementDecl ed, XmlQualifiedName qname, XmlSchemaObject partialValidationType, out AttributeMatchState attributeMatchState) { }

	internal SchemaAttDef GetAttributeXsd(SchemaElementDecl ed, XmlQualifiedName qname, ref bool skip) { }

	internal void Add(SchemaInfo sinfo, ValidationEventHandler eventhandler) { }

	internal void Finish() { }

	private bool System.Xml.IDtdInfo.get_HasDefaultAttributes() { }

	private bool System.Xml.IDtdInfo.get_HasNonCDataAttributes() { }

	private IDtdAttributeListInfo System.Xml.IDtdInfo.LookupAttributeList(string prefix, string localName) { }

	private IDtdEntityInfo System.Xml.IDtdInfo.LookupEntity(string name) { }

	private XmlQualifiedName System.Xml.IDtdInfo.get_Name() { }

	private string System.Xml.IDtdInfo.get_InternalDtdSubset() { }

}

internal struct SchemaInfo // TypeDefIndex: 4379
{	public string name; // 0x0
	public string typeName; // 0x8
	public Type type; // 0x10

}

