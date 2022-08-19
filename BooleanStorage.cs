internal sealed class BooleanStorage : DataStorage // TypeDefIndex: 4366
{	// Fields
	private bool[] _values; // 0x50

	// Methods

	// RVA: 0x126C2D0 Offset: 0x126B6D0 VA: 0x18126C2D0
	internal void .ctor(DataColumn column) { }

	// RVA: 0x126B690 Offset: 0x126AA90 VA: 0x18126B690 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x126BAB0 Offset: 0x126AEB0 VA: 0x18126BAB0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x126B990 Offset: 0x126AD90 VA: 0x18126B990 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x126BBD0 Offset: 0x126AFD0 VA: 0x18126BBD0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x126BE50 Offset: 0x126B250 VA: 0x18126BE50 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x126BF40 Offset: 0x126B340 VA: 0x18126BF40 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x126C180 Offset: 0x126B580 VA: 0x18126C180 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x126C000 Offset: 0x126B400 VA: 0x18126C000 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x126BCB0 Offset: 0x126B0B0 VA: 0x18126BCB0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x126BB50 Offset: 0x126AF50 VA: 0x18126BB50 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x126BF00 Offset: 0x126B300 VA: 0x18126BF00 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x126BD20 Offset: 0x126B120 VA: 0x18126BD20 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x126C0E0 Offset: 0x126B4E0 VA: 0x18126C0E0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

