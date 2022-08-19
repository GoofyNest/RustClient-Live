internal sealed class SingleStorage : DataStorage // TypeDefIndex: 4429
{	// Fields
	private float[] _values; // 0x50

	// Methods

	// RVA: 0x17D3CD0 Offset: 0x17D30D0 VA: 0x1817D3CD0
	public void .ctor(DataColumn column) { }

	// RVA: 0x17D2CF0 Offset: 0x17D20F0 VA: 0x1817D2CF0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17D3500 Offset: 0x17D2900 VA: 0x1817D3500 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17D33D0 Offset: 0x17D27D0 VA: 0x1817D33D0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17D3620 Offset: 0x17D2A20 VA: 0x1817D3620 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x17D38B0 Offset: 0x17D2CB0 VA: 0x1817D38B0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17D3970 Offset: 0x17D2D70 VA: 0x1817D3970 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17D3B90 Offset: 0x17D2F90 VA: 0x1817D3B90 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17D3A10 Offset: 0x17D2E10 VA: 0x1817D3A10 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17D3700 Offset: 0x17D2B00 VA: 0x1817D3700 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17D35A0 Offset: 0x17D29A0 VA: 0x1817D35A0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17D3930 Offset: 0x17D2D30 VA: 0x1817D3930 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17D3770 Offset: 0x17D2B70 VA: 0x1817D3770 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17D3AF0 Offset: 0x17D2EF0 VA: 0x1817D3AF0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

