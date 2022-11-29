public struct SqlDouble : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4350
{
	private bool m_fNotNull; 
	private double m_value; 
	public static readonly SqlDouble Null; 
	public static readonly SqlDouble Zero; 
	public static readonly SqlDouble MinValue; 
	public static readonly SqlDouble MaxValue; 

	public bool IsNull { get; }
	public double Value { get; }


	private void .ctor(bool fNull) { }

	public void .ctor(double value) { }

	public bool get_IsNull() { }

	public double get_Value() { }

	public static SqlDouble op_Implicit(double x) { }

	public override string ToString() { }

	public static SqlDouble op_UnaryNegation(SqlDouble x) { }

	public static SqlDouble op_Addition(SqlDouble x, SqlDouble y) { }

	public static SqlDouble op_Subtraction(SqlDouble x, SqlDouble y) { }

	public static SqlDouble op_Multiply(SqlDouble x, SqlDouble y) { }

	public static SqlDouble op_Division(SqlDouble x, SqlDouble y) { }

	public static SqlDouble op_Implicit(SqlByte x) { }

	public static SqlDouble op_Implicit(SqlInt16 x) { }

	public static SqlDouble op_Implicit(SqlInt32 x) { }

	public static SqlDouble op_Implicit(SqlInt64 x) { }

	public static SqlDouble op_Implicit(SqlSingle x) { }

	public static SqlDouble op_Implicit(SqlMoney x) { }

	public static SqlDouble op_Implicit(SqlDecimal x) { }

	public static SqlBoolean op_Equality(SqlDouble x, SqlDouble y) { }

	public static SqlBoolean op_LessThan(SqlDouble x, SqlDouble y) { }

	public static SqlBoolean op_GreaterThan(SqlDouble x, SqlDouble y) { }

	public static SqlBoolean LessThan(SqlDouble x, SqlDouble y) { }

	public static SqlBoolean GreaterThan(SqlDouble x, SqlDouble y) { }

	public SqlSingle ToSqlSingle() { }

	public int CompareTo(object value) { }

	public int CompareTo(SqlDouble value) { }

	public override bool Equals(object value) { }

	public override int GetHashCode() { }

	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	private static void .cctor() { }

}

