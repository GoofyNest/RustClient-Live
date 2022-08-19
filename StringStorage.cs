internal sealed class StringStorage : DataStorage // TypeDefIndex: 4431
{	// Fields
	private string[] _values; // 0x50

	// Methods

	// RVA: 0x123A5D0 Offset: 0x12399D0 VA: 0x18123A5D0
	public void .ctor(DataColumn column) { }

	// RVA: 0x1239B40 Offset: 0x1238F40 VA: 0x181239B40 Slot: 4
	public override object Aggregate(int[] recordNos, AggregateType kind) { }

	// RVA: 0x1239F70 Offset: 0x1239370 VA: 0x181239F70 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1239E80 Offset: 0x1239280 VA: 0x181239E80 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x123A050 Offset: 0x1239450 VA: 0x18123A050 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x123A210 Offset: 0x1239610 VA: 0x18123A210 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x123A340 Offset: 0x1239740 VA: 0x18123A340 Slot: 9
	public override object Get(int recordNo) { }

	// RVA: 0x123A2F0 Offset: 0x12396F0 VA: 0x18123A2F0 Slot: 10
	public override int GetStringLength(int record) { }

	// RVA: 0x123A380 Offset: 0x1239780 VA: 0x18123A380 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x123A500 Offset: 0x1239900 VA: 0x18123A500 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x123A3C0 Offset: 0x12397C0 VA: 0x18123A3C0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x7B2BE0 Offset: 0x7B1FE0 VA: 0x1807B2BE0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x123A000 Offset: 0x1239400 VA: 0x18123A000 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x123A2B0 Offset: 0x12396B0 VA: 0x18123A2B0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x123A080 Offset: 0x1239480 VA: 0x18123A080 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x123A480 Offset: 0x1239880 VA: 0x18123A480 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

