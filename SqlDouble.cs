public struct SqlDouble : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4345
{	// Fields
	private bool m_fNotNull; // 0x0
	private double m_value; // 0x8
	public static readonly SqlDouble Null; // 0x0
	public static readonly SqlDouble Zero; // 0x10
	public static readonly SqlDouble MinValue; // 0x20
	public static readonly SqlDouble MaxValue; // 0x30

	// Properties
	public bool IsNull { get; }
	public double Value { get; }

	// Methods

	// RVA: 0x117FC0 Offset: 0x1173C0 VA: 0x180117FC0
	private void .ctor(bool fNull) { }

	// RVA: 0x117FD0 Offset: 0x1173D0 VA: 0x180117FD0
	public void .ctor(double value) { }

	// RVA: 0x117FE0 Offset: 0x1173E0 VA: 0x180117FE0 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x117FF0 Offset: 0x1173F0 VA: 0x180117FF0
	public double get_Value() { }

	// RVA: 0xCBC0F0 Offset: 0xCBB4F0 VA: 0x180CBC0F0
	public static SqlDouble op_Implicit(double x) { }

	// RVA: 0x117FA0 Offset: 0x1173A0 VA: 0x180117FA0 Slot: 3
	public override string ToString() { }

	// RVA: 0xCBC420 Offset: 0xCBB820 VA: 0x180CBC420
	public static SqlDouble op_UnaryNegation(SqlDouble x) { }

	// RVA: 0xCBB7C0 Offset: 0xCBABC0 VA: 0x180CBB7C0
	public static SqlDouble op_Addition(SqlDouble x, SqlDouble y) { }

	// RVA: 0xCBC2F0 Offset: 0xCBB6F0 VA: 0x180CBC2F0
	public static SqlDouble op_Subtraction(SqlDouble x, SqlDouble y) { }

	// RVA: 0xCBC1C0 Offset: 0xCBB5C0 VA: 0x180CBC1C0
	public static SqlDouble op_Multiply(SqlDouble x, SqlDouble y) { }

	// RVA: 0xCBB8F0 Offset: 0xCBACF0 VA: 0x180CBB8F0
	public static SqlDouble op_Division(SqlDouble x, SqlDouble y) { }

	// RVA: 0xCBBCB0 Offset: 0xCBB0B0 VA: 0x180CBBCB0
	public static SqlDouble op_Implicit(SqlByte x) { }

	// RVA: 0xCBBD60 Offset: 0xCBB160 VA: 0x180CBBD60
	public static SqlDouble op_Implicit(SqlInt16 x) { }

	// RVA: 0xCBBBF0 Offset: 0xCBAFF0 VA: 0x180CBBBF0
	public static SqlDouble op_Implicit(SqlInt32 x) { }

	// RVA: 0xCBBF70 Offset: 0xCBB370 VA: 0x180CBBF70
	public static SqlDouble op_Implicit(SqlInt64 x) { }

	// RVA: 0xCBC030 Offset: 0xCBB430 VA: 0x180CBC030
	public static SqlDouble op_Implicit(SqlSingle x) { }

	// RVA: 0xCBBE20 Offset: 0xCBB220 VA: 0x180CBBE20
	public static SqlDouble op_Implicit(SqlMoney x) { }

	// RVA: 0xCBBEC0 Offset: 0xCBB2C0 VA: 0x180CBBEC0
	public static SqlDouble op_Implicit(SqlDecimal x) { }

	// RVA: 0xCBBA70 Offset: 0xCBAE70 VA: 0x180CBBA70
	public static SqlBoolean op_Equality(SqlDouble x, SqlDouble y) { }

	// RVA: 0xCBC110 Offset: 0xCBB510 VA: 0x180CBC110
	public static SqlBoolean op_LessThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0xCBBB40 Offset: 0xCBAF40 VA: 0x180CBBB40
	public static SqlBoolean op_GreaterThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0xCBB300 Offset: 0xCBA700 VA: 0x180CBB300
	public static SqlBoolean LessThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0xCBB210 Offset: 0xCBA610 VA: 0x180CBB210
	public static SqlBoolean GreaterThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0x117E20 Offset: 0x117220 VA: 0x180117E20
	public SqlSingle ToSqlSingle() { }

	// RVA: 0x117890 Offset: 0x116C90 VA: 0x180117890 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1179A0 Offset: 0x116DA0 VA: 0x1801179A0
	public int CompareTo(SqlDouble value) { }

	// RVA: 0x1179C0 Offset: 0x116DC0 VA: 0x1801179C0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x117B80 Offset: 0x116F80 VA: 0x180117B80 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x117C10 Offset: 0x117010 VA: 0x180117C10 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x117C20 Offset: 0x117020 VA: 0x180117C20 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x117D40 Offset: 0x117140 VA: 0x180117D40 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xCBB1B0 Offset: 0xCBA5B0 VA: 0x180CBB1B0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xCBB570 Offset: 0xCBA970 VA: 0x180CBB570
	private static void .cctor() { }

}

