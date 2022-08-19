internal class CircularByteBuffer // TypeDefIndex: 7386
{	// Fields
	private byte[] _DataArray; // 0x10
	private int _Index; // 0x18
	private int _Length; // 0x1C
	private int _NumValid; // 0x20

	// Properties
	internal byte Item { get; }
	internal int NumValid { get; }

	// Methods

	// RVA: 0x5F6160 Offset: 0x5F5560 VA: 0x1805F6160
	internal void .ctor(int size) { }

	// RVA: 0x5F61C0 Offset: 0x5F55C0 VA: 0x1805F61C0
	internal byte get_Item(int index) { }

	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170
	internal int get_NumValid() { }

	// RVA: 0x5F5D20 Offset: 0x5F5120 VA: 0x1805F5D20
	internal byte Push(byte newValue) { }

	// RVA: 0x5F5CC0 Offset: 0x5F50C0 VA: 0x1805F5CC0
	private byte InternalGet(int offset) { }

	// RVA: 0x5F5E70 Offset: 0x5F5270 VA: 0x1805F5E70 Slot: 3
	public override string ToString() { }

}

