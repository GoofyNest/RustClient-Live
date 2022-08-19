internal sealed class DoubleStorage : DataStorage // TypeDefIndex: 4402
{	// Fields
	private double[] _values; // 0x50

	// Methods

	// RVA: 0x17CAF70 Offset: 0x17CA370 VA: 0x1817CAF70
	internal void .ctor(DataColumn column) { }

	// RVA: 0x17C9FC0 Offset: 0x17C93C0 VA: 0x1817C9FC0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17CA7A0 Offset: 0x17C9BA0 VA: 0x1817CA7A0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17CA670 Offset: 0x17C9A70 VA: 0x1817CA670 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17CA8C0 Offset: 0x17C9CC0 VA: 0x1817CA8C0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x17CAB50 Offset: 0x17C9F50 VA: 0x1817CAB50 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17CAC10 Offset: 0x17CA010 VA: 0x1817CAC10 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17CAE30 Offset: 0x17CA230 VA: 0x1817CAE30 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17CACB0 Offset: 0x17CA0B0 VA: 0x1817CACB0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17CA9A0 Offset: 0x17C9DA0 VA: 0x1817CA9A0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17CA840 Offset: 0x17C9C40 VA: 0x1817CA840 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17CABD0 Offset: 0x17C9FD0 VA: 0x1817CABD0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17CAA10 Offset: 0x17C9E10 VA: 0x1817CAA10 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17CAD90 Offset: 0x17CA190 VA: 0x1817CAD90 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

