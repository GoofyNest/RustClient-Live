public struct SqlInt16 : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4347
{	// Fields
	private bool m_fNotNull; // 0x0
	private short m_value; // 0x2
	private static readonly int s_MASKI2; // 0x0
	public static readonly SqlInt16 Null; // 0x4
	public static readonly SqlInt16 Zero; // 0x8
	public static readonly SqlInt16 MinValue; // 0xC
	public static readonly SqlInt16 MaxValue; // 0x10

	// Properties
	public bool IsNull { get; }
	public short Value { get; }

	// Methods

	// RVA: 0x118F10 Offset: 0x118310 VA: 0x180118F10
	private void .ctor(bool fNull) { }

	// RVA: 0x118F20 Offset: 0x118320 VA: 0x180118F20
	public void .ctor(short value) { }

	// RVA: 0x117FE0 Offset: 0x1173E0 VA: 0x180117FE0 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x118F30 Offset: 0x118330 VA: 0x180118F30
	public short get_Value() { }

	// RVA: 0xCBDBB0 Offset: 0xCBCFB0 VA: 0x180CBDBB0
	public static SqlInt16 op_Implicit(short x) { }

	// RVA: 0x118EF0 Offset: 0x1182F0 VA: 0x180118EF0 Slot: 3
	public override string ToString() { }

	// RVA: 0xCBDEA0 Offset: 0xCBD2A0 VA: 0x180CBDEA0
	public static SqlInt16 op_UnaryNegation(SqlInt16 x) { }

	// RVA: 0xCBD6C0 Offset: 0xCBCAC0 VA: 0x180CBD6C0
	public static SqlInt16 op_Addition(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xCBDDB0 Offset: 0xCBD1B0 VA: 0x180CBDDB0
	public static SqlInt16 op_Subtraction(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xCBDC70 Offset: 0xCBD070 VA: 0x180CBDC70
	public static SqlInt16 op_Multiply(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xCBD7B0 Offset: 0xCBCBB0 VA: 0x180CBD7B0
	public static SqlInt16 op_Division(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xCBDB10 Offset: 0xCBCF10 VA: 0x180CBDB10
	public static SqlInt16 op_Implicit(SqlByte x) { }

	// RVA: 0xCBD980 Offset: 0xCBCD80 VA: 0x180CBD980
	public static SqlInt16 op_Explicit(SqlInt64 x) { }

	// RVA: 0xCBD8E0 Offset: 0xCBCCE0 VA: 0x180CBD8E0
	public static SqlBoolean op_Equality(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xCBDBD0 Offset: 0xCBCFD0 VA: 0x180CBDBD0
	public static SqlBoolean op_LessThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xCBDA70 Offset: 0xCBCE70 VA: 0x180CBDA70
	public static SqlBoolean op_GreaterThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xCBD2C0 Offset: 0xCBC6C0 VA: 0x180CBD2C0
	public static SqlBoolean LessThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xCBD260 Offset: 0xCBC660 VA: 0x180CBD260
	public static SqlBoolean GreaterThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x118C70 Offset: 0x118070 VA: 0x180118C70
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x118DB0 Offset: 0x1181B0 VA: 0x180118DB0
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0x118790 Offset: 0x117B90 VA: 0x180118790 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x118780 Offset: 0x117B80 VA: 0x180118780
	public int CompareTo(SqlInt16 value) { }

	// RVA: 0x118890 Offset: 0x117C90 VA: 0x180118890 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x118A00 Offset: 0x117E00 VA: 0x180118A00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x117C10 Offset: 0x117010 VA: 0x180117C10 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x118A80 Offset: 0x117E80 VA: 0x180118A80 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x118BA0 Offset: 0x117FA0 VA: 0x180118BA0 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xCBD200 Offset: 0xCBC600 VA: 0x180CBD200
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xCBD590 Offset: 0xCBC990 VA: 0x180CBD590
	private static void .cctor() { }

}

