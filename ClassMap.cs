internal class ClassMap : ObjectMap // TypeDefIndex: 2128
{	private Hashtable _elements; // 0x10
	private ArrayList _elementMembers; // 0x18
	private Hashtable _attributeMembers; // 0x20
	private XmlTypeMapMemberAttribute[] _attributeMembersArray; // 0x28
	private ArrayList _flatLists; // 0x30
	private ArrayList _allMembers; // 0x38
	private ArrayList _membersWithDefault; // 0x40
	private ArrayList _listMembers; // 0x48
	private XmlTypeMapMemberAnyElement _defaultAnyElement; // 0x50
	private XmlTypeMapMemberAnyAttribute _defaultAnyAttribute; // 0x58
	private XmlTypeMapMemberNamespaces _namespaceDeclarations; // 0x60
	private XmlTypeMapMember _xmlTextCollector; // 0x68
	private XmlTypeMapMember _returnMember; // 0x70
	private bool _ignoreMemberNamespace; // 0x78
	private bool _canBeSimpleType; // 0x79
	private Nullable<bool> _isOrderDependentMap; // 0x7A

	public bool IsOrderDependentMap { get; }
	public XmlTypeMapMemberAnyElement DefaultAnyElementMember { get; }
	public XmlTypeMapMemberAnyAttribute DefaultAnyAttributeMember { get; }
	public XmlTypeMapMemberNamespaces NamespaceDeclarations { get; }
	public ICollection AttributeMembers { get; }
	public ICollection ElementMembers { get; }
	public ArrayList AllMembers { get; }
	public ArrayList FlatLists { get; }
	public ArrayList ListMembers { get; }
	public XmlTypeMapMember XmlTextCollector { get; }
	public XmlTypeMapMember ReturnMember { get; }
	public XmlQualifiedName SimpleContentBaseType { get; }
	public bool HasSimpleContent { get; }


	public void AddMember(XmlTypeMapMember member) { }

	private void RegisterFlatList(XmlTypeMapMemberExpandable member) { }

	public XmlTypeMapMemberAttribute GetAttribute(string name, string ns) { }

	public XmlTypeMapElementInfo GetElement(string name, string ns, int minimalOrder) { }

	public XmlTypeMapElementInfo GetElement(string name, string ns) { }

	private string BuildKey(string name, string ns, int explicitOrder) { }

	public bool get_IsOrderDependentMap() { }

	public XmlTypeMapMemberAnyElement get_DefaultAnyElementMember() { }

	public XmlTypeMapMemberAnyAttribute get_DefaultAnyAttributeMember() { }

	public XmlTypeMapMemberNamespaces get_NamespaceDeclarations() { }

	public ICollection get_AttributeMembers() { }

	public ICollection get_ElementMembers() { }

	public ArrayList get_AllMembers() { }

	public ArrayList get_FlatLists() { }

	public ArrayList get_ListMembers() { }

	public XmlTypeMapMember get_XmlTextCollector() { }

	public XmlTypeMapMember get_ReturnMember() { }

	public XmlQualifiedName get_SimpleContentBaseType() { }

	public void SetCanBeSimpleType(bool can) { }

	public bool get_HasSimpleContent() { }

	public void .ctor() { }

}

