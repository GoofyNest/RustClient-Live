internal sealed class ObjectStorage : DataStorage // TypeDefIndex: 4406
{	// Fields
	private static readonly object s_defaultValue; // 0x0
	private object[] _values; // 0x50
	private readonly bool _implementsIXmlSerializable; // 0x58
	private static readonly object s_tempAssemblyCacheLock; // 0x8
	private static Dictionary<KeyValuePair<Type, XmlRootAttribute>, XmlSerializer> s_tempAssemblyCache; // 0x10
	private static readonly XmlSerializerFactory s_serializerFactory; // 0x18

	// Methods

	// RVA: 0x17D1570 Offset: 0x17D0970 VA: 0x1817D1570
	internal void .ctor(DataColumn column, Type type) { }

	// RVA: 0x17CE180 Offset: 0x17CD580 VA: 0x1817CE180 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x17CE900 Offset: 0x17CDD00 VA: 0x1817CE900 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x17CE340 Offset: 0x17CD740 VA: 0x1817CE340 Slot: 6
	public override int CompareValueTo(int recordNo1, object value) { }

	// RVA: 0x17CE1D0 Offset: 0x17CD5D0 VA: 0x1817CE1D0
	private int CompareTo(object valueNo1, object valueNo2) { }

	// RVA: 0x17CE4D0 Offset: 0x17CD8D0 VA: 0x1817CE4D0
	private int CompareWithFamilies(object valueNo1, object valueNo2) { }

	// RVA: 0x123A210 Offset: 0x1239610 VA: 0x18123A210 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x123A340 Offset: 0x1239740 VA: 0x18123A340 Slot: 9
	public override object Get(int recordNo) { }

	// RVA: 0x17CFDD0 Offset: 0x17CF1D0 VA: 0x1817CFDD0
	private ObjectStorage.Families GetFamily(Type dataType) { }

	// RVA: 0x123A380 Offset: 0x1239780 VA: 0x18123A380 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x17D07F0 Offset: 0x17CFBF0 VA: 0x1817D07F0 Slot: 12
	public override void Set(int recordNo, object value) { }

	// RVA: 0x17D0530 Offset: 0x17CF930 VA: 0x1817D0530 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x17CF100 Offset: 0x17CE500 VA: 0x1817CF100 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x17CF4F0 Offset: 0x17CE8F0 VA: 0x1817CF4F0 Slot: 15
	public override object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x17CEB90 Offset: 0x17CDF90 VA: 0x1817CEB90 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x17CEA70 Offset: 0x17CDE70 VA: 0x1817CEA70 Slot: 17
	public override void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x17CFD90 Offset: 0x17CF190 VA: 0x1817CFD90 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x17CFB00 Offset: 0x17CEF00 VA: 0x1817CFB00 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x17D05F0 Offset: 0x17CF9F0 VA: 0x1817D05F0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x17D13A0 Offset: 0x17D07A0 VA: 0x1817D13A0
	internal static void VerifyIDynamicMetaObjectProvider(Type type) { }

	// RVA: 0x17CFF20 Offset: 0x17CF320 VA: 0x1817CFF20
	internal static XmlSerializer GetXmlSerializer(Type type) { }

	// RVA: 0x17CFFA0 Offset: 0x17CF3A0 VA: 0x1817CFFA0
	internal static XmlSerializer GetXmlSerializer(Type type, XmlRootAttribute attribute) { }

	// RVA: 0x17D14C0 Offset: 0x17D08C0 VA: 0x1817D14C0
	private static void .cctor() { }

}

private enum ObjectStorage.Families // TypeDefIndex: 4407
{	// Fields
	public int value__; // 0x0
	public const ObjectStorage.Families DATETIME = 0;
	public const ObjectStorage.Families NUMBER = 1;
	public const ObjectStorage.Families STRING = 2;
	public const ObjectStorage.Families BOOLEAN = 3;
	public const ObjectStorage.Families ARRAY = 4;

}

private class ObjectStorage.TempAssemblyComparer : IEqualityComparer<KeyValuePair<Type, XmlRootAttribute>> // TypeDefIndex: 4408
{	// Fields
	internal static readonly IEqualityComparer<KeyValuePair<Type, XmlRootAttribute>> s_default; // 0x127B0

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	private void .ctor() { }

	// RVA: 0x17E81D0 Offset: 0x17E75D0 VA: 0x1817E81D0 Slot: 4
	public bool Equals(KeyValuePair<Type, XmlRootAttribute> x, KeyValuePair<Type, XmlRootAttribute> y) { }

	// RVA: 0x17E8300 Offset: 0x17E7700 VA: 0x1817E8300 Slot: 5
	public int GetHashCode(KeyValuePair<Type, XmlRootAttribute> obj) { }

	// RVA: 0x17E8380 Offset: 0x17E7780 VA: 0x1817E8380
	private static void .cctor() { }

}

