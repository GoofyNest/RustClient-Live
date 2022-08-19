internal sealed class Int32Storage : DataStorage // TypeDefIndex: 4404
{	// Fields
	private int[] _values; // 0x50

	// Methods

	// RVA: 0x17CD020 Offset: 0x17CC420 VA: 0x1817CD020
	internal void .ctor(DataColumn column) { }

	// RVA: 0x17CC0B0 Offset: 0x17CB4B0 VA: 0x1817CC0B0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17CC920 Offset: 0x17CBD20 VA: 0x1817CC920 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17CC810 Offset: 0x17CBC10 VA: 0x1817CC810 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x17CCA40 Offset: 0x17CBE40 VA: 0x1817CCA40 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x123DD70 Offset: 0x123D170 VA: 0x18123DD70 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x17CCCE0 Offset: 0x17CC0E0 VA: 0x1817CCCE0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x17CCEF0 Offset: 0x17CC2F0 VA: 0x1817CCEF0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x17CCD70 Offset: 0x17CC170 VA: 0x1817CCD70 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17CCB10 Offset: 0x17CBF10 VA: 0x1817CCB10 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17CC9C0 Offset: 0x17CBDC0 VA: 0x1817CC9C0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17CCCA0 Offset: 0x17CC0A0 VA: 0x1817CCCA0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17CCB80 Offset: 0x17CBF80 VA: 0x1817CCB80 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17CCE50 Offset: 0x17CC250 VA: 0x1817CCE50 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

