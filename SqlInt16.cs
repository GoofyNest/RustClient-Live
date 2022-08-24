public struct SqlInt16 : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4347
{
	private bool m_fNotNull; 
	private short m_value; 
	private static readonly int s_MASKI2; 
	public static readonly SqlInt16 Null; 
	public static readonly SqlInt16 Zero; 
	public static readonly SqlInt16 MinValue; 
	public static readonly SqlInt16 MaxValue; 

public bool IsNull { get; }
public short Value { get; }


private void .ctor(bool fNull) { }

public void .ctor(short value) { }

public bool get_IsNull() { }

public short get_Value() { }

public static SqlInt16 op_Implicit(short x) { }

public override string ToString() { }

public static SqlInt16 op_UnaryNegation(SqlInt16 x) { }

public static SqlInt16 op_Addition(SqlInt16 x, SqlInt16 y) { }

public static SqlInt16 op_Subtraction(SqlInt16 x, SqlInt16 y) { }

public static SqlInt16 op_Multiply(SqlInt16 x, SqlInt16 y) { }

public static SqlInt16 op_Division(SqlInt16 x, SqlInt16 y) { }

public static SqlInt16 op_Implicit(SqlByte x) { }

public static SqlInt16 op_Explicit(SqlInt64 x) { }

public static SqlBoolean op_Equality(SqlInt16 x, SqlInt16 y) { }

public static SqlBoolean op_LessThan(SqlInt16 x, SqlInt16 y) { }

public static SqlBoolean op_GreaterThan(SqlInt16 x, SqlInt16 y) { }

public static SqlBoolean LessThan(SqlInt16 x, SqlInt16 y) { }

public static SqlBoolean GreaterThan(SqlInt16 x, SqlInt16 y) { }

public SqlDouble ToSqlDouble() { }

public SqlInt64 ToSqlInt64() { }

public int CompareTo(object value) { }

public int CompareTo(SqlInt16 value) { }

public override bool Equals(object value) { }

public override int GetHashCode() { }

private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

private static void .cctor() { }

}

