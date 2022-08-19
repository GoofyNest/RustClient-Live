internal class SchemaInfo : IDtdInfo // TypeDefIndex: 2280
{	// Fields
	private Dictionary<XmlQualifiedName, SchemaElementDecl> elementDecls; // 0x10
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

	// Properties
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

	// Methods

	// RVA: 0xEE3260 Offset: 0xEE2660 VA: 0x180EE3260
	internal void .ctor() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public XmlQualifiedName get_DocTypeName() { }

	// RVA: 0x4A2F10 Offset: 0x4A2310 VA: 0x1804A2F10
	public void set_DocTypeName(XmlQualifiedName value) { }

	// RVA: 0x5089D0 Offset: 0x507DD0 VA: 0x1805089D0
	internal void set_InternalDtdSubset(string value) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> get_ElementDecls() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> get_UndeclaredElementDecls() { }

	// RVA: 0xEE33F0 Offset: 0xEE27F0 VA: 0x180EE33F0
	internal Dictionary<XmlQualifiedName, SchemaEntity> get_GeneralEntities() { }

	// RVA: 0xEE34D0 Offset: 0xEE28D0 VA: 0x180EE34D0
	internal Dictionary<XmlQualifiedName, SchemaEntity> get_ParameterEntities() { }

	// RVA: 0x58DC00 Offset: 0x58D000 VA: 0x18058DC00
	internal SchemaType get_SchemaType() { }

	// RVA: 0x58DC90 Offset: 0x58D090 VA: 0x18058DC90
	internal void set_SchemaType(SchemaType value) { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0
	internal Dictionary<string, bool> get_TargetNamespaces() { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> get_ElementDeclsByType() { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	internal Dictionary<XmlQualifiedName, SchemaAttDef> get_AttributeDecls() { }

	// RVA: 0xEE3460 Offset: 0xEE2860 VA: 0x180EE3460
	internal Dictionary<string, SchemaNotation> get_Notations() { }

	// RVA: 0xAE4F70 Offset: 0xAE4370 VA: 0x180AE4F70
	internal int get_ErrorCount() { }

	// RVA: 0xD229D0 Offset: 0xD21DD0 VA: 0x180D229D0
	internal void set_ErrorCount(int value) { }

	// RVA: 0xEE2EF0 Offset: 0xEE22F0 VA: 0x180EE2EF0
	internal SchemaElementDecl GetElementDecl(XmlQualifiedName qname) { }

	// RVA: 0xEE3000 Offset: 0xEE2400 VA: 0x180EE3000
	internal SchemaElementDecl GetTypeDecl(XmlQualifiedName qname) { }

	// RVA: 0xEE2F70 Offset: 0xEE2370 VA: 0x180EE2F70
	internal XmlSchemaElement GetElement(XmlQualifiedName qname) { }

	// RVA: 0xEE3080 Offset: 0xEE2480 VA: 0x180EE3080
	internal bool HasSchema(string ns) { }

	// RVA: 0xEE27C0 Offset: 0xEE1BC0 VA: 0x180EE27C0
	internal bool Contains(string ns) { }

	// RVA: 0xEE29B0 Offset: 0xEE1DB0 VA: 0x180EE29B0
	internal SchemaAttDef GetAttributeXdr(SchemaElementDecl ed, XmlQualifiedName qname) { }

	// RVA: 0xEE2C80 Offset: 0xEE2080 VA: 0x180EE2C80
	internal SchemaAttDef GetAttributeXsd(SchemaElementDecl ed, XmlQualifiedName qname, XmlSchemaObject partialValidationType, out AttributeMatchState attributeMatchState) { }

	// RVA: 0xEE2B30 Offset: 0xEE1F30 VA: 0x180EE2B30
	internal SchemaAttDef GetAttributeXsd(SchemaElementDecl ed, XmlQualifiedName qname, ref bool skip) { }

	// RVA: 0xEE1F40 Offset: 0xEE1340 VA: 0x180EE1F40
	internal void Add(SchemaInfo sinfo, ValidationEventHandler eventhandler) { }

	// RVA: 0xEE2820 Offset: 0xEE1C20 VA: 0x180EE2820
	internal void Finish() { }

	// RVA: 0xEE1D40 Offset: 0xEE1140 VA: 0x180EE1D40 Slot: 6
	private bool System.Xml.IDtdInfo.get_HasDefaultAttributes() { }

	// RVA: 0x7E53F0 Offset: 0x7E47F0 VA: 0x1807E53F0 Slot: 7
	private bool System.Xml.IDtdInfo.get_HasNonCDataAttributes() { }

	// RVA: 0xEE30E0 Offset: 0xEE24E0 VA: 0x180EE30E0 Slot: 8
	private IDtdAttributeListInfo System.Xml.IDtdInfo.LookupAttributeList(string prefix, string localName) { }

	// RVA: 0xEE31A0 Offset: 0xEE25A0 VA: 0x180EE31A0 Slot: 9
	private IDtdEntityInfo System.Xml.IDtdInfo.LookupEntity(string name) { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0 Slot: 4
	private XmlQualifiedName System.Xml.IDtdInfo.get_Name() { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00 Slot: 5
	private string System.Xml.IDtdInfo.get_InternalDtdSubset() { }

}

internal struct SchemaInfo // TypeDefIndex: 4379
{	// Fields
	public string name; // 0x0
	public string typeName; // 0x8
	public Type type; // 0x10

}

