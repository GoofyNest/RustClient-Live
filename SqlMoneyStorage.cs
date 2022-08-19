internal sealed class SqlMoneyStorage : DataStorage // TypeDefIndex: 4423
{	// Fields
	private SqlMoney[] _values; // 0x50

	// Methods

	// RVA: 0x1235A20 Offset: 0x1234E20 VA: 0x181235A20
	public void .ctor(DataColumn column) { }

	// RVA: 0x12342A0 Offset: 0x12336A0 VA: 0x1812342A0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1235140 Offset: 0x1234540 VA: 0x181235140 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1235090 Offset: 0x1234490 VA: 0x181235090 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1235370 Offset: 0x1234770 VA: 0x181235370 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1235700 Offset: 0x1234B00 VA: 0x181235700 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x12357B0 Offset: 0x1234BB0 VA: 0x1812357B0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1235830 Offset: 0x1234C30 VA: 0x181235830 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x12359C0 Offset: 0x1234DC0 VA: 0x1812359C0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1235880 Offset: 0x1234C80 VA: 0x181235880 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x12353F0 Offset: 0x12347F0 VA: 0x1812353F0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x12351C0 Offset: 0x12345C0 VA: 0x1812351C0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1235770 Offset: 0x1234B70 VA: 0x181235770 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x12355B0 Offset: 0x12349B0 VA: 0x1812355B0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1235940 Offset: 0x1234D40 VA: 0x181235940 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

