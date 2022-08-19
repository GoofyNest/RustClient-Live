internal class NamespaceListNode : SyntaxTreeNode // TypeDefIndex: 2158
{	// Fields
	protected NamespaceList namespaceList; // 0x10
	protected object particle; // 0x18

	// Properties
	public override bool IsNullable { get; }

	// Methods

	// RVA: 0x805420 Offset: 0x804820 VA: 0x180805420
	public void .ctor(NamespaceList namespaceList, object particle) { }

	// RVA: 0xB0D0A0 Offset: 0xB0C4A0 VA: 0x180B0D0A0 Slot: 8
	public virtual ICollection GetResolvedSymbols(SymbolsDictionary symbols) { }

	// RVA: 0xB0CDA0 Offset: 0xB0C1A0 VA: 0x180B0CDA0 Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0xB0CD50 Offset: 0xB0C150 VA: 0x180B0CD50 Slot: 5
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0xB0D0D0 Offset: 0xB0C4D0 VA: 0x180B0D0D0 Slot: 6
	public override bool get_IsNullable() { }

}

