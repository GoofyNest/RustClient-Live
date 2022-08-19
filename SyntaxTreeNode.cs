internal abstract class SyntaxTreeNode // TypeDefIndex: 2156
{	// Properties
	public abstract bool IsNullable { get; }
	public virtual bool IsRangeNode { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_IsNullable();

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 7
	public virtual bool get_IsRangeNode() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

