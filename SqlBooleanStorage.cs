internal sealed class SqlBooleanStorage : DataStorage // TypeDefIndex: 4426
{	// Fields
	private SqlBoolean[] _values; // 0x50

	// Methods

	// RVA: 0x17D5680 Offset: 0x17D4A80 VA: 0x1817D5680
	public void .ctor(DataColumn column) { }

	// RVA: 0x17D49C0 Offset: 0x17D3DC0 VA: 0x1817D49C0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17D4E50 Offset: 0x17D4250 VA: 0x1817D4E50 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17D4DB0 Offset: 0x17D41B0 VA: 0x1817D4DB0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17D5060 Offset: 0x17D4460 VA: 0x1817D5060 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x17D5390 Offset: 0x17D4790 VA: 0x1817D5390 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17D5430 Offset: 0x17D4830 VA: 0x1817D5430 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17D54B0 Offset: 0x17D48B0 VA: 0x1817D54B0 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17D5630 Offset: 0x17D4A30 VA: 0x1817D5630 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17D54F0 Offset: 0x17D48F0 VA: 0x1817D54F0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17D50D0 Offset: 0x17D44D0 VA: 0x1817D50D0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17D4EB0 Offset: 0x17D42B0 VA: 0x1817D4EB0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17D53F0 Offset: 0x17D47F0 VA: 0x1817D53F0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17D5270 Offset: 0x17D4670 VA: 0x1817D5270 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17D55B0 Offset: 0x17D49B0 VA: 0x1817D55B0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

