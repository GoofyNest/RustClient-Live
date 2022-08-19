internal sealed class SqlUdtStorage : DataStorage // TypeDefIndex: 4430
{	// Fields
	private object[] _values; // 0x50
	private readonly bool _implementsIXmlSerializable; // 0x58
	private readonly bool _implementsIComparable; // 0x59
	private static readonly Dictionary<Type, object> s_typeToNull; // 0x0

	// Methods

	// RVA: 0x12399A0 Offset: 0x1238DA0 VA: 0x1812399A0
	public void .ctor(DataColumn column, Type type) { }

	// RVA: 0x1239840 Offset: 0x1238C40 VA: 0x181239840
	private void .ctor(DataColumn column, Type type, object nullValue) { }

	// RVA: 0x12390B0 Offset: 0x12384B0 VA: 0x1812390B0
	internal static object GetStaticNullForUdtType(Type type) { }

	// RVA: 0x1239380 Offset: 0x1238780 VA: 0x181239380 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1238440 Offset: 0x1237840 VA: 0x181238440 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x12386A0 Offset: 0x1237AA0 VA: 0x1812386A0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1238490 Offset: 0x1237890 VA: 0x181238490 Slot: 6
	public override int CompareValueTo(int recordNo1, object value) { }

	// RVA: 0x1238FC0 Offset: 0x12383C0 VA: 0x181238FC0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1239340 Offset: 0x1238740 VA: 0x181239340 Slot: 9
	public override object Get(int recordNo) { }

	// RVA: 0x12395A0 Offset: 0x12389A0 VA: 0x1812395A0 Slot: 12
	public override void Set(int recordNo, object value) { }

	// RVA: 0x1239440 Offset: 0x1238840 VA: 0x181239440 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1238A00 Offset: 0x1237E00 VA: 0x181238A00 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1238C20 Offset: 0x1238020 VA: 0x181238C20 Slot: 15
	public override object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x1238800 Offset: 0x1237C00 VA: 0x181238800 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x12386F0 Offset: 0x1237AF0 VA: 0x1812386F0 Slot: 17
	public override void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x1239070 Offset: 0x1238470 VA: 0x181239070 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1238E30 Offset: 0x1238230 VA: 0x181238E30 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1239520 Offset: 0x1238920 VA: 0x181239520 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x12397E0 Offset: 0x1238BE0 VA: 0x1812397E0
	private static void .cctor() { }

}

