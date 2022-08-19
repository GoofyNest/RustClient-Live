internal sealed class SqlSingleStorage : DataStorage // TypeDefIndex: 4424
{	// Fields
	private SqlSingle[] _values; // 0x50

	// Methods

	// RVA: 0x1237150 Offset: 0x1236550 VA: 0x181237150
	public void .ctor(DataColumn column) { }

	// RVA: 0x1235B60 Offset: 0x1234F60 VA: 0x181235B60 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1236920 Offset: 0x1235D20 VA: 0x181236920 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1236870 Offset: 0x1235C70 VA: 0x181236870 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1236B30 Offset: 0x1235F30 VA: 0x181236B30 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1236E60 Offset: 0x1236260 VA: 0x181236E60 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1236F00 Offset: 0x1236300 VA: 0x181236F00 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1236F80 Offset: 0x1236380 VA: 0x181236F80 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1237100 Offset: 0x1236500 VA: 0x181237100 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1236FC0 Offset: 0x12363C0 VA: 0x181236FC0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1236BA0 Offset: 0x1235FA0 VA: 0x181236BA0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1236980 Offset: 0x1235D80 VA: 0x181236980 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1236EC0 Offset: 0x12362C0 VA: 0x181236EC0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1236D40 Offset: 0x1236140 VA: 0x181236D40 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1237080 Offset: 0x1236480 VA: 0x181237080 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

