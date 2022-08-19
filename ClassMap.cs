internal class ClassMap : ObjectMap // TypeDefIndex: 2128
{	// Fields
	private Hashtable _elements; // 0x10
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

	// Properties
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

	// Methods

	// RVA: 0x10F8A80 Offset: 0x10F7E80 VA: 0x1810F8A80
	public void AddMember(XmlTypeMapMember member) { }

	// RVA: 0x10F9D10 Offset: 0x10F9110 VA: 0x1810F9D10
	private void RegisterFlatList(XmlTypeMapMemberExpandable member) { }

	// RVA: 0x10F9770 Offset: 0x10F8B70 VA: 0x1810F9770
	public XmlTypeMapMemberAttribute GetAttribute(string name, string ns) { }

	// RVA: 0x10F9A90 Offset: 0x10F8E90 VA: 0x1810F9A90
	public XmlTypeMapElementInfo GetElement(string name, string ns, int minimalOrder) { }

	// RVA: 0x10F9880 Offset: 0x10F8C80 VA: 0x1810F9880
	public XmlTypeMapElementInfo GetElement(string name, string ns) { }

	// RVA: 0x10F96C0 Offset: 0x10F8AC0 VA: 0x1810F96C0
	private string BuildKey(string name, string ns, int explicitOrder) { }

	// RVA: 0x10FA1C0 Offset: 0x10F95C0 VA: 0x1810FA1C0
	public bool get_IsOrderDependentMap() { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	public XmlTypeMapMemberAnyElement get_DefaultAnyElementMember() { }

	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340
	public XmlTypeMapMemberAnyAttribute get_DefaultAnyAttributeMember() { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	public XmlTypeMapMemberNamespaces get_NamespaceDeclarations() { }

	// RVA: 0x10F9E70 Offset: 0x10F9270 VA: 0x1810F9E70
	public ICollection get_AttributeMembers() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public ICollection get_ElementMembers() { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public ArrayList get_AllMembers() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public ArrayList get_FlatLists() { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0
	public ArrayList get_ListMembers() { }

	// RVA: 0x5334F0 Offset: 0x5328F0 VA: 0x1805334F0
	public XmlTypeMapMember get_XmlTextCollector() { }

	// RVA: 0x58DC30 Offset: 0x58D030 VA: 0x18058DC30
	public XmlTypeMapMember get_ReturnMember() { }

	// RVA: 0x10FA420 Offset: 0x10F9820 VA: 0x1810FA420
	public XmlQualifiedName get_SimpleContentBaseType() { }

	// RVA: 0x10F9DD0 Offset: 0x10F91D0 VA: 0x1810F9DD0
	public void SetCanBeSimpleType(bool can) { }

	// RVA: 0x10FA150 Offset: 0x10F9550 VA: 0x1810FA150
	public bool get_HasSimpleContent() { }

	// RVA: 0x10F9DE0 Offset: 0x10F91E0 VA: 0x1810F9DE0
	public void .ctor() { }

}

