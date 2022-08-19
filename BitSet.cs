internal sealed class BitSet // TypeDefIndex: 2141
{	// Fields
	private int count; // 0x10
	private uint[] bits; // 0x18

	// Properties
	public int Count { get; }
	public bool Item { get; }
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	private void .ctor() { }

	// RVA: 0xF41F20 Offset: 0xF41320 VA: 0x180F41F20
	public void .ctor(int count) { }

	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	public int get_Count() { }

	// RVA: 0xF41BE0 Offset: 0xF40FE0 VA: 0x180F41BE0
	public bool get_Item(int index) { }

	// RVA: 0xF41880 Offset: 0xF40C80 VA: 0x180F41880
	public void Clear() { }

	// RVA: 0xF41EA0 Offset: 0xF412A0 VA: 0x180F41EA0
	public void Set(int index) { }

	// RVA: 0xF41BE0 Offset: 0xF40FE0 VA: 0x180F41BE0
	public bool Get(int index) { }

	// RVA: 0xF41D40 Offset: 0xF41140 VA: 0x180F41D40
	public int NextSet(int startFrom) { }

	// RVA: 0xF41790 Offset: 0xF40B90 VA: 0x180F41790
	public void And(BitSet other) { }

	// RVA: 0xF41DF0 Offset: 0xF411F0 VA: 0x180F41DF0
	public void Or(BitSet other) { }

	// RVA: 0xF41BA0 Offset: 0xF40FA0 VA: 0x180F41BA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xF41A30 Offset: 0xF40E30 VA: 0x180F41A30 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xF418E0 Offset: 0xF40CE0 VA: 0x180F418E0
	public BitSet Clone() { }

	// RVA: 0xF41F90 Offset: 0xF41390 VA: 0x180F41F90
	public bool get_IsEmpty() { }

	// RVA: 0xF41C40 Offset: 0xF41040 VA: 0x180F41C40
	public bool Intersects(BitSet other) { }

	// RVA: 0xF41F10 Offset: 0xF41310 VA: 0x180F41F10
	private int Subscript(int bitIndex) { }

	// RVA: 0xF419A0 Offset: 0xF40DA0 VA: 0x180F419A0
	private void EnsureLength(int nRequiredLength) { }

}

