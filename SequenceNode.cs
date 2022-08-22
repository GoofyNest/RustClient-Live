internal sealed class SequenceNode : InteriorNode // TypeDefIndex: 2160
{	public override bool IsNullable { get; }


	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	public override bool get_IsNullable() { }

	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	public void .ctor() { }

}

private struct SequenceNode.SequenceConstructPosContext // TypeDefIndex: 2161
{	public SequenceNode this_; // 0x0
	public BitSet firstpos; // 0x8
	public BitSet lastpos; // 0x10
	public BitSet lastposLeft; // 0x18
	public BitSet firstposRight; // 0x20


	public void .ctor(SequenceNode node, BitSet firstpos, BitSet lastpos) { }

}

