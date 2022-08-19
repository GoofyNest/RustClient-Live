internal sealed class SqlDecimalStorage : DataStorage // TypeDefIndex: 4417
{	// Fields
	private SqlDecimal[] _values; // 0x50

	// Methods

	// RVA: 0x17E1890 Offset: 0x17E0C90 VA: 0x1817E1890
	public void .ctor(DataColumn column) { }

	// RVA: 0x17E0130 Offset: 0x17DF530 VA: 0x1817E0130 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17E0F90 Offset: 0x17E0390 VA: 0x1817E0F90 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17E0ED0 Offset: 0x17E02D0 VA: 0x1817E0ED0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17E11C0 Offset: 0x17E05C0 VA: 0x1817E11C0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x17E1550 Offset: 0x17E0950 VA: 0x1817E1550 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17E1600 Offset: 0x17E0A00 VA: 0x1817E1600 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17E1690 Offset: 0x17E0A90 VA: 0x1817E1690 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17E1820 Offset: 0x17E0C20 VA: 0x1817E1820 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17E16E0 Offset: 0x17E0AE0 VA: 0x1817E16E0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17E1240 Offset: 0x17E0640 VA: 0x1817E1240 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17E1010 Offset: 0x17E0410 VA: 0x1817E1010 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17E15C0 Offset: 0x17E09C0 VA: 0x1817E15C0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17E1400 Offset: 0x17E0800 VA: 0x1817E1400 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17E17A0 Offset: 0x17E0BA0 VA: 0x1817E17A0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

