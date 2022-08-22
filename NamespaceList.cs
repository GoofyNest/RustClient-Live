internal class NamespaceList // TypeDefIndex: 2262
{	private NamespaceList.ListType type; // 0x10
	private Hashtable set; // 0x18
	private string targetNamespace; // 0x20

	public NamespaceList.ListType Type { get; }
	public string Excluded { get; }
	public ICollection Enumerate { get; }


	public void .ctor() { }

	public void .ctor(string namespaces, string targetNamespace) { }

	public NamespaceList Clone() { }

	public NamespaceList.ListType get_Type() { }

	public string get_Excluded() { }

	public ICollection get_Enumerate() { }

	public virtual bool Allows(string ns) { }

	public bool Allows(XmlQualifiedName qname) { }

	public override string ToString() { }

	public static bool IsSubset(NamespaceList sub, NamespaceList super) { }

	public static NamespaceList Union(NamespaceList o1, NamespaceList o2, bool v1Compat) { }

	private NamespaceList CompareSetToOther(NamespaceList other) { }

	public static NamespaceList Intersection(NamespaceList o1, NamespaceList o2, bool v1Compat) { }

	private void RemoveNamespace(string tns) { }

}

public enum NamespaceList.ListType // TypeDefIndex: 2263
{	public int value__; // 0x0
	public const NamespaceList.ListType Any = 0;
	public const NamespaceList.ListType Other = 1;
	public const NamespaceList.ListType Set = 2;

}

