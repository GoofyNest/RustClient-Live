internal sealed class SqlStringStorage : DataStorage // TypeDefIndex: 4425
{	// Fields
	private SqlString[] _values; // 0x50

	// Methods

	// RVA: 0x12382E0 Offset: 0x12376E0 VA: 0x1812382E0
	public void .ctor(DataColumn column) { }

	// RVA: 0x1237280 Offset: 0x1236680 VA: 0x181237280 Slot: 4
	public override object Aggregate(int[] recordNos, AggregateType kind) { }

	// RVA: 0x12377A0 Offset: 0x1236BA0 VA: 0x1812377A0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x12378E0 Offset: 0x1236CE0 VA: 0x1812378E0
	public int Compare(SqlString valueNo1, SqlString valueNo2) { }

	// RVA: 0x1237600 Offset: 0x1236A00 VA: 0x181237600 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1237B70 Offset: 0x1236F70 VA: 0x181237B70 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1237F20 Offset: 0x1237320 VA: 0x181237F20 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1238060 Offset: 0x1237460 VA: 0x181238060 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1237FE0 Offset: 0x12373E0 VA: 0x181237FE0 Slot: 10
	public override int GetStringLength(int record) { }

	// RVA: 0x12380F0 Offset: 0x12374F0 VA: 0x1812380F0 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1238270 Offset: 0x1237670 VA: 0x181238270 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1238130 Offset: 0x1237530 VA: 0x181238130 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1237BF0 Offset: 0x1236FF0 VA: 0x181237BF0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x12379C0 Offset: 0x1236DC0 VA: 0x1812379C0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1237FA0 Offset: 0x12373A0 VA: 0x181237FA0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1237DB0 Offset: 0x12371B0 VA: 0x181237DB0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x12381F0 Offset: 0x12375F0 VA: 0x1812381F0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

