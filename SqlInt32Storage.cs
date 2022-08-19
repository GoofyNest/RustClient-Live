internal sealed class SqlInt32Storage : DataStorage // TypeDefIndex: 4421
{	// Fields
	private SqlInt32[] _values; // 0x50

	// Methods

	// RVA: 0x17E68D0 Offset: 0x17E5CD0 VA: 0x1817E68D0
	public void .ctor(DataColumn column) { }

	// RVA: 0x17E5360 Offset: 0x17E4760 VA: 0x1817E5360 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17E6140 Offset: 0x17E5540 VA: 0x1817E6140 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17E6090 Offset: 0x17E5490 VA: 0x1817E6090 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17E6350 Offset: 0x17E5750 VA: 0x1817E6350 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1236E60 Offset: 0x1236260 VA: 0x181236E60 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17E66C0 Offset: 0x17E5AC0 VA: 0x1817E66C0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1236F80 Offset: 0x1236380 VA: 0x181236F80 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17E6880 Offset: 0x17E5C80 VA: 0x1817E6880 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17E6740 Offset: 0x17E5B40 VA: 0x1817E6740 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17E63C0 Offset: 0x17E57C0 VA: 0x1817E63C0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17E61A0 Offset: 0x17E55A0 VA: 0x1817E61A0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17E6680 Offset: 0x17E5A80 VA: 0x1817E6680 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17E6560 Offset: 0x17E5960 VA: 0x1817E6560 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17E6800 Offset: 0x17E5C00 VA: 0x1817E6800 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

