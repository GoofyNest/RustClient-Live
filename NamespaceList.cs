internal class NamespaceList // TypeDefIndex: 2262
{	// Fields
	private NamespaceList.ListType type; // 0x10
	private Hashtable set; // 0x18
	private string targetNamespace; // 0x20

	// Properties
	public NamespaceList.ListType Type { get; }
	public string Excluded { get; }
	public ICollection Enumerate { get; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xB0E310 Offset: 0xB0D710 VA: 0x180B0E310
	public void .ctor(string namespaces, string targetNamespace) { }

	// RVA: 0xB0D280 Offset: 0xB0C680 VA: 0x180B0D280
	public NamespaceList Clone() { }

	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	public NamespaceList.ListType get_Type() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public string get_Excluded() { }

	// RVA: 0xB0E5C0 Offset: 0xB0D9C0 VA: 0x180B0E5C0
	public ICollection get_Enumerate() { }

	// RVA: 0xB0D1D0 Offset: 0xB0C5D0 VA: 0x180B0D1D0 Slot: 4
	public virtual bool Allows(string ns) { }

	// RVA: 0xB0D250 Offset: 0xB0C650 VA: 0x180B0D250
	public bool Allows(XmlQualifiedName qname) { }

	// RVA: 0xB0DBE0 Offset: 0xB0CFE0 VA: 0x180B0DBE0 Slot: 3
	public override string ToString() { }

	// RVA: 0xB0D910 Offset: 0xB0CD10 VA: 0x180B0D910
	public static bool IsSubset(NamespaceList sub, NamespaceList super) { }

	// RVA: 0xB0DEF0 Offset: 0xB0D2F0 VA: 0x180B0DEF0
	public static NamespaceList Union(NamespaceList o1, NamespaceList o2, bool v1Compat) { }

	// RVA: 0xB0D3B0 Offset: 0xB0C7B0 VA: 0x180B0D3B0
	private NamespaceList CompareSetToOther(NamespaceList other) { }

	// RVA: 0xB0D500 Offset: 0xB0C900 VA: 0x180B0D500
	public static NamespaceList Intersection(NamespaceList o1, NamespaceList o2, bool v1Compat) { }

	// RVA: 0xB0DB80 Offset: 0xB0CF80 VA: 0x180B0DB80
	private void RemoveNamespace(string tns) { }

}

public enum NamespaceList.ListType // TypeDefIndex: 2263
{	// Fields
	public int value__; // 0x0
	public const NamespaceList.ListType Any = 0;
	public const NamespaceList.ListType Other = 1;
	public const NamespaceList.ListType Set = 2;

}

