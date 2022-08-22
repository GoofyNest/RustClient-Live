public struct SqlSingle : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4351
{	private bool _fNotNull; // 0x0
	private float _value; // 0x4
	public static readonly SqlSingle Null; // 0x0
	public static readonly SqlSingle Zero; // 0x8
	public static readonly SqlSingle MinValue; // 0x10
	public static readonly SqlSingle MaxValue; // 0x18

	public bool IsNull { get; }
	public float Value { get; }


	private void .ctor(bool fNull) { }

	public void .ctor(float value) { }

	public void .ctor(double value) { }

	public bool get_IsNull() { }

	public float get_Value() { }

	public static SqlSingle op_Implicit(float x) { }

	public override string ToString() { }

	public static SqlSingle op_UnaryNegation(SqlSingle x) { }

	public static SqlSingle op_Addition(SqlSingle x, SqlSingle y) { }

	public static SqlSingle op_Subtraction(SqlSingle x, SqlSingle y) { }

	public static SqlSingle op_Multiply(SqlSingle x, SqlSingle y) { }

	public static SqlSingle op_Division(SqlSingle x, SqlSingle y) { }

	public static SqlSingle op_Implicit(SqlByte x) { }

	public static SqlSingle op_Implicit(SqlInt16 x) { }

	public static SqlSingle op_Implicit(SqlInt32 x) { }

	public static SqlSingle op_Implicit(SqlInt64 x) { }

	public static SqlSingle op_Implicit(SqlMoney x) { }

	public static SqlSingle op_Implicit(SqlDecimal x) { }

	public static SqlSingle op_Explicit(SqlDouble x) { }

	public static SqlBoolean op_Equality(SqlSingle x, SqlSingle y) { }

	public static SqlBoolean op_LessThan(SqlSingle x, SqlSingle y) { }

	public static SqlBoolean op_GreaterThan(SqlSingle x, SqlSingle y) { }

	public static SqlBoolean LessThan(SqlSingle x, SqlSingle y) { }

	public static SqlBoolean GreaterThan(SqlSingle x, SqlSingle y) { }

	public SqlDouble ToSqlDouble() { }

	public int CompareTo(object value) { }

	public int CompareTo(SqlSingle value) { }

	public override bool Equals(object value) { }

	public override int GetHashCode() { }

	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	private static void .cctor() { }

}

