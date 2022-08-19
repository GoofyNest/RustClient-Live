internal sealed class CharStorage : DataStorage // TypeDefIndex: 4368
{	// Fields
	private char[] _values; // 0x50

	// Methods

	// RVA: 0x126E140 Offset: 0x126D540 VA: 0x18126E140
	internal void .ctor(DataColumn column) { }

	// RVA: 0x126D4C0 Offset: 0x126C8C0 VA: 0x18126D4C0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x126D8F0 Offset: 0x126CCF0 VA: 0x18126D8F0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x126D7D0 Offset: 0x126CBD0 VA: 0x18126D7D0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x126DA10 Offset: 0x126CE10 VA: 0x18126DA10 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x126DC80 Offset: 0x126D080 VA: 0x18126DC80 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x126DD60 Offset: 0x126D160 VA: 0x18126DD60 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x126DF90 Offset: 0x126D390 VA: 0x18126DF90 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x126DE10 Offset: 0x126D210 VA: 0x18126DE10 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x126DAF0 Offset: 0x126CEF0 VA: 0x18126DAF0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x126D990 Offset: 0x126CD90 VA: 0x18126D990 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x126DD20 Offset: 0x126D120 VA: 0x18126DD20 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x126DB60 Offset: 0x126CF60 VA: 0x18126DB60 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x126DEF0 Offset: 0x126D2F0 VA: 0x18126DEF0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

