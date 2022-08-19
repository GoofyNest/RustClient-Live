internal sealed class SqlDoubleStorage : DataStorage // TypeDefIndex: 4418
{	// Fields
	private SqlDouble[] _values; // 0x50

	// Methods

	// RVA: 0x17E2F90 Offset: 0x17E2390 VA: 0x1817E2F90
	public void .ctor(DataColumn column) { }

	// RVA: 0x17E19F0 Offset: 0x17E0DF0 VA: 0x1817E19F0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17E2770 Offset: 0x17E1B70 VA: 0x1817E2770 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17E26C0 Offset: 0x17E1AC0 VA: 0x1817E26C0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17E29A0 Offset: 0x17E1DA0 VA: 0x1817E29A0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1235700 Offset: 0x1234B00 VA: 0x181235700 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17E2D70 Offset: 0x17E2170 VA: 0x1817E2D70 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1235830 Offset: 0x1234C30 VA: 0x181235830 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17E2F30 Offset: 0x17E2330 VA: 0x1817E2F30 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17E2DF0 Offset: 0x17E21F0 VA: 0x1817E2DF0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17E2A20 Offset: 0x17E1E20 VA: 0x1817E2A20 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17E27F0 Offset: 0x17E1BF0 VA: 0x1817E27F0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17E2D30 Offset: 0x17E2130 VA: 0x1817E2D30 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17E2BE0 Offset: 0x17E1FE0 VA: 0x1817E2BE0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17E2EB0 Offset: 0x17E22B0 VA: 0x1817E2EB0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

