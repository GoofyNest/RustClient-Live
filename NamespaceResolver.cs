internal struct NamespaceResolver // TypeDefIndex: 5839
{	private int scope; // 0x0
	private NamespaceResolver.NamespaceDeclaration declaration; // 0x8
	private NamespaceResolver.NamespaceDeclaration rover; // 0x10


	public void PushScope() { }

	public void PopScope() { }

	public void Add(string prefix, XNamespace ns) { }

	public void AddFirst(string prefix, XNamespace ns) { }

	public string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace) { }

}

private class NamespaceResolver.NamespaceDeclaration // TypeDefIndex: 5840
{	public string prefix; // 0x10
	public XNamespace ns; // 0x18
	public int scope; // 0x20
	public NamespaceResolver.NamespaceDeclaration prev; // 0x28


	public void .ctor() { }

}

