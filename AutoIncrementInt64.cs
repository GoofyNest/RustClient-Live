internal sealed class AutoIncrementInt64 : AutoIncrementValue // TypeDefIndex: 4183
{	// Fields
	private long _current; // 0x18
	private long _seed; // 0x20
	private long _step; // 0x28

	// Properties
	internal override object Current { get; set; }
	internal override Type DataType { get; }
	internal override long Seed { get; set; }
	internal override long Step { get; set; }

	// Methods

	// RVA: 0x12629D0 Offset: 0x1261DD0 VA: 0x1812629D0 Slot: 4
	internal override object get_Current() { }

	// RVA: 0x1262A80 Offset: 0x1261E80 VA: 0x181262A80 Slot: 5
	internal override void set_Current(object value) { }

	// RVA: 0x1262A20 Offset: 0x1261E20 VA: 0x181262A20 Slot: 10
	internal override Type get_DataType() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00 Slot: 6
	internal override long get_Seed() { }

	// RVA: 0x1262AF0 Offset: 0x1261EF0 VA: 0x181262AF0 Slot: 7
	internal override void set_Seed(long value) { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230 Slot: 8
	internal override long get_Step() { }

	// RVA: 0x1262C30 Offset: 0x1262030 VA: 0x181262C30 Slot: 9
	internal override void set_Step(long value) { }

	// RVA: 0x12627F0 Offset: 0x1261BF0 VA: 0x1812627F0 Slot: 13
	internal override void MoveAfter() { }

	// RVA: 0x1262940 Offset: 0x1261D40 VA: 0x181262940 Slot: 11
	internal override void SetCurrent(object value, IFormatProvider formatProvider) { }

	// RVA: 0x1262800 Offset: 0x1261C00 VA: 0x181262800 Slot: 12
	internal override void SetCurrentAndIncrement(object value) { }

	// RVA: 0x1262710 Offset: 0x1261B10 VA: 0x181262710
	private bool BoundaryCheck(BigInteger value) { }

	// RVA: 0x12629C0 Offset: 0x1261DC0 VA: 0x1812629C0
	public void .ctor() { }

}

