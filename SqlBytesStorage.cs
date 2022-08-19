internal sealed class SqlBytesStorage : DataStorage // TypeDefIndex: 4414
{	// Fields
	private SqlBytes[] _values; // 0x50

	// Methods

	// RVA: 0x17D7900 Offset: 0x17D6D00 VA: 0x1817D7900
	public void .ctor(DataColumn column) { }

	// RVA: 0x17D6F10 Offset: 0x17D6310 VA: 0x1817D6F10 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x123A210 Offset: 0x1239610 VA: 0x18123A210 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1239340 Offset: 0x1238740 VA: 0x181239340 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17D75E0 Offset: 0x17D69E0 VA: 0x1817D75E0 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17D7770 Offset: 0x17D6B70 VA: 0x1817D7770 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17D7630 Offset: 0x17D6A30 VA: 0x1817D7630 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17D7270 Offset: 0x17D6670 VA: 0x1817D7270 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17D70C0 Offset: 0x17D64C0 VA: 0x1817D70C0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17D75A0 Offset: 0x17D69A0 VA: 0x1817D75A0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17D7410 Offset: 0x17D6810 VA: 0x1817D7410 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17D76F0 Offset: 0x17D6AF0 VA: 0x1817D76F0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

