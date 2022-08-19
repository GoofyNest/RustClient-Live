internal sealed class Int64Storage : DataStorage // TypeDefIndex: 4405
{	// Fields
	private long[] _values; // 0x50

	// Methods

	// RVA: 0x17CE0A0 Offset: 0x17CD4A0 VA: 0x1817CE0A0
	internal void .ctor(DataColumn column) { }

	// RVA: 0x17CD100 Offset: 0x17CC500 VA: 0x1817CD100 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17CD970 Offset: 0x17CCD70 VA: 0x1817CD970 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17CD860 Offset: 0x17CCC60 VA: 0x1817CD860 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17CDA90 Offset: 0x17CCE90 VA: 0x1817CDA90 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x123EFA0 Offset: 0x123E3A0 VA: 0x18123EFA0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17CDD40 Offset: 0x17CD140 VA: 0x1817CDD40 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17CDF60 Offset: 0x17CD360 VA: 0x1817CDF60 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17CDDE0 Offset: 0x17CD1E0 VA: 0x1817CDDE0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17CDB70 Offset: 0x17CCF70 VA: 0x1817CDB70 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17CDA10 Offset: 0x17CCE10 VA: 0x1817CDA10 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17CDD00 Offset: 0x17CD100 VA: 0x1817CDD00 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17CDBE0 Offset: 0x17CCFE0 VA: 0x1817CDBE0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17CDEC0 Offset: 0x17CD2C0 VA: 0x1817CDEC0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

