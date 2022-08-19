public struct SqlInt64 : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4349
{	// Fields
	private bool m_fNotNull; // 0x0
	private long m_value; // 0x8
	private static readonly long s_lLowIntMask; // 0x0
	private static readonly long s_lHighIntMask; // 0x8
	public static readonly SqlInt64 Null; // 0x10
	public static readonly SqlInt64 Zero; // 0x20
	public static readonly SqlInt64 MinValue; // 0x30
	public static readonly SqlInt64 MaxValue; // 0x40

	// Properties
	public bool IsNull { get; }
	public long Value { get; }

	// Methods

	// RVA: 0x117FC0 Offset: 0x1173C0 VA: 0x180117FC0
	private void .ctor(bool fNull) { }

	// RVA: 0x11A1B0 Offset: 0x1195B0 VA: 0x18011A1B0
	public void .ctor(long value) { }

	// RVA: 0x117FE0 Offset: 0x1173E0 VA: 0x180117FE0 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x11A1C0 Offset: 0x1195C0 VA: 0x18011A1C0
	public long get_Value() { }

	// RVA: 0xCC0660 Offset: 0xCBFA60 VA: 0x180CC0660
	public static SqlInt64 op_Implicit(long x) { }

	// RVA: 0x11A190 Offset: 0x119590 VA: 0x18011A190 Slot: 3
	public override string ToString() { }

	// RVA: 0xCC0D20 Offset: 0xCC0120 VA: 0x180CC0D20
	public static SqlInt64 op_UnaryNegation(SqlInt64 x) { }

	// RVA: 0xCBFDA0 Offset: 0xCBF1A0 VA: 0x180CBFDA0
	public static SqlInt64 op_Addition(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xCC0BA0 Offset: 0xCBFFA0 VA: 0x180CC0BA0
	public static SqlInt64 op_Subtraction(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xCC08D0 Offset: 0xCBFCD0 VA: 0x180CC08D0
	public static SqlInt64 op_Multiply(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xCBFF20 Offset: 0xCBF320 VA: 0x180CBFF20
	public static SqlInt64 op_Division(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xCC0740 Offset: 0xCBFB40 VA: 0x180CC0740
	public static SqlInt64 op_Modulus(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xCC0440 Offset: 0xCBF840 VA: 0x180CC0440
	public static SqlInt64 op_Implicit(SqlByte x) { }

	// RVA: 0xCC05A0 Offset: 0xCBF9A0 VA: 0x180CC05A0
	public static SqlInt64 op_Implicit(SqlInt16 x) { }

	// RVA: 0xCC04E0 Offset: 0xCBF8E0 VA: 0x180CC04E0
	public static SqlInt64 op_Implicit(SqlInt32 x) { }

	// RVA: 0xCC0170 Offset: 0xCBF570 VA: 0x180CC0170
	public static SqlInt64 op_Explicit(SqlDecimal x) { }

	// RVA: 0xCBF790 Offset: 0xCBEB90 VA: 0x180CBF790
	private static bool SameSignLong(long x, long y) { }

	// RVA: 0xCC00B0 Offset: 0xCBF4B0 VA: 0x180CC00B0
	public static SqlBoolean op_Equality(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xCC0680 Offset: 0xCBFA80 VA: 0x180CC0680
	public static SqlBoolean op_LessThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xCC0380 Offset: 0xCBF780 VA: 0x180CC0380
	public static SqlBoolean op_GreaterThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xCBF680 Offset: 0xCBEA80 VA: 0x180CBF680
	public static SqlBoolean LessThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xCBF570 Offset: 0xCBE970 VA: 0x180CBF570
	public static SqlBoolean GreaterThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x119CF0 Offset: 0x1190F0 VA: 0x180119CF0
	public SqlByte ToSqlByte() { }

	// RVA: 0x119DF0 Offset: 0x1191F0 VA: 0x180119DF0
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x119F10 Offset: 0x119310 VA: 0x180119F10
	public SqlInt16 ToSqlInt16() { }

	// RVA: 0x11A050 Offset: 0x119450 VA: 0x18011A050
	public SqlInt32 ToSqlInt32() { }

	// RVA: 0x119D60 Offset: 0x119160 VA: 0x180119D60
	public SqlDecimal ToSqlDecimal() { }

	// RVA: 0x1197C0 Offset: 0x118BC0 VA: 0x1801197C0 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1198D0 Offset: 0x118CD0 VA: 0x1801198D0
	public int CompareTo(SqlInt64 value) { }

	// RVA: 0x1198F0 Offset: 0x118CF0 VA: 0x1801198F0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x119A80 Offset: 0x118E80 VA: 0x180119A80 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x117C10 Offset: 0x117010 VA: 0x180117C10 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x119B00 Offset: 0x118F00 VA: 0x180119B00 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x119C20 Offset: 0x119020 VA: 0x180119C20 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xCBF510 Offset: 0xCBE910 VA: 0x180CBF510
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xCBFC40 Offset: 0xCBF040 VA: 0x180CBFC40
	private static void .cctor() { }

}

