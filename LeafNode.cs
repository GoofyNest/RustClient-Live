internal class LeafNode : SyntaxTreeNode // TypeDefIndex: 2157
{	// Fields
	private int pos; // 0x10

	// Properties
	public int Pos { get; set; }
	public override bool IsNullable { get; }

	// Methods

	// RVA: 0xB0C8A0 Offset: 0xB0BCA0 VA: 0x180B0C8A0
	public void .ctor(int pos) { }

	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	public int get_Pos() { }

	// RVA: 0x596240 Offset: 0x595640 VA: 0x180596240
	public void set_Pos(int value) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0xB0C850 Offset: 0xB0BC50 VA: 0x180B0C850 Slot: 5
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 6
	public override bool get_IsNullable() { }

}

