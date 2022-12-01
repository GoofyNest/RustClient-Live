public struct SqlMoney : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4355
{
	private bool _fNotNull;
	private long _value;
	internal static readonly int s_iMoneyScale;
	private static readonly long s_lTickBase;
	private static readonly double s_dTickBase;
	private static readonly long s_minLong;
	private static readonly long s_maxLong;
	public static readonly SqlMoney Null;
	public static readonly SqlMoney Zero;
	public static readonly SqlMoney MinValue;
	public static readonly SqlMoney MaxValue;

	public bool IsNull { get; }
	public Decimal Value { get; }


	private void .ctor(bool fNull) { }

	internal void .ctor(long value, int ignored) { }

	public void .ctor(int value) { }

	public void .ctor(long value) { }

	public void .ctor(Decimal value) { }

	public bool get_IsNull() { }

	public Decimal get_Value() { }

	public Decimal ToDecimal() { }

	public double ToDouble() { }

	public static SqlMoney op_Implicit(Decimal x) { }

	public static SqlMoney op_Implicit(long x) { }

	public override string ToString() { }

	public static SqlMoney op_UnaryNegation(SqlMoney x) { }

	public static SqlMoney op_Addition(SqlMoney x, SqlMoney y) { }

	public static SqlMoney op_Subtraction(SqlMoney x, SqlMoney y) { }

	public static SqlMoney op_Multiply(SqlMoney x, SqlMoney y) { }

	public static SqlMoney op_Division(SqlMoney x, SqlMoney y) { }

	public static SqlMoney op_Implicit(SqlByte x) { }

	public static SqlMoney op_Implicit(SqlInt16 x) { }

	public static SqlMoney op_Implicit(SqlInt32 x) { }

	public static SqlMoney op_Implicit(SqlInt64 x) { }

	public static SqlMoney op_Explicit(SqlDecimal x) { }

	public static SqlBoolean op_Equality(SqlMoney x, SqlMoney y) { }

	public static SqlBoolean op_LessThan(SqlMoney x, SqlMoney y) { }

	public static SqlBoolean op_GreaterThan(SqlMoney x, SqlMoney y) { }

	public static SqlBoolean LessThan(SqlMoney x, SqlMoney y) { }

	public static SqlBoolean GreaterThan(SqlMoney x, SqlMoney y) { }

	public SqlDouble ToSqlDouble() { }

	public SqlDecimal ToSqlDecimal() { }

	public int CompareTo(object value) { }

	public int CompareTo(SqlMoney value) { }

	public override bool Equals(object value) { }

	public override int GetHashCode() { }

	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	private static void .cctor() { }

}

