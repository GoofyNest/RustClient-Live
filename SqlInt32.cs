public struct SqlInt32 : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4348
{	// Fields
	private bool m_fNotNull; // 0x0
	private int m_value; // 0x4
	private static readonly long s_iIntMin; // 0x0
	private static readonly long s_lBitNotIntMax; // 0x8
	public static readonly SqlInt32 Null; // 0x10
	public static readonly SqlInt32 Zero; // 0x18
	public static readonly SqlInt32 MinValue; // 0x20
	public static readonly SqlInt32 MaxValue; // 0x28

	// Properties
	public bool IsNull { get; }
	public int Value { get; }

	// Methods

	// RVA: 0x119720 Offset: 0x118B20 VA: 0x180119720
	private void .ctor(bool fNull) { }

	// RVA: 0x119730 Offset: 0x118B30 VA: 0x180119730
	public void .ctor(int value) { }

	// RVA: 0x117FE0 Offset: 0x1173E0 VA: 0x180117FE0 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x119740 Offset: 0x118B40 VA: 0x180119740
	public int get_Value() { }

	// RVA: 0xCBED30 Offset: 0xCBE130 VA: 0x180CBED30
	public static SqlInt32 op_Implicit(int x) { }

	// RVA: 0x119700 Offset: 0x118B00 VA: 0x180119700 Slot: 3
	public override string ToString() { }

	// RVA: 0xCBF0A0 Offset: 0xCBE4A0 VA: 0x180CBF0A0
	public static SqlInt32 op_UnaryNegation(SqlInt32 x) { }

	// RVA: 0xCBE6F0 Offset: 0xCBDAF0 VA: 0x180CBE6F0
	public static SqlInt32 op_Addition(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xCBEF50 Offset: 0xCBE350 VA: 0x180CBEF50
	public static SqlInt32 op_Subtraction(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xCBEE00 Offset: 0xCBE200 VA: 0x180CBEE00
	public static SqlInt32 op_Multiply(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xCBE840 Offset: 0xCBDC40 VA: 0x180CBE840
	public static SqlInt32 op_Division(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xCBEBF0 Offset: 0xCBDFF0 VA: 0x180CBEBF0
	public static SqlInt32 op_Implicit(SqlByte x) { }

	// RVA: 0xCBEC90 Offset: 0xCBE090 VA: 0x180CBEC90
	public static SqlInt32 op_Implicit(SqlInt16 x) { }

	// RVA: 0xCBEA50 Offset: 0xCBDE50 VA: 0x180CBEA50
	public static SqlInt32 op_Explicit(SqlInt64 x) { }

	// RVA: 0xCBE330 Offset: 0xCBD730 VA: 0x180CBE330
	private static bool SameSignInt(int x, int y) { }

	// RVA: 0xCBE9A0 Offset: 0xCBDDA0 VA: 0x180CBE9A0
	public static SqlBoolean op_Equality(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xCBED50 Offset: 0xCBE150 VA: 0x180CBED50
	public static SqlBoolean op_LessThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xCBEB40 Offset: 0xCBDF40 VA: 0x180CBEB40
	public static SqlBoolean op_GreaterThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xCBE2C0 Offset: 0xCBD6C0 VA: 0x180CBE2C0
	public static SqlBoolean LessThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xCBE250 Offset: 0xCBD650 VA: 0x180CBE250
	public static SqlBoolean GreaterThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x1194B0 Offset: 0x1188B0 VA: 0x1801194B0
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x1195C0 Offset: 0x1189C0 VA: 0x1801195C0
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0x118FC0 Offset: 0x1183C0 VA: 0x180118FC0 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1190C0 Offset: 0x1184C0 VA: 0x1801190C0
	public int CompareTo(SqlInt32 value) { }

	// RVA: 0x1190D0 Offset: 0x1184D0 VA: 0x1801190D0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x119250 Offset: 0x118650 VA: 0x180119250 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x117C10 Offset: 0x117010 VA: 0x180117C10 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1192D0 Offset: 0x1186D0 VA: 0x1801192D0 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1193E0 Offset: 0x1187E0 VA: 0x1801193E0 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xCBE1F0 Offset: 0xCBD5F0 VA: 0x180CBE1F0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xCBE5A0 Offset: 0xCBD9A0 VA: 0x180CBE5A0
	private static void .cctor() { }

}

