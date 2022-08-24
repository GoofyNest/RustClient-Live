internal abstract class SyntaxTreeNode // TypeDefIndex: 2156
{
	public abstract bool IsNullable { get; }
	public virtual bool IsRangeNode { get; }


	public abstract void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions);

	public abstract void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos);

	public abstract bool get_IsNullable();

	public virtual bool get_IsRangeNode() { }

	protected void .ctor() { }

}

