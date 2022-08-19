internal sealed class SequenceNode : InteriorNode // TypeDefIndex: 2160
{	// Properties
	public override bool IsNullable { get; }

	// Methods

	// RVA: 0xEEA1E0 Offset: 0xEE95E0 VA: 0x180EEA1E0 Slot: 5
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0xEEA690 Offset: 0xEE9A90 VA: 0x180EEA690 Slot: 6
	public override bool get_IsNullable() { }

	// RVA: 0xEEA680 Offset: 0xEE9A80 VA: 0x180EEA680 Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x531100 Offset: 0x530500 VA: 0x180531100
	public void .ctor() { }

}

private struct SequenceNode.SequenceConstructPosContext // TypeDefIndex: 2161
{	// Fields
	public SequenceNode this_; // 0x0
	public BitSet firstpos; // 0x8
	public BitSet lastpos; // 0x10
	public BitSet lastposLeft; // 0x18
	public BitSet firstposRight; // 0x20

	// Methods

	// RVA: 0x13AD70 Offset: 0x13A170 VA: 0x18013AD70
	public void .ctor(SequenceNode node, BitSet firstpos, BitSet lastpos) { }

}

