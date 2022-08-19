internal sealed class TimeSpanStorage : DataStorage // TypeDefIndex: 4432
{	// Fields
	private static readonly TimeSpan s_defaultValue; // 0x0
	private TimeSpan[] _values; // 0x50

	// Methods

	// RVA: 0x123BE70 Offset: 0x123B270 VA: 0x18123BE70
	public void .ctor(DataColumn column) { }

	// RVA: 0x123A6A0 Offset: 0x1239AA0 VA: 0x18123A6A0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x123B350 Offset: 0x123A750 VA: 0x18123B350 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x123B1D0 Offset: 0x123A5D0 VA: 0x18123B1D0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x123B580 Offset: 0x123A980 VA: 0x18123B580
	private static TimeSpan ConvertToTimeSpan(object value) { }

	// RVA: 0x123B780 Offset: 0x123AB80 VA: 0x18123B780 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x123B9A0 Offset: 0x123ADA0 VA: 0x18123B9A0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x123BA60 Offset: 0x123AE60 VA: 0x18123BA60 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x123BCF0 Offset: 0x123B0F0 VA: 0x18123BCF0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x123BB70 Offset: 0x123AF70 VA: 0x18123BB70 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x123B810 Offset: 0x123AC10 VA: 0x18123B810 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x123B500 Offset: 0x123A900 VA: 0x18123B500 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x123BA20 Offset: 0x123AE20 VA: 0x18123BA20 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x123B880 Offset: 0x123AC80 VA: 0x18123B880 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x123BC50 Offset: 0x123B050 VA: 0x18123BC50 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x123BE00 Offset: 0x123B200 VA: 0x18123BE00
	private static void .cctor() { }

}

