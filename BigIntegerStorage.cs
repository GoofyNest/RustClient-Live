internal sealed class BigIntegerStorage : DataStorage // TypeDefIndex: 4365
{	// Fields
	private BigInteger[] _values; // 0x50

	// Methods

	// RVA: 0x12647B0 Offset: 0x1263BB0 VA: 0x1812647B0
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1262E30 Offset: 0x1262230 VA: 0x181262E30 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1262FC0 Offset: 0x12623C0 VA: 0x181262FC0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1262E80 Offset: 0x1262280 VA: 0x181262E80 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x12638A0 Offset: 0x1262CA0 VA: 0x1812638A0
	internal static BigInteger ConvertToBigInteger(object value, IFormatProvider formatProvider) { }

	// RVA: 0x12630B0 Offset: 0x12624B0 VA: 0x1812630B0
	internal static object ConvertFromBigInteger(BigInteger value, Type type, IFormatProvider formatProvider) { }

	// RVA: 0x1263FF0 Offset: 0x12633F0 VA: 0x181263FF0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1264290 Offset: 0x1263690 VA: 0x181264290 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x12643A0 Offset: 0x12637A0 VA: 0x1812643A0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1264600 Offset: 0x1263A00 VA: 0x181264600 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1264480 Offset: 0x1263880 VA: 0x181264480 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1264080 Offset: 0x1263480 VA: 0x181264080 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1263800 Offset: 0x1262C00 VA: 0x181263800 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1264360 Offset: 0x1263760 VA: 0x181264360 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1264130 Offset: 0x1263530 VA: 0x181264130 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1264560 Offset: 0x1263960 VA: 0x181264560 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

