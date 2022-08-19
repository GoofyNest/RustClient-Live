public struct SqlByte : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4339
{	// Fields
	private bool m_fNotNull; // 0x0
	private byte m_value; // 0x1
	private static readonly int s_iBitNotByteMax; // 0x0
	public static readonly SqlByte Null; // 0x4
	public static readonly SqlByte Zero; // 0x6
	public static readonly SqlByte MinValue; // 0x8
	public static readonly SqlByte MaxValue; // 0xA

	// Properties
	public bool IsNull { get; }
	public byte Value { get; }

	// Methods

	// RVA: 0x138A70 Offset: 0x137E70 VA: 0x180138A70
	private void .ctor(bool fNull) { }

	// RVA: 0x138A80 Offset: 0x137E80 VA: 0x180138A80
	public void .ctor(byte value) { }

	// RVA: 0x117FE0 Offset: 0x1173E0 VA: 0x180117FE0 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x138A90 Offset: 0x137E90 VA: 0x180138A90
	public byte get_Value() { }

	// RVA: 0xEB0C80 Offset: 0xEB0080 VA: 0x180EB0C80
	public static SqlByte op_Implicit(byte x) { }

	// RVA: 0x138A20 Offset: 0x137E20 VA: 0x180138A20 Slot: 3
	public override string ToString() { }

	// RVA: 0xEB0880 Offset: 0xEAFC80 VA: 0x180EB0880
	public static SqlByte op_Addition(SqlByte x, SqlByte y) { }

	// RVA: 0xEB0E30 Offset: 0xEB0230 VA: 0x180EB0E30
	public static SqlByte op_Subtraction(SqlByte x, SqlByte y) { }

	// RVA: 0xEB0D20 Offset: 0xEB0120 VA: 0x180EB0D20
	public static SqlByte op_Multiply(SqlByte x, SqlByte y) { }

	// RVA: 0xEB0980 Offset: 0xEAFD80 VA: 0x180EB0980
	public static SqlByte op_Division(SqlByte x, SqlByte y) { }

	// RVA: 0xEB0AF0 Offset: 0xEAFEF0 VA: 0x180EB0AF0
	public static SqlByte op_Explicit(SqlInt64 x) { }

	// RVA: 0xEB0A60 Offset: 0xEAFE60 VA: 0x180EB0A60
	public static SqlBoolean op_Equality(SqlByte x, SqlByte y) { }

	// RVA: 0xEB0C90 Offset: 0xEB0090 VA: 0x180EB0C90
	public static SqlBoolean op_LessThan(SqlByte x, SqlByte y) { }

	// RVA: 0xEB0BF0 Offset: 0xEAFFF0 VA: 0x180EB0BF0
	public static SqlBoolean op_GreaterThan(SqlByte x, SqlByte y) { }

	// RVA: 0xEB0610 Offset: 0xEAFA10 VA: 0x180EB0610
	public static SqlBoolean LessThan(SqlByte x, SqlByte y) { }

	// RVA: 0xEB05A0 Offset: 0xEAF9A0 VA: 0x180EB05A0
	public static SqlBoolean GreaterThan(SqlByte x, SqlByte y) { }

	// RVA: 0x138920 Offset: 0x137D20 VA: 0x180138920
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x1389A0 Offset: 0x137DA0 VA: 0x1801389A0
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0x138420 Offset: 0x137820 VA: 0x180138420 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x138520 Offset: 0x137920 VA: 0x180138520
	public int CompareTo(SqlByte value) { }

	// RVA: 0x138530 Offset: 0x137930 VA: 0x180138530 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1386C0 Offset: 0x137AC0 VA: 0x1801386C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x117C10 Offset: 0x117010 VA: 0x180117C10 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x138740 Offset: 0x137B40 VA: 0x180138740 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x138850 Offset: 0x137C50 VA: 0x180138850 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xEB0540 Offset: 0xEAF940 VA: 0x180EB0540
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xEB0760 Offset: 0xEAFB60 VA: 0x180EB0760
	private static void .cctor() { }

}

