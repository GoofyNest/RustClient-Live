public struct SqlInt32 : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4348
{
	private bool m_fNotNull; 
	private int m_value; 
	private static readonly long s_iIntMin; 
	private static readonly long s_lBitNotIntMax; 
	public static readonly SqlInt32 Null; 
	public static readonly SqlInt32 Zero; 
	public static readonly SqlInt32 MinValue; 
	public static readonly SqlInt32 MaxValue; 

public bool IsNull { get; }
public int Value { get; }


private void .ctor(bool fNull) { }

public void .ctor(int value) { }

public bool get_IsNull() { }

public int get_Value() { }

public static SqlInt32 op_Implicit(int x) { }

public override string ToString() { }

public static SqlInt32 op_UnaryNegation(SqlInt32 x) { }

public static SqlInt32 op_Addition(SqlInt32 x, SqlInt32 y) { }

public static SqlInt32 op_Subtraction(SqlInt32 x, SqlInt32 y) { }

public static SqlInt32 op_Multiply(SqlInt32 x, SqlInt32 y) { }

public static SqlInt32 op_Division(SqlInt32 x, SqlInt32 y) { }

public static SqlInt32 op_Implicit(SqlByte x) { }

public static SqlInt32 op_Implicit(SqlInt16 x) { }

public static SqlInt32 op_Explicit(SqlInt64 x) { }

private static bool SameSignInt(int x, int y) { }

public static SqlBoolean op_Equality(SqlInt32 x, SqlInt32 y) { }

public static SqlBoolean op_LessThan(SqlInt32 x, SqlInt32 y) { }

public static SqlBoolean op_GreaterThan(SqlInt32 x, SqlInt32 y) { }

public static SqlBoolean LessThan(SqlInt32 x, SqlInt32 y) { }

public static SqlBoolean GreaterThan(SqlInt32 x, SqlInt32 y) { }

public SqlDouble ToSqlDouble() { }

public SqlInt64 ToSqlInt64() { }

public int CompareTo(object value) { }

public int CompareTo(SqlInt32 value) { }

public override bool Equals(object value) { }

public override int GetHashCode() { }

private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

private static void .cctor() { }

}

