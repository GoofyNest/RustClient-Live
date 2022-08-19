internal sealed class IntSizedArray : ICloneable // TypeDefIndex: 1120
{	// Fields
	internal int[] objects; // 0x10
	internal int[] negObjects; // 0x18

	// Properties
	internal int Item { get; set; }

	// Methods

	// RVA: 0x11F0650 Offset: 0x11EFA50 VA: 0x1811F0650
	public void .ctor() { }

	// RVA: 0x11F0520 Offset: 0x11EF920 VA: 0x1811F0520
	private void .ctor(IntSizedArray sizedArray) { }

	// RVA: 0x11F01F0 Offset: 0x11EF5F0 VA: 0x1811F01F0 Slot: 4
	public object Clone() { }

	// RVA: 0x11F06D0 Offset: 0x11EFAD0 VA: 0x1811F06D0
	internal int get_Item(int index) { }

	// RVA: 0x11F0750 Offset: 0x11EFB50 VA: 0x1811F0750
	internal void set_Item(int index, int value) { }

	// RVA: 0x11F0350 Offset: 0x11EF750 VA: 0x1811F0350
	internal void IncreaseCapacity(int index) { }

}

