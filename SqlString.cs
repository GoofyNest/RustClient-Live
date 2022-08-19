public struct SqlString : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4353
{	// Fields
	private string m_value; // 0x0
	private CompareInfo m_cmpInfo; // 0x8
	private int m_lcid; // 0x10
	private SqlCompareOptions m_flag; // 0x14
	private bool m_fNotNull; // 0x18
	public static readonly SqlString Null; // 0x0
	internal static readonly UnicodeEncoding s_unicodeEncoding; // 0x20
	public static readonly int IgnoreCase; // 0x28
	public static readonly int IgnoreWidth; // 0x2C
	public static readonly int IgnoreNonSpace; // 0x30
	public static readonly int IgnoreKanaType; // 0x34
	public static readonly int BinarySort; // 0x38
	public static readonly int BinarySort2; // 0x3C
	private static readonly SqlCompareOptions s_iDefaultFlag; // 0x40
	private static readonly CompareOptions s_iValidCompareOptionMask; // 0x44
	internal static readonly SqlCompareOptions s_iValidSqlCompareOptionMask; // 0x48
	internal static readonly int s_lcidUSEnglish; // 0x4C
	private static readonly int s_lcidBinary; // 0x50

	// Properties
	public bool IsNull { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x11B3B0 Offset: 0x11A7B0 VA: 0x18011B3B0
	private void .ctor(bool fNull) { }

	// RVA: 0x11B3F0 Offset: 0x11A7F0 VA: 0x18011B3F0
	public void .ctor(string data, int lcid, SqlCompareOptions compareOptions) { }

	// RVA: 0x11B3A0 Offset: 0x11A7A0 VA: 0x18011B3A0
	public void .ctor(string data) { }

	// RVA: 0x11B400 Offset: 0x11A800 VA: 0x18011B400
	private void .ctor(int lcid, SqlCompareOptions compareOptions, string data, CompareInfo cmpInfo) { }

	// RVA: 0x11B4D0 Offset: 0x11A8D0 VA: 0x18011B4D0 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x11B4E0 Offset: 0x11A8E0 VA: 0x18011B4E0
	public string get_Value() { }

	// RVA: 0x11B1D0 Offset: 0x11A5D0 VA: 0x18011B1D0
	private void SetCompareInfo() { }

	// RVA: 0xCC5B20 Offset: 0xCC4F20 VA: 0x180CC5B20
	public static SqlString op_Implicit(string x) { }

	// RVA: 0x11B380 Offset: 0x11A780 VA: 0x18011B380 Slot: 3
	public override string ToString() { }

	// RVA: 0xCC5840 Offset: 0xCC4C40 VA: 0x180CC5840
	public static SqlString op_Addition(SqlString x, SqlString y) { }

	// RVA: 0xCC4E60 Offset: 0xCC4260 VA: 0x180CC4E60
	private static int StringCompare(SqlString x, SqlString y) { }

	// RVA: 0xCC4760 Offset: 0xCC3B60 VA: 0x180CC4760
	private static SqlBoolean Compare(SqlString x, SqlString y, EComparison ecExpectedResult) { }

	// RVA: 0xCC59C0 Offset: 0xCC4DC0 VA: 0x180CC59C0
	public static SqlBoolean op_Equality(SqlString x, SqlString y) { }

	// RVA: 0xCC5330 Offset: 0xCC4730 VA: 0x180CC5330
	private static void ValidateSqlCompareOptions(SqlCompareOptions compareOptions) { }

	// RVA: 0xCC45B0 Offset: 0xCC39B0 VA: 0x180CC45B0
	public static CompareOptions CompareOptionsFromSqlCompareOptions(SqlCompareOptions compareOptions) { }

	// RVA: 0x11B1A0 Offset: 0x11A5A0 VA: 0x18011B1A0
	private bool FBinarySort() { }

	// RVA: 0xCC4340 Offset: 0xCC3740 VA: 0x180CC4340
	private static int CompareBinary(SqlString x, SqlString y) { }

	// RVA: 0xCC41D0 Offset: 0xCC35D0 VA: 0x180CC41D0
	private static int CompareBinary2(SqlString x, SqlString y) { }

	// RVA: 0x11B040 Offset: 0x11A440 VA: 0x18011B040 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x11B160 Offset: 0x11A560 VA: 0x18011B160
	public int CompareTo(SqlString value) { }

	// RVA: 0x11B190 Offset: 0x11A590 VA: 0x18011B190 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x11B1C0 Offset: 0x11A5C0 VA: 0x18011B1C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x117C10 Offset: 0x117010 VA: 0x180117C10 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x11B1E0 Offset: 0x11A5E0 VA: 0x18011B1E0 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x11B2E0 Offset: 0x11A6E0 VA: 0x18011B2E0 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xCC4D60 Offset: 0xCC4160 VA: 0x180CC4D60
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xCC53D0 Offset: 0xCC47D0 VA: 0x180CC53D0
	private static void .cctor() { }

}

