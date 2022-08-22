public struct SqlByte : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4339
{	private bool m_fNotNull; // 0x0
	private byte m_value; // 0x1
	private static readonly int s_iBitNotByteMax; // 0x0
	public static readonly SqlByte Null; // 0x4
	public static readonly SqlByte Zero; // 0x6
	public static readonly SqlByte MinValue; // 0x8
	public static readonly SqlByte MaxValue; // 0xA

	public bool IsNull { get; }
	public byte Value { get; }


	private void .ctor(bool fNull) { }

	public void .ctor(byte value) { }

	public bool get_IsNull() { }

	public byte get_Value() { }

	public static SqlByte op_Implicit(byte x) { }

	public override string ToString() { }

	public static SqlByte op_Addition(SqlByte x, SqlByte y) { }

	public static SqlByte op_Subtraction(SqlByte x, SqlByte y) { }

	public static SqlByte op_Multiply(SqlByte x, SqlByte y) { }

	public static SqlByte op_Division(SqlByte x, SqlByte y) { }

	public static SqlByte op_Explicit(SqlInt64 x) { }

	public static SqlBoolean op_Equality(SqlByte x, SqlByte y) { }

	public static SqlBoolean op_LessThan(SqlByte x, SqlByte y) { }

	public static SqlBoolean op_GreaterThan(SqlByte x, SqlByte y) { }

	public static SqlBoolean LessThan(SqlByte x, SqlByte y) { }

	public static SqlBoolean GreaterThan(SqlByte x, SqlByte y) { }

	public SqlDouble ToSqlDouble() { }

	public SqlInt64 ToSqlInt64() { }

	public int CompareTo(object value) { }

	public int CompareTo(SqlByte value) { }

	public override bool Equals(object value) { }

	public override int GetHashCode() { }

	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	private static void .cctor() { }

}

