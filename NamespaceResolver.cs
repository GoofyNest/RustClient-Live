internal struct NamespaceResolver // TypeDefIndex: 5839
{
	private int scope; 
	private NamespaceResolver.NamespaceDeclaration declaration; 
	private NamespaceResolver.NamespaceDeclaration rover; 


	public void PushScope() { }

	public void PopScope() { }

	public void Add(string prefix, XNamespace ns) { }

	public void AddFirst(string prefix, XNamespace ns) { }

	public string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace) { }

}

private class NamespaceResolver.NamespaceDeclaration // TypeDefIndex: 5840
{
	public string prefix; 
	public XNamespace ns; 
	public int scope; 
	public NamespaceResolver.NamespaceDeclaration prev; 


	public void .ctor() { }

}

