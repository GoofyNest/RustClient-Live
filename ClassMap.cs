internal class ClassMap : ObjectMap // TypeDefIndex: 2128
{
	private Hashtable _elements;
	private ArrayList _elementMembers;
	private Hashtable _attributeMembers;
	private XmlTypeMapMemberAttribute[] _attributeMembersArray;
	private ArrayList _flatLists;
	private ArrayList _allMembers;
	private ArrayList _membersWithDefault;
	private ArrayList _listMembers;
	private XmlTypeMapMemberAnyElement _defaultAnyElement;
	private XmlTypeMapMemberAnyAttribute _defaultAnyAttribute;
	private XmlTypeMapMemberNamespaces _namespaceDeclarations;
	private XmlTypeMapMember _xmlTextCollector;
	private XmlTypeMapMember _returnMember;
	private bool _ignoreMemberNamespace;
	private bool _canBeSimpleType;
	private Nullable<bool> _isOrderDependentMap;

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

