public struct SqlMoney : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4350
{	private bool _fNotNull; // 0x0
	private long _value; // 0x8
	internal static readonly int s_iMoneyScale; // 0x0
	private static readonly long s_lTickBase; // 0x8
	private static readonly double s_dTickBase; // 0x10
	private static readonly long s_minLong; // 0x18
	private static readonly long s_maxLong; // 0x20
	public static readonly SqlMoney Null; // 0x28
	public static readonly SqlMoney Zero; // 0x38
	public static readonly SqlMoney MinValue; // 0x48
	public static readonly SqlMoney MaxValue; // 0x58

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

