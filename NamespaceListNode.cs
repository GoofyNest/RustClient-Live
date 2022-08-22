internal class NamespaceListNode : SyntaxTreeNode // TypeDefIndex: 2158
{	protected NamespaceList namespaceList; // 0x10
	protected object particle; // 0x18

	public override bool IsNullable { get; }


	public void .ctor(NamespaceList namespaceList, object particle) { }

	public virtual ICollection GetResolvedSymbols(SymbolsDictionary symbols) { }

	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	public override bool get_IsNullable() { }

}

