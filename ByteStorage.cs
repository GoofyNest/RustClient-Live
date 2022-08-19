internal sealed class ByteStorage : DataStorage // TypeDefIndex: 4367
{	// Fields
	private byte[] _values; // 0x50

	// Methods

	// RVA: 0x126D3E0 Offset: 0x126C7E0 VA: 0x18126D3E0
	internal void .ctor(DataColumn column) { }

	// RVA: 0x126C3B0 Offset: 0x126B7B0 VA: 0x18126C3B0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x126CC00 Offset: 0x126C000 VA: 0x18126CC00 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x126CAE0 Offset: 0x126BEE0 VA: 0x18126CAE0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x126CD10 Offset: 0x126C110 VA: 0x18126CD10 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x126CF80 Offset: 0x126C380 VA: 0x18126CF80 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x126D060 Offset: 0x126C460 VA: 0x18126D060 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x126D290 Offset: 0x126C690 VA: 0x18126D290 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x126D110 Offset: 0x126C510 VA: 0x18126D110 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x126CDF0 Offset: 0x126C1F0 VA: 0x18126CDF0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x126CC90 Offset: 0x126C090 VA: 0x18126CC90 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x126D020 Offset: 0x126C420 VA: 0x18126D020 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x126CE60 Offset: 0x126C260 VA: 0x18126CE60 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x126D1F0 Offset: 0x126C5F0 VA: 0x18126D1F0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

