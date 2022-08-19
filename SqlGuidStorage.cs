internal sealed class SqlGuidStorage : DataStorage // TypeDefIndex: 4419
{	// Fields
	private SqlGuid[] _values; // 0x50

	// Methods

	// RVA: 0x17E3B00 Offset: 0x17E2F00 VA: 0x1817E3B00
	public void .ctor(DataColumn column) { }

	// RVA: 0x17E30D0 Offset: 0x17E24D0 VA: 0x1817E30D0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17E3340 Offset: 0x17E2740 VA: 0x1817E3340 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17E3290 Offset: 0x17E2690 VA: 0x1817E3290 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17E3550 Offset: 0x17E2950 VA: 0x1817E3550 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x17D4580 Offset: 0x17D3980 VA: 0x1817D4580 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17E38E0 Offset: 0x17E2CE0 VA: 0x1817E38E0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17D46B0 Offset: 0x17D3AB0 VA: 0x1817D46B0 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17E3AA0 Offset: 0x17E2EA0 VA: 0x1817E3AA0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17E3960 Offset: 0x17E2D60 VA: 0x1817E3960 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17E35C0 Offset: 0x17E29C0 VA: 0x1817E35C0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17E33A0 Offset: 0x17E27A0 VA: 0x1817E33A0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17E38A0 Offset: 0x17E2CA0 VA: 0x1817E38A0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17E3760 Offset: 0x17E2B60 VA: 0x1817E3760 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17E3A20 Offset: 0x17E2E20 VA: 0x1817E3A20 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

