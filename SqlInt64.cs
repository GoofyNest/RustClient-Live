public struct SqlInt64 : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4352
{
	private bool m_fNotNull; 
	private long m_value; 
	private static readonly long s_lLowIntMask; 
	private static readonly long s_lHighIntMask; 
	public static readonly SqlInt64 Null; 
	public static readonly SqlInt64 Zero; 
	public static readonly SqlInt64 MinValue; 
	public static readonly SqlInt64 MaxValue; 

	public bool IsNull { get; }
	public long Value { get; }


	private void .ctor(bool fNull) { }

	public void .ctor(long value) { }

	public bool get_IsNull() { }

	public long get_Value() { }

	public static SqlInt64 op_Implicit(long x) { }

	public override string ToString() { }

	public static SqlInt64 op_UnaryNegation(SqlInt64 x) { }

	public static SqlInt64 op_Addition(SqlInt64 x, SqlInt64 y) { }

	public static SqlInt64 op_Subtraction(SqlInt64 x, SqlInt64 y) { }

	public static SqlInt64 op_Multiply(SqlInt64 x, SqlInt64 y) { }

	public static SqlInt64 op_Division(SqlInt64 x, SqlInt64 y) { }

	public static SqlInt64 op_Modulus(SqlInt64 x, SqlInt64 y) { }

	public static SqlInt64 op_Implicit(SqlByte x) { }

	public static SqlInt64 op_Implicit(SqlInt16 x) { }

	public static SqlInt64 op_Implicit(SqlInt32 x) { }

	public static SqlInt64 op_Explicit(SqlDecimal x) { }

	private static bool SameSignLong(long x, long y) { }

	public static SqlBoolean op_Equality(SqlInt64 x, SqlInt64 y) { }

	public static SqlBoolean op_LessThan(SqlInt64 x, SqlInt64 y) { }

	public static SqlBoolean op_GreaterThan(SqlInt64 x, SqlInt64 y) { }

	public static SqlBoolean LessThan(SqlInt64 x, SqlInt64 y) { }

	public static SqlBoolean GreaterThan(SqlInt64 x, SqlInt64 y) { }

	public SqlByte ToSqlByte() { }

	public SqlDouble ToSqlDouble() { }

	public SqlInt16 ToSqlInt16() { }

	public SqlInt32 ToSqlInt32() { }

	public SqlDecimal ToSqlDecimal() { }

	public int CompareTo(object value) { }

	public int CompareTo(SqlInt64 value) { }

	public override bool Equals(object value) { }

	public override int GetHashCode() { }

	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	private static void .cctor() { }

}

