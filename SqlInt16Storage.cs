internal sealed class SqlInt16Storage : DataStorage // TypeDefIndex: 4420
{	// Fields
	private SqlInt16[] _values; // 0x50

	// Methods

	// RVA: 0x17E5230 Offset: 0x17E4630 VA: 0x1817E5230
	public void .ctor(DataColumn column) { }

	// RVA: 0x17E3C30 Offset: 0x17E3030 VA: 0x1817E3C30 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17E4A10 Offset: 0x17E3E10 VA: 0x1817E4A10 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17E4960 Offset: 0x17E3D60 VA: 0x1817E4960 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17E4C20 Offset: 0x17E4020 VA: 0x1817E4C20 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x17E4F40 Offset: 0x17E4340 VA: 0x1817E4F40 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17E4FE0 Offset: 0x17E43E0 VA: 0x1817E4FE0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17E5060 Offset: 0x17E4460 VA: 0x1817E5060 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17E51E0 Offset: 0x17E45E0 VA: 0x1817E51E0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17E50A0 Offset: 0x17E44A0 VA: 0x1817E50A0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17E4C90 Offset: 0x17E4090 VA: 0x1817E4C90 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17E4A70 Offset: 0x17E3E70 VA: 0x1817E4A70 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17E4FA0 Offset: 0x17E43A0 VA: 0x1817E4FA0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17E4E20 Offset: 0x17E4220 VA: 0x1817E4E20 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17E5160 Offset: 0x17E4560 VA: 0x1817E5160 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

