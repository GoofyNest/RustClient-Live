internal sealed class SqlDateTimeStorage : DataStorage // TypeDefIndex: 4416
{	// Fields
	private SqlDateTime[] _values; // 0x50

	// Methods

	// RVA: 0x17DFFD0 Offset: 0x17DF3D0 VA: 0x1817DFFD0
	public void .ctor(DataColumn column) { }

	// RVA: 0x17DF090 Offset: 0x17DE490 VA: 0x1817DF090 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17DF6D0 Offset: 0x17DEAD0 VA: 0x1817DF6D0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17DF610 Offset: 0x17DEA10 VA: 0x1817DF610 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17DF900 Offset: 0x17DED00 VA: 0x1817DF900 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x17DFC90 Offset: 0x17DF090 VA: 0x1817DFC90 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17DFD40 Offset: 0x17DF140 VA: 0x1817DFD40 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17DFDD0 Offset: 0x17DF1D0 VA: 0x1817DFDD0 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17DFF60 Offset: 0x17DF360 VA: 0x1817DFF60 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17DFE20 Offset: 0x17DF220 VA: 0x1817DFE20 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17DF980 Offset: 0x17DED80 VA: 0x1817DF980 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17DF750 Offset: 0x17DEB50 VA: 0x1817DF750 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17DFD00 Offset: 0x17DF100 VA: 0x1817DFD00 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17DFB40 Offset: 0x17DEF40 VA: 0x1817DFB40 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17DFEE0 Offset: 0x17DF2E0 VA: 0x1817DFEE0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

