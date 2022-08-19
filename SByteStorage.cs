internal sealed class SByteStorage : DataStorage // TypeDefIndex: 4410
{	// Fields
	private sbyte[] _values; // 0x50

	// Methods

	// RVA: 0x17D27D0 Offset: 0x17D1BD0 VA: 0x1817D27D0
	public void .ctor(DataColumn column) { }

	// RVA: 0x17D17A0 Offset: 0x17D0BA0 VA: 0x1817D17A0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17D2000 Offset: 0x17D1400 VA: 0x1817D2000 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17D1EE0 Offset: 0x17D12E0 VA: 0x1817D1EE0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17D2150 Offset: 0x17D1550 VA: 0x1817D2150 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x17D23B0 Offset: 0x17D17B0 VA: 0x1817D23B0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17D2470 Offset: 0x17D1870 VA: 0x1817D2470 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17D26A0 Offset: 0x17D1AA0 VA: 0x1817D26A0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17D2520 Offset: 0x17D1920 VA: 0x1817D2520 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17D2220 Offset: 0x17D1620 VA: 0x1817D2220 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17D20D0 Offset: 0x17D14D0 VA: 0x1817D20D0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17D2430 Offset: 0x17D1830 VA: 0x1817D2430 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17D2290 Offset: 0x17D1690 VA: 0x1817D2290 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17D2600 Offset: 0x17D1A00 VA: 0x1817D2600 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

