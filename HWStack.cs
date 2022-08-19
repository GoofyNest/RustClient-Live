internal class HWStack : ICloneable // TypeDefIndex: 1984
{	// Fields
	private object[] stack; // 0x10
	private int growthRate; // 0x18
	private int used; // 0x1C
	private int size; // 0x20
	private int limit; // 0x24

	// Properties
	internal object Item { get; set; }
	internal int Length { get; }

	// Methods

	// RVA: 0x12EB540 Offset: 0x12EA940 VA: 0x1812EB540
	internal void .ctor(int GrowthRate) { }

	// RVA: 0x12EB460 Offset: 0x12EA860 VA: 0x1812EB460
	internal void .ctor(int GrowthRate, int limit) { }

	// RVA: 0x12EB340 Offset: 0x12EA740 VA: 0x1812EB340
	internal object Push() { }

	// RVA: 0x12EB2F0 Offset: 0x12EA6F0 VA: 0x1812EB2F0
	internal object Pop() { }

	// RVA: 0x12EB2A0 Offset: 0x12EA6A0 VA: 0x1812EB2A0
	internal object Peek() { }

	// RVA: 0x12EB110 Offset: 0x12EA510 VA: 0x1812EB110
	internal void AddToTop(object o) { }

	// RVA: 0x12EB5B0 Offset: 0x12EA9B0 VA: 0x1812EB5B0
	internal object get_Item(int index) { }

	// RVA: 0x12EB650 Offset: 0x12EAA50 VA: 0x1812EB650
	internal void set_Item(int index, object value) { }

	// RVA: 0x4BE1F0 Offset: 0x4BD5F0 VA: 0x1804BE1F0
	internal int get_Length() { }

	// RVA: 0x12EB4E0 Offset: 0x12EA8E0 VA: 0x1812EB4E0
	private void .ctor(object[] stack, int growthRate, int used, int size) { }

	// RVA: 0x12EB1A0 Offset: 0x12EA5A0 VA: 0x1812EB1A0 Slot: 4
	public object Clone() { }

}

