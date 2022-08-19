internal sealed class DecimalStorage : DataStorage // TypeDefIndex: 4401
{	// Fields
	private static readonly Decimal s_defaultValue; // 0x0
	private Decimal[] _values; // 0x50

	// Methods

	// RVA: 0x17C9ED0 Offset: 0x17C92D0 VA: 0x1817C9ED0
	internal void .ctor(DataColumn column) { }

	// RVA: 0x17C89F0 Offset: 0x17C7DF0 VA: 0x1817C89F0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17C9510 Offset: 0x17C8910 VA: 0x1817C9510 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17C9360 Offset: 0x17C8760 VA: 0x1817C9360 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17C9770 Offset: 0x17C8B70 VA: 0x1817C9770 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x17C9A10 Offset: 0x17C8E10 VA: 0x1817C9A10 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17C9AE0 Offset: 0x17C8EE0 VA: 0x1817C9AE0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17C9D00 Offset: 0x17C9100 VA: 0x1817C9D00 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17C9B80 Offset: 0x17C8F80 VA: 0x1817C9B80 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17C9850 Offset: 0x17C8C50 VA: 0x1817C9850 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17C96E0 Offset: 0x17C8AE0 VA: 0x1817C96E0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17C9AA0 Offset: 0x17C8EA0 VA: 0x1817C9AA0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17C98D0 Offset: 0x17C8CD0 VA: 0x1817C98D0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17C9C60 Offset: 0x17C9060 VA: 0x1817C9C60 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

