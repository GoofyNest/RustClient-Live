internal sealed class Int16Storage : DataStorage // TypeDefIndex: 4403
{	// Fields
	private short[] _values; // 0x50

	// Methods

	// RVA: 0x17CBFD0 Offset: 0x17CB3D0 VA: 0x1817CBFD0
	internal void .ctor(DataColumn column) { }

	// RVA: 0x17CB050 Offset: 0x17CA450 VA: 0x1817CB050 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17CB8C0 Offset: 0x17CACC0 VA: 0x1817CB8C0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17CB7B0 Offset: 0x17CABB0 VA: 0x1817CB7B0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17CB9D0 Offset: 0x17CADD0 VA: 0x1817CB9D0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x123CBF0 Offset: 0x123BFF0 VA: 0x18123CBF0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17CBC80 Offset: 0x17CB080 VA: 0x1817CBC80 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17CBEA0 Offset: 0x17CB2A0 VA: 0x1817CBEA0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17CBD20 Offset: 0x17CB120 VA: 0x1817CBD20 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17CBAB0 Offset: 0x17CAEB0 VA: 0x1817CBAB0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17CB950 Offset: 0x17CAD50 VA: 0x1817CB950 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17CBC40 Offset: 0x17CB040 VA: 0x1817CBC40 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17CBB20 Offset: 0x17CAF20 VA: 0x1817CBB20 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17CBE00 Offset: 0x17CB200 VA: 0x1817CBE00 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

