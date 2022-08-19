internal sealed class SqlBinaryStorage : DataStorage // TypeDefIndex: 4412
{	// Fields
	private SqlBinary[] _values; // 0x50

	// Methods

	// RVA: 0x17D4890 Offset: 0x17D3C90 VA: 0x1817D4890
	public void .ctor(DataColumn column) { }

	// RVA: 0x17D3DB0 Offset: 0x17D31B0 VA: 0x1817D3DB0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17D4020 Offset: 0x17D3420 VA: 0x1817D4020 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17D3F70 Offset: 0x17D3370 VA: 0x1817D3F70 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17D4230 Offset: 0x17D3630 VA: 0x1817D4230 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x17D4580 Offset: 0x17D3980 VA: 0x1817D4580 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17D4630 Offset: 0x17D3A30 VA: 0x1817D4630 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17D46B0 Offset: 0x17D3AB0 VA: 0x1817D46B0 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17D4830 Offset: 0x17D3C30 VA: 0x1817D4830 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17D46F0 Offset: 0x17D3AF0 VA: 0x1817D46F0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17D42A0 Offset: 0x17D36A0 VA: 0x1817D42A0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17D4080 Offset: 0x17D3480 VA: 0x1817D4080 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17D45F0 Offset: 0x17D39F0 VA: 0x1817D45F0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17D4440 Offset: 0x17D3840 VA: 0x1817D4440 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17D47B0 Offset: 0x17D3BB0 VA: 0x1817D47B0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

