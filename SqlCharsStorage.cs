internal sealed class SqlCharsStorage : DataStorage // TypeDefIndex: 4415
{	// Fields
	private SqlChars[] _values; // 0x50

	// Methods

	// RVA: 0x17D83B0 Offset: 0x17D77B0 VA: 0x1817D83B0
	public void .ctor(DataColumn column) { }

	// RVA: 0x17D79F0 Offset: 0x17D6DF0 VA: 0x1817D79F0 Slot: 4
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

	// RVA: 0x17D8220 Offset: 0x17D7620 VA: 0x1817D8220 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17D80E0 Offset: 0x17D74E0 VA: 0x1817D80E0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17D7D50 Offset: 0x17D7150 VA: 0x1817D7D50 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17D7BA0 Offset: 0x17D6FA0 VA: 0x1817D7BA0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17D80A0 Offset: 0x17D74A0 VA: 0x1817D80A0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17D7F10 Offset: 0x17D7310 VA: 0x1817D7F10 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17D81A0 Offset: 0x17D75A0 VA: 0x1817D81A0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

