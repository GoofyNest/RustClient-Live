internal sealed class AutoIncrementBigInteger : AutoIncrementValue // TypeDefIndex: 4184
{	// Fields
	private BigInteger _current; // 0x18
	private long _seed; // 0x28
	private BigInteger _step; // 0x30

	// Properties
	internal override object Current { get; set; }
	internal override Type DataType { get; }
	internal override long Seed { get; set; }
	internal override long Step { get; set; }

	// Methods

	// RVA: 0x1262260 Offset: 0x1261660 VA: 0x181262260 Slot: 4
	internal override object get_Current() { }

	// RVA: 0x1262380 Offset: 0x1261780 VA: 0x181262380 Slot: 5
	internal override void set_Current(object value) { }

	// RVA: 0x12622B0 Offset: 0x12616B0 VA: 0x1812622B0 Slot: 10
	internal override Type get_DataType() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230 Slot: 6
	internal override long get_Seed() { }

	// RVA: 0x1262400 Offset: 0x1261800 VA: 0x181262400 Slot: 7
	internal override void set_Seed(long value) { }

	// RVA: 0x1262310 Offset: 0x1261710 VA: 0x181262310 Slot: 8
	internal override long get_Step() { }

	// RVA: 0x1262520 Offset: 0x1261920 VA: 0x181262520 Slot: 9
	internal override void set_Step(long value) { }

	// RVA: 0x1262010 Offset: 0x1261410 VA: 0x181262010 Slot: 13
	internal override void MoveAfter() { }

	// RVA: 0x12621B0 Offset: 0x12615B0 VA: 0x1812621B0 Slot: 11
	internal override void SetCurrent(object value, IFormatProvider formatProvider) { }

	// RVA: 0x12620B0 Offset: 0x12614B0 VA: 0x1812620B0 Slot: 12
	internal override void SetCurrentAndIncrement(object value) { }

	// RVA: 0x1261EB0 Offset: 0x12612B0 VA: 0x181261EB0
	private bool BoundaryCheck(BigInteger value) { }

	// RVA: 0x12621E0 Offset: 0x12615E0 VA: 0x1812621E0
	public void .ctor() { }

}

