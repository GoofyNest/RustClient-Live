internal sealed class SqlInt64Storage : DataStorage // TypeDefIndex: 4422
{	// Fields
	private SqlInt64[] _values; // 0x50

	// Methods

	// RVA: 0x17E8090 Offset: 0x17E7490 VA: 0x1817E8090
	public void .ctor(DataColumn column) { }

	// RVA: 0x17E6A00 Offset: 0x17E5E00 VA: 0x1817E6A00 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17E7870 Offset: 0x17E6C70 VA: 0x1817E7870 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17E77C0 Offset: 0x17E6BC0 VA: 0x1817E77C0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17E7AA0 Offset: 0x17E6EA0 VA: 0x1817E7AA0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1235700 Offset: 0x1234B00 VA: 0x181235700 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17E7E70 Offset: 0x17E7270 VA: 0x1817E7E70 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1235830 Offset: 0x1234C30 VA: 0x181235830 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17E8030 Offset: 0x17E7430 VA: 0x1817E8030 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17E7EF0 Offset: 0x17E72F0 VA: 0x1817E7EF0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17E7B20 Offset: 0x17E6F20 VA: 0x1817E7B20 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17E78F0 Offset: 0x17E6CF0 VA: 0x1817E78F0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17E7E30 Offset: 0x17E7230 VA: 0x1817E7E30 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17E7CE0 Offset: 0x17E70E0 VA: 0x1817E7CE0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17E7FB0 Offset: 0x17E73B0 VA: 0x1817E7FB0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

