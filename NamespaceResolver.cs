internal struct NamespaceResolver // TypeDefIndex: 5839
{	// Fields
	private int scope; // 0x0
	private NamespaceResolver.NamespaceDeclaration declaration; // 0x8
	private NamespaceResolver.NamespaceDeclaration rover; // 0x10

	// Methods

	// RVA: 0x237570 Offset: 0x236970 VA: 0x180237570
	public void PushScope() { }

	// RVA: 0x237560 Offset: 0x236960 VA: 0x180237560
	public void PopScope() { }

	// RVA: 0x237540 Offset: 0x236940 VA: 0x180237540
	public void Add(string prefix, XNamespace ns) { }

	// RVA: 0x237530 Offset: 0x236930 VA: 0x180237530
	public void AddFirst(string prefix, XNamespace ns) { }

	// RVA: 0x237550 Offset: 0x236950 VA: 0x180237550
	public string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace) { }

}

private class NamespaceResolver.NamespaceDeclaration // TypeDefIndex: 5840
{	// Fields
	public string prefix; // 0x10
	public XNamespace ns; // 0x18
	public int scope; // 0x20
	public NamespaceResolver.NamespaceDeclaration prev; // 0x28

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

