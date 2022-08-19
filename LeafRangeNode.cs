internal sealed class LeafRangeNode : LeafNode // TypeDefIndex: 2166
{	// Fields
	private Decimal min; // 0x18
	private Decimal max; // 0x28
	private BitSet nextIteration; // 0x38

	// Properties
	public Decimal Max { get; }
	public Decimal Min { get; }
	public BitSet NextIteration { get; set; }
	public override bool IsRangeNode { get; }

	// Methods

	// RVA: 0xB0C910 Offset: 0xB0BD10 VA: 0x180B0C910
	public void .ctor(Decimal min, Decimal max) { }

	// RVA: 0xB0C960 Offset: 0xB0BD60 VA: 0x180B0C960
	public void .ctor(int pos, Decimal min, Decimal max) { }

	// RVA: 0xB0C9B0 Offset: 0xB0BDB0 VA: 0x180B0C9B0
	public Decimal get_Max() { }

	// RVA: 0xB0C9C0 Offset: 0xB0BDC0 VA: 0x180B0C9C0
	public Decimal get_Min() { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public BitSet get_NextIteration() { }

	// RVA: 0x5089D0 Offset: 0x507DD0 VA: 0x1805089D0
	public void set_NextIteration(BitSet value) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 7
	public override bool get_IsRangeNode() { }

	// RVA: 0xB0C8D0 Offset: 0xB0BCD0 VA: 0x180B0C8D0 Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

}

