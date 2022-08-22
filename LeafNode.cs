internal class LeafNode : SyntaxTreeNode // TypeDefIndex: 2157
{	private int pos; // 0x10

	public int Pos { get; set; }
	public override bool IsNullable { get; }


	public void .ctor(int pos) { }

	public int get_Pos() { }

	public void set_Pos(int value) { }

	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	public override bool get_IsNullable() { }

}

