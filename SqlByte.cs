public struct SqlByte : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4339
{
	private bool m_fNotNull; 
	private byte m_value; 
	private static readonly int s_iBitNotByteMax; 
	public static readonly SqlByte Null; 
	public static readonly SqlByte Zero; 
	public static readonly SqlByte MinValue; 
	public static readonly SqlByte MaxValue; 

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

