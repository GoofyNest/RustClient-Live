internal sealed class SqlByteStorage : DataStorage // TypeDefIndex: 4413
{	// Fields
	private SqlByte[] _values; // 0x50

	// Methods

	// RVA: 0x17D6DE0 Offset: 0x17D61E0 VA: 0x1817D6DE0
	public void .ctor(DataColumn column) { }

	// RVA: 0x17D57B0 Offset: 0x17D4BB0 VA: 0x1817D57B0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17D65A0 Offset: 0x17D59A0 VA: 0x1817D65A0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17D64F0 Offset: 0x17D58F0 VA: 0x1817D64F0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17D67B0 Offset: 0x17D5BB0 VA: 0x1817D67B0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x17D6AF0 Offset: 0x17D5EF0 VA: 0x1817D6AF0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17D6B90 Offset: 0x17D5F90 VA: 0x1817D6B90 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17D6C10 Offset: 0x17D6010 VA: 0x1817D6C10 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17D6D90 Offset: 0x17D6190 VA: 0x1817D6D90 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17D6C50 Offset: 0x17D6050 VA: 0x1817D6C50 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17D6820 Offset: 0x17D5C20 VA: 0x1817D6820 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17D6600 Offset: 0x17D5A00 VA: 0x1817D6600 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17D6B50 Offset: 0x17D5F50 VA: 0x1817D6B50 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17D69C0 Offset: 0x17D5DC0 VA: 0x1817D69C0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17D6D10 Offset: 0x17D6110 VA: 0x1817D6D10 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

